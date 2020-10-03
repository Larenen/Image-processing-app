namespace APO_Czerniawski
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszCTRLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeNaHisogramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyrównanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.losMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neibghMetodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodaWłasnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozciaganieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjePunktoweJednoargumentoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redukcjaPoziomówSzarościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniwersalnyOperatorPunktowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punktoweDwuargumentowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wygładzanieWyostrzanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtracjaLogicznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szkieletyzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erozjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segemntacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watershedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozrostObszaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompresjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytmŻółwiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizaObrazuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steganografiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.obrazToolStripMenuItem,
            this.operacjeToolStripMenuItem,
            this.analizaObrazuToolStripMenuItem,
            this.steganografiaToolStripMenuItem1,
            this.informacjeOProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.zapiszCTRLSToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openFileToolStripMenuItem.Text = "Otworz (CTRL + O)";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // zapiszCTRLSToolStripMenuItem
            // 
            this.zapiszCTRLSToolStripMenuItem.Enabled = false;
            this.zapiszCTRLSToolStripMenuItem.Name = "zapiszCTRLSToolStripMenuItem";
            this.zapiszCTRLSToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.zapiszCTRLSToolStripMenuItem.Text = "Zapisz (CTRL + S)";
            this.zapiszCTRLSToolStripMenuItem.Click += new System.EventHandler(this.ZapiszCTRLSToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Enabled = false;
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.ZapiszJakoToolStripMenuItem_Click);
            // 
            // obrazToolStripMenuItem
            // 
            this.obrazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cloneWindowToolStripMenuItem});
            this.obrazToolStripMenuItem.Enabled = false;
            this.obrazToolStripMenuItem.Name = "obrazToolStripMenuItem";
            this.obrazToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.obrazToolStripMenuItem.Text = "Obraz";
            // 
            // cloneWindowToolStripMenuItem
            // 
            this.cloneWindowToolStripMenuItem.Name = "cloneWindowToolStripMenuItem";
            this.cloneWindowToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cloneWindowToolStripMenuItem.Text = "Duplikuj (CTRL + D)";
            this.cloneWindowToolStripMenuItem.Click += new System.EventHandler(this.cloneWindowToolStripMenuItem_Click);
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacjeNaHisogramieToolStripMenuItem,
            this.operacjePunktoweJednoargumentoweToolStripMenuItem,
            this.punktoweDwuargumentowToolStripMenuItem,
            this.wygładzanieWyostrzanieToolStripMenuItem,
            this.medianaToolStripMenuItem,
            this.filtracjaLogicznaToolStripMenuItem,
            this.gradientoweToolStripMenuItem,
            this.szkieletyzacjaToolStripMenuItem,
            this.erozjaToolStripMenuItem,
            this.segemntacjaToolStripMenuItem,
            this.kompresjaToolStripMenuItem,
            this.algorytmŻółwiaToolStripMenuItem});
            this.operacjeToolStripMenuItem.Enabled = false;
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "Operacje";
            // 
            // operacjeNaHisogramieToolStripMenuItem
            // 
            this.operacjeNaHisogramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyrównanieToolStripMenuItem,
            this.rozciaganieToolStripMenuItem});
            this.operacjeNaHisogramieToolStripMenuItem.Name = "operacjeNaHisogramieToolStripMenuItem";
            this.operacjeNaHisogramieToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.operacjeNaHisogramieToolStripMenuItem.Text = "Histogramowe";
            // 
            // wyrównanieToolStripMenuItem
            // 
            this.wyrównanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avgMethodToolStripMenuItem,
            this.losMethodToolStripMenuItem,
            this.neibghMetodToolStripMenuItem,
            this.metodaWłasnaToolStripMenuItem});
            this.wyrównanieToolStripMenuItem.Name = "wyrównanieToolStripMenuItem";
            this.wyrównanieToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.wyrównanieToolStripMenuItem.Text = "Wyrównanie";
            // 
            // avgMethodToolStripMenuItem
            // 
            this.avgMethodToolStripMenuItem.Name = "avgMethodToolStripMenuItem";
            this.avgMethodToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.avgMethodToolStripMenuItem.Text = "Metoda Średnich";
            this.avgMethodToolStripMenuItem.Click += new System.EventHandler(this.avgMethodToolStripMenuItem_Click);
            // 
            // losMethodToolStripMenuItem
            // 
            this.losMethodToolStripMenuItem.Name = "losMethodToolStripMenuItem";
            this.losMethodToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.losMethodToolStripMenuItem.Text = "Metoda Losowych";
            this.losMethodToolStripMenuItem.Click += new System.EventHandler(this.losMethodToolStripMenuItem_Click);
            // 
            // neibghMetodToolStripMenuItem
            // 
            this.neibghMetodToolStripMenuItem.Name = "neibghMetodToolStripMenuItem";
            this.neibghMetodToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.neibghMetodToolStripMenuItem.Text = "Metoda Sasiedztwa";
            this.neibghMetodToolStripMenuItem.Click += new System.EventHandler(this.neibghMetodToolStripMenuItem_Click);
            // 
            // metodaWłasnaToolStripMenuItem
            // 
            this.metodaWłasnaToolStripMenuItem.Name = "metodaWłasnaToolStripMenuItem";
            this.metodaWłasnaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.metodaWłasnaToolStripMenuItem.Text = "Metoda Własna";
            this.metodaWłasnaToolStripMenuItem.Click += new System.EventHandler(this.metodaWłasnaToolStripMenuItem_Click);
            // 
            // rozciaganieToolStripMenuItem
            // 
            this.rozciaganieToolStripMenuItem.Name = "rozciaganieToolStripMenuItem";
            this.rozciaganieToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.rozciaganieToolStripMenuItem.Text = "Rozciaganie";
            this.rozciaganieToolStripMenuItem.Click += new System.EventHandler(this.rozciaganieToolStripMenuItem_Click);
            // 
            // operacjePunktoweJednoargumentoweToolStripMenuItem
            // 
            this.operacjePunktoweJednoargumentoweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negacjaToolStripMenuItem,
            this.progowanieToolStripMenuItem,
            this.redukcjaPoziomówSzarościToolStripMenuItem,
            this.uniwersalnyOperatorPunktowyToolStripMenuItem});
            this.operacjePunktoweJednoargumentoweToolStripMenuItem.Name = "operacjePunktoweJednoargumentoweToolStripMenuItem";
            this.operacjePunktoweJednoargumentoweToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.operacjePunktoweJednoargumentoweToolStripMenuItem.Text = "Punktowe Jednoargumentowe ";
            // 
            // negacjaToolStripMenuItem
            // 
            this.negacjaToolStripMenuItem.Name = "negacjaToolStripMenuItem";
            this.negacjaToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.negacjaToolStripMenuItem.Text = "Negacja";
            this.negacjaToolStripMenuItem.Click += new System.EventHandler(this.negacjaToolStripMenuItem_Click);
            // 
            // progowanieToolStripMenuItem
            // 
            this.progowanieToolStripMenuItem.Name = "progowanieToolStripMenuItem";
            this.progowanieToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.progowanieToolStripMenuItem.Text = "Progowanie";
            this.progowanieToolStripMenuItem.Click += new System.EventHandler(this.progowanieToolStripMenuItem_Click);
            // 
            // redukcjaPoziomówSzarościToolStripMenuItem
            // 
            this.redukcjaPoziomówSzarościToolStripMenuItem.Name = "redukcjaPoziomówSzarościToolStripMenuItem";
            this.redukcjaPoziomówSzarościToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.redukcjaPoziomówSzarościToolStripMenuItem.Text = "Redukcja Poziomów Szarości";
            this.redukcjaPoziomówSzarościToolStripMenuItem.Click += new System.EventHandler(this.redukcjaPoziomówSzarościToolStripMenuItem_Click);
            // 
            // uniwersalnyOperatorPunktowyToolStripMenuItem
            // 
            this.uniwersalnyOperatorPunktowyToolStripMenuItem.Name = "uniwersalnyOperatorPunktowyToolStripMenuItem";
            this.uniwersalnyOperatorPunktowyToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.uniwersalnyOperatorPunktowyToolStripMenuItem.Text = "Uniwersalny Operator Punktowy";
            this.uniwersalnyOperatorPunktowyToolStripMenuItem.Click += new System.EventHandler(this.UniwersalnyOperatorPunktowyToolStripMenuItem_Click);
            // 
            // punktoweDwuargumentowToolStripMenuItem
            // 
            this.punktoweDwuargumentowToolStripMenuItem.Name = "punktoweDwuargumentowToolStripMenuItem";
            this.punktoweDwuargumentowToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.punktoweDwuargumentowToolStripMenuItem.Text = "Punktowe Dwuargumentowe";
            this.punktoweDwuargumentowToolStripMenuItem.Click += new System.EventHandler(this.punktoweDwuargumentowToolStripMenuItem_Click);
            // 
            // wygładzanieWyostrzanieToolStripMenuItem
            // 
            this.wygładzanieWyostrzanieToolStripMenuItem.Name = "wygładzanieWyostrzanieToolStripMenuItem";
            this.wygładzanieWyostrzanieToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.wygładzanieWyostrzanieToolStripMenuItem.Text = "Wygładzanie/Wyostrzanie";
            this.wygładzanieWyostrzanieToolStripMenuItem.Click += new System.EventHandler(this.wygładzanieWyostrzanieToolStripMenuItem_Click);
            // 
            // medianaToolStripMenuItem
            // 
            this.medianaToolStripMenuItem.Name = "medianaToolStripMenuItem";
            this.medianaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.medianaToolStripMenuItem.Text = "Filtracja Medianowa";
            this.medianaToolStripMenuItem.Click += new System.EventHandler(this.medianaToolStripMenuItem_Click);
            // 
            // filtracjaLogicznaToolStripMenuItem
            // 
            this.filtracjaLogicznaToolStripMenuItem.Name = "filtracjaLogicznaToolStripMenuItem";
            this.filtracjaLogicznaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.filtracjaLogicznaToolStripMenuItem.Text = "Filtracja Logiczna";
            this.filtracjaLogicznaToolStripMenuItem.Click += new System.EventHandler(this.filtracjaLogicznaToolStripMenuItem_Click);
            // 
            // gradientoweToolStripMenuItem
            // 
            this.gradientoweToolStripMenuItem.Name = "gradientoweToolStripMenuItem";
            this.gradientoweToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.gradientoweToolStripMenuItem.Text = "Gradientowe";
            this.gradientoweToolStripMenuItem.Click += new System.EventHandler(this.gradientoweToolStripMenuItem_Click);
            // 
            // szkieletyzacjaToolStripMenuItem
            // 
            this.szkieletyzacjaToolStripMenuItem.Name = "szkieletyzacjaToolStripMenuItem";
            this.szkieletyzacjaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.szkieletyzacjaToolStripMenuItem.Text = "Szkieletyzacja";
            this.szkieletyzacjaToolStripMenuItem.Click += new System.EventHandler(this.SzkieletyzacjaToolStripMenuItem_Click);
            // 
            // erozjaToolStripMenuItem
            // 
            this.erozjaToolStripMenuItem.Name = "erozjaToolStripMenuItem";
            this.erozjaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.erozjaToolStripMenuItem.Text = "Morfologiczne";
            this.erozjaToolStripMenuItem.Click += new System.EventHandler(this.MorphologicalToolStripMenuItem_Click);
            // 
            // segemntacjaToolStripMenuItem
            // 
            this.segemntacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watershedToolStripMenuItem,
            this.rozrostObszaruToolStripMenuItem});
            this.segemntacjaToolStripMenuItem.Name = "segemntacjaToolStripMenuItem";
            this.segemntacjaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.segemntacjaToolStripMenuItem.Text = "Segmentacja";
            // 
            // watershedToolStripMenuItem
            // 
            this.watershedToolStripMenuItem.Name = "watershedToolStripMenuItem";
            this.watershedToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.watershedToolStripMenuItem.Text = "Watershed";
            this.watershedToolStripMenuItem.Click += new System.EventHandler(this.WatershedToolStripMenuItem_Click);
            // 
            // rozrostObszaruToolStripMenuItem
            // 
            this.rozrostObszaruToolStripMenuItem.Name = "rozrostObszaruToolStripMenuItem";
            this.rozrostObszaruToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.rozrostObszaruToolStripMenuItem.Text = "Rozrost Obszaru";
            this.rozrostObszaruToolStripMenuItem.Click += new System.EventHandler(this.RozrostObszaruToolStripMenuItem_Click);
            // 
            // kompresjaToolStripMenuItem
            // 
            this.kompresjaToolStripMenuItem.Name = "kompresjaToolStripMenuItem";
            this.kompresjaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.kompresjaToolStripMenuItem.Text = "Kompresja";
            this.kompresjaToolStripMenuItem.Click += new System.EventHandler(this.KompresjaToolStripMenuItem_Click);
            // 
            // algorytmŻółwiaToolStripMenuItem
            // 
            this.algorytmŻółwiaToolStripMenuItem.Name = "algorytmŻółwiaToolStripMenuItem";
            this.algorytmŻółwiaToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.algorytmŻółwiaToolStripMenuItem.Text = "Algorytm Żółwia";
            this.algorytmŻółwiaToolStripMenuItem.Click += new System.EventHandler(this.AlgorytmŻółwiaToolStripMenuItem_Click);
            // 
            // analizaObrazuToolStripMenuItem
            // 
            this.analizaObrazuToolStripMenuItem.Enabled = false;
            this.analizaObrazuToolStripMenuItem.Name = "analizaObrazuToolStripMenuItem";
            this.analizaObrazuToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.analizaObrazuToolStripMenuItem.Text = "Analiza Obrazu";
            this.analizaObrazuToolStripMenuItem.Click += new System.EventHandler(this.AnalizaObrazuToolStripMenuItem_Click);
            // 
            // steganografiaToolStripMenuItem1
            // 
            this.steganografiaToolStripMenuItem1.Name = "steganografiaToolStripMenuItem1";
            this.steganografiaToolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.steganografiaToolStripMenuItem1.Text = "Steganografia";
            this.steganografiaToolStripMenuItem1.Click += new System.EventHandler(this.SteganografiaToolStripMenuItem1_Click);
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o autorze";
            this.informacjeOProgramieToolStripMenuItem.Click += new System.EventHandler(this.InformacjeOProgramieToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 423);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "APO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainWindow_MdiChildActivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeNaHisogramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyrównanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem losMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neibghMetodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozciaganieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodaWłasnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjePunktoweJednoargumentoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redukcjaPoziomówSzarościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punktoweDwuargumentowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wygładzanieWyostrzanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtracjaLogicznaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szkieletyzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erozjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompresjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segemntacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watershedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozrostObszaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizaObrazuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steganografiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszCTRLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem uniwersalnyOperatorPunktowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytmŻółwiaToolStripMenuItem;
    }
}