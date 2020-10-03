using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace APO_Czerniawski
{
    public partial class CompressWindow : Form
    {

        private Image imageClone;

        public CompressWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            imageClone = (Image)imageWindow.getImage().Clone();
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {

            ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/tiff");
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".tiff|*.tiff";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (radioButtonRle.Checked)
                {
                    myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionRle);
                    imageClone.Save(saveFileDialog.FileName, myImageCodecInfo, myEncoderParameters);
                }
                else if (radioButtonLZW.Checked)
                {
                    myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionLZW);
                    imageClone.Save(saveFileDialog.FileName, myImageCodecInfo, myEncoderParameters);
                }
                else if (radioButtonHuffman.Checked)
                {
                    myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionCCITT4);
                    imageClone.Save(saveFileDialog.FileName, myImageCodecInfo, myEncoderParameters);
                }
                else
                {
                    Bitmap bm = BlockCompress((Bitmap) imageClone, Convert.ToInt32(numericUpDownBlock.Value));
                    bm.Save(saveFileDialog.FileName,ImageFormat.Tiff);
                }

                MessageBox.Show("Zapisywanie powiodło się!");
            }
        }

        
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        //*******Source SokolowLineProfile13*******//
        private Bitmap BlockCompress(Bitmap bitmap, int value)
        {
            Bitmap bm = new Bitmap(bitmap);
            int newValuePixel = 0;

            for (int x = 0; x < bm.Width - (bm.Width % value); x += value)
            {
                for (int y = 0; y < bm.Height - (bm.Height % value); y += value)
                {
                    int average = 0, averageUp = 0, averageDown = 0;
                    int averageCount = 0, averageUpCount = 0, averageDownCount = 0;

                    for (int a = 0; a < value; ++a)
                    {
                        for (int b = 0; b < value; ++b)
                        {
                            Color c = bm.GetPixel(x+a, y+b);

                            average += c.R;
                            ++averageCount;
                        }
                    }

                    average = Convert.ToInt32((double) (average / averageCount));

                    for (int a = 0; a < value; ++a)
                    {
                        for (int b = 0; b < value; ++b)
                        {
                            Color c = bm.GetPixel(x + a, y + b);

                            if(c.R >= average)
                            {
                                averageUp += c.R;
                                ++averageUpCount;
                            }
                            else
                            {
                                averageDown += c.R;
                                ++averageDownCount;
                            }
                        }
                    }

                    if (averageUp > 0 && averageUpCount > 0)
                    {
                        averageUp = Convert.ToInt32((double)averageUp / averageUpCount);
                    }
                    else
                    {
                        averageUp = average;
                    }

                    if (averageDown > 0 && averageDownCount > 0)
                    {
                        averageDown = Convert.ToInt32((double)averageDown / averageDownCount);
                    }
                    else
                    {
                        averageDown = 0;
                    }

                    for(int a = 0; a < value; ++a)
                    {
                        for(int b = 0; b < value; ++b)
                        {
                            Color c = bm.GetPixel(x+a, y+b);

                            if (c.R >= average)
                            {
                                newValuePixel = averageUp;
                            }
                            else
                            {
                                newValuePixel = averageDown;
                            }

                            Color newColor = Color.FromArgb(255, newValuePixel, newValuePixel, newValuePixel);
                            bm.SetPixel(x+a, y+b, newColor);
                        }
                    }
                }
            }
            return bm;
        }
        //*******Source SokolowLineProfile13*******//

        private void RadioButtonBlokowy_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSize.Enabled = radioButtonBlokowy.Checked;
        }
    }
}
