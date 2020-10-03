using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.XImgproc;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace APO_Czerniawski
{
    public partial class ImageWindow : Form
    {
        private readonly MainWindow _main;
        private int[] histoTab;
        public string FilePath { get; set; }
        private int maxBmpLevel = 0;

        /// <summary>
        /// Przetrzymuje informacje o tym czy mysz jest wcisnięta
        /// </summary>
        private Boolean bHaveMouse;

        /// <summary>
        /// Początkowy punkt wycinania
        /// </summary>
        private Point ptOriginal = new Point();

        /// <summary>
        /// Końcowy punkt wycinania
        /// </summary>
        private Point ptLast = new Point();

        /// <summary>
        /// Kształt do wycięcia z obrazu
        /// </summary>
        private Rectangle rectCropArea;

        /// <summary>
        /// Obraz wczytany z dysku
        /// </summary>
        private Image _image;

        public ImageWindow(string fp,string name,MainWindow main)
        {
            _main = main;
            InitializeComponent();
            FilePath = fp;
            Text = name;
            _image = Image.FromFile(fp);
            pictureBox1.Image = _image;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);

        }

        public ImageWindow(Image image,string name,MainWindow main)
        {
            _main = main;
            InitializeComponent();
            Text = name;
            _image = image;
            pictureBox1.Image = image;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);
        }

        public ImageWindow(Image image, string name)
        {
            InitializeComponent();
            Text = name;
            _image = image;
            pictureBox1.Image = image;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);
        }

        //To cloning window
        private ImageWindow(string fp, PictureBox pB, string name)
        {
            InitializeComponent();
            FilePath = fp;
            Text = name;
            _image = (Image)pB.Image.Clone();
            pictureBox1.Image = _image;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);
        }

        protected override void OnClosed(EventArgs e)
        {
            _image.Dispose();
            base.OnClosed(e);
        }

        public ImageWindow clone(string name)
        {
            return new ImageWindow(name, pictureBox1,Path.GetFileName(name));
        }

        public Image getImage()
        {
            return pictureBox1.Image;
        }

        public void setNewImage(Image image)
        {
            pictureBox1.Image = image;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);

        }

        public void setNewImage(Image image,int[] histTab)
        {
            pictureBox1.Image = image;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = histTab;
            chart1.Series["Series1"].Points.AddXY(0, histoTab[0]);
            chart1.Series["Series1"].Points.AddXY(1, histoTab[1]);

        }


        public void avgMethodHisto()
        {
            int hAvg = 0;
            int R = 0;
            int Hint = 0;
            int[] left = new int[maxBmpLevel+1];
            int[] right = new int[maxBmpLevel+1];
            int[] newValue = new int [maxBmpLevel+1];

            for (int i = 0; i < histoTab.Length; i++)
            {
                hAvg += histoTab[i];
            }

            Bitmap bm = new Bitmap(pictureBox1.Image);
            hAvg = hAvg / maxBmpLevel;

            for (int Z = 0; Z < histoTab.Length; Z++)
            {
                left[Z] = R;
                Hint = Hint + histoTab[Z];
                while (Hint > hAvg)
                {
                    Hint = Hint - hAvg;
                    R++;
                }
                right[Z] = R;
                newValue[Z] = (left[Z] + right[Z])/2;
            }

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    if (left[c.R] == right[c.R])
                    {
                        Color color = Color.FromArgb(255, left[c.R], left[c.R], left[c.R]);
                        bm.SetPixel(x, y, color);
                    }
                    else
                    {
                        Color color = Color.FromArgb(255, newValue[c.R], newValue[c.R], newValue[c.R]);
                        bm.SetPixel(x, y, color);
                    }                        
                }
            }

            pictureBox1.Image = bm;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);

        }

        public void losMethodHisto()
        {
            int hAvg = 0;
            int R = 0;
            int Hint = 0;
            int[] left = new int[maxBmpLevel+1];
            int[] right = new int[maxBmpLevel+1];
            int[] newValue = new int[maxBmpLevel+1];

            for (int i = 0; i < histoTab.Length; i++)
            {
                hAvg += histoTab[i];
            }

            Bitmap bm = new Bitmap(pictureBox1.Image);
            hAvg = hAvg / 256;

            for (int Z = 0; Z < histoTab.Length; Z++)
            {
                left[Z] = R;
                Hint = Hint + histoTab[Z];
                while (Hint > hAvg)
                {
                    Hint = Hint - hAvg;
                    R++;
                }
                right[Z] = R;
                newValue[Z] = right[Z] - left[Z];
            }

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    if (left[c.R] == right[c.R])
                    {
                        Color color = Color.FromArgb(255, left[c.R], left[c.R], left[c.R]);
                        bm.SetPixel(x, y, color);
                    }
                    else
                    {
                        Random rnd = new Random();
                        int los = rnd.Next(0, newValue[c.R]);
                        Color color = Color.FromArgb(255, left[c.R] + los, left[c.R] + los, left[c.R] + los);
                        bm.SetPixel(x, y, color);
                    }
                }
            }

            pictureBox1.Image = bm;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);
        }

        public void neibghMethodHisto()
        {
            int hAvg = 0;
            int R = 0;
            int Hint = 0;
            int[] left = new int[maxBmpLevel+1];
            int[] right = new int[maxBmpLevel+1];

            for (int i = 0; i < histoTab.Length; i++)
            {
                hAvg += histoTab[i];
            }

            Bitmap bm = new Bitmap(pictureBox1.Image);
            hAvg = hAvg / 256;

            for (int Z = 0; Z < histoTab.Length; Z++)
            {
                left[Z] = R;
                Hint = Hint + histoTab[Z];
                while (Hint > hAvg)
                {
                    Hint = Hint - hAvg;
                    R++;
                }
                right[Z] = R;
            }

            for (int x = 1; x < bm.Width-1; x++)
            {
                for (int y = 1; y < bm.Height-1; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    if (left[c.R] == right[c.R])
                    {
                        Color color = Color.FromArgb(255, left[c.R], left[c.R], left[c.R]);
                        bm.SetPixel(x, y, color);
                    }
                    else
                    {
                        int avgN = (bm.GetPixel(x-1,y-1).R + bm.GetPixel(x, y - 1).R + bm.GetPixel(x + 1, y - 1).R +
                            bm.GetPixel(x - 1, y).R + bm.GetPixel(x,y).R + bm.GetPixel(x + 1, y).R + bm.GetPixel(x - 1, y + 1).R + bm.GetPixel(x, y + 1).R
                            + bm.GetPixel(x + 1, y + 1).R)/9;
                        if(avgN > right[c.R])
                        {
                            Color color = Color.FromArgb(255, right[c.R], right[c.R], right[c.R]);
                            bm.SetPixel(x, y, color);
                        }
                        else if(avgN < left[c.R])
                        {
                            Color color = Color.FromArgb(255, left[c.R], left[c.R], left[c.R]);
                            bm.SetPixel(x, y, color);
                        }
                        else
                        {
                            Color color = Color.FromArgb(255, avgN, avgN, avgN);
                            bm.SetPixel(x, y, color);
                        }

                    }
                }
            }

            pictureBox1.Image = bm;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);
        }

        public void wlasnaMethodHisto()
        {
            int hAvg = 0;
            int R = 0;
            int Hint = 0;
            int[] left = new int[maxBmpLevel+1];
            int[] right = new int[maxBmpLevel+1];
            int[] newValue = new int[maxBmpLevel+1];

            for (int i = 0; i < histoTab.Length; i++)
            {
                hAvg += histoTab[i];
            }

            Bitmap bm = new Bitmap(pictureBox1.Image);
            hAvg = hAvg / 256;

            for (int Z = 0; Z < histoTab.Length; Z++)
            {
                left[Z] = R;
                Hint = Hint + histoTab[Z];
                while (Hint > hAvg)
                {
                    Hint = Hint - hAvg;
                    R++;
                }
                right[Z] = R;
                newValue[Z] = Convert.ToInt32((left[Z] + right[Z]) / 2.0);
            }

            for (int x = 1; x < bm.Width - 1; x++)
            {
                for (int y = 1; y < bm.Height - 1; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    if (left[c.R] == right[c.R])
                    {
                        Color color = Color.FromArgb(255, left[c.R], left[c.R], left[c.R]);
                        bm.SetPixel(x, y, color);
                    }
                    else
                    {
                        Random rnd = new Random();
                        int los = rnd.Next(0, newValue[c.R]);
                        Color color = Color.FromArgb(255,(newValue[c.R] + rnd.Next(0, newValue[c.R])) / 2, (newValue[c.R] + rnd.Next(0, newValue[c.R])) / 2, (newValue[c.R] + rnd.Next(0, newValue[c.R])) / 2);
                    }
                }
            }

            pictureBox1.Image = bm;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);
        }

        public void negacja()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            for(int x = 0;x < bitmap.Width; x++)
            {
                for(int y = 0; y < bitmap.Height; y++)
                {
                    Color currentPixelColor = bitmap.GetPixel(x, y);
                    Color newColor = Color.FromArgb(maxBmpLevel - currentPixelColor.R, maxBmpLevel - currentPixelColor.G, maxBmpLevel - currentPixelColor.B);
                    bitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBox1.Image = bitmap;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image,maxBmpLevel);
        }

        public void Thining()
        {
            Image<Gray, Byte> sourceImage = new Image<Gray, byte>((Bitmap)pictureBox1.Image);
            Image<Gray,Byte> dstImage = new Image<Gray, Byte>(sourceImage.Width, sourceImage.Height);
            
            XImgprocInvoke.Thinning(sourceImage, dstImage, ThinningTypes.ZhangSuen);

            pictureBox1.Image = dstImage.ToBitmap();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);
        }

        public void Watershed()
        {

            //Source : http://yy-programer.blogspot.com/2012/11/emgucv-image-process-transforming_29.html

            //Read input image
            Image<Bgr, Byte> image = new Image<Bgr, Byte>((Bitmap)pictureBox1.Image);

            //Get the binary image
            Image<Gray, Byte> binary = 
                image.Convert<Gray,Byte>().ThresholdBinaryInv(new Gray(140), new Gray(255));
            Mat closeElement = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse,new Size(5,5),new Point(2,2));
            binary = binary.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Close, closeElement, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());

            
            //Eliminate noise and smaller objects
            Image<Gray, Byte> foreground = binary.Erode(6);

            //Identify image pixels without objects
            Image<Gray, Byte> background = binary.Dilate(6);
            background._ThresholdBinaryInv(new Gray(1), new Gray(128));

            //Create markers image
            Image<Gray, Byte> markers = background + foreground;
            //Create watershed segmentation object
            WatershedSegmenter watershedSegmenter = new WatershedSegmenter();
            //Set markers and process
            watershedSegmenter.SetMakers(markers);
            Image<Gray, Int32> boundaryImage = watershedSegmenter.Process(image);

            pictureBox1.Image = watershedSegmenter.GetWatersheds().ToBitmap();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);
        }

        public void RegionGrowing()
        {
            Image<Bgr, Byte> img = new Image<Bgr, byte>((Bitmap)pictureBox1.Image);
            Image<Gray, byte> grayImg = img.Convert<Gray, byte>();
            Image<Gray, byte> binImg = new Image<Gray, byte>(grayImg.Size);
            CvInvoke.Threshold(grayImg, binImg, 100, 255, ThresholdType.Otsu | ThresholdType.Binary);

            pictureBox1.Image = binImg.ToBitmap();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);
        }

        //Source : AnalizaRozpGrab13_14
        public void ImageAnalysis() {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            int perimeter = 0;
            int area = 0;
            int size = bmp.Width * bmp.Height;
            double areaNorm = 0.0;
            int[] r0 = new int[] { 0, 0 };
            long m00 = 0;
            long m10 = 0;
            long m01 = 0;
            long m11 = 0;

            for (int x = 0; x < bmp.Width; x++) {
                for (int y = 0; y < bmp.Height; y++) {
                    int rpixel = bmp.GetPixel(x, y).R;
                    if (rpixel > 0) {
                        area++;
                        m00 += bmp.GetPixel(x, y).R;
                        m10 += x * bmp.GetPixel(x, y).R;
                        m01 += y * bmp.GetPixel(x, y).R;
                        m11 += x * y * bmp.GetPixel(x, y).R;

                        for (int i = -1; i < 2; i++) {
                            for (int j = -1; j < 2; j++) {
                                if (isPixelValid(x + i, y + j, bmp.Width, bmp.Height)) {
                                    int sasiad = bmp.GetPixel(x + i, y + j).R;
                                    if (sasiad == 0) {
                                        perimeter++;
                                        r0[0] += x;
                                        r0[1] += y;
                                        goto next;
                                    }
                                }
                            }
                        }
                    } 
                    next: ;
                }
            }

            if (perimeter > 0) {
                r0[0] = r0[0] / perimeter;
                r0[1] = r0[1] / perimeter;
            }
            areaNorm = (double)area / (double)size;
            double W1 = 2.0 * Math.Sqrt((double)area / Math.PI);
            double W2 = (double)perimeter / Math.PI;
            double W3 = (double)perimeter / (2.0 * Math.Sqrt((double)area * Math.PI));
            double W9 = (2.0 * Math.Sqrt((double)area * Math.PI)) / (double)perimeter;
            int minX = -1;
            int maxX = -1;
            int minY = -1;
            int maxY = -1;
            bool isSet = false;
            long sumaOdl = 0;
            long M10 = 0;
            long M01 = 0;
            long M11 = 0;

            for (int x = 0; x < bmp.Width; x++) {
                for (int y = 0; y < bmp.Height; y++) {
                    int rpixel = bmp.GetPixel(x, y).R;
                    if (rpixel > 0) {
                        if (!isSet) {
                            isSet = true;
                            if (minX == -1) minX = x;
                            if (maxX == -1) maxX = x;
                            if (minY == -1) minY = y;
                            if (maxY == -1) maxY = y;
                        }
                        if (x < minX) minX = x;
                        if (x > maxX) maxX = x;
                        if (y < minY) minY = y;
                        if (y > maxY) maxY = y;

                        M10 += (x - r0[0]) * bmp.GetPixel(x, y).R;
                        M01 += (y - r0[1]) * bmp.GetPixel(x, y).R;
                        M11 += (x - r0[0]) * (y - r0[1]) * bmp.GetPixel(x, y).R;
                        sumaOdl += (long)Math.Pow(Math.Sqrt(Math.Pow(x - r0[0], 2) + Math.Pow(y - r0[1], 2)), 2);
                    }
                }
            }
            int gabarytX = maxX - minX;
            int gabarytY = maxY - minY;
            int gabaryt;
            if (gabarytX > gabarytY) gabaryt = gabarytX;
            else gabaryt = gabarytY;
            double W8 = (double)gabaryt / (double)perimeter;
            double W4 = (double)area / Math.Sqrt(2 * Math.PI * sumaOdl);

            MessageBox.Show("Pixels in image: " + size +
                            "\nBackground pixels: " + (size - area) +
                            "\nObject area: " + area +
                            //"\nArea (normalized): " + areaNorm +
                            "\nObject perimeter: " + perimeter +
                            "\nCenter of mass: " + r0[0] + ", " + r0[1] +
                            "\n\nW1: " + W1 +
                            "\nW2: " + W2 +
                            "\nW3: " + W3 +
                            "\nW4: " + W4 +
                            "\nW8: " + W8 +
                            "\nW9: " + W9 +
                            "\n\nMoment m(0, 0): " + m00 +
                            "\nMoment m(0, 1): " + m01 +
                            "\nMoment m(1, 0): " + m10 +
                            "\nMoment m(1, 1): " + m11 +
                            "\n\nCentral moment M(1, 0): " + M10 +
                            "\nCentral moment M(0, 1): " + M01 +
                            "\nCentral moment M(1, 1): " + M11,
                            //"\nGabaryt w poziomie: " + gabarytX +
                            //"\nGabaryt w pionie: " + gabarytY +
                            //"\nMaksymalny gabaryt: " + gabaryt,
                            "Wyniki Analizy");
        }

        public static bool isPixelValid(int x, int y, int width, int height) {
            if (x >= 0 && y >= 0 && x < width && y < height)
                return true;
            return false;
        }
        
        //Source: SokolowLineProfile13 
        public void Turtle()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            int[,] rtab = new int[bmp.Width, bmp.Height];
            int[,] gtab = new int[bmp.Width, bmp.Height];
            int[,] btab = new int[bmp.Width, bmp.Height];

            int i, j;
            for (i = 1; i < bmp.Width - 1; i++)
            {
                for (j = 1; j < bmp.Height - 1; j++)
                {
                    rtab[i, j] = bmp.GetPixel(i, j).R;
                    gtab[i, j] = bmp.GetPixel(i, j).G;
                    btab[i, j] = bmp.GetPixel(i, j).B;
                }
            }
            int d = 0;
            int pami = 0, pamj = 0, ja = 0, ia = 0;
            int x, y;
            int[] wynik = new int[bmp.Width * bmp.Height];
            int[] droga = new int[bmp.Width * bmp.Height];
            for (i = 1; i < bmp.Height - 1; i++)
            {
                for (j = 1; j < bmp.Width - 1; j++)
                {
                    if (rtab[j, i] != 0 || gtab[j, i] != 0 || btab[j, i] != 0)
                    {
                        ja = j;
                        ia = i;
                        pamj = j;
                        pami = i;
                        wynik[bmp.Width * i + j] = maxBmpLevel - 1;
                        goto cont;
                    }
                }
            }
        cont:
            j = pamj;
            i = pami - 1;
            wynik[bmp.Width * i + j] = maxBmpLevel - 1;
            droga[d] = 1;
            do
            {
                x = j - pamj;
                y = i - pami;
                pamj = j;
                pami = i;
                d++;
                if (rtab[j, i] != 0 || gtab[j, i] != 0 || btab[j, i] != 0)
                {
                    if (x == 0 && y == (-1))
                    {
                        j--;
                        droga[d] = 2;
                    }
                    if (x == 1 && y == 0)
                    {
                        i--;
                        droga[d] = 1;
                    }
                    if (x == 0 && y == 1)
                    {
                        j++;
                        droga[d] = 0;
                    }
                    if (x == (-1) && y == 0)
                    {
                        i++;
                        droga[d] = 3;
                    }
                }
                else
                {
                    if (x == 0 && y == (-1))
                    {
                        j++;
                        droga[d] = 0;
                    }
                    if (x == 1 && y == 0)
                    {
                        i++;
                        droga[d] = 3;
                    }
                    if (x == 0 && y == 1)
                    {
                        j--;
                        droga[d] = 2;
                    }
                    if (x == (-1) && y == 0)
                    {
                        i--;
                        droga[d] = 1;
                    }
                }
                wynik[bmp.Width * i + j] = maxBmpLevel - 1;
            }
            while (j != ja || i != ia);
            for (i = 0; i < bmp.Height; i++)
            {
                for (j = 0; j < bmp.Width; j++)
                {
                    if (wynik[bmp.Width * i + j] == maxBmpLevel - 1)
                    {
                        rtab[j, i] = maxBmpLevel / 2;
                        gtab[j, i] = 0;
                        btab[j, i] = 0;
                    }
                }
            }

            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i,j,Color.FromArgb(rtab[i, j],gtab[i, j],btab[i, j]));
                }
            }

            pictureBox1.Image = bmp;
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox1.Image);
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox1.Image, maxBmpLevel);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && ((PictureBox) sender).Image != null)
            {
                ArraysSteganography arraysSteganography = new ArraysSteganography(((PictureBox) sender).Image,((PictureBox) sender).Tag.ToString());
                arraysSteganography.MdiParent = _main;
                arraysSteganography.Show();
            }
            else
            {
                if (((PictureBox) sender).Image != null)
                    // Make a note that we "have the mouse".
                    bHaveMouse = true;

                // Store the "starting point" for this rubber-band rectangle.
                ptOriginal.X = e.X;
                ptOriginal.Y = e.Y;

                // Special value lets us know that no previous
                // rectangle needs to be erased.

                ptLast.X = -1;
                ptLast.Y = -1;

                rectCropArea = new Rectangle(new Point(e.X, e.Y), new Size());
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Set internal flag to know we no longer "have the mouse".
            bHaveMouse = false;

            if (rectCropArea.Width > 0 && rectCropArea.Height > 0)
            {

                // If we have drawn previously, draw again in that spot
                // to remove the lines.
                if (ptLast.X != -1)
                {
                    Point ptCurrent = new Point(e.X, e.Y);

                }

                // Set flags to know that there is no "previous" line to reverse.
                ptLast.X = -1;
                ptLast.Y = -1;
                ptOriginal.X = -1;
                ptOriginal.Y = -1;

                Bitmap sourceBitmap = new Bitmap(((PictureBox) sender).Image, ((PictureBox) sender).Width,
                    ((PictureBox) sender).Height);
                Bitmap croppedBitmap = new Bitmap(rectCropArea.Width, rectCropArea.Height);


                using (Graphics g = Graphics.FromImage(croppedBitmap))
                {
                    g.DrawImage(sourceBitmap, new Rectangle(0, 0, croppedBitmap.Width, croppedBitmap.Height),
                        rectCropArea, GraphicsUnit.Pixel);
                }

                //Good practice to dispose the System.Drawing objects when not in use.
                sourceBitmap.Dispose();

                int countWindows = 0;

                foreach (var child in _main.MdiChildren)
                {
                    if (child.Text.StartsWith("Wycięty obraz"))
                        countWindows++;
                }

                ImageWindow imageWindow = new ImageWindow(croppedBitmap, "Wycięty obraz"+countWindows,_main);

                imageWindow.MdiParent = _main;
                imageWindow.Show();
                ((PictureBox) sender).Invalidate();

                rectCropArea.Height = 0;
                rectCropArea.Width = 0;
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);

            // If we "have the mouse", then we draw our lines.
            if (bHaveMouse)
            {
                // Update last point.
                ptLast = ptCurrent;

                // Draw new lines.

                // e.X - rectCropArea.X;
                // normal
                if (e.X > ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;

                    // e.Y - rectCropArea.Height;
                    rectCropArea.Height = e.Y - ptOriginal.Y;
                }
                else if (e.X < ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = ptOriginal.X - e.X;
                    rectCropArea.Height = e.Y - ptOriginal.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = ptOriginal.Y;
                }
                else if (e.X > ptOriginal.X && e.Y < ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;
                    rectCropArea.Height = ptOriginal.Y - e.Y;

                    rectCropArea.X = ptOriginal.X;
                    rectCropArea.Y = e.Y;
                }
                else
                {
                    rectCropArea.Width = ptOriginal.X - e.X;

                    // e.Y - rectCropArea.Height;
                    rectCropArea.Height = ptOriginal.Y - e.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = e.Y;
                }

                ((PictureBox) sender).Refresh();
            }

        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen drawLine = new Pen(Color.Black,2);
            drawLine.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(drawLine, rectCropArea);
        }
    }
}
