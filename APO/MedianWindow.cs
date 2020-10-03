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
    public partial class MedianWindow : Form
    {
        private Image currentImage;
        private ImageWindow imageWindow;
        private int maxBMPLevel;
        public MedianWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;

            firstDomainUpDown.SelectedIndex = 2;
            secondDomainUpDown.SelectedIndex = 2;

            pictureBox1.Image = (Image)imageWindow.getImage().Clone();
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);

        }

        private void calcMedian()
        {
            Bitmap bm = new Bitmap(imageWindow.getImage());
            Bitmap resultBitmap = new Bitmap(bm.Width, bm.Height);

            int width = Convert.ToInt32(firstDomainUpDown.SelectedItem);
            int height = Convert.ToInt32(secondDomainUpDown.SelectedItem);
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    int i = 0;
                    int[] medianArrayInts = new int[height * width];
                    for (int x1 = -width / 2; x1 <= width / 2; x1++)
                    {
                        for (int y1 = -height / 2; y1 <= height / 2; y1++)
                        {
                            if (x + x1 >= 0 && y + y1 >= 0 && x + x1 < bm.Width && y + y1 < bm.Height)
                            {
                                medianArrayInts[i++] = bm.GetPixel(x + x1, y + y1).R;
                            }
                        }
                    }
                    Array.Sort(medianArrayInts, 0, i);
                    if (i % 2 == 1)
                    {
                        resultBitmap.SetPixel(x, y, Color.FromArgb(medianArrayInts[i / 2], medianArrayInts[i / 2], medianArrayInts[i / 2]));
                    }
                    else
                    {
                        int val = (medianArrayInts[i / 2] + medianArrayInts[i / 2 + 1]) / 2;
                        resultBitmap.SetPixel(x, y, Color.FromArgb(val, val, val));
                    }
                }
            }
            currentImage = resultBitmap;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            calcMedian();
            pictureBox1.Image = currentImage;
            HistogramOperations.clearHistogram(chart1);
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);
            acceptButton.Enabled = true;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            imageWindow.setNewImage(currentImage);
            Close();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            firstDomainUpDown.SelectedIndex = 2;
            secondDomainUpDown.SelectedIndex = 2;

            pictureBox1.Image = (Image)imageWindow.getImage().Clone();
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);
        }
    }
}
