using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace APO_Czerniawski
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            var imageExtensions = string.Join(";", ImageCodecInfo.GetImageDecoders().Select(ici => ici.FilenameExtension));
            openFileDialog1.Filter = string.Format("Images|{0}", imageExtensions);
            openFileDialog1.FilterIndex = 0;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int countWindows = 0;
                    ImageWindow imageWindow;

                    foreach (var child in MdiChildren)
                    {
                        if (child.Text.StartsWith(Path.GetFileName(openFileDialog1.FileName)))
                            countWindows++;
                    }

                    if (countWindows > 0)
                    {
                        string windowName = Path.GetFileName(openFileDialog1.FileName) + countWindows;
                        imageWindow = new ImageWindow(openFileDialog1.FileName,windowName,this);
                    }
                    else
                    {
                        imageWindow = new ImageWindow(openFileDialog1.FileName, Path.GetFileName(openFileDialog1.FileName),this);
                    }
                
                    imageWindow.MdiParent = this;
                    imageWindow.Show();
                    obrazToolStripMenuItem.Enabled = true;
                    operacjeToolStripMenuItem.Enabled = true;
                    analizaObrazuToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas wczytywania obrazu!", "Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private ImageWindow getSelectedImageWindow()
        {
            try
            {
                ImageWindow activeImageWindow = (ImageWindow)ActiveMdiChild;
                if (activeImageWindow == null)
                {
                    MessageBox.Show("Nie wybrano żadnego okna obrazu", "Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return null;
                }

                return activeImageWindow;
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano poprawnego okna obrazu", "Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

        }

        private void cloneWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int countWindows = 0;

            foreach (var child in MdiChildren)
            {
                if (child.Text.StartsWith(Path.GetFileName(openFileDialog1.FileName)))
                    countWindows++;
            }

            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;
            ImageWindow imageCloneWindow = activeImageWindow.clone(activeImageWindow.FilePath + countWindows);
            imageCloneWindow.MdiParent = this;
            imageCloneWindow.Show();

        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                cloneWindowToolStripMenuItem_Click(sender,e);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                openFileToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                ZapiszCTRLSToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                if(ActiveMdiChild != null && ActiveMdiChild.GetType() != typeof(SteganographyPreviewWindow))
                    ActiveMdiChild.Close();
            }
        }

        private void avgMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;
            activeImageWindow.avgMethodHisto();
        }

        private void losMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;
            activeImageWindow.losMethodHisto();
        }

        private void neibghMetodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;
            activeImageWindow.neibghMethodHisto();
        }

        private void metodaWłasnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;
            activeImageWindow.wlasnaMethodHisto();
        }

        private void rozciaganieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            StretchWindow stretchWindow = new StretchWindow(activeImageWindow);
            stretchWindow.MdiParent = this;
            stretchWindow.Show();
        }

        private void negacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            activeImageWindow.negacja();
        }

        private void progowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            TresholdingWindow stretchWindow = new TresholdingWindow(activeImageWindow);
            stretchWindow.MdiParent = this;
            stretchWindow.Show();
        }

        private void redukcjaPoziomówSzarościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            GrayscaleReductionWindow grayscaleReductionWindow = new GrayscaleReductionWindow(activeImageWindow);
            grayscaleReductionWindow.MdiParent = this;
            grayscaleReductionWindow.Show();
        }

        private void punktoweDwuargumentowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<NamedImage> namedImages = new List<NamedImage>();

            foreach (ImageWindow imageWindow in MdiChildren.Cast<ImageWindow>().ToArray())
            {
                namedImages.Add(new NamedImage(imageWindow.getImage(), imageWindow.Text));
            }

            BinaryOperations binaryOperations = new BinaryOperations(namedImages, this);
            binaryOperations.MdiParent = this;
            binaryOperations.Show();
        }

        private void MainWindow_MdiChildActivate(object sender, EventArgs e)
        {
            obrazToolStripMenuItem.Enabled = operacjeToolStripMenuItem.Enabled = analizaObrazuToolStripMenuItem.Enabled = (MdiChildren.Length-1 > 0);
            zapiszJakoToolStripMenuItem.Enabled = zapiszCTRLSToolStripMenuItem.Enabled = (MdiChildren.Length > 0);
        }

        private void wygładzanieWyostrzanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            LinearOperations linearOperationsWindow = new LinearOperations(activeImageWindow);
            linearOperationsWindow.MdiParent = this;
            linearOperationsWindow.Show();
        }

        private void medianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            MedianWindow medianWindow = new MedianWindow(activeImageWindow);
            medianWindow.MdiParent = this;
            medianWindow.Show();
        }

        private void filtracjaLogicznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            LogicalWindow logicalWindow = new LogicalWindow(activeImageWindow);
            logicalWindow.MdiParent = this;
            logicalWindow.Show();
        }

        private void gradientoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            GradientWindow gradientWindow = new GradientWindow(activeImageWindow);
            gradientWindow.MdiParent = this;
            gradientWindow.Show();
        }

        private void SzkieletyzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            activeImageWindow.Thining();
        }

        private void MorphologicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            MorphologicalWindow morphologicalWindow = new MorphologicalWindow(activeImageWindow);
            morphologicalWindow.MdiParent = this;
            morphologicalWindow.Show();
        }

        private void KompresjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            CompressWindow morphologicalWindow = new CompressWindow(activeImageWindow);
            morphologicalWindow.MdiParent = this;
            morphologicalWindow.Show();
        }

        private void WatershedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            activeImageWindow.Watershed();
        }

        private void RozrostObszaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            activeImageWindow.RegionGrowing();
        }

        private void AlgorytmZółwiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            activeImageWindow.Turtle();
        }

        private void AnalizaObrazuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            activeImageWindow.ImageAnalysis();
        }

        private void SteganografiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SteganographyWindow steganographyWindow = new SteganographyWindow(this);
            steganographyWindow.MdiParent = this;
            steganographyWindow.Show();
        }

        private void InformacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorInfo authorInfo = new AuthorInfo();
            authorInfo.StartPosition = FormStartPosition.CenterScreen;
            authorInfo.ShowDialog();
        }

        private void ZapiszCTRLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            var filePath = activeImageWindow.FilePath;
            try
            {
                if (File.Exists(filePath))
                    activeImageWindow.getImage().Save(filePath);
                else
                    ZapiszJakoToolStripMenuItem_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas zapisywania obrazu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "";

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;

            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                saveFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", saveFileDialog.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }

            saveFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", saveFileDialog.Filter, sep, "All Files", "*.*"); 

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    activeImageWindow.getImage().Save(saveFileDialog.FileName);

                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas zapisywania obrazu!", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void UniwersalnyOperatorPunktowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            UOPWindow uopWindow = new UOPWindow(activeImageWindow);
            uopWindow.MdiParent = this;
            uopWindow.Show();
        }

        private void AlgorytmŻółwiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageWindow activeImageWindow;
            if ((activeImageWindow = getSelectedImageWindow()) == null)
                return;

            activeImageWindow.Turtle();
        }
    }
}
