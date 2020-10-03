using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace APO_Czerniawski
{
    public partial class MorphologicalWindow : Form
    {
        private readonly ImageWindow imageWindow;
        private int maxBMPLevel;
        Bitmap bitmapCopy;
        private Image<Gray, Byte> acttualImage;

        public MorphologicalWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;
            pictureBox1.Image = (Image)imageWindow.getImage().Clone();
            acttualImage = new Image<Gray, byte>((Bitmap)pictureBox1.Image);
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);
            bitmapCopy = (Bitmap)imageWindow.getImage().Clone();
        }

        private void ButtonPreview_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> sourceImage = acttualImage;
            Image<Gray, Byte> dstImage = new Image<Gray, Byte>(sourceImage.Width, sourceImage.Height);
            Mat structuringElement;

            if (radioButtonFourNeighbors.Checked)
                structuringElement = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
            else
                structuringElement = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

            if (radioButtonErode.Checked)
                CvInvoke.Erode(sourceImage, dstImage, structuringElement, new Point(-1, -1), (int)numericUpDownIterations.Value, Emgu.CV.CvEnum.BorderType.Replicate, new MCvScalar(1));
            else if (radioButtonDilatation.Checked)
                CvInvoke.Dilate(sourceImage, dstImage, structuringElement, new Point(-1, -1), (int)numericUpDownIterations.Value, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(1));
            else if (radioButtonOpen.Checked)
                CvInvoke.MorphologyEx(sourceImage, dstImage, Emgu.CV.CvEnum.MorphOp.Open, structuringElement, new Point(-1, -1), (int)numericUpDownIterations.Value, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(1));
            else if (radioButtonClose.Checked)
                CvInvoke.MorphologyEx(sourceImage, dstImage, Emgu.CV.CvEnum.MorphOp.Close, structuringElement, new Point(-1, -1), (int)numericUpDownIterations.Value, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(1));

            acttualImage = dstImage;
            pictureBox1.Image = dstImage.ToBitmap();
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);

            buttonSave.Enabled = true;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmapCopy;
            acttualImage = new Image<Gray, byte>(bitmapCopy);
            maxBMPLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBMPLevel);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            imageWindow.setNewImage(pictureBox1.Image);
            Close();
            
        }
    }
}
