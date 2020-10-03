namespace APO_Czerniawski
{
    partial class StretchWindow
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StretchWindow));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bottomTrackBar = new System.Windows.Forms.TrackBar();
            this.upperTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bottomValueTextBox = new System.Windows.Forms.TextBox();
            this.upperValueTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart1, 3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(467, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(471, 380);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bottomTrackBar
            // 
            this.bottomTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.bottomTrackBar, 2);
            this.bottomTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTrackBar.Location = new System.Drawing.Point(3, 389);
            this.bottomTrackBar.Maximum = 255;
            this.bottomTrackBar.Name = "bottomTrackBar";
            this.bottomTrackBar.Size = new System.Drawing.Size(753, 28);
            this.bottomTrackBar.TabIndex = 6;
            this.bottomTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bottomTrackBar.Scroll += new System.EventHandler(this.bottomTrackBar_Scroll);
            this.bottomTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // upperTrackBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.upperTrackBar, 2);
            this.upperTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperTrackBar.Location = new System.Drawing.Point(3, 423);
            this.upperTrackBar.Maximum = 255;
            this.upperTrackBar.Name = "upperTrackBar";
            this.upperTrackBar.Size = new System.Drawing.Size(753, 25);
            this.upperTrackBar.TabIndex = 7;
            this.upperTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.upperTrackBar.Value = 255;
            this.upperTrackBar.Scroll += new System.EventHandler(this.upperTrackBar_Scroll);
            this.upperTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(851, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wartosc Dolna";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(851, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wartosc Gorna";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(762, 454);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(83, 22);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Zapisz";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.3617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.34963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.458023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.776834F));
            this.tableLayoutPanel1.Controls.Add(this.bottomTrackBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.upperTrackBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.bottomValueTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.upperValueTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.58455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.098121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.471816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.636743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 479);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // bottomValueTextBox
            // 
            this.bottomValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomValueTextBox.Enabled = false;
            this.bottomValueTextBox.Location = new System.Drawing.Point(762, 389);
            this.bottomValueTextBox.Name = "bottomValueTextBox";
            this.bottomValueTextBox.Size = new System.Drawing.Size(83, 20);
            this.bottomValueTextBox.TabIndex = 13;
            this.bottomValueTextBox.Leave += new System.EventHandler(this.bottomValueTextBox_Leave);
            // 
            // upperValueTextBox
            // 
            this.upperValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperValueTextBox.Enabled = false;
            this.upperValueTextBox.Location = new System.Drawing.Point(762, 423);
            this.upperValueTextBox.Name = "upperValueTextBox";
            this.upperValueTextBox.Size = new System.Drawing.Size(83, 20);
            this.upperValueTextBox.TabIndex = 14;
            this.upperValueTextBox.Leave += new System.EventHandler(this.upperValueTextBox_Leave);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(851, 454);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 22);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Resetuj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // StretchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(100, 200);
            this.Name = "StretchWindow";
            this.Text = "Rozciaganie";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar bottomTrackBar;
        private System.Windows.Forms.TrackBar upperTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox bottomValueTextBox;
        private System.Windows.Forms.TextBox upperValueTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}