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
    public partial class TresholdingWindow : Form
    {
        private ImageWindow imageWindow;
        private int maxBmpLevel;
        private int[] histoTab;

        public TresholdingWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;
            pictureBox1.Image = (Image)imageWindow.getImage().Clone();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            histoTab = HistogramOperations.drawHistogram(chart1,pictureBox1.Image,maxBmpLevel);

            //TrackBars and labels init
            bottomValueTrackBar.Maximum = maxBmpLevel;
            upperValueTrackBar.Maximum = maxBmpLevel;
            bottomValueLabel.Text = "0";
            upperValueLabel.Text = maxBmpLevel.ToString();
        }

        private void tresholding()
        {
            Bitmap bitmap= new Bitmap(imageWindow.getImage());
            histoTab = new int[2];

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    if (c.R <= bottomValueTrackBar.Value)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        histoTab[0]++;
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        histoTab[1]++;
                    }
                }
            }

            pictureBox1.Image = bitmap;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            chart1.Series["Series1"].Points.AddXY(0, histoTab[0]);
            chart1.Series["Series1"].Points.AddXY(1, histoTab[1]);
        }

        private void maintainingTresholding()
        {
            Bitmap bitmap= new Bitmap(imageWindow.getImage());

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    if (c.R <= bottomValueTrackBar.Value || c.R >= upperValueTrackBar.Value)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        histoTab[0]++;
                    }
                }
            }

            pictureBox1.Image = bitmap;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (maintainingTresholdingCheckBox.Checked)
                maintainingTresholding();
            else
                tresholding();
        }

        private void bottomTrackBar_Scroll(object sender, EventArgs e)
        {
            if (bottomValueTrackBar.Value > upperValueTrackBar.Value)
                upperValueTrackBar.Value = bottomValueTrackBar.Value + 1;
            bottomValueLabel.Text = bottomValueTrackBar.Value.ToString();
            upperValueLabel.Text = upperValueTrackBar.Value.ToString();
        }

        private void upperValueTrackBar_Scroll(object sender, EventArgs e)
        {
            if (upperValueTrackBar.Value < bottomValueTrackBar.Value)
                bottomValueTrackBar.Value = upperValueTrackBar.Value - 1;
            bottomValueLabel.Text = bottomValueTrackBar.Value.ToString();
            upperValueLabel.Text = upperValueTrackBar.Value.ToString();

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(maintainingTresholdingCheckBox.Checked)
                imageWindow.setNewImage(pictureBox1.Image);
            else
                imageWindow.setNewImage(pictureBox1.Image,histoTab);
            Close();
        }

        private void maintainingTresholdingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(maintainingTresholdingCheckBox.Checked)
                maintainingTresholding();
            else
                tresholding();

            upperValueTrackBar.Enabled = maintainingTresholdingCheckBox.Checked;
            upperValueLabel.Enabled = maintainingTresholdingCheckBox.Checked;
            label2.Enabled = maintainingTresholdingCheckBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)imageWindow.getImage().Clone();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);

            bottomValueTrackBar.Value = 0;
            upperValueTrackBar.Value = maxBmpLevel;

            bottomValueLabel.Text = "0";
            upperValueLabel.Text = maxBmpLevel.ToString();
        }
    }
}
