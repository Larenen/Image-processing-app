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
    public partial class LogicalWindow : Form
    {
        private ImageWindow imageWindow;
        private int maxBMPLevel;

        public LogicalWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;
            pictureBox1.Image = (Image)imageWindow.getImage().Clone();
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);

        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(imageWindow.getImage());
            Bitmap resultbBitmap = new Bitmap(imageWindow.getImage().Width,imageWindow.getImage().Height);

            for (int x = 1; x < bm.Width - 1; x++)
            {
                for (int y = 1; y < bm.Height - 1; y++)
                {
                   if(uprightRadioButton.Checked)
                       if(bm.GetPixel(x,y-1).R == bm.GetPixel(x,y+1).R)
                           resultbBitmap.SetPixel(x,y,bm.GetPixel(x,y+1));
                       else
                           resultbBitmap.SetPixel(x,y,bm.GetPixel(x,y));
                   else if(horizontallyRadioButton.Checked)
                       if(bm.GetPixel(x-1,y).R == bm.GetPixel(x+1,y).R)
                           resultbBitmap.SetPixel(x,y,bm.GetPixel(x+1,y));
                   else
                           resultbBitmap.SetPixel(x,y,bm.GetPixel(x,y));
                   else if(bothRadioButton.Checked)
                       if(bm.GetPixel(x,y-1) == bm.GetPixel(x,y+1) && bm.GetPixel(x-1,y) == bm.GetPixel(x+1,y) && bm.GetPixel(x-1,y) == bm.GetPixel(x,y-1))
                           resultbBitmap.SetPixel(x,y,bm.GetPixel(x,y-1));
                   else
                           resultbBitmap.SetPixel(x,y,bm.GetPixel(x,y));
                }
            }

            pictureBox1.Image = resultbBitmap;
            HistogramOperations.clearHistogram(chart1);
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);
            acceptButton.Enabled = true;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            imageWindow.setNewImage(pictureBox1.Image);
            Close();
        }
    }
}
