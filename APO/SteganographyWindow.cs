using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using Label = System.Windows.Forms.Label;

namespace APO_Czerniawski
{
    public partial class SteganographyWindow : Form
    {
        /// <summary>
        /// Głowne okno aplikacji
        /// </summary>
        private readonly MainWindow _main;

        /// <summary>
        /// Przetrzymuje obraz na jakim bedziemy ukyrwać
        /// </summary>
        private Image _image;

        /// <summary>
        /// Przetrzymuje obraz do ukrycia
        /// </summary>
        private Image _imageToHide;

        /// <summary>
        /// Przetrzymuje obraz z ktorego bedziemy odkrywać obraz
        /// </summary>
        private Image _imageToDecrypt;

        /// <summary>
        /// Przetrzymuje informacje o tym czy mysz jest wcisnięta
        /// </summary>
        private Boolean bHaveMouse;

        /// <summary>
        /// Początkowy punkt wycinania
        /// </summary>
        private Point ptOriginal = new Point();

        /// <summary>
        /// Końcowy punkt wycinania
        /// </summary>
        private Point ptLast = new Point();

        /// <summary>
        /// Kształt do wycięcia z obrazu
        /// </summary>
        private Rectangle rectCropArea;

        /// <summary>
        /// Okno podglądu operacji stegangorafi
        /// </summary>
        private SteganographyPreviewWindow _steganographyPreviewWindow;

        /// <summary>
        /// Okno będące odpowiedzialne za wykonywanie operacji steganografi na obrazach
        /// </summary>
        /// <param name="main">Głowne okno aplikacji</param>
        public SteganographyWindow(MainWindow main)
        {
            _main = main;
            InitializeComponent();

            pictureBoxImage.Tag = "Obraz";
            pictureBoxImageToHide.Tag = "Ukrywany obraz";
            pictureBoxResult.Tag = "Obraz po steganografi";

            pictureBoxImageToDecrypt.Tag = "Obraz do odkrycia";
            pictureBoxEncryptedImage.Tag = "Obraz odkryty";

            _steganographyPreviewWindow =  new SteganographyPreviewWindow(this,pictureBoxImage, pictureBoxImageToHide, pictureBoxResult,pictureBoxImageToDecrypt,pictureBoxEncryptedImage);
            _steganographyPreviewWindow.MdiParent = main;
            _steganographyPreviewWindow.ControlBox = false;
            _steganographyPreviewWindow.StartPosition = FormStartPosition.Manual;
            _steganographyPreviewWindow.Location = new Point(Width+50,50);
            _steganographyPreviewWindow.Show();
            _steganographyPreviewWindow.SetBitsNumberShow(2);
            _steganographyPreviewWindow.SetBitsNumberHide(2);
        }

        /// <summary>
        /// Funkcja odpowiada za guzik wczytaj pod obrazem, wczytuje obraz aktywuje guzik do wczytania obrazu jaki chcemy ukryć i rysuje histogramy
        /// </summary>
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            _image = LoadImage(_image);
            if (_image != null)
            {
                pictureBoxImage.Image = _image;
                buttonLoadToHide.Enabled = true;
                DrawHistograms(chartImageR, chartImageG, chartImageB, _image, MaxBmpLevel(_image));

            }
        }

        /// <summary>
        /// Funkcja odpowiada za guzik "Wczytaj" pod Ukrywanym obrazem wczytuje obraz do ukrycia sprawdcza czy jego rozmiar jest poprawny i jest on mniejszy niz obraz
        /// na jakim chcemy go zapisać, rysuje histogramy i odswieża podgląd w oknie podglądu
        /// </summary>
        private void ButtonLoadToHide_Click(object sender, EventArgs e)
        {
            _imageToHide = LoadImage(_imageToHide);
            if(_imageToHide != null)
            {
                pictureBoxImageToHide.Image = _imageToHide;
                //Sprawdzamy czy obraz do ukrycia jest mniejszy niz ten na jakim chcemy ukryc, w przeciwnym wypadku steganografia jest nie mozliwa
                if (_imageToHide.Width > _image.Width || _imageToHide.Height > _image.Height)
                {
                    MessageBox.Show(
                        "Obraz ktory chcesz wczytać jest większy niż obraz w którym ma być on ukryty, wybierz mniejszy",
                        "Błędne rozmiary");
                    buttonHide.Enabled = false;
                    pictureBoxImageToHide.Image = null;
                    return;
                }

                DrawHistograms(chartImageToHideR, chartImageToHideG, chartImageToHideB, _imageToHide,
                    MaxBmpLevel(_imageToHide));

                buttonHide.Enabled = true;
                _steganographyPreviewWindow.CalcHide();
            }
        }

        /// <summary>
        /// Funkcja odpowiada za guzik "Wczytaj" pod Obrazem do odkrycia wczytuje obraz ustawia guzik do wykonania operacji na włączony i rysuje histogramy
        /// </summary>
        private void ButtonToEncryptLoad_Click(object sender, EventArgs e)
        {
            _imageToDecrypt = LoadImage(_imageToDecrypt);
            if (_imageToDecrypt != null)
            {
                pictureBoxImageToDecrypt.Image = _imageToDecrypt;
                buttonShow.Enabled = true;
                DrawHistograms(chartToEncodeR, chartToEncodeG, chartToEncodeB, _imageToDecrypt, MaxBmpLevel(_imageToDecrypt));
            }
        }

        /// <summary>
        /// Funkcja odpowiada za guzik "Ukryj" ukrywa obraz rysuje histogramy i wpisuje wartosci na oknie pogladu
        /// </summary>
        private void ButtonHide_Click(object sender, EventArgs e)
        {
            if(_image != null && _imageToHide != null && Steganography.HideImage(_image,_imageToHide,Convert.ToInt32(numericUpDownHide.Value),pictureBoxResult))
            {
                buttonSaveHidden.Enabled = true;

                DrawHistograms(chartImageHiddenR, chartImageHiddenG, chartImageHiddenB, pictureBoxResult.Image,
                    MaxBmpLevel(pictureBoxResult.Image));
                
                _steganographyPreviewWindow.CalcHidden();
            }
        }

        /// <summary>
        /// Funkcja odpowiada za guzik "Pokaż" odkrywa obraz rysuje histogramy i aktualania okno podglądu
        /// </summary>
        private void ButtonShow_Click(object sender, EventArgs e)
        {
            if (_imageToDecrypt != null && Steganography.UnhideImage(_imageToDecrypt, Convert.ToInt32(numericUpDownShow.Value),pictureBoxEncryptedImage))
            {
                buttonSaveEncrypted.Enabled = true;

                DrawHistograms(chartEncodedR, chartEncodedG, chartEncodedB, pictureBoxEncryptedImage.Image, MaxBmpLevel(pictureBoxEncryptedImage.Image));

                _steganographyPreviewWindow.CalcShow();
            }
        }

        /// <summary>
        /// Funkcja odpowiada za guzik "Zapisz w zakladce ukrywanie"
        /// </summary>
        private void ButtonSaveHidden_Click(object sender, EventArgs e)
        {
            SaveImage(pictureBoxResult);
        }

        /// <summary>
        /// Funkcja odpowiada za guzik "Zapisz w zakladce odkrywanie"
        /// </summary>
        private void buttonSaveEncrypted_Click(object sender, EventArgs e)
        {
            SaveImage(pictureBoxEncryptedImage);
        }

        /// <summary>
        /// Funkcja wczytuje przy pomocy klasy wbudowanej OpenFileDialog plik do pamieci naszego programu
        /// </summary>
        /// <param name="image">Zmienna do jakiej ma byc wczytany obraz</param>
        /// <returns>Zwraca wczytany obraz</returns>
        private Image LoadImage(Image image)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                Image imageToSave = image;
                openFileDialog.InitialDirectory = "c:\\"; //Ustawiamy katalog startowy na C:/
                openFileDialog.Filter =
                    "Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|PNG (*.png)|*.png"; //Ustawiamy odpowiednie filtry aby nie wystąpił błąd podczas wczytywania pliku ktory nie jest obrazem

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imageToSave = Image.FromFile(openFileDialog.FileName); //Wczytujemy do zmiennej obraz na ktorym bedziemy ukrywac
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Błąd podczas wczytywania obrazu!", "Błąd", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Error); //Gdyby jednak wydarzylo sie cos zlego podczas wczytywania obrazu jest zapewniona oblsuga wyjatku
                    }
                }
                return imageToSave;
            }
        }

        /// <summary>
        /// Funkcja zapisuje przy pomocy klasy wbudowanej SaveFileDialog plik na dysk
        /// </summary>
        /// <param name="pictureBox">PictureBox z ktorego funkcja pobiera obraz do zapisania</param>
        private void SaveImage(PictureBox pictureBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".bmp|*.bmp";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                    MessageBox.Show("Zapisywanie powiodło się!", "Sukces!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas zapisywania obrazu!", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon
                            .Error); //Gdyby jednak wydarzylo sie cos zlego podczas zapisywania obrazu jest zapewniona oblsuga wyjatku
                }
                
            }
        }

        /// <summary>
        /// Funkcja odpowiada za oprogramowanie kliku myszka w przypadku lewego guzika jest to rozpoczecie rysowania obszaru wycinania
        /// w przypadku prawego guzika jest to wyswietlenie tablicy wartosci pikseli
        /// </summary>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Sprwadzamy czy wcisiniety guzik to prawy i czy mamy zaladowany obraz
            if (e.Button == MouseButtons.Right && ((PictureBox) sender).Image != null)
            {
                //Utworzenie noweg okna z tablicami wartosci pikseli i wyswietlenie go
                ArraysSteganography arraysSteganography = new ArraysSteganography(((PictureBox) sender).Image,((PictureBox) sender).Tag.ToString());
                arraysSteganography.MdiParent = _main;
                arraysSteganography.Show();
            }
            else
            {
                //Sprawdzenie czy mamy załadowany obraz
                if (((PictureBox) sender).Image != null)
                    //Zaznaczmy ze mamy wcisnięty klawisz myszy
                    bHaveMouse = true;

                //Zachowujemu kordynaty początkowe naszego zacznaczenia do wycięcia
                ptOriginal.X = e.X;
                ptOriginal.Y = e.Y;

                // Special value lets us know that no previous
                // rectangle needs to be erased.

                //Specjalne wartosci mowią o tym że nie ma poprzedniego zaznaczenia do wyczyszczenia

                ptLast.X = -1;
                ptLast.Y = -1;

                rectCropArea = new Rectangle(new Point(e.X, e.Y), new Size());
            }
        }
        

        /// <summary>
        /// Funkcja odpowiada za obsługe wycięcia zaznaczonego przez nas fragmentu
        /// </summary>
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            //Ustawiamy flage że mysz została puszczona
            bHaveMouse = false;

            if (rectCropArea.Width > 0 && rectCropArea.Height > 0)
            {

                //Jezeli rysowalismy rysujemy ponownie w tym miejscu zeby usunąć linie
                if (ptLast.X != -1)
                {
                    Point ptCurrent = new Point(e.X, e.Y);
                }

                // Ustawiamy flagi jako info że nie ma poprzedniej lini do usunięcia
                ptLast.X = -1;
                ptLast.Y = -1;
                ptOriginal.X = -1;
                ptOriginal.Y = -1;

                
                Bitmap sourceBitmap = new Bitmap(((PictureBox) sender).Image, ((PictureBox) sender).Width,
                    ((PictureBox) sender).Height);

                //Utworzenie bitmapy do ktorej zostanie zapisany wyciety przez nas fragment
                Bitmap croppedBitmap = new Bitmap(rectCropArea.Width, rectCropArea.Height);

                //Przerysowujemy zaznaczona czesc obrazu do nowej zmiennej
                using (Graphics g = Graphics.FromImage(croppedBitmap))
                {
                    g.DrawImage(sourceBitmap, new Rectangle(0, 0, croppedBitmap.Width, croppedBitmap.Height),
                        rectCropArea, GraphicsUnit.Pixel);
                }

                sourceBitmap.Dispose();

                int countWindows = 0;

                //Sprawdzamy ile aktualnie mamy okien o nazwie zaczynajacej sie od "Wycięty obraz" aby żadne wycięte okno się nie powtarzało
                foreach (var child in _main.MdiChildren)
                {
                    if (child.Text.StartsWith("Wycięty obraz"))
                        countWindows++;
                }

                //Tworzymy nowe okno z obrazem i histogramem z wycietego obrazu
                ImageWindow imageWindow = new ImageWindow(croppedBitmap, "Wycięty obraz"+countWindows,_main);
                imageWindow.MdiParent = _main;
                imageWindow.Show();

                ((PictureBox) sender).Invalidate();

                //Usuwamy stare zaznaczenie
                rectCropArea.Height = 0;
                rectCropArea.Width = 0;
            }
        }

        /// <summary>
        /// Funkcja odpowiada za aktualizacje aktualnego miejsca zaznaczenia
        /// </summary>
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);

            //Jeżeli mysz jest wcisniety to rysujemy linie
            if (bHaveMouse)
            {
                // Aktualizujemy ostatnio znana pozycje
                ptLast = ptCurrent;

                // Rysujemy nowe linie

                if (e.X > ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;
                    rectCropArea.Height = e.Y - ptOriginal.Y;
                }
                else if (e.X < ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = ptOriginal.X - e.X;
                    rectCropArea.Height = e.Y - ptOriginal.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = ptOriginal.Y;
                }
                else if (e.X > ptOriginal.X && e.Y < ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;
                    rectCropArea.Height = ptOriginal.Y - e.Y;
                    rectCropArea.X = ptOriginal.X;
                    rectCropArea.Y = e.Y;
                }
                else
                {
                    rectCropArea.Width = ptOriginal.X - e.X;
                    rectCropArea.Height = ptOriginal.Y - e.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = e.Y;
                }

                ((PictureBox) sender).Refresh();
            }

        }

        /// <summary>
        /// Funkcja odpowiada za rysowanie zaznaczenia
        /// </summary>
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen drawLine = new Pen(Color.Black,2);
            drawLine.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(drawLine, rectCropArea);
        }

        /// <summary>
        /// Funkcja odpowiada za rysowanie histogramów dla 3 kanałów z podanego obrazu
        /// </summary>
        /// <param name="chartR">Histogram dla kanału czerwonego</param>
        /// <param name="chartG">Histogram dla kanału zieloneg</param>
        /// <param name="chartB">Histogram dla kanału niebieskiego</param>
        /// <param name="image">Obraz z jakiego bedzięmy rysować histogramy</param>
        /// <param name="maxBmpLevel">Tablica z maksymalnymi poziomami nasycenia kolorów wszystkich 3 kanałów</param>
        private static void DrawHistograms(Chart chartR,Chart chartG,Chart chartB, Image image, int[] maxBmpLevel)
        {

            chartR.Series[0].Points.Clear();
            chartG.Series[0].Points.Clear();
            chartB.Series[0].Points.Clear();

            int[] histoTabR = new int[maxBmpLevel[0]+1];
            int[] histoTabG = new int[maxBmpLevel[1]+1];
            int[] histoTabB = new int[maxBmpLevel[2]+1];

            Bitmap bm = (Bitmap)image;
            //Przechodzimy obraz piksel po pikselu zliczajac ilosć odcieni dla kazdego z 3 kanałów
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);

                    histoTabR[c.R] += 1;
                    histoTabG[c.G] += 1;
                    histoTabB[c.B] += 1;
                }
            }

            //Dodajemy punkty do histogramu
            for (int i =0;i<histoTabR.Length;++i)
            {
                chartR.Series["Series1"].Points.AddXY(i, histoTabR[i]);
            }

            for (int i =0;i<histoTabG.Length;++i)
            {
                chartG.Series["Series1"].Points.AddXY(i, histoTabG[i]);
            }

            for (int i =0;i<histoTabB.Length;++i)
            {
                chartB.Series["Series1"].Points.AddXY(i, histoTabB[i]);
            }
        }

        /// <summary>
        /// Funkcja oblicza maksymalny poziom nasycenia dla kazdego z 3 kanałów
        /// </summary>
        /// <param name="image">Obraz z jakiego chcemy wyznaczyć poziomy nasycenia</param>
        /// <returns>Tablice zawierającą poziomy nasycenia 3 kanałów RGB</returns>
        private int[] MaxBmpLevel(Image image)
        {
            int maxBmpLevelR = 0;
            int maxBmpLevelG = 0;
            int maxBmpLevelB = 0;

            Bitmap bm = (Bitmap)image;

            //Przchodzimy piksel po pikselu
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    //Sprawdzamy czy aktualnie przetwarzany piksel jest większy niż maksymalny dotychczas znaleziony dla wszystkich 3 kanałów
                    if (bm.GetPixel(x, y).R > maxBmpLevelR)
                        maxBmpLevelR = bm.GetPixel(x, y).R;

                    if (bm.GetPixel(x, y).G > maxBmpLevelG) 
                        maxBmpLevelG = bm.GetPixel(x, y).G;

                    if (bm.GetPixel(x, y).B > maxBmpLevelB)
                        maxBmpLevelB = bm.GetPixel(x, y).B;

                }
            }

            return new int[]
            {
                maxBmpLevelR,
                maxBmpLevelG,
                maxBmpLevelB
            };
        }

        /// <summary>
        /// Funkcja odpowiada za zamknięcie okna podglądu
        /// </summary>
        private void SteganographyWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _steganographyPreviewWindow.Close();
        }

        /// <summary>
        /// Funkcja odpowiada za synchronizowanie zakładek miedzy aktualnym oknem a oknem podglądu
        /// </summary>
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _steganographyPreviewWindow.SwapTabs(tabControl1.SelectedIndex);
        }

        /// <summary>
        /// Funkcja umozliwia zmianę aktualnie wybranej zakładki
        /// </summary>
        /// <param name="index">Numer zakładki</param>
        public void SwapTabs(int index)
        {
            tabControl1.SelectTab(index);
        }

        /// <summary>
        /// Funkcja odpowaida za aktualizacje opisu w oknie podgladu po zmianie wartosci ilosci wybranych pikseli dla okna ukrywania
        /// </summary>
        private void NumericUpDownHide_ValueChanged(object sender, EventArgs e)
        {
            var bitsCount = Convert.ToInt32(numericUpDownHide.Value);
            _steganographyPreviewWindow.SetBitsNumberHide(bitsCount);
        }

        /// <summary>
        /// Funkcja odpowaida za aktualizacje opisu w oknie podgladu po zmianie wartosci ilosci wybranych pikseli dla okna odkrywania
        /// </summary>
        private void NumericUpDownShow_ValueChanged(object sender, EventArgs e)
        {
            var bitsCount = Convert.ToInt32(numericUpDownHide.Value);
            _steganographyPreviewWindow.SetBitsNumberShow(bitsCount);
        }

        protected override void OnClosed(EventArgs e)
        {
            _image?.Dispose();
            _imageToDecrypt?.Dispose();
            _imageToHide?.Dispose();
            base.OnClosed(e);
        }
    }
}
