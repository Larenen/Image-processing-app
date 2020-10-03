namespace APO_Czerniawski
{
    partial class TresholdingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TresholdingWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bottomValueTrackBar = new System.Windows.Forms.TrackBar();
            this.bottomValueLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upperValueLabel = new System.Windows.Forms.Label();
            this.upperValueTrackBar = new System.Windows.Forms.TrackBar();
            this.maintainingTresholdingCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomValueTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperValueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart1, 4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(543, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(487, 358);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // bottomValueTrackBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bottomValueTrackBar, 2);
            this.bottomValueTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomValueTrackBar.Location = new System.Drawing.Point(2, 364);
            this.bottomValueTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.bottomValueTrackBar.Maximum = 255;
            this.bottomValueTrackBar.Name = "bottomValueTrackBar";
            this.bottomValueTrackBar.Size = new System.Drawing.Size(731, 29);
            this.bottomValueTrackBar.TabIndex = 2;
            this.bottomValueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bottomValueTrackBar.Scroll += new System.EventHandler(this.bottomTrackBar_Scroll);
            this.bottomValueTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // bottomValueLabel
            // 
            this.bottomValueLabel.AutoSize = true;
            this.bottomValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomValueLabel.Location = new System.Drawing.Point(737, 362);
            this.bottomValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bottomValueLabel.Name = "bottomValueLabel";
            this.bottomValueLabel.Size = new System.Drawing.Size(55, 33);
            this.bottomValueLabel.TabIndex = 3;
            this.bottomValueLabel.Text = "0";
            this.bottomValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.acceptButton.Location = new System.Drawing.Point(796, 435);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(107, 26);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Ok";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.47333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.81668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.722599F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.85271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2093F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bottomValueTrackBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bottomValueLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.upperValueLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.upperValueTrackBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maintainingTresholdingCheckBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.acceptButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.18575F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.12743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.207343F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.263499F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 463);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(797, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wartosc Dolna";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(797, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wartosc Górna";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upperValueLabel
            // 
            this.upperValueLabel.AutoSize = true;
            this.upperValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperValueLabel.Enabled = false;
            this.upperValueLabel.Location = new System.Drawing.Point(738, 395);
            this.upperValueLabel.Name = "upperValueLabel";
            this.upperValueLabel.Size = new System.Drawing.Size(53, 38);
            this.upperValueLabel.TabIndex = 7;
            this.upperValueLabel.Text = "255";
            this.upperValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upperValueTrackBar
            // 
            this.upperValueTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.upperValueTrackBar, 2);
            this.upperValueTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperValueTrackBar.Enabled = false;
            this.upperValueTrackBar.Location = new System.Drawing.Point(3, 398);
            this.upperValueTrackBar.Maximum = 255;
            this.upperValueTrackBar.Minimum = 1;
            this.upperValueTrackBar.Name = "upperValueTrackBar";
            this.upperValueTrackBar.Size = new System.Drawing.Size(729, 32);
            this.upperValueTrackBar.TabIndex = 8;
            this.upperValueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.upperValueTrackBar.Value = 255;
            this.upperValueTrackBar.Scroll += new System.EventHandler(this.upperValueTrackBar_Scroll);
            this.upperValueTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // maintainingTresholdingCheckBox
            // 
            this.maintainingTresholdingCheckBox.AutoSize = true;
            this.maintainingTresholdingCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintainingTresholdingCheckBox.Location = new System.Drawing.Point(908, 365);
            this.maintainingTresholdingCheckBox.Name = "maintainingTresholdingCheckBox";
            this.tableLayoutPanel1.SetRowSpan(this.maintainingTresholdingCheckBox, 2);
            this.maintainingTresholdingCheckBox.Size = new System.Drawing.Size(121, 65);
            this.maintainingTresholdingCheckBox.TabIndex = 9;
            this.maintainingTresholdingCheckBox.Text = "Z zachowaniem poziomów szarości";
            this.maintainingTresholdingCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maintainingTresholdingCheckBox.UseVisualStyleBackColor = true;
            this.maintainingTresholdingCheckBox.CheckedChanged += new System.EventHandler(this.maintainingTresholdingCheckBox_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(908, 436);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 24);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Resetuj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TresholdingWindow
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TresholdingWindow";
            this.Text = "Progowanie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomValueTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperValueTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar bottomValueTrackBar;
        private System.Windows.Forms.Label bottomValueLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label upperValueLabel;
        private System.Windows.Forms.TrackBar upperValueTrackBar;
        private System.Windows.Forms.CheckBox maintainingTresholdingCheckBox;
        private System.Windows.Forms.Button cancelButton;
    }
}