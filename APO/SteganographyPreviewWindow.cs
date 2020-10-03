using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Czerniawski
{
    public partial class SteganographyPreviewWindow : Form
    {
        /// <summary>
        /// Głowne okno z którym okno podglądu jest połączone
        /// </summary>
        private readonly SteganographyWindow _steganographyWindow;  
        /// <summary>
        /// Referencja do PictureBoxa zawierajacego obraz na którym będzimy ukrywać
        /// </summary>
        private readonly PictureBox _pictureBoxImage;
        /// <summary>
        /// Referencja do PictureBoxa zawierajacego ukrywany obraz
        /// </summary>
        private readonly PictureBox _pictureBoxImageToHide;
        /// <summary>
        /// Referencja do PictureBoxa zawierajacego obraz wynikowy po operacji ukrycia
        /// </summary>
        private readonly PictureBox _pictureBoxResult;
        /// <summary>
        /// Referencja do PictureBoxa zawierajacego obraz z którego bedziemy odkrywać
        /// </summary>
        private readonly PictureBox _pictureBoxImageToDecrypt;
        /// <summary>
        /// Referencja do PictureBoxa zawierajacego obraz wynikowy po operacji odkrycia
        /// </summary>
        private readonly PictureBox _pictureBoxEncryptedImage;

        /// <summary>
        /// Tablica z adresami losowych pixeli do pokazania
        /// </summary>
        private int[,] randomPixelsHide = new int[5,2]; 
        /// <summary>
        /// Tablica z adresami losowych pixeli do pokazania
        /// </summary>
        private int[,] randomPixelsShow = new int[5,2];
        
        /// <summary>
        /// Klasa tworząca obiekt umozliwiający podgląd na żywo operacji steganografii
        /// </summary>
        /// <param name="steganographyWindow">Głowne okno z którym okno podglądu jest połączone</param>
        /// <param name="pictureBoxImage">Referencja do PictureBoxa zawierajacego obraz na którym będzimy ukrywać</param>
        /// <param name="pictureBoxImageToHide">Referencja do PictureBoxa zawierajacego ukrywany obraz</param>
        /// <param name="pictureBoxResult">Referencja do PictureBoxa zawierajacego obraz wynikowy po operacji ukrycia</param>
        /// <param name="pictureBoxImageToDecrypt">Referencja do PictureBoxa zawierajacego obraz z którego bedziemy odkrywać</param>
        /// <param name="pictureBoxEncryptedImage">Referencja do PictureBoxa zawierajacego obraz wynikowy po operacji odkrycia</param>
        public SteganographyPreviewWindow(SteganographyWindow steganographyWindow, PictureBox pictureBoxImage,PictureBox pictureBoxImageToHide,PictureBox pictureBoxResult,PictureBox pictureBoxImageToDecrypt,PictureBox pictureBoxEncryptedImage)
        {
            _steganographyWindow = steganographyWindow;
            _pictureBoxImage = pictureBoxImage;
            _pictureBoxImageToHide = pictureBoxImageToHide;
            _pictureBoxResult = pictureBoxResult;
            _pictureBoxImageToDecrypt = pictureBoxImageToDecrypt;
            _pictureBoxEncryptedImage = pictureBoxEncryptedImage;
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja wybiera 5 losowych pikseli z czerwonego kanału które zostaną wybrane jako podgląd wartosci obrazów służących do operacji steganografi, ustawia odpowiednie etykiety na wartosci binarne
        /// </summary>
        public void CalcHide()
        {
            //Wybieramy losowo 5 pikseli dla jakich zostanie zobrazowany przebieg algorytmu
            Random rnd = new Random();

            //Losowanie 5 pikseli
            for (int i = 0; i < 5; i++)
            {
                randomPixelsHide[i, 0] = rnd.Next(0, _pictureBoxImageToHide.Image.Width);  
                randomPixelsHide[i, 1] = rnd.Next(0, _pictureBoxImageToHide.Image.Height);
            }

            Bitmap image = new Bitmap(_pictureBoxImage.Image);

            //Ustawienie odpowiednich etykiet na binarne wartosci pikseli z kanału czerwonego
            labelImagePixel1.Text = Convert
                .ToString(image.GetPixel(randomPixelsHide[0, 0], randomPixelsHide[0, 1]).R, 2).PadLeft(8, '0');
            labelImagePixel2.Text = Convert
                .ToString(image.GetPixel(randomPixelsHide[1, 0], randomPixelsHide[1, 1]).R, 2).PadLeft(8, '0');
            labelImagePixel3.Text = Convert
                .ToString(image.GetPixel(randomPixelsHide[2, 0], randomPixelsHide[2, 1]).R, 2).PadLeft(8, '0');
            labelImagePixel4.Text = Convert
                .ToString(image.GetPixel(randomPixelsHide[3, 0], randomPixelsHide[3, 1]).R, 2).PadLeft(8, '0');
            labelImagePixel5.Text = Convert
                .ToString(image.GetPixel(randomPixelsHide[4, 0], randomPixelsHide[4, 1]).R, 2).PadLeft(8, '0');

            Bitmap imageToHide = new Bitmap(_pictureBoxImageToHide.Image);
            labelImageToHidePixel1.Text = Convert
                .ToString(imageToHide.GetPixel(randomPixelsHide[0, 0], randomPixelsHide[0, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageToHidePixel2.Text = Convert
                .ToString(imageToHide.GetPixel(randomPixelsHide[1, 0], randomPixelsHide[1, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageToHidePixel3.Text = Convert
                .ToString(imageToHide.GetPixel(randomPixelsHide[2, 0], randomPixelsHide[2, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageToHidePixel4.Text = Convert
                .ToString(imageToHide.GetPixel(randomPixelsHide[3, 0], randomPixelsHide[3, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageToHidePixel5.Text = Convert
                .ToString(imageToHide.GetPixel(randomPixelsHide[4, 0], randomPixelsHide[4, 1]).R, 2)
                .PadLeft(8, '0');
        }

        /// <summary>
        /// Ustawienie odpowiednich etykiet dla obrazu wynikowego wczesniej wybranych 5 losowych pikseli, po operacji ukrycia
        /// </summary>
        public void CalcHidden()
        {
            Bitmap imageResult = new Bitmap(_pictureBoxResult.Image);

            //Ustawienie odpowiednich etykiet na binarne wartosci pikseli z kanału czerwonego
            labelImageResultPixel1.Text = Convert
                .ToString(imageResult.GetPixel(randomPixelsHide[0, 0], randomPixelsHide[0, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageResultPixel2.Text = Convert
                .ToString(imageResult.GetPixel(randomPixelsHide[1, 0], randomPixelsHide[1, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageResultPixel3.Text = Convert
                .ToString(imageResult.GetPixel(randomPixelsHide[2, 0], randomPixelsHide[2, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageResultPixel4.Text = Convert
                .ToString(imageResult.GetPixel(randomPixelsHide[3, 0], randomPixelsHide[3, 1]).R, 2)
                .PadLeft(8, '0');
            labelImageResultPixel5.Text = Convert
                .ToString(imageResult.GetPixel(randomPixelsHide[4, 0], randomPixelsHide[4, 1]).R, 2)
                .PadLeft(8, '0');
        }

        /// <summary>
        /// Funkcja wybiera 5 losowych pikseli z czerwonego kanału które zostaną wybrane jako podgląd wartosci obrazu odkrywanego i odkrytego, ustawia odpowiednie etykiety na wartosci binarne
        /// </summary>
        public void CalcShow()
        {
            //Wybieramy losowo 5 pikseli dla jakich zostanie zobrazowany przebieg algorytmu
                Random rnd = new Random();

                for (int i = 0; i < 5; i++)
                {
                    randomPixelsShow[i, 0] = rnd.Next(0, _pictureBoxEncryptedImage.Image.Width);
                    randomPixelsShow[i, 1] = rnd.Next(0, _pictureBoxEncryptedImage.Image.Height);
                }

                Bitmap imageToDecrypt = new Bitmap(_pictureBoxImageToDecrypt.Image);

                //Ustawienie odpowiednich etykiet na binarne wartosci pikseli z kanału czerwonego
                labelImageToEncryptPixel1.Text = Convert
                    .ToString(imageToDecrypt.GetPixel(randomPixelsShow[0, 0], randomPixelsShow[0, 1]).R, 2)
                    .PadLeft(8, '0');
                labelImageToEncryptPixel2.Text = Convert
                    .ToString(imageToDecrypt.GetPixel(randomPixelsShow[1, 0], randomPixelsShow[1, 1]).R, 2)
                    .PadLeft(8, '0');
                labelImageToEncryptPixel3.Text = Convert
                    .ToString(imageToDecrypt.GetPixel(randomPixelsShow[2, 0], randomPixelsShow[2, 1]).R, 2)
                    .PadLeft(8, '0');
                labelImageToEncryptPixel4.Text = Convert
                    .ToString(imageToDecrypt.GetPixel(randomPixelsShow[3, 0], randomPixelsShow[3, 1]).R, 2)
                    .PadLeft(8, '0');
                labelImageToEncryptPixel5.Text = Convert
                    .ToString(imageToDecrypt.GetPixel(randomPixelsShow[4, 0], randomPixelsShow[4, 1]).R, 2)
                    .PadLeft(8, '0');

                Bitmap encryptedImage = new Bitmap(_pictureBoxEncryptedImage.Image);
                labelEncryptedImagePixel1.Text = Convert
                    .ToString(encryptedImage.GetPixel(randomPixelsShow[0, 0], randomPixelsShow[0, 1]).R, 2)
                    .PadLeft(8, '0');
                labelEncryptedImagePixel2.Text = Convert
                    .ToString(encryptedImage.GetPixel(randomPixelsShow[1, 0], randomPixelsShow[1, 1]).R, 2)
                    .PadLeft(8, '0');
                labelEncryptedImagePixel3.Text = Convert
                    .ToString(encryptedImage.GetPixel(randomPixelsShow[2, 0], randomPixelsShow[2, 1]).R, 2)
                    .PadLeft(8, '0');
                labelEncryptedImagePixel4.Text = Convert
                    .ToString(encryptedImage.GetPixel(randomPixelsShow[3, 0], randomPixelsShow[3, 1]).R, 2)
                    .PadLeft(8, '0');
                labelEncryptedImagePixel5.Text = Convert
                    .ToString(encryptedImage.GetPixel(randomPixelsShow[4, 0], randomPixelsShow[4, 1]).R, 2)
                    .PadLeft(8, '0');
        }

        /// <summary>
        /// Funkcja zamienia zakładki w oknie podgladu tak aby mogły zostać w synchronizacji z oknem głownym
        /// </summary>
        /// <param name="index">Numer aktualnie wybranej karty</param>
        public void SwapTabs(int index)
        {
            tabControl1.SelectTab(index);
        }

        /// <summary>
        /// Funkcja odpowiedzialna za zmiane zakładki w oknie głownym
        /// </summary>
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _steganographyWindow.SwapTabs(tabControl1.SelectedIndex);
        }
        /// <summary>
        /// Funkcja odpowiada za zmiane opisu na ilość wartości jakie mamy zwracać uwage podczas podgladu operacji w zakladce ukrywanie
        /// </summary>
        /// <param name="bitsCount">Liczba bitów na jakich ukrywany jest obraz</param>
        public void SetBitsNumberHide(int bitsCount)
        {
            labelImage.Text = "Obraz (interesuje nas " + (8-bitsCount) + " pierwszych bitów)";
            labelImageToHide.Text = "Ukrywany Obraz (interesuje nas " + bitsCount + " pierwszych bitów)";
        }

        /// <summary>
        /// Funkcja odpowiada za zmiane opisu na ilość wartości jakie mamy zwracać uwage podczas podgladu operacji w zakladce odkrywanie
        /// </summary>
        /// <param name="bitsCount"></param>
        public void SetBitsNumberShow(int bitsCount)
        {
            labelImageToDecode.Text = "Obraz (interesuje nas " + (bitsCount) + " ostatnich bitów)";
        }
    }
}
