namespace APO_Czerniawski
{
    partial class CompressWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBlokowy = new System.Windows.Forms.RadioButton();
            this.radioButtonHuffman = new System.Windows.Forms.RadioButton();
            this.radioButtonLZW = new System.Windows.Forms.RadioButton();
            this.radioButtonRle = new System.Windows.Forms.RadioButton();
            this.buttonShow = new System.Windows.Forms.Button();
            this.numericUpDownBlock = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlock)).BeginInit();
            this.groupBoxSize.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBlokowy);
            this.groupBox1.Controls.Add(this.radioButtonHuffman);
            this.groupBox1.Controls.Add(this.radioButtonLZW);
            this.groupBox1.Controls.Add(this.radioButtonRle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Typ kompresji";
            // 
            // radioButtonBlokowy
            // 
            this.radioButtonBlokowy.AutoSize = true;
            this.radioButtonBlokowy.Location = new System.Drawing.Point(7, 91);
            this.radioButtonBlokowy.Name = "radioButtonBlokowy";
            this.radioButtonBlokowy.Size = new System.Drawing.Size(66, 17);
            this.radioButtonBlokowy.TabIndex = 3;
            this.radioButtonBlokowy.TabStop = true;
            this.radioButtonBlokowy.Text = "Blokowa";
            this.radioButtonBlokowy.UseVisualStyleBackColor = true;
            this.radioButtonBlokowy.CheckedChanged += new System.EventHandler(this.RadioButtonBlokowy_CheckedChanged);
            // 
            // radioButtonHuffman
            // 
            this.radioButtonHuffman.AutoSize = true;
            this.radioButtonHuffman.Location = new System.Drawing.Point(7, 68);
            this.radioButtonHuffman.Name = "radioButtonHuffman";
            this.radioButtonHuffman.Size = new System.Drawing.Size(65, 17);
            this.radioButtonHuffman.TabIndex = 2;
            this.radioButtonHuffman.TabStop = true;
            this.radioButtonHuffman.Text = "Huffman";
            this.radioButtonHuffman.UseVisualStyleBackColor = true;
            // 
            // radioButtonLZW
            // 
            this.radioButtonLZW.AutoSize = true;
            this.radioButtonLZW.Location = new System.Drawing.Point(7, 44);
            this.radioButtonLZW.Name = "radioButtonLZW";
            this.radioButtonLZW.Size = new System.Drawing.Size(49, 17);
            this.radioButtonLZW.TabIndex = 1;
            this.radioButtonLZW.Text = "LZW";
            this.radioButtonLZW.UseVisualStyleBackColor = true;
            // 
            // radioButtonRle
            // 
            this.radioButtonRle.AutoSize = true;
            this.radioButtonRle.Checked = true;
            this.radioButtonRle.Location = new System.Drawing.Point(7, 20);
            this.radioButtonRle.Name = "radioButtonRle";
            this.radioButtonRle.Size = new System.Drawing.Size(46, 17);
            this.radioButtonRle.TabIndex = 0;
            this.radioButtonRle.TabStop = true;
            this.radioButtonRle.Text = "RLE";
            this.radioButtonRle.UseVisualStyleBackColor = true;
            // 
            // buttonShow
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonShow, 2);
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShow.Location = new System.Drawing.Point(3, 131);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(322, 27);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Zapisz";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // numericUpDownBlock
            // 
            this.numericUpDownBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownBlock.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownBlock.Location = new System.Drawing.Point(3, 16);
            this.numericUpDownBlock.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownBlock.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownBlock.Name = "numericUpDownBlock";
            this.numericUpDownBlock.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownBlock.TabIndex = 3;
            this.numericUpDownBlock.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.numericUpDownBlock);
            this.groupBoxSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSize.Enabled = false;
            this.groupBoxSize.Location = new System.Drawing.Point(167, 3);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(158, 122);
            this.groupBoxSize.TabIndex = 5;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Rozmiar Kompresji Blokowej";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShow, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.94924F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 161);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // CompressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompressWindow";
            this.Text = "Kompresja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlock)).EndInit();
            this.groupBoxSize.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLZW;
        private System.Windows.Forms.RadioButton radioButtonRle;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.RadioButton radioButtonBlokowy;
        private System.Windows.Forms.RadioButton radioButtonHuffman;
        private System.Windows.Forms.NumericUpDown numericUpDownBlock;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}