namespace APO_Czerniawski
{
    partial class GradientWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradientWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.masksComboBox = new System.Windows.Forms.ComboBox();
            this.maskTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.scalingMethodsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maska:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masksComboBox
            // 
            this.masksComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masksComboBox.FormattingEnabled = true;
            this.masksComboBox.Location = new System.Drawing.Point(3, 31);
            this.masksComboBox.Name = "masksComboBox";
            this.masksComboBox.Size = new System.Drawing.Size(123, 21);
            this.masksComboBox.TabIndex = 1;
            this.masksComboBox.SelectedIndexChanged += new System.EventHandler(this.masksComboBox_SelectedIndexChanged);
            // 
            // maskTextBox
            // 
            this.maskTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskTextBox.Location = new System.Drawing.Point(3, 66);
            this.maskTextBox.Multiline = true;
            this.maskTextBox.Name = "maskTextBox";
            this.maskTextBox.ReadOnly = true;
            this.maskTextBox.Size = new System.Drawing.Size(123, 161);
            this.maskTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(260, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(384, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // previewButton
            // 
            this.previewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewButton.Location = new System.Drawing.Point(3, 495);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(123, 34);
            this.previewButton.TabIndex = 4;
            this.previewButton.Text = "Podgląd";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // scalingMethodsComboBox
            // 
            this.scalingMethodsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scalingMethodsComboBox.FormattingEnabled = true;
            this.scalingMethodsComboBox.Location = new System.Drawing.Point(132, 31);
            this.scalingMethodsComboBox.Name = "scalingMethodsComboBox";
            this.scalingMethodsComboBox.Size = new System.Drawing.Size(122, 21);
            this.scalingMethodsComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(132, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Metoda Skalowania:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionLabel.Location = new System.Drawing.Point(3, 230);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(123, 23);
            this.directionLabel.TabIndex = 7;
            this.directionLabel.Text = "Kierunek";
            this.directionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directionComboBox
            // 
            this.directionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Location = new System.Drawing.Point(3, 256);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(123, 21);
            this.directionComboBox.TabIndex = 8;
            this.directionComboBox.SelectedIndexChanged += new System.EventHandler(this.directionComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.93818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.78362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.12365F));
            this.tableLayoutPanel1.Controls.Add(this.masksComboBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.directionComboBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.scalingMethodsComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.directionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.acceptButton, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.511278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.30075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 532);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(260, 256);
            this.chart1.Name = "chart1";
            this.tableLayoutPanel1.SetRowSpan(this.chart1, 2);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(384, 273);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // acceptButton
            // 
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptButton.Location = new System.Drawing.Point(132, 495);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(122, 34);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "Akceptuj";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // GradientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GradientWindow";
            this.Text = "Wykrywanie Krawędzi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox masksComboBox;
        private System.Windows.Forms.TextBox maskTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.ComboBox scalingMethodsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.ComboBox directionComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button acceptButton;
    }
}