namespace APO_Czerniawski
{
    partial class MorphologicalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MorphologicalWindow));
            this.radioButtonFourNeighbors = new System.Windows.Forms.RadioButton();
            this.radioButtonEightNeighborbood = new System.Windows.Forms.RadioButton();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonDilatation = new System.Windows.Forms.RadioButton();
            this.radioButtonErode = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonFourNeighbors
            // 
            this.radioButtonFourNeighbors.AutoSize = true;
            this.radioButtonFourNeighbors.Checked = true;
            this.radioButtonFourNeighbors.Location = new System.Drawing.Point(6, 13);
            this.radioButtonFourNeighbors.Name = "radioButtonFourNeighbors";
            this.radioButtonFourNeighbors.Size = new System.Drawing.Size(107, 17);
            this.radioButtonFourNeighbors.TabIndex = 0;
            this.radioButtonFourNeighbors.TabStop = true;
            this.radioButtonFourNeighbors.Text = "Czterosąsiedztwo";
            this.radioButtonFourNeighbors.UseVisualStyleBackColor = true;
            // 
            // radioButtonEightNeighborbood
            // 
            this.radioButtonEightNeighborbood.AutoSize = true;
            this.radioButtonEightNeighborbood.Location = new System.Drawing.Point(6, 37);
            this.radioButtonEightNeighborbood.Name = "radioButtonEightNeighborbood";
            this.radioButtonEightNeighborbood.Size = new System.Drawing.Size(106, 17);
            this.radioButtonEightNeighborbood.TabIndex = 1;
            this.radioButtonEightNeighborbood.TabStop = true;
            this.radioButtonEightNeighborbood.Text = "Ośmiosąsiedztwo";
            this.radioButtonEightNeighborbood.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Location = new System.Drawing.Point(3, 207);
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(180, 20);
            this.numericUpDownIterations.TabIndex = 3;
            this.numericUpDownIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEightNeighborbood);
            this.groupBox1.Controls.Add(this.radioButtonFourNeighbors);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Element Strukturalny";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonClose);
            this.groupBox2.Controls.Add(this.radioButtonOpen);
            this.groupBox2.Controls.Add(this.radioButtonDilatation);
            this.groupBox2.Controls.Add(this.radioButtonErode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operacja";
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Location = new System.Drawing.Point(6, 92);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(80, 17);
            this.radioButtonClose.TabIndex = 3;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Zamknięcie";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(7, 68);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(67, 17);
            this.radioButtonOpen.TabIndex = 2;
            this.radioButtonOpen.TabStop = true;
            this.radioButtonOpen.Text = "Otwarcie";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            // 
            // radioButtonDilatation
            // 
            this.radioButtonDilatation.AutoSize = true;
            this.radioButtonDilatation.Location = new System.Drawing.Point(7, 44);
            this.radioButtonDilatation.Name = "radioButtonDilatation";
            this.radioButtonDilatation.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDilatation.TabIndex = 1;
            this.radioButtonDilatation.TabStop = true;
            this.radioButtonDilatation.Text = "Dylatacja";
            this.radioButtonDilatation.UseVisualStyleBackColor = true;
            // 
            // radioButtonErode
            // 
            this.radioButtonErode.AutoSize = true;
            this.radioButtonErode.Checked = true;
            this.radioButtonErode.Location = new System.Drawing.Point(6, 20);
            this.radioButtonErode.Name = "radioButtonErode";
            this.radioButtonErode.Size = new System.Drawing.Size(54, 17);
            this.radioButtonErode.TabIndex = 0;
            this.radioButtonErode.TabStop = true;
            this.radioButtonErode.Text = "Erozja";
            this.radioButtonErode.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart1, 2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(598, 3);
            this.chart1.Name = "chart1";
            this.tableLayoutPanel1.SetRowSpan(this.chart1, 5);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(401, 403);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(189, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(403, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonPreview, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownIterations, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.94084F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.74038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.400978F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.27628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.601467F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 409);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Location = new System.Drawing.Point(393, 384);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(199, 22);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Resetuj";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(189, 384);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 22);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPreview.Location = new System.Drawing.Point(3, 384);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(180, 22);
            this.buttonPreview.TabIndex = 2;
            this.buttonPreview.Text = "Podgląd";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.ButtonPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ilość Iteracji:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MorphologicalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MorphologicalWindow";
            this.Text = "Operacje Morfologiczne";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFourNeighbors;
        private System.Windows.Forms.RadioButton radioButtonEightNeighborbood;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDilatation;
        private System.Windows.Forms.RadioButton radioButtonErode;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Label label1;
    }
}