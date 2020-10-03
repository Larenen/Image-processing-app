using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO_Czerniawski
{
    partial class SteganographyWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteganographyWindow));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadToHide = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonToEncryptLoad = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageToHide = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonSaveHidden = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownHide = new System.Windows.Forms.NumericUpDown();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartImageR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartImageG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chartImageB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chartImageToHideR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.chartImageToHideG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chartImageToHideB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.chartImageHiddenR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.chartImageHiddenG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.chartImageHiddenB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxImageToDecrypt = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxEncryptedImage = new System.Windows.Forms.PictureBox();
            this.buttonSaveEncrypted = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownShow = new System.Windows.Forms.NumericUpDown();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.chartToEncodeR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.chartToEncodeG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.chartToEncodeB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab3 = new System.Windows.Forms.TabControl();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.chartEncodedR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.chartEncodedG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.chartEncodedB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageToHide)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHide)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageR)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageG)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageB)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageToHideR)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageToHideG)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageToHideB)).BeginInit();
            this.tabControl4.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageHiddenR)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageHiddenG)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartImageHiddenB)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageToDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryptedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShow)).BeginInit();
            this.tabControl5.SuspendLayout();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartToEncodeR)).BeginInit();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartToEncodeG)).BeginInit();
            this.tabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartToEncodeB)).BeginInit();
            this.tab3.SuspendLayout();
            this.tabPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEncodedR)).BeginInit();
            this.tabPage16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEncodedG)).BeginInit();
            this.tabPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEncodedB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.Location = new System.Drawing.Point(3, 547);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(272, 25);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obraz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(281, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ukrywany Obraz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoadToHide
            // 
            this.buttonLoadToHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoadToHide.Enabled = false;
            this.buttonLoadToHide.Location = new System.Drawing.Point(281, 547);
            this.buttonLoadToHide.Name = "buttonLoadToHide";
            this.buttonLoadToHide.Size = new System.Drawing.Size(310, 25);
            this.buttonLoadToHide.TabIndex = 3;
            this.buttonLoadToHide.Text = "Wczytaj";
            this.buttonLoadToHide.UseVisualStyleBackColor = true;
            this.buttonLoadToHide.Click += new System.EventHandler(this.ButtonLoadToHide_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHide.Enabled = false;
            this.buttonHide.Location = new System.Drawing.Point(597, 547);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(234, 25);
            this.buttonHide.TabIndex = 4;
            this.buttonHide.Text = "Ukryj";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.ButtonHide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Obraz do odkrycia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonToEncryptLoad
            // 
            this.buttonToEncryptLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToEncryptLoad.Location = new System.Drawing.Point(3, 546);
            this.buttonToEncryptLoad.Name = "buttonToEncryptLoad";
            this.buttonToEncryptLoad.Size = new System.Drawing.Size(445, 26);
            this.buttonToEncryptLoad.TabIndex = 6;
            this.buttonToEncryptLoad.Text = "Wczytaj";
            this.buttonToEncryptLoad.UseVisualStyleBackColor = true;
            this.buttonToEncryptLoad.Click += new System.EventHandler(this.ButtonToEncryptLoad_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShow.Enabled = false;
            this.buttonShow.Location = new System.Drawing.Point(454, 546);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(375, 26);
            this.buttonShow.TabIndex = 7;
            this.buttonShow.Text = "Pokaż";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(3, 31);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxImage, 2);
            this.pictureBoxImage.Size = new System.Drawing.Size(272, 303);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 8;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBoxImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBoxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // pictureBoxImageToHide
            // 
            this.pictureBoxImageToHide.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxImageToHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImageToHide.Location = new System.Drawing.Point(281, 31);
            this.pictureBoxImageToHide.Name = "pictureBoxImageToHide";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxImageToHide, 2);
            this.pictureBoxImageToHide.Size = new System.Drawing.Size(310, 303);
            this.pictureBoxImageToHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageToHide.TabIndex = 9;
            this.pictureBoxImageToHide.TabStop = false;
            this.pictureBoxImageToHide.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBoxImageToHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBoxImageToHide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBoxImageToHide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 607);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ukrywanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.52675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.68313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.312757F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxImageToHide, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxResult, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoad, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoadToHide, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonHide, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonSaveHidden, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHide, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tabControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tabControl4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.017301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.2699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.691629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.90842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.3007F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.716896F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 575);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(597, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Obraz Wynikowy";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxResult, 2);
            this.pictureBoxResult.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxResult.Location = new System.Drawing.Point(597, 31);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(343, 271);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 11;
            this.pictureBoxResult.TabStop = false;
            this.pictureBoxResult.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBoxResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBoxResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBoxResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // buttonSaveHidden
            // 
            this.buttonSaveHidden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveHidden.Enabled = false;
            this.buttonSaveHidden.Location = new System.Drawing.Point(837, 547);
            this.buttonSaveHidden.Name = "buttonSaveHidden";
            this.buttonSaveHidden.Size = new System.Drawing.Size(103, 25);
            this.buttonSaveHidden.TabIndex = 10;
            this.buttonSaveHidden.Text = "Zapisz";
            this.buttonSaveHidden.UseVisualStyleBackColor = true;
            this.buttonSaveHidden.Click += new System.EventHandler(this.ButtonSaveHidden_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(597, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ilość bitów na jakich chcesz ukryć obraz";
            // 
            // numericUpDownHide
            // 
            this.numericUpDownHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownHide.Location = new System.Drawing.Point(837, 523);
            this.numericUpDownHide.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownHide.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHide.Name = "numericUpDownHide";
            this.numericUpDownHide.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownHide.TabIndex = 13;
            this.numericUpDownHide.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownHide.ValueChanged += new System.EventHandler(this.NumericUpDownHide_ValueChanged);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 340);
            this.tabControl3.Name = "tabControl3";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl3, 2);
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(272, 201);
            this.tabControl3.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartImageR);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(264, 175);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "R";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartImageR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartImageR.ChartAreas.Add(chartArea1);
            this.chartImageR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageR.Location = new System.Drawing.Point(3, 3);
            this.chartImageR.Name = "chartImageR";
            this.chartImageR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartImageR.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            this.chartImageR.Series.Add(series1);
            this.chartImageR.Size = new System.Drawing.Size(258, 169);
            this.chartImageR.TabIndex = 15;
            this.chartImageR.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartImageG);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(264, 175);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "G";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartImageG
            // 
            chartArea2.Name = "ChartArea1";
            this.chartImageG.ChartAreas.Add(chartArea2);
            this.chartImageG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageG.Location = new System.Drawing.Point(3, 3);
            this.chartImageG.Name = "chartImageG";
            this.chartImageG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.IsXValueIndexed = true;
            series2.Name = "Series1";
            this.chartImageG.Series.Add(series2);
            this.chartImageG.Size = new System.Drawing.Size(258, 169);
            this.chartImageG.TabIndex = 16;
            this.chartImageG.Text = "chart1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chartImageB);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(264, 175);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "B";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chartImageB
            // 
            chartArea3.Name = "ChartArea1";
            this.chartImageB.ChartAreas.Add(chartArea3);
            this.chartImageB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageB.Location = new System.Drawing.Point(3, 3);
            this.chartImageB.Name = "chartImageB";
            this.chartImageB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.IsXValueIndexed = true;
            series3.Name = "Series1";
            this.chartImageB.Series.Add(series3);
            this.chartImageB.Size = new System.Drawing.Size(258, 169);
            this.chartImageB.TabIndex = 16;
            this.chartImageB.Text = "chart1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(281, 340);
            this.tabControl2.Name = "tabControl2";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl2, 2);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(310, 201);
            this.tabControl2.TabIndex = 26;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chartImageToHideR);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(302, 175);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "R";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chartImageToHideR
            // 
            chartArea4.Name = "ChartArea1";
            this.chartImageToHideR.ChartAreas.Add(chartArea4);
            this.chartImageToHideR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageToHideR.Location = new System.Drawing.Point(3, 3);
            this.chartImageToHideR.Name = "chartImageToHideR";
            this.chartImageToHideR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartImageToHideR.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.IsXValueIndexed = true;
            series4.Name = "Series1";
            this.chartImageToHideR.Series.Add(series4);
            this.chartImageToHideR.Size = new System.Drawing.Size(296, 169);
            this.chartImageToHideR.TabIndex = 16;
            this.chartImageToHideR.Text = "chart2";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.chartImageToHideG);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(302, 175);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "G";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // chartImageToHideG
            // 
            chartArea5.Name = "ChartArea1";
            this.chartImageToHideG.ChartAreas.Add(chartArea5);
            this.chartImageToHideG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageToHideG.Location = new System.Drawing.Point(3, 3);
            this.chartImageToHideG.Name = "chartImageToHideG";
            this.chartImageToHideG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.IsXValueIndexed = true;
            series5.Name = "Series1";
            this.chartImageToHideG.Series.Add(series5);
            this.chartImageToHideG.Size = new System.Drawing.Size(296, 169);
            this.chartImageToHideG.TabIndex = 17;
            this.chartImageToHideG.Text = "chart2";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chartImageToHideB);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(302, 175);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "B";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chartImageToHideB
            // 
            chartArea6.Name = "ChartArea1";
            this.chartImageToHideB.ChartAreas.Add(chartArea6);
            this.chartImageToHideB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageToHideB.Location = new System.Drawing.Point(3, 3);
            this.chartImageToHideB.Name = "chartImageToHideB";
            this.chartImageToHideB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.IsXValueIndexed = true;
            series6.Name = "Series1";
            this.chartImageToHideB.Series.Add(series6);
            this.chartImageToHideB.Size = new System.Drawing.Size(296, 169);
            this.chartImageToHideB.TabIndex = 17;
            this.chartImageToHideB.Text = "chart2";
            // 
            // tabControl4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl4, 2);
            this.tabControl4.Controls.Add(this.tabPage9);
            this.tabControl4.Controls.Add(this.tabPage10);
            this.tabControl4.Controls.Add(this.tabPage11);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(597, 308);
            this.tabControl4.Name = "tabControl4";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl4, 2);
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(343, 209);
            this.tabControl4.TabIndex = 27;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.chartImageHiddenR);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(335, 183);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "R";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // chartImageHiddenR
            // 
            chartArea7.Name = "ChartArea1";
            this.chartImageHiddenR.ChartAreas.Add(chartArea7);
            this.chartImageHiddenR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageHiddenR.Location = new System.Drawing.Point(3, 3);
            this.chartImageHiddenR.Margin = new System.Windows.Forms.Padding(2);
            this.chartImageHiddenR.Name = "chartImageHiddenR";
            this.chartImageHiddenR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartImageHiddenR.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.IsXValueIndexed = true;
            series7.Name = "Series1";
            this.chartImageHiddenR.Series.Add(series7);
            this.chartImageHiddenR.Size = new System.Drawing.Size(329, 177);
            this.chartImageHiddenR.TabIndex = 17;
            this.chartImageHiddenR.Text = "chart1";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.chartImageHiddenG);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(335, 183);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "G";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // chartImageHiddenG
            // 
            chartArea8.Name = "ChartArea1";
            this.chartImageHiddenG.ChartAreas.Add(chartArea8);
            this.chartImageHiddenG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageHiddenG.Location = new System.Drawing.Point(3, 3);
            this.chartImageHiddenG.Margin = new System.Windows.Forms.Padding(2);
            this.chartImageHiddenG.Name = "chartImageHiddenG";
            this.chartImageHiddenG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series8.IsXValueIndexed = true;
            series8.Name = "Series1";
            this.chartImageHiddenG.Series.Add(series8);
            this.chartImageHiddenG.Size = new System.Drawing.Size(329, 177);
            this.chartImageHiddenG.TabIndex = 18;
            this.chartImageHiddenG.Text = "chart1";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.chartImageHiddenB);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(335, 183);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "B";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // chartImageHiddenB
            // 
            chartArea9.Name = "ChartArea1";
            this.chartImageHiddenB.ChartAreas.Add(chartArea9);
            this.chartImageHiddenB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartImageHiddenB.Location = new System.Drawing.Point(3, 3);
            this.chartImageHiddenB.Margin = new System.Windows.Forms.Padding(2);
            this.chartImageHiddenB.Name = "chartImageHiddenB";
            this.chartImageHiddenB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series9.IsXValueIndexed = true;
            series9.Name = "Series1";
            this.chartImageHiddenB.Series.Add(series9);
            this.chartImageHiddenB.Size = new System.Drawing.Size(329, 177);
            this.chartImageHiddenB.TabIndex = 18;
            this.chartImageHiddenB.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odkrywanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66255F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.47737F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.230453F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxImageToDecrypt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxEncryptedImage, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonShow, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonSaveEncrypted, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownShow, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonToEncryptLoad, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tabControl5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tab3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.442314F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.36122F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.942924F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.50822F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.747992F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997323F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(943, 575);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // pictureBoxImageToDecrypt
            // 
            this.pictureBoxImageToDecrypt.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxImageToDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImageToDecrypt.Location = new System.Drawing.Point(3, 22);
            this.pictureBoxImageToDecrypt.Name = "pictureBoxImageToDecrypt";
            this.pictureBoxImageToDecrypt.Size = new System.Drawing.Size(445, 260);
            this.pictureBoxImageToDecrypt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageToDecrypt.TabIndex = 8;
            this.pictureBoxImageToDecrypt.TabStop = false;
            this.pictureBoxImageToDecrypt.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBoxImageToDecrypt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBoxImageToDecrypt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBoxImageToDecrypt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(454, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Obraz wynikowy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEncryptedImage
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pictureBoxEncryptedImage, 2);
            this.pictureBoxEncryptedImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxEncryptedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEncryptedImage.Location = new System.Drawing.Point(454, 22);
            this.pictureBoxEncryptedImage.Name = "pictureBoxEncryptedImage";
            this.pictureBoxEncryptedImage.Size = new System.Drawing.Size(486, 260);
            this.pictureBoxEncryptedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEncryptedImage.TabIndex = 9;
            this.pictureBoxEncryptedImage.TabStop = false;
            this.pictureBoxEncryptedImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBoxEncryptedImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBoxEncryptedImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBoxEncryptedImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // buttonSaveEncrypted
            // 
            this.buttonSaveEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveEncrypted.Enabled = false;
            this.buttonSaveEncrypted.Location = new System.Drawing.Point(835, 546);
            this.buttonSaveEncrypted.Name = "buttonSaveEncrypted";
            this.buttonSaveEncrypted.Size = new System.Drawing.Size(105, 26);
            this.buttonSaveEncrypted.TabIndex = 11;
            this.buttonSaveEncrypted.Text = "Zapisz";
            this.buttonSaveEncrypted.UseVisualStyleBackColor = true;
            this.buttonSaveEncrypted.Click += new System.EventHandler(this.buttonSaveEncrypted_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(454, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ilość bitów na jakich obraz został ukryty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownShow
            // 
            this.numericUpDownShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownShow.Location = new System.Drawing.Point(835, 525);
            this.numericUpDownShow.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownShow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShow.Name = "numericUpDownShow";
            this.numericUpDownShow.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownShow.TabIndex = 13;
            this.numericUpDownShow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownShow.ValueChanged += new System.EventHandler(this.NumericUpDownShow_ValueChanged);
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage12);
            this.tabControl5.Controls.Add(this.tabPage13);
            this.tabControl5.Controls.Add(this.tabPage14);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(3, 288);
            this.tabControl5.Name = "tabControl5";
            this.tableLayoutPanel2.SetRowSpan(this.tabControl5, 3);
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(445, 252);
            this.tabControl5.TabIndex = 17;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.chartToEncodeR);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(437, 226);
            this.tabPage12.TabIndex = 0;
            this.tabPage12.Text = "R";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // chartToEncodeR
            // 
            chartArea10.Name = "ChartArea1";
            this.chartToEncodeR.ChartAreas.Add(chartArea10);
            this.chartToEncodeR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartToEncodeR.Location = new System.Drawing.Point(3, 3);
            this.chartToEncodeR.Name = "chartToEncodeR";
            this.chartToEncodeR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartToEncodeR.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series10.IsXValueIndexed = true;
            series10.Name = "Series1";
            this.chartToEncodeR.Series.Add(series10);
            this.chartToEncodeR.Size = new System.Drawing.Size(431, 220);
            this.chartToEncodeR.TabIndex = 14;
            this.chartToEncodeR.Text = "chart1";
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.chartToEncodeG);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(437, 226);
            this.tabPage13.TabIndex = 1;
            this.tabPage13.Text = "G";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // chartToEncodeG
            // 
            chartArea11.Name = "ChartArea1";
            this.chartToEncodeG.ChartAreas.Add(chartArea11);
            this.chartToEncodeG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartToEncodeG.Location = new System.Drawing.Point(3, 3);
            this.chartToEncodeG.Name = "chartToEncodeG";
            this.chartToEncodeG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.IsXValueIndexed = true;
            series11.Name = "Series1";
            this.chartToEncodeG.Series.Add(series11);
            this.chartToEncodeG.Size = new System.Drawing.Size(431, 220);
            this.chartToEncodeG.TabIndex = 15;
            this.chartToEncodeG.Text = "chart1";
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.chartToEncodeB);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(437, 226);
            this.tabPage14.TabIndex = 2;
            this.tabPage14.Text = "B";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // chartToEncodeB
            // 
            chartArea12.Name = "ChartArea1";
            this.chartToEncodeB.ChartAreas.Add(chartArea12);
            this.chartToEncodeB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartToEncodeB.Location = new System.Drawing.Point(3, 3);
            this.chartToEncodeB.Name = "chartToEncodeB";
            this.chartToEncodeB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series12.IsXValueIndexed = true;
            series12.Name = "Series1";
            this.chartToEncodeB.Series.Add(series12);
            this.chartToEncodeB.Size = new System.Drawing.Size(431, 220);
            this.chartToEncodeB.TabIndex = 15;
            this.chartToEncodeB.Text = "chart1";
            // 
            // tab3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tab3, 2);
            this.tab3.Controls.Add(this.tabPage15);
            this.tab3.Controls.Add(this.tabPage16);
            this.tab3.Controls.Add(this.tabPage17);
            this.tab3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab3.Location = new System.Drawing.Point(454, 288);
            this.tab3.Name = "tab3";
            this.tableLayoutPanel2.SetRowSpan(this.tab3, 2);
            this.tab3.SelectedIndex = 0;
            this.tab3.Size = new System.Drawing.Size(486, 231);
            this.tab3.TabIndex = 18;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.chartEncodedR);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(478, 205);
            this.tabPage15.TabIndex = 0;
            this.tabPage15.Text = "R";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // chartEncodedR
            // 
            chartArea13.Name = "ChartArea1";
            this.chartEncodedR.ChartAreas.Add(chartArea13);
            this.chartEncodedR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEncodedR.Location = new System.Drawing.Point(3, 3);
            this.chartEncodedR.Name = "chartEncodedR";
            this.chartEncodedR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartEncodedR.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series13.IsXValueIndexed = true;
            series13.Name = "Series1";
            this.chartEncodedR.Series.Add(series13);
            this.chartEncodedR.Size = new System.Drawing.Size(472, 199);
            this.chartEncodedR.TabIndex = 15;
            this.chartEncodedR.Text = "chart1";
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.chartEncodedG);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(478, 205);
            this.tabPage16.TabIndex = 1;
            this.tabPage16.Text = "G";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // chartEncodedG
            // 
            chartArea14.Name = "ChartArea1";
            this.chartEncodedG.ChartAreas.Add(chartArea14);
            this.chartEncodedG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEncodedG.Location = new System.Drawing.Point(3, 3);
            this.chartEncodedG.Name = "chartEncodedG";
            this.chartEncodedG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series14.IsXValueIndexed = true;
            series14.Name = "Series1";
            this.chartEncodedG.Series.Add(series14);
            this.chartEncodedG.Size = new System.Drawing.Size(472, 199);
            this.chartEncodedG.TabIndex = 16;
            this.chartEncodedG.Text = "chart1";
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.chartEncodedB);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(478, 205);
            this.tabPage17.TabIndex = 2;
            this.tabPage17.Text = "B";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // chartEncodedB
            // 
            chartArea15.Name = "ChartArea1";
            this.chartEncodedB.ChartAreas.Add(chartArea15);
            this.chartEncodedB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEncodedB.Location = new System.Drawing.Point(3, 3);
            this.chartEncodedB.Name = "chartEncodedB";
            this.chartEncodedB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series15.IsXValueIndexed = true;
            series15.Name = "Series1";
            this.chartEncodedB.Series.Add(series15);
            this.chartEncodedB.Size = new System.Drawing.Size(472, 199);
            this.chartEncodedB.TabIndex = 16;
            this.chartEncodedB.Text = "chart1";
            // 
            // SteganographyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 607);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SteganographyWindow";
            this.Text = "Steganografia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SteganographyWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageToHide)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHide)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageR)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageG)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageB)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageToHideR)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageToHideG)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageToHideB)).EndInit();
            this.tabControl4.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageHiddenR)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageHiddenG)).EndInit();
            this.tabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartImageHiddenB)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageToDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryptedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShow)).EndInit();
            this.tabControl5.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartToEncodeR)).EndInit();
            this.tabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartToEncodeG)).EndInit();
            this.tabPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartToEncodeB)).EndInit();
            this.tab3.ResumeLayout(false);
            this.tabPage15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEncodedR)).EndInit();
            this.tabPage16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEncodedG)).EndInit();
            this.tabPage17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEncodedB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLoad;
        private Label label1;
        private Label label2;
        private Button buttonLoadToHide;
        private Button buttonHide;
        private Label label3;
        private Button buttonToEncryptLoad;
        private Button buttonShow;
        private PictureBox pictureBoxImage;
        private PictureBox pictureBoxImageToHide;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private PictureBox pictureBoxEncryptedImage;
        private PictureBox pictureBoxImageToDecrypt;
        private Label label5;
        private PictureBox pictureBoxResult;
        private Button buttonSaveHidden;
        private Button buttonSaveEncrypted;
        private Label label6;
        private NumericUpDown numericUpDownHide;
        private NumericUpDown numericUpDownShow;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Chart chartImageR;
        private Chart chartImageToHideR;
        private TableLayoutPanel tableLayoutPanel2;
        private Chart chartToEncodeR;
        private Chart chartEncodedR;
        private Chart chartImageHiddenR;
        private TabControl tabControl3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Chart chartImageG;
        private TabPage tabPage5;
        private Chart chartImageB;
        private TabControl tabControl2;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Chart chartImageToHideG;
        private TabPage tabPage8;
        private Chart chartImageToHideB;
        private TabControl tabControl4;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private Chart chartImageHiddenG;
        private TabPage tabPage11;
        private Chart chartImageHiddenB;
        private TabControl tabControl5;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private Chart chartToEncodeG;
        private TabPage tabPage14;
        private Chart chartToEncodeB;
        private TabControl tab3;
        private TabPage tabPage15;
        private TabPage tabPage16;
        private Chart chartEncodedG;
        private TabPage tabPage17;
        private Chart chartEncodedB;
    }
}