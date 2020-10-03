using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO_Czerniawski
{
    class HistogramOperations
    {
        public static void clearHistogram(Chart chart)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
        }

        public static int[] drawHistogram(Chart chart, Image image, int maxBmpLevel)
        {
            int[] histoTab = new int[maxBmpLevel+1];

            Bitmap bm = (Bitmap)image;

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    histoTab[c.R] += 1;
                }
            }

            for (int i = 0; i < histoTab.Length; i++)
            {
                chart.Series["Series1"].Points.AddXY(i, histoTab[i]);
            }

            return histoTab;
        }

        public static int MaxBmpLevel(Image image)
        {
            int maxBmpLevel = 0;

            Bitmap bm = (Bitmap)image;
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    if (bm.GetPixel(x, y).R > maxBmpLevel)
                        maxBmpLevel = bm.GetPixel(x, y).R;
                }
            }

            return maxBmpLevel;
        }

        public static int MinBmpLevel(Image image)
        {
            int maxBmpLevel = 255;

            Bitmap bm = (Bitmap)image;
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    if (bm.GetPixel(x, y).R < maxBmpLevel)
                        maxBmpLevel = bm.GetPixel(x, y).R;
                }
            }

            return maxBmpLevel;
        }

    }
}
