using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO_Czerniawski
{
    public partial class GrayscaleReductionWindow : Form
    {
        private ImageWindow imageWindow;
        private int maxBmpLevel;
        private int[] histoTab;
        DataPoint selectedDataPoint = null;

        public GrayscaleReductionWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;
            pictureBox.Image = (Image) imageWindow.getImage().Clone();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox.Image);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox.Image, maxBmpLevel);
            initializeReductionChart(2);

            for (int i = 29; i > 1; --i)
                domainUpDown1.Items.Add(i);

            domainUpDown1.SelectedIndex = 27;

            chartDrawing.ChartAreas[0].AxisX.Maximum = maxBmpLevel;
            chartDrawing.ChartAreas[0].AxisX.Minimum = 0;

            chartDrawing.ChartAreas[0].AxisY.Maximum = maxBmpLevel;
            chartDrawing.ChartAreas[0].AxisY.Minimum = 0;

        }

        private void initializeReductionChart(int levels)
        {
            chartDrawing.Series["Series1"].Points.Clear();
            
            //int count = 0;
            //int countLevels = 0;

            for(int i = 0;i<=levels;i++)
            {
                chartDrawing.Series["Series1"].Points.AddXY((maxBmpLevel / levels) * i, (maxBmpLevel / levels) * i);
            }


            //Dodowanie duzej ilosci punktow
            //for (int i = 0; i <= maxBmpLevel; i++)
            //{
            //    chartDrawing.Series["Series1"].Points.AddXY(i, (maxBmpLevel / levels) * countLevels);
            //    count++;

            //    if (count == (maxBmpLevel / levels))
            //    {
            //        countLevels++;
            //        count = 0;
            //    }
            //}
        }

        private void chartDrawing_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
	        // Call Hit Test Method
	        HitTestResult hitResult = chartDrawing.HitTest( e.X, e.Y );

	        // Initialize currently selected data point
	        selectedDataPoint = null;
	        if( hitResult.ChartElementType == ChartElementType.DataPoint )
	        {
		        selectedDataPoint = (DataPoint)hitResult.Object;

		        // Show point value as label
		        selectedDataPoint.IsValueShownAsLabel = true;

		        // Set cursor shape
                chartDrawing.Cursor = Cursors.SizeNS;
	        }
}

        private void chartDrawing_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
	        // Check if data point selected
	        if(selectedDataPoint != null)
	        {
		        // Mouse coordinates should not be outside of the chart 
		        int coordinate = e.Y;
		        if(coordinate < 0)
			        coordinate = 0;
		        if(coordinate > chartDrawing.Size.Height - 1)
			        coordinate = chartDrawing.Size.Height - 1;

		        // Calculate new Y value from current cursor position
		        double yValue = chartDrawing.ChartAreas["ChartArea1"].AxisY.PixelPositionToValue(coordinate);
		        yValue = Math.Min(yValue, chartDrawing.ChartAreas["ChartArea1"].AxisY.Maximum);
		        yValue = Math.Max(yValue, chartDrawing.ChartAreas["ChartArea1"].AxisY.Minimum);

		        // Update selected point Y value

                //Wszystkie punkty przsuswane razem
                //var dataPointsCollection = chartDrawing.Series["Series1"].Points.FindAllByValue(selectedDataPoint.YValues[0]);
                //foreach (var point in dataPointsCollection)
                //{
                //    point.YValues[0] = yValue;
                //}

                selectedDataPoint.YValues[0] = yValue;

		        // Invalidate chart
                chartDrawing.Invalidate();
	        }
	        else
	        {
		        // Set different shape of cursor over the data points
		        HitTestResult hitResult = chartDrawing.HitTest( e.X, e.Y );
		        if( hitResult.ChartElementType == ChartElementType.DataPoint )
		        {
                    chartDrawing.Cursor = Cursors.Hand;
		        }
		        else
		        {
                    chartDrawing.Cursor = Cursors.Default;
		        }
	        }
        }

        private void chartDrawing_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
	        // Initialize currently selected data point
	        if(selectedDataPoint != null)
	        {
		        // Hide point label
		        selectedDataPoint.IsValueShownAsLabel = false;

		        // reset selected object
		        selectedDataPoint = null;

		        // Invalidate chart
                chartDrawing.Invalidate();

		        // Reset cursor style
                chartDrawing.Cursor = Cursors.Default;

                grayscaleReduction();
	        }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            initializeReductionChart((int) domainUpDown1.SelectedItem);
            grayscaleReduction();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            initializeReductionChart((int) domainUpDown1.SelectedItem);
            HistogramOperations.clearHistogram(chart1);
            pictureBox.Image = (Image) imageWindow.getImage().Clone();
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox.Image, maxBmpLevel);
            grayscaleReduction();
        }

        private void grayscaleReduction()
        {
            Bitmap bm = new Bitmap(imageWindow.getImage());

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    var points = chartDrawing.Series["Series1"].Points;
                    for (int i = 0; i < points.Count-1; ++i)
                    {
                        if (c.R >= points[i].XValue && c.R <= points[i + 1].XValue)
                        {
                            int q = Convert.ToInt32(points[i].YValues[0]);
                            Color color = Color.FromArgb(255, q, q, q);
                            bm.SetPixel(x, y, color);
                        }
                    }
                }
            }

            pictureBox.Image = bm;
            HistogramOperations.clearHistogram(chart1);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox.Image,maxBmpLevel);
        }
    }
}
