using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO_Czerniawski
{
    class Steganography
    {
        /// <summary>
        /// Funkcja służąca do ukrywania obrazu w obrazie
        /// </summary>
        /// <param name="image">Obraz na jakim planujemy ukryć wiadomość</param>
        /// <param name="imageToHide">Obraz jaki planujemy ukryć</param>
        /// <param name="onNumberBitesToHide">Ilość bitów na jakich ukrywamy obraz</param>
        /// <param name="pictureBox">PictureBox w jakim ma zostać wyswietlony obraz wyjsciowy</param>
        /// <returns></returns>
        public static bool HideImage(Image image,Image imageToHide,int onNumberBitesToHide,PictureBox pictureBox)
        {
            //Sprawdzamy czy obraz do ukrycia jest mniejszy niz ten na jakim chcemy ukryc, w przeciwnym wypadku steganografia jest nie mozliwa
            if (imageToHide.Width > image.Width || imageToHide.Height > image.Height)
            {
                MessageBox.Show("Obraz ktory chcesz ukryć jest większy niż obraz w którym ma być on ukryty",
                    "Błędne rozmiary");
                return false;
            }

            Bitmap newImage = new Bitmap(image.Width, image.Height);
            Bitmap bitmapImage = new Bitmap(image);
            Bitmap bitmapImageToHide = new Bitmap(imageToHide);

            //Przechodzimy przez cały obraz piksel po pikselu na ktorym bedziemy zapisywac drugi obraz
            for (int i = 0; i < bitmapImage.Width; i++)
            {
                for (int j = 0; j < bitmapImage.Height; j++)
                {
                    string[] rgbImage = RgbToBinary(bitmapImage.GetPixel(i, j));       //Zamieniamy kolor danego piksela z wszystkich 3 kanałow RGB na system binarny i zapisujemy w tablicy stringow
                    string[] rgbImageToHide = RgbToBinary(Color.Black);                         //Zamieniamy kolor czarny z wszystkich 3 kanałow RGB na system binarny i zapisujemy w tablicy stringow

                    if (i < bitmapImageToHide.Width && j < bitmapImageToHide.Height)            //Sprawdzamy czy piksel z obrazu na ktorym bedziemy ukyrwać ma swój odpowiednik w obrazie ukrywanym
                        rgbImageToHide = RgbToBinary(bitmapImageToHide.GetPixel(i, j)); //Jezeli tak to konwertujemy kolor z wszystkich 3 kanałów na system binarny

                    string[] newRgb = MergeRgb(rgbImage, rgbImageToHide, onNumberBitesToHide);  //Dokonujemy złączenia 8-x najbardziej znaczących bitów z obrazu na ktorym ukrywamy z x najbardziej znaczacymi bitami z obrazu ukrywanego

                    newImage.SetPixel(i, j, BinaryToRgb(newRgb));       //Ustawiamy wartosc nowo wyznaczonego piksela wczesniej konwertujac liczby z systemu binarnego na Color
                }
            }

            pictureBox.Image = newImage;        //Ustawiamy obraz wynikowy do wyswietlenia

            return true;    //Zwracamy true po udanym zakoczenie ukrywania
        }

        /// <summary>
        /// Funkcja słuzy do odkrywania obrazu z obrazu na którym wcześniej został ukryty obrazek.
        /// </summary>
        /// <param name="imageToDecrypt">Obraz z jakiego odczytamy ukryty w nim obraz</param>
        /// <param name="onNumberBitesToHide">Ilość bitów na jakich ukryty jest obraz</param>
        /// <param name="pictureBox">PictureBox w jakim ma zostać wyswietlony obraz wyjsciowy</param>
        /// <returns></returns>
        public static bool UnhideImage(Image imageToDecrypt,int onNumberBitesToHide,PictureBox pictureBox)
        {
            Bitmap toDecryptImageBitmap = new Bitmap(imageToDecrypt);
            Bitmap decryptedImageBitmap = new Bitmap(toDecryptImageBitmap.Width, toDecryptImageBitmap.Height);
            int[] originalSize = new int[2] {0, 0};

            //Przechodzimy przez cały obraz piksel po pikselu
            for (int i = 0; i < toDecryptImageBitmap.Width; i++)
            {
                for (int j = 0; j < toDecryptImageBitmap.Height; j++)
                {
                    string[] rgbToDecrypt = RgbToBinary(toDecryptImageBitmap.GetPixel(i, j));   //Zamieniamy kolor danego piksela z wszystkich 3 kanałow RGB na system binarny i zapisujemy w tablicy stringow

                    string[] decryptedRgb = DecryptRgb(rgbToDecrypt,onNumberBitesToHide);   //Z kazdego z 3 kanałów odkrywamy ukryte wartosći według zadanego parametru

                    decryptedImageBitmap.SetPixel(i, j, BinaryToRgb(decryptedRgb));  //Zamienieamy odkryte wartosci na Color i umiesczamy je w pikselu

                    if (decryptedImageBitmap.GetPixel(i, j) != Color.FromArgb(0, 0, 0))  //Sprawdzamy czy pixel w danym miejscu jest czarny jezeli nie to inkrementujemy zmienne ktore pomoga nam w odtworzeniu rozmiaru ukrytego obrazka
                    {
                        originalSize[0] = i + 1;
                        originalSize[1] = j + 1;
                    }
                }
            }

            Rectangle section = new Rectangle(0, 0, originalSize[0], originalSize[1]); //Tworzymy prostokąt ktory wyznacza obszar naszego ukrytego obrazu
            if (section.Width > 0 && section.Height > 0)
                decryptedImageBitmap = decryptedImageBitmap.Clone(section, PixelFormat.Format24bppRgb); //Przycinamy obraz wyjsciowy do odpowiedniego rozmiaru

            pictureBox.Image = decryptedImageBitmap; //Ustawiamy obraz wynikowy

            return true;    //Zwracamy true poniewaz odkrywanie sie udało
        }

        /// <summary>
        /// Funkcja służy do wyciągania okreslonej ilości najmniej znaczacych bitów z pixela zapisanego binarnie i stworzenia "odkodowanego" piksela
        /// </summary>
        /// <param name="rgbToDecrypt">Tablica stringow zawierajaca wartosci rgb zapisane w systemie binarnym</param>
        /// <param name="onNumberBitesToHide"> Liczba bitow na jakim zostal ukryty obraz</param>
        /// <returns></returns>
        private static string[] DecryptRgb(string[] rgbToDecrypt,int onNumberBitesToHide)
        {
            string[] encryptedRgb = new string[3];

            encryptedRgb[0] = rgbToDecrypt[0].Substring(8 - onNumberBitesToHide, onNumberBitesToHide).PadRight(8, '0'); //Z obrazu wycinamy interesujace nas najmniej znaczace bity w liczbie zadanej przez uzytkownika,uzupelniajac je zerami z prawej strony tak by dopelnic do 8
            encryptedRgb[1] = rgbToDecrypt[1].Substring(8 - onNumberBitesToHide, onNumberBitesToHide).PadRight(8, '0');
            encryptedRgb[2] = rgbToDecrypt[2].Substring(8 - onNumberBitesToHide, onNumberBitesToHide).PadRight(8, '0');

            return encryptedRgb;
        } 

        /// <summary>
        /// Funkcja służy do konwersji koloru na tablice stringow zawierajaca binarna reprezentacje koloru piksela z 3 kanałów RGB
        /// </summary>
        /// <param name="color">Reprezentacja koloru ktory chcemy zapisac binarnie</param>
        /// <returns></returns>
        private static string[] RgbToBinary(Color color)
        {
            string[] strings = new string[3];
            strings[0] = Convert.ToString(color.R, 2).PadLeft(8, '0');  //Dokonujemy zamiany wartosci decymalnej na binarną, w przypadku kiedy liczba nie jest zapisana na 8 bitach dodwane są zera z lewej strony tak aby zawsze było 8 bitów
            strings[1] = Convert.ToString(color.G, 2).PadLeft(8, '0');
            strings[2] = Convert.ToString(color.B, 2).PadLeft(8, '0');

            return strings;
        }

        /// <summary>
        /// Funkcja słuzy do łączenia wartości bitowej dwóch pikseli w odpowiedni sposób zadany przez argument bitsToSave
        /// </summary>
        /// <param name="rgb1">Tablica stringów reprezentująca wartości 3 kanałów RGB w postaci binarnej</param>
        /// <param name="rgb2">Tablica stringów reprezentująca wartości 3 kanałów RGB w postaci binarnej</param>
        /// <param name="bitsToSave">Liczba wyrażająca ilość najmniej znaczących bitów na jakie ma zostać wpisane rgb2</param>
        /// <returns></returns>
        private static string[] MergeRgb(string[] rgb1, string[] rgb2,int bitsToSave)
        {
            string[] mergedStrings = new string[3];

            mergedStrings[0] = rgb1[0].Substring(0, 8-bitsToSave) + rgb2[0].Substring(0, bitsToSave);   //Dodaje do siebie 8-x najbardziej znaczących bitów danego kanału piksela1 i x najbardziej znaczących bitów danego kanału piksela2
            mergedStrings[1] = rgb1[1].Substring(0, 8-bitsToSave) + rgb2[1].Substring(0, bitsToSave);
            mergedStrings[2] = rgb1[2].Substring(0, 8-bitsToSave) + rgb2[2].Substring(0, bitsToSave);

            return mergedStrings;
        }

        /// <summary>
        /// Funkcja słuzy do zamiany tablicy stringów zawierającej wartości binarne kolorow z 3 kanałów RBG do koloru w C#
        /// </summary>
        /// <param name="strings">Tablica stringów zawierająca wartosci binarne</param>
        /// <returns></returns>
        private static Color BinaryToRgb(string[] strings)
        {
            Color newValue = Color.FromArgb(Convert.ToInt32(strings[0], 2), Convert.ToInt32(strings[1], 2),
                Convert.ToInt32(strings[2], 2));

            return newValue;
        }
    }
}
