using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Czerniawski
{
    public partial class StretchWindow : Form
    {
        //TODO Chnage it to load from window
        private int[] histoTab;
        private ImageWindow imageWindow;
        private int maxBmpLevel;
        private int upperValue = 255;
        private int bottomValue = 0;


        public StretchWindow(ImageWindow imageWindowRef)
        {
            InitializeComponent();
            imageWindow = imageWindowRef;
            pictureBox1.Image = (Image)imageWindowRef.getImage().Clone();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            histoTab = HistogramOperations.drawHistogram(chart1,pictureBox1.Image,maxBmpLevel);
            bottomValueTextBox.Text = bottomTrackBar.Value.ToString();
            upperValueTextBox.Text = upperTrackBar.Value.ToString();
        }

        private void stretchHisto()
        {
            Bitmap bm = new Bitmap(imageWindow.getImage());

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    if (c.R >= bottomTrackBar.Value && c.R < upperTrackBar.Value)
                    {
                        int q = (c.R - bottomTrackBar.Value) * (255/ (upperTrackBar.Value - bottomTrackBar.Value));
                        Color color = Color.FromArgb(255, q, q, q);
                        bm.SetPixel(x, y, color);
                    }
                }
            }

            pictureBox1.Image = bm;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            bottomValueTextBox.Text = bottomTrackBar.Value.ToString();
            upperValueTextBox.Text = upperTrackBar.Value.ToString();
            stretchHisto();
        }

        private void bottomTrackBar_Scroll(object sender, EventArgs e)
        {
            if (bottomTrackBar.Value > upperTrackBar.Value)
                upperTrackBar.Value = bottomTrackBar.Value + 1;
            bottomValueTextBox.Text = bottomTrackBar.Value.ToString();
            upperValueTextBox.Text = upperTrackBar.Value.ToString();
        }

        private void upperTrackBar_Scroll(object sender, EventArgs e)
        {
            if (upperTrackBar.Value < bottomTrackBar.Value)
                bottomTrackBar.Value = upperTrackBar.Value - 1;
            bottomValueTextBox.Text = bottomTrackBar.Value.ToString();
            upperValueTextBox.Text = upperTrackBar.Value.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            imageWindow.setNewImage(pictureBox1.Image);
            Close();
        }

        private void upperValueTextBox_Leave(object sender, EventArgs e)
        {
            

            if (Int32.TryParse(upperValueTextBox.Text, out upperValue))
            {
                if (upperValue > bottomValue && upperValue <= 255 && upperValue > 0)
                {
                    upperTrackBar.Value = upperValue;
                    stretchHisto();
                }
                else
                {
                    MessageBox.Show("Wprowadzone wartosci nie sa poprawne.", "Nie prawidłowe dane");
                    upperValueTextBox.Focus();
                    upperValueTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Wprowadzone wartosci nie sa poprawne.", "Nie prawidłowe dane");
            }
        }

        private void bottomValueTextBox_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(bottomValueTextBox.Text, out bottomValue))
            {

                if (bottomValue < upperValue && bottomValue < 255 && bottomValue >= 0)
                {
                    bottomTrackBar.Value = bottomValue;
                    stretchHisto();
                }
                else
                {
                    MessageBox.Show("Wprowadzone wartosci nie sa poprawne.", "Nie prawidłowe dane");
                    bottomValueTextBox.Focus();
                    bottomValueTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Wprowadzone wartosci nie sa poprawne.", "Nie prawidłowe dane");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image) imageWindow.getImage().Clone();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);

            bottomTrackBar.Value = 0;
            upperTrackBar.Value = 255;

            bottomValueTextBox.Text = "0";
            upperValueTextBox.Text = "255";
        }
    }
}
