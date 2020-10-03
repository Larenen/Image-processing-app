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
    public partial class BinaryOperations : Form
    {
        private int[] histoTab;
        private int maxBmpLevel;
        private MainWindow mainWindow;

        enum OperationType
        {
            Add,
            Sub,
            Or,
            And,
            Xor,
        }

        public BinaryOperations(List<NamedImage> images,MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            foreach (var image in images)
            {
                firstImageComboBox.Items.Add(image);
                secondImageComboBox.Items.Add(image);
            }

            operationComboBox.Items.Add(OperationType.Add);
            operationComboBox.Items.Add(OperationType.Sub);
            operationComboBox.Items.Add(OperationType.Or);
            operationComboBox.Items.Add(OperationType.And);
            operationComboBox.Items.Add(OperationType.Xor);

            operationComboBox.SelectedIndex = 0;
            firstImageComboBox.SelectedIndex = 0;
            secondImageComboBox.SelectedIndex = 0;
        }

        private void binaryOperation(Image image1, Image image2,OperationType operationType)
        {
            Bitmap bitmapImage1 = new Bitmap(image1);
            Bitmap bitmapImage2 = new Bitmap(image2);
            Bitmap bitmapNewImage = new Bitmap(bitmapImage1.Width,bitmapImage1.Height);

            if (bitmapImage1.Width == bitmapImage2.Width && bitmapImage1.Height == bitmapImage2.Height)
            {
                for (int x = 0; x < bitmapImage1.Width; x++)
                {
                    for (int y = 0; y < bitmapImage1.Height; y++)
                    {
                        Color c1 = bitmapImage1.GetPixel(x, y);
                        Color c2 = bitmapImage2.GetPixel(x, y);
                        int q = 0;

                        switch (operationType)
                        {
                            case OperationType.Add:
                                q = (c1.R + c2.R) / 2;
                                break;

                            case OperationType.Sub:
                                q = Math.Abs(c1.R - c2.R);
                                break;

                            case OperationType.Or:
                                q = c1.R | c2.R;
                                break;

                            case OperationType.And:
                                q = c1.R & c2.R;
                                break;

                            case OperationType.Xor:
                                q = c1.R ^ c2.R;
                                break;
                        }

                        bitmapNewImage.SetPixel(x, y, Color.FromArgb(255, q, q, q));
                    }
                }

                pictureBox1.Image = bitmapNewImage;
                HistogramOperations.clearHistogram(chart1);
                maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
                histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);
            }
            else
            {
                MessageBox.Show("Dla operacji dwuargumentowych, należy wybrać obrazy o takich samych wymiarach.", "Nie poprawne wymiary obrazów");
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            binaryOperation(((NamedImage)firstImageComboBox.SelectedItem).getImage(),((NamedImage)secondImageComboBox.SelectedItem).getImage(),(OperationType)operationComboBox.SelectedItem);

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            binaryOperation(((NamedImage)firstImageComboBox.SelectedItem).getImage(),((NamedImage)secondImageComboBox.SelectedItem).getImage(),(OperationType)operationComboBox.SelectedItem);
            ImageWindow imageWindow = new ImageWindow(pictureBox1.Image,"Nowy Obraz");
            imageWindow.MdiParent = mainWindow;
            imageWindow.Show();
            Close();
        }
    }
}
