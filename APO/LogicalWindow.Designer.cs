namespace APO_Czerniawski
{
    partial class LogicalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogicalWindow));
            this.uprightRadioButton = new System.Windows.Forms.RadioButton();
            this.horizontallyRadioButton = new System.Windows.Forms.RadioButton();
            this.bothRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.previewButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uprightRadioButton
            // 
            this.uprightRadioButton.AutoSize = true;
            this.uprightRadioButton.Checked = true;
            this.uprightRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uprightRadioButton.Location = new System.Drawing.Point(3, 621);
            this.uprightRadioButton.Name = "uprightRadioButton";
            this.uprightRadioButton.Size = new System.Drawing.Size(96, 23);
            this.uprightRadioButton.TabIndex = 0;
            this.uprightRadioButton.TabStop = true;
            this.uprightRadioButton.Text = "Pionowo";
            this.uprightRadioButton.UseVisualStyleBackColor = true;
            // 
            // horizontallyRadioButton
            // 
            this.horizontallyRadioButton.AutoSize = true;
            this.horizontallyRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontallyRadioButton.Location = new System.Drawing.Point(105, 621);
            this.horizontallyRadioButton.Name = "horizontallyRadioButton";
            this.horizontallyRadioButton.Size = new System.Drawing.Size(84, 23);
            this.horizontallyRadioButton.TabIndex = 1;
            this.horizontallyRadioButton.Text = "Poziomo";
            this.horizontallyRadioButton.UseVisualStyleBackColor = true;
            // 
            // bothRadioButton
            // 
            this.bothRadioButton.AutoSize = true;
            this.bothRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bothRadioButton.Location = new System.Drawing.Point(195, 621);
            this.bothRadioButton.Name = "bothRadioButton";
            this.bothRadioButton.Size = new System.Drawing.Size(136, 23);
            this.bothRadioButton.TabIndex = 2;
            this.bothRadioButton.Text = "Oby Dwa Kierunki";
            this.bothRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart1, 4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(3, 304);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(328, 311);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // previewButton
            // 
            this.previewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewButton.Location = new System.Drawing.Point(3, 650);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(96, 26);
            this.previewButton.TabIndex = 5;
            this.previewButton.Text = "Podgląd";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.439446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.574394F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20761F));
            this.tableLayoutPanel1.Controls.Add(this.uprightRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.horizontallyRadioButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.previewButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.acceptButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bothRadioButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.6863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.270987F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.418262F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 679);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // acceptButton
            // 
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(105, 650);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(84, 26);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Akceptuj";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // LogicalWindow
            // 
            this.AcceptButton = this.previewButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 679);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogicalWindow";
            this.Text = "Filtracja Logiczna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton uprightRadioButton;
        private System.Windows.Forms.RadioButton horizontallyRadioButton;
        private System.Windows.Forms.RadioButton bothRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button acceptButton;
    }
}