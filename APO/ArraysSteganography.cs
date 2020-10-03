using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APO;
using SourceGrid;

namespace APO_Czerniawski
{
    public partial class ArraysSteganography : Form
    {
        /// <summary>
        /// Tworzy nowe okno które tworzy tablice liczb RGB w postaci dziesiętnej oraz binarnej
        /// </summary>
        /// <param name="image">Obraz z jakiego mają zostać wyliczone tablice</param>
        /// <param name="name">Nazwa obrazu dla jakiego mają zostać wyznaczone wartości(może być dowolna)</param>
        public ArraysSteganography(Image image,string name)
        {
            InitializeComponent();
            Text = "Tablice wartości dla: " + name;
            int[,] intRDec = new int[image.Width,image.Height]; //Tablica zawierająca wartości pikseli dla kanału czerowonego w formacie dziesiętnym
            int[,] intGDec = new int[image.Width,image.Height]; //Tablica zawierająca wartości pikseli dla kanału zielonego w formacie dziesiętnym
            int[,] intBDec = new int[image.Width,image.Height]; //Tablica zawierająca wartości pikseli dla kanału niebieskiego w formacie dziesiętnym

            int[,] intRBin = new int[image.Width,image.Height]; //Tablica zawierająca wartości pikseli dla kanału czerowonego w formacie binarnym
            int[,] intGBin = new int[image.Width,image.Height]; //Tablica zawierająca wartości pikseli dla kanału zielonego w formacie binarnym
            int[,] intBBin = new int[image.Width,image.Height]; //Tablica zawierająca wartości pikseli dla kanału niebieskiego w formacie binarnym
            
            //Tworzymy bitmape z obrazu
            Bitmap bitmap = new Bitmap(image);

            //Przechodzimy po całym obrazku piksel po pikselu wyciągając kazdego wartość
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);

                    intRDec[i, j] = pixel.R;    //Zapisujemy wartości dziesiętne do odpowiednich tablic
                    intGDec[i, j] = pixel.G;
                    intBDec[i, j] = pixel.B;

                    intRBin[i,j] = Convert.ToInt32(Convert.ToString(pixel.R, 2).PadLeft(8, '0'));   //Konwersja na system binarny + zapis do odpowiedniej tablicy
                    intGBin[i,j] = Convert.ToInt32(Convert.ToString(pixel.G, 2).PadLeft(8, '0'));
                    intBBin[i,j] = Convert.ToInt32(Convert.ToString(pixel.B, 2).PadLeft(8, '0'));
                }
            }

            CreateImageGridDec(intRDec, tabPageRDec);   //Tworzy tabele dla odpowiedniego kanału oraz systemu liczbowego
            CreateImageGridDec(intGDec, tabPageGDec);
            CreateImageGridDec(intBDec, tabPageBDec);

            CreateImageGridDec(intRBin, tabPageRBin);
            CreateImageGridDec(intGBin, tabPageGBin);
            CreateImageGridDec(intBBin, tabPageBBin);

        }

        /// <summary>
        /// Tworzy tablice z wartosciami liczbowymi i umieszcza ja w odpowiedniej stronie kontrolki TabControl
        /// </summary>
        /// <param name="array">Dwuwymiarowa tablica wartości z jakiej ma zostać utworzona tablica w Formie</param>
        /// <param name="pageToAttachTo">Strona w jakiej ma zostać umieszczona tablica</param>
        public void CreateImageGridDec(int[,] array, TabPage pageToAttachTo)
        {
            ImageGrid grid = new ImageGrid();
            pageToAttachTo.Controls.Add(grid);
            grid.FixedColumns = 1;
            grid.FixedRows = 1;
            grid.BorderStyle = BorderStyle.Fixed3D;
            grid.Dock = DockStyle.Fill;
            grid.DataSource = array;
        }
    }
}
