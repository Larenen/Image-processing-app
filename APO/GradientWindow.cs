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
    public partial class GradientWindow : Form
    {
        private ImageWindow imageWindow;
        private int maxBMPLevel;
        private int minBMPLevel;

        private int[,] XRoberts = { { 1, 0 }, { 0, -1 } };
        private int[,] YRoberts = { { 0, -1 }, { 1, 0 } };

        private int[,] XSobel = { { -1, 0, 1 }, { -2, 0, 2 },{-1,0,1} };
        private int[,] YSobel = { { -1, -2, -1 }, { 0, 0,0 },{1 ,2 ,1} };

        private int[,] NPrewitt = {{1, 1, 1}, {1, -2, 1}, {-1, -1, -1}};
        private int[,] SPrewitt = {{-1, -1, -1}, {1, -2, 1}, {1, 1, 1}};

        private int[,] NKirsch = {{3, 3, 3}, {3, 0, 3}, {-5, -5, -5}};
        private int[,] SKirsch = {{-5, -5, -5}, {3, 0, 3}, {3, 3, 3}};

        public GradientWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;
            pictureBox1.Image = (Image)imageWindow.getImage().Clone();
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            minBMPLevel = HistogramOperations.MinBmpLevel(pictureBox1.Image);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);

            masksComboBox.Items.Add("Maska Robertsa");
            masksComboBox.Items.Add("Maska Sobela");
            masksComboBox.Items.Add("Maski Prewitta");
            masksComboBox.Items.Add("Maski Kirscha");
            masksComboBox.SelectedIndex = 0;

            scalingMethodsComboBox.Items.Add("Metoda Proporcjonalna");
            scalingMethodsComboBox.Items.Add("Metoda Trójwartościowa");
            scalingMethodsComboBox.Items.Add("Metoda Obcinająca");
            scalingMethodsComboBox.SelectedIndex = 0;

            directionComboBox.Items.Add("N");
            directionComboBox.Items.Add("S");

            directionComboBox.Visible = false;
            directionLabel.Visible = false;
        }

        private void masksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (masksComboBox.SelectedIndex)
            {
                case 0:
                    maskTextBox.Clear();
                    maskTextBox.AppendText($"{XRoberts[0,0]}  {XRoberts[0,1]} | {YRoberts[0,0]}  {YRoberts[0,1]} {Environment.NewLine}");
                    maskTextBox.AppendText($"{XRoberts[1,0]}  {XRoberts[1,1]} | {YRoberts[1,0]}  {YRoberts[1,1]} {Environment.NewLine}");
                    directionComboBox.Visible = false;
                    directionLabel.Visible = false;
                    break;
                case 1:
                    maskTextBox.Clear();
                    maskTextBox.AppendText($"{XSobel[0,0]}  {XSobel[0,1]}  {XSobel[0,2]} | {YSobel[0,0]}  {YSobel[0,1]}  {YSobel[0,2]} {Environment.NewLine}");
                    maskTextBox.AppendText($"{XSobel[1,0]}  {XSobel[1,1]}  {XSobel[1,2]} | {YSobel[1,0]}  {YSobel[1,1]}  {YSobel[1,2]} {Environment.NewLine}");
                    maskTextBox.AppendText($"{XSobel[2,0]}  {XSobel[2,1]}  {XSobel[2,2]} | {YSobel[2,0]}  {YSobel[2,1]}  {YSobel[2,2]} {Environment.NewLine}");
                    directionComboBox.Visible = false;
                    directionLabel.Visible = false;
                    break;
                case 2:
                    directionComboBox.SelectedIndex = -1;
                    directionComboBox.SelectedIndex = 0;
                    directionComboBox.Visible = true;
                    directionLabel.Visible = true;
                    break;
                case 3:
                    directionComboBox.SelectedIndex = -1;
                    directionComboBox.SelectedIndex = 0;
                    directionComboBox.Visible = true;
                    directionLabel.Visible = true;
                    break;
            }
        }

        private int scaleColor(int color)
        {
            switch (scalingMethodsComboBox.SelectedIndex)
            {
                case 0:
                    color = ((color - minBMPLevel) / (maxBMPLevel - minBMPLevel)) * 255;
                    //TODO Jak to ma w koncu dzialac
                    //color=(int)((((double)color - (double)0) / ((double)255 - (double)0)) * 255);
                    if (color > 255)
                    {
                        color = 255;
                    }
                    else if (color < 0)
                    {
                        color = 0;
                    }
                    break;
                case 1:
                    if (color > 0)
                    {
                        color = maxBMPLevel;
                    }
                    else if (color < 0)
                    {
                        color = 0;
                    }
                    else
                    {
                        color = maxBMPLevel/2;
                    }
                    break;
                case 2:
                    if (color < 0)
                        color = 0;
                    else if (color > maxBMPLevel)
                        color = maxBMPLevel;
                    break;
            }

            return color;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(imageWindow.getImage());
            Bitmap resultbBitmap = new Bitmap(imageWindow.getImage().Width,imageWindow.getImage().Height);
            Color c;
            int color;

            for (int x = 1; x < bm.Width - 1; x++)
            {
                for (int y = 1; y < bm.Height - 1; y++)
                {
                    switch (masksComboBox.SelectedIndex)
                    {
                        case 0:
                            int gx = Math.Abs(bm.GetPixel(x, y).R - bm.GetPixel(x + 1, y + 1).R); 
                            int gy = Math.Abs(bm.GetPixel(x+1, y).R - bm.GetPixel(x, y + 1).R);
                            color = scaleColor(gx + gy);
                            c = Color.FromArgb(color,color,color);
                            resultbBitmap.SetPixel(x,y,c);
                            break;

                        case 1:
                            int sx = (bm.GetPixel(x-1, y-1).R + 2*bm.GetPixel(x, y - 1).R + bm.GetPixel(x +1, y - 1).R) -
                                              (bm.GetPixel(x-1, y + 1).R + 2*bm.GetPixel(x, y + 1).R + bm.GetPixel(x+1, y + 1).R); 
                            int sy = (bm.GetPixel(x+1, y-1).R + 2*bm.GetPixel(x+1, y).R + bm.GetPixel(x +1, y + 1).R) -
                                              (bm.GetPixel(x-1, y - 1).R + 2*bm.GetPixel(x-1, y).R + bm.GetPixel(x-1, y + 1).R); 
                            color = scaleColor(Convert.ToInt32(Math.Sqrt(Math.Pow(sx,2) + Math.Pow(sy,2))));
                            c = Color.FromArgb(color,color,color);
                            resultbBitmap.SetPixel(x,y,c);
                            break;

                        case 2:
                            if (directionComboBox.SelectedIndex == 0)
                            {
                                int avgN =
                                    NPrewitt[0,0] * bm.GetPixel(x - 1, y - 1).R +
                                    NPrewitt[0,1] * bm.GetPixel(x - 1, y).R +
                                    NPrewitt[0,2] * bm.GetPixel(x - 1, y + 1).R +
                                    NPrewitt[1,0] * bm.GetPixel(x, y - 1).R +
                                    NPrewitt[1,1] * bm.GetPixel(x, y).R +
                                    NPrewitt[1,2] * bm.GetPixel(x, y + 1).R +
                                    NPrewitt[2,0] * bm.GetPixel(x + 1, y - 1).R +
                                    NPrewitt[2,1] * bm.GetPixel(x + 1, y).R +
                                    NPrewitt[2,2] * bm.GetPixel(x + 1, y + 1).R;
                                color = scaleColor(avgN);
                                c = Color.FromArgb(color,color,color);
                                resultbBitmap.SetPixel(x,y,c);
                            }
                            else if(directionComboBox.SelectedIndex == 1)
                            {
                                int avgN =
                                    SPrewitt[0,0] * bm.GetPixel(x - 1, y - 1).R +
                                    SPrewitt[0,1] * bm.GetPixel(x - 1, y).R +
                                    SPrewitt[0,2] * bm.GetPixel(x - 1, y + 1).R +
                                    SPrewitt[1,0] * bm.GetPixel(x, y - 1).R +
                                    SPrewitt[1,1] * bm.GetPixel(x, y).R +
                                    SPrewitt[1,2] * bm.GetPixel(x, y + 1).R +
                                    SPrewitt[2,0] * bm.GetPixel(x + 1, y - 1).R +
                                    SPrewitt[2,1] * bm.GetPixel(x + 1, y).R +
                                    SPrewitt[2,2] * bm.GetPixel(x + 1, y + 1).R;
                                color = scaleColor(avgN);
                                c = Color.FromArgb(color,color,color);
                                resultbBitmap.SetPixel(x,y,c);
                            }
                            break;

                        case 3:
                            if (directionComboBox.SelectedIndex == 0)
                            {
                                int avgN =
                                    NKirsch[0,0] * bm.GetPixel(x - 1, y - 1).R +
                                    NKirsch[0,1] * bm.GetPixel(x - 1, y).R +
                                    NKirsch[0,2] * bm.GetPixel(x - 1, y + 1).R +
                                    NKirsch[1,0] * bm.GetPixel(x, y - 1).R +
                                    NKirsch[1,1] * bm.GetPixel(x, y).R +
                                    NKirsch[1,2] * bm.GetPixel(x, y + 1).R +
                                    NKirsch[2,0] * bm.GetPixel(x + 1, y - 1).R +
                                    NKirsch[2,1] * bm.GetPixel(x + 1, y).R +
                                    NKirsch[2,2] * bm.GetPixel(x + 1, y + 1).R;
                                color = scaleColor(avgN);
                                c = Color.FromArgb(color,color,color);
                                resultbBitmap.SetPixel(x,y,c);
                            }
                            else if(directionComboBox.SelectedIndex == 1)
                            {
                                int avgN =
                                    SKirsch[0,0] * bm.GetPixel(x - 1, y - 1).R +
                                    SKirsch[0,1] * bm.GetPixel(x - 1, y).R +
                                    SKirsch[0,2] * bm.GetPixel(x - 1, y + 1).R +
                                    SKirsch[1,0] * bm.GetPixel(x, y - 1).R +
                                    SKirsch[1,1] * bm.GetPixel(x, y).R +
                                    SKirsch[1,2] * bm.GetPixel(x, y + 1).R +
                                    SKirsch[2,0] * bm.GetPixel(x + 1, y - 1).R +
                                    SKirsch[2,1] * bm.GetPixel(x + 1, y).R +
                                    SKirsch[2,2] * bm.GetPixel(x + 1, y + 1).R;
                                color = scaleColor(avgN);
                                c = Color.FromArgb(color,color,color);
                                resultbBitmap.SetPixel(x,y,c);
                            }
                            break;
                    }

                }
            }

            pictureBox1.Image = resultbBitmap;
            HistogramOperations.clearHistogram(chart1);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, HistogramOperations.MaxBmpLevel(pictureBox1.Image));
        }

        private void directionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (directionComboBox.SelectedIndex)
            {
                case 0:
                    if (masksComboBox.SelectedIndex == 2)
                    {
                        maskTextBox.Clear();
                        maskTextBox.AppendText($"{NPrewitt[0,0]}  {NPrewitt[0,1]}  {NPrewitt[0,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{NPrewitt[1,0]}  {NPrewitt[1,1]}  {NPrewitt[1,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{NPrewitt[2,0]}  {NPrewitt[2,1]}  {NPrewitt[2,2]}  {Environment.NewLine}");
                    }
                    else if (masksComboBox.SelectedIndex == 3)
                    {
                        maskTextBox.Clear();
                        maskTextBox.AppendText($"{NKirsch[0,0]}  {NKirsch[0,1]}  {NKirsch[0,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{NKirsch[1,0]}  {NKirsch[1,1]}  {NKirsch[1,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{NKirsch[2,0]}  {NKirsch[2,1]}  {NKirsch[2,2]}  {Environment.NewLine}");
                    }
                    break;
                case 1:
                    if (masksComboBox.SelectedIndex == 2)
                    {
                        maskTextBox.Clear();
                        maskTextBox.AppendText($"{SPrewitt[0,0]}  {SPrewitt[0,1]}  {SPrewitt[0,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{SPrewitt[1,0]}  {SPrewitt[1,1]}  {SPrewitt[1,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{SPrewitt[2,0]}  {SPrewitt[2,1]}  {SPrewitt[2,2]}  {Environment.NewLine}");
                    }
                    else if (masksComboBox.SelectedIndex == 3)
                    {
                        maskTextBox.Clear();
                        maskTextBox.AppendText($"{SKirsch[0,0]}  {SKirsch[0,1]}  {SKirsch[0,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{SKirsch[1,0]}  {SKirsch[1,1]}  {SKirsch[1,2]}  {Environment.NewLine}");
                        maskTextBox.AppendText($"{SKirsch[2,0]}  {SKirsch[2,1]}  {SKirsch[2,2]}  {Environment.NewLine}");
                    }
                    break;
            }
        }
    }
}
