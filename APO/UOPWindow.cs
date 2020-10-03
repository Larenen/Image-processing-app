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
    public partial class UOPWindow : Form
    {
        private ImageWindow imageWindow;
        private int maxBmpLevel;
        private int[] histoTab;
        DataPoint selectedDataPoint = null;

        public UOPWindow(ImageWindow imageWindow)
        {
            InitializeComponent();
            this.imageWindow = imageWindow;
            pictureBox.Image = (Image) imageWindow.getImage().Clone();
            maxBmpLevel = HistogramOperations.MaxBmpLevel(pictureBox.Image);
            histoTab = HistogramOperations.drawHistogram(chart1, pictureBox.Image, maxBmpLevel);

            initializeUopChart();
            uopCalc();

        }

        private void initializeUopChart()
        {
            uopChart.Series[0].Points.Clear();

            uopChart.ChartAreas[0].AxisX.Maximum = maxBmpLevel;
            uopChart.ChartAreas[0].AxisX.Minimum = 0;

            uopChart.ChartAreas[0].AxisY.Maximum = maxBmpLevel;
            uopChart.ChartAreas[0].AxisY.Minimum = 0;

            uopChart.Series["Series1"].Points.AddXY(0, 0);
            uopChart.Series["Series1"].Points.AddXY(maxBmpLevel/2, maxBmpLevel/2);
            uopChart.Series["Series1"].Points.AddXY(maxBmpLevel, maxBmpLevel);
        
            uopChart.ChartAreas[0].AxisX.Interval = maxBmpLevel/4;
            uopChart.ChartAreas[0].AxisY.Interval = maxBmpLevel/4;
        }

         private void uopChart_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
	        // Call Hit Test Method
	        HitTestResult hitResult = uopChart.HitTest( e.X, e.Y );

	        // Initialize currently selected data point
	        selectedDataPoint = null;
	        if( hitResult.ChartElementType == ChartElementType.DataPoint)
	        {
                if (e.Button == MouseButtons.Right && ((DataPoint)hitResult.Object).XValue != maxBmpLevel)
                {
                    uopChart.Series[0].Points.Remove((DataPoint) hitResult.Object);
                    uopChart.Series["Series1"].Sort(PointSortOrder.Ascending,"X");
                    uopCalc();
                }
                else
                {
                    selectedDataPoint = (DataPoint)hitResult.Object;

                    // Show point value as label
                    selectedDataPoint.IsValueShownAsLabel = true;

                    // Set cursor shape
                    uopChart.Cursor = Cursors.SizeNS;   
                }
	        }
            else if(e.Button == MouseButtons.Left)
            {
                //Adding point to UOP Chart
                // Mouse coordinates should not be outside of the chart 
                int coordinateY = e.Y;
                if(coordinateY < 0)
                    coordinateY = 0;
                if(coordinateY > uopChart.Size.Height - 1)
                    coordinateY = uopChart.Size.Height - 1;

                int coordinateX = e.X;
                if(coordinateX < 0)
                    coordinateX = 0;
                if(coordinateX > uopChart.Size.Width - 1)
                    coordinateX = uopChart.Size.Width - 1;

                // Calculate new Y value from current cursor position
                double yValue = uopChart.ChartAreas["ChartArea1"].AxisY.PixelPositionToValue(coordinateY);
                yValue = Math.Min(yValue, uopChart.ChartAreas["ChartArea1"].AxisY.Maximum);
                yValue = Math.Max(yValue, uopChart.ChartAreas["ChartArea1"].AxisY.Minimum);

                // Calculate new X value from current cursor position
                double xValue = uopChart.ChartAreas["ChartArea1"].AxisX.PixelPositionToValue(coordinateX);
                xValue = Math.Min(xValue, uopChart.ChartAreas["ChartArea1"].AxisX.Maximum);
                xValue = Math.Max(xValue, uopChart.ChartAreas["ChartArea1"].AxisX.Minimum);

                uopChart.Series["Series1"].Points.AddXY(xValue,yValue);
                uopChart.Series["Series1"].Sort(PointSortOrder.Ascending,"X");
                uopCalc();
            }
}

        private void uopChart_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
	        // Check if data point selected
	        if(selectedDataPoint != null)
	        {
		        // Mouse coordinates should not be outside of the chart 
		        int coordinateY = e.Y;
		        if(coordinateY < 0)
                    coordinateY = 0;
		        if(coordinateY > uopChart.Size.Height - 1)
                    coordinateY = uopChart.Size.Height - 2;

                int coordinateX = e.X;
                if(coordinateX < 0)
                    coordinateX = 0;
                if(coordinateX > uopChart.Size.Width - 1)
                    coordinateX = uopChart.Size.Width - 1;

		        // Calculate new Y value from current cursor position
		        double yValue = uopChart.ChartAreas["ChartArea1"].AxisY.PixelPositionToValue(coordinateY);
		        yValue = Math.Min(yValue, uopChart.ChartAreas["ChartArea1"].AxisY.Maximum);
		        yValue = Math.Max(yValue, uopChart.ChartAreas["ChartArea1"].AxisY.Minimum);
                
                // Update selected point Y value

                selectedDataPoint.YValues[0] = yValue;

                if (selectedDataPoint.XValue != maxBmpLevel)
                {

                    // Calculate new X value from current cursor position

                    double xValue = uopChart.ChartAreas["ChartArea1"].AxisX.PixelPositionToValue(coordinateX);
                    xValue = Math.Min(xValue, uopChart.ChartAreas["ChartArea1"].AxisX.Maximum);
                    xValue = Math.Max(xValue, uopChart.ChartAreas["ChartArea1"].AxisX.Minimum);

                    var points = uopChart.Series["Series1"].Points;
                    var index = points.IndexOf(selectedDataPoint);

                    if(index <1)
                        return;

                    if(xValue > points[index-1].XValue && xValue < points[index+1].XValue)
                        // Update selected point X value
                        selectedDataPoint.XValue = xValue;


                }

                // Invalidate chart
                uopChart.Invalidate();
	        }
	        else
	        {
		        // Set different shape of cursor over the data points
		        HitTestResult hitResult = uopChart.HitTest( e.X, e.Y );
		        if( hitResult.ChartElementType == ChartElementType.DataPoint )
		        {
                    uopChart.Cursor = Cursors.Hand;
		        }
		        else
		        {
                    uopChart.Cursor = Cursors.Default;
		        }
	        }
        }

        private void uopChart_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
	        // Initialize currently selected data point
	        if(selectedDataPoint != null)
	        {
		        // Hide point label
		        selectedDataPoint.IsValueShownAsLabel = false;

		        // reset selected object
		        selectedDataPoint = null;

		        // Invalidate chart
                uopChart.Invalidate();

		        // Reset cursor style
                uopChart.Cursor = Cursors.Default;

                uopCalc();
            }
        }

        private void uopCalc()
        {
            Bitmap bm = new Bitmap(imageWindow.getImage());

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    var points = uopChart.Series["Series1"].Points;
                    for (int i = 0; i < points.Count-1; ++i)
                    {
                        if (c.R >= points[i].XValue && c.R <= points[i + 1].XValue)
                        {
                            double a = (points[i + 1].YValues[0] - points[i].YValues[0])/(points[i + 1].XValue - points[i].XValue);
                            double b = points[i].YValues[0] - (a * points[i].XValue);

                            int q = Convert.ToInt32((a * c.R) + b);
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

        private void acceptButton_Click(object sender, EventArgs e)
        {
            imageWindow.setNewImage(pictureBox.Image);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            initializeUopChart();
            uopCalc();
        }
    }
}
