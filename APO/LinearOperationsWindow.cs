using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Czerniawski
{
    public partial class LinearOperations : Form
    {
        private ImageWindow imageWindow;
        private Image currentImage;
        private int k = 0;
        private int maxBMPValue;
        private int minBMPValue;

        public LinearOperations(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;

            foreach (NumericUpDown numericUpDown in numericUpDownPanel.Controls)
            {
                numericUpDown.Minimum = -20;
                numericUpDown.Maximum = 20;
            }

            imageMethodsComboBox.Items.Add("Wygładzanie K=1/9");
            imageMethodsComboBox.Items.Add("Wygładzanie K=1/10");
            imageMethodsComboBox.Items.Add("Wygładzanie K=1/16");
            imageMethodsComboBox.Items.Add("Wyostrzanie Maska 1");
            imageMethodsComboBox.Items.Add("Wyostrzanie Maska 2");
            imageMethodsComboBox.Items.Add("Wyostrzanie Maska 3");
            imageMethodsComboBox.Items.Add("Wyostrzanie Maska 4");
            imageMethodsComboBox.Items.Add("Wyostrzanie Maska 5");
            imageMethodsComboBox.Items.Add("Detekcja Krawędzi Maska 1");
            imageMethodsComboBox.Items.Add("Detekcja Krawędzi Maska 2");
            imageMethodsComboBox.Items.Add("Detekcja Krawędzi Maska 3");
            imageMethodsComboBox.SelectedIndex = 0;

            scalingMethodsComboBox.Items.Add("Metoda Proporcjonalna");
            scalingMethodsComboBox.Items.Add("Metoda Trójwartościowa");
            scalingMethodsComboBox.Items.Add("Metoda Obcinająca");
            scalingMethodsComboBox.SelectedIndex = 0;

            pictureBox1.Image = (Image)this.imageWindow.getImage().Clone();
            maxBMPValue = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            minBMPValue = HistogramOperations.MinBmpLevel(pictureBox1.Image);
            //minBMPValue = 0;
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPValue);
        }

        private void imageMethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (imageMethodsComboBox.SelectedIndex)
            {
                case 0:
                    numericUpDown1.Value = 1;
                    numericUpDown2.Value = 1;
                    numericUpDown3.Value = 1;
                    numericUpDown4.Value = 1;
                    numericUpDown5.Value = 1;
                    numericUpDown6.Value = 1;
                    numericUpDown7.Value = 1;
                    numericUpDown8.Value = 1;
                    numericUpDown9.Value = 1;
                    break;
                case 1:
                    numericUpDown1.Value = 1;
                    numericUpDown2.Value = 1;
                    numericUpDown3.Value = 1;
                    numericUpDown4.Value = 1;
                    numericUpDown5.Value = 2;
                    numericUpDown6.Value = 1;
                    numericUpDown7.Value = 1;
                    numericUpDown8.Value = 1;
                    numericUpDown9.Value = 1;
                    break;
                case 2:
                    numericUpDown1.Value = 1;
                    numericUpDown2.Value = 2;
                    numericUpDown3.Value = 1;
                    numericUpDown4.Value = 2;
                    numericUpDown5.Value = 4;
                    numericUpDown6.Value = 2;
                    numericUpDown7.Value = 1;
                    numericUpDown8.Value = 2;
                    numericUpDown9.Value = 1;
                    break;
                case 3:
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 1;
                    numericUpDown3.Value = 0;
                    numericUpDown4.Value = 1;
                    numericUpDown5.Value = -4;
                    numericUpDown6.Value = 1;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = 1;
                    numericUpDown9.Value = 0;
                    break;
                case 4:
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = -1;
                    numericUpDown3.Value = 0;
                    numericUpDown4.Value = -1;
                    numericUpDown5.Value = 4;
                    numericUpDown6.Value = -1;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = -1;
                    numericUpDown9.Value = 0;
                    break;
                case 5:
                    numericUpDown1.Value = -1;
                    numericUpDown2.Value = -1;
                    numericUpDown3.Value = -1;
                    numericUpDown4.Value = -1;
                    numericUpDown5.Value = 8;
                    numericUpDown6.Value = -1;
                    numericUpDown7.Value = -1;
                    numericUpDown8.Value = -1;
                    numericUpDown9.Value = -1;
                    break;
                case 6:
                    numericUpDown1.Value = 1;
                    numericUpDown2.Value = -2;
                    numericUpDown3.Value = 1;
                    numericUpDown4.Value = -2;
                    numericUpDown5.Value = 4;
                    numericUpDown6.Value = -2;
                    numericUpDown7.Value = 1;
                    numericUpDown8.Value = -2;
                    numericUpDown9.Value = 1;
                    break;
                case 7:
                    numericUpDown1.Value = -1;
                    numericUpDown2.Value = -1;
                    numericUpDown3.Value = -1;
                    numericUpDown4.Value = -1;
                    numericUpDown5.Value = 9;
                    numericUpDown6.Value = -1;
                    numericUpDown7.Value = -1;
                    numericUpDown8.Value = -1;
                    numericUpDown9.Value = -1;
                    break;
                case 8:
                    numericUpDown1.Value = 1;
                    numericUpDown2.Value = -2;
                    numericUpDown3.Value = 1;
                    numericUpDown4.Value = -2;
                    numericUpDown5.Value = 5;
                    numericUpDown6.Value = -2;
                    numericUpDown7.Value = 1;
                    numericUpDown8.Value = -2;
                    numericUpDown9.Value = 1;
                    break;
                case 9:
                    numericUpDown1.Value = -1;
                    numericUpDown2.Value = -1;
                    numericUpDown3.Value = -1;
                    numericUpDown4.Value = -1;
                    numericUpDown5.Value = 9;
                    numericUpDown6.Value = -1;
                    numericUpDown7.Value = -1;
                    numericUpDown8.Value = -1;
                    numericUpDown9.Value = -1;
                    break;
                case 10:
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = -1;
                    numericUpDown3.Value = 0;
                    numericUpDown4.Value = -1;
                    numericUpDown5.Value = 5;
                    numericUpDown6.Value = -1;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = -1;
                    numericUpDown9.Value = 0;
                    break;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            imageWindow.setNewImage(currentImage);
            Close();
        }

        private void operatioCalc()
        {
            Bitmap bm = new Bitmap(imageWindow.getImage());
            Bitmap resultbBitmap = new Bitmap(imageWindow.getImage().Width,imageWindow.getImage().Height);

            for (int x = 1; x < bm.Width-1; x++)
            {

                for (int y = 1; y < bm.Height-1; y++)
                {
                    int avgN = (Convert.ToInt32(numericUpDown1.Value)*bm.GetPixel(x-1,y-1).R + Convert.ToInt32(numericUpDown2.Value)*bm.GetPixel(x-1, y).R + 
                                Convert.ToInt32(numericUpDown3.Value)*bm.GetPixel(x - 1, y + 1).R + Convert.ToInt32(numericUpDown4.Value)*bm.GetPixel(x, y-1).R + 
                                Convert.ToInt32(numericUpDown5.Value)*bm.GetPixel(x,y).R + Convert.ToInt32(numericUpDown6.Value)*bm.GetPixel(x, y+1).R + 
                                Convert.ToInt32(numericUpDown7.Value)*bm.GetPixel(x + 1, y - 1).R + Convert.ToInt32(numericUpDown8.Value)*bm.GetPixel(x+1, y).R +
                                Convert.ToInt32(numericUpDown9.Value)*bm.GetPixel(x + 1, y + 1).R)/k;
                    if (k == 1)
                    {
                        switch (scalingMethodsComboBox.SelectedIndex)
                        {
                         case 0:
                                avgN = ((avgN - minBMPValue) / (maxBMPValue - minBMPValue)) * 255;
                                //TODO Jak to ma w koncu dzialac
                                //avgN=(int)((((double)avgN - (double)0) / ((double)255 - (double)0)) * 255);
                                if (avgN > 255)
                                {
                                    avgN = 255;
                                }
                                else if (avgN < 0)
                                {
                                    avgN = 0;
                                }
                                break;
                         case 1:
                             if (avgN > 0)
                             {
                                 avgN = 255;
                             }
                             else if (avgN < 0)
                             {
                                 avgN = 0;
                             }
                             else
                             {
                                 avgN = 255/2;
                             }
                             break;
                         case 2:
                             if (avgN < 0)
                                 avgN = 0;
                             else if (avgN > 255)
                                 avgN = 255;
                             break;
                        }
                    }

                    try
                    {
                        resultbBitmap.SetPixel(x, y, Color.FromArgb(avgN, avgN, avgN));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Niepoprawna maska!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            currentImage = resultbBitmap;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calcK();
        }

        private void calcK()
        {
            int pom = Convert.ToInt32(numericUpDown1.Value) + Convert.ToInt32(numericUpDown2.Value) + Convert.ToInt32(numericUpDown3.Value) +
                      Convert.ToInt32(numericUpDown4.Value) + Convert.ToInt32(numericUpDown5.Value) + Convert.ToInt32(numericUpDown6.Value) +
                      Convert.ToInt32(numericUpDown7.Value) + Convert.ToInt32(numericUpDown8.Value) + Convert.ToInt32(numericUpDown9.Value);

            if (pom <= 1)
            {
                k = 1;
                scalingMethodsComboBox.Enabled = true;
            }
            else
            {
                k = pom;
                scalingMethodsComboBox.Enabled = false;
            }

            kLabel.Text = k.ToString();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            operatioCalc();
            pictureBox1.Image = currentImage;
            HistogramOperations.clearHistogram(chart1);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, HistogramOperations.MaxBmpLevel(pictureBox1.Image));
            acceptButton.Enabled = true;
        }
    }
}
