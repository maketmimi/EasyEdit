using EasyEdit.GUI;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyEdit
{
    public partial class FrmMain : Form
    {
        private string[] _FilesToOpenAtStartup = null; 

        public FrmMain(string[] FilesToOpen = null)
        {
            InitializeComponent();

            DiaOpenFile.Filter = FrmCanvas.FileDialogsFilter;
            DiaOpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            _FilesToOpenAtStartup = FilesToOpen;
        }

        private FrmAbout frmAbout = new FrmAbout();

        private void ItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItmUndo_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.Undo();
            }
        }

        private void ItmCut_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.Cut();
            }
        }

        private void ItmCopy_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.Copy();
            }
        }

        private void ItmPaste_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.Paste();
            }
        }

        private void ItmDelete_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.Delete();
            }
        }

        private void ItmSelectAll_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.SelectAll();
            }
        }

        private void MnuEdit_DropDownOpening(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ItmUndo.Enabled = ActiveDocument.CanUndo();

                bool IsTextSelected = ActiveDocument.IsTextSelected();
                ItmCut.Enabled = IsTextSelected;
                ItmCopy.Enabled = IsTextSelected;
                ItmDelete.Enabled = IsTextSelected;

                ItmPaste.Enabled = Clipboard.ContainsText();
            }
        }

        private void ItmWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.WordWrap = ItmWordWrap.Checked;
            }
        }

        private void ItmAlignTextRight_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.AlignTextRigth();
            }
        }

        private void ItmAlignTextLeft_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.AlignTextLeft();
            }
        }

        private void AlignTextCenter_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.AlignTextCenter();
            }
        }

        private void ItmFont_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                MainFontDialog.Font = ActiveDocument.TextFont;
                if (MainFontDialog.ShowDialog() == DialogResult.OK)
                    ActiveDocument.TextFont = MainFontDialog.Font;
            }
        }

        private void ItmRtlLtr_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.Toggle_Rtl_LTR();
            }
        }
                
        private void ItmForeColor_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                MainColorDialog.Color = ActiveDocument.FontColor;
                if (MainColorDialog.ShowDialog() == DialogResult.OK)
                    ActiveDocument.FontColor = MainColorDialog.Color;
            }

        }

        private void ItmAboutProgram_Click(object sender, EventArgs e)
        {
            if (frmAbout == null || frmAbout.IsDisposed)
                frmAbout = new FrmAbout();

            frmAbout.Show();
        }

        private void ToolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.SaveAs();
            }
        }

        private void TryOpenFile(string FilePath)
        {
            try
            {
                FrmCanvas NewDocument = FrmCanvas.OpenFile(FilePath);

                if (NewDocument != null)
                {
                    NewDocument.MdiParent = this;
                    NewDocument.Show();
                }
                else
                {
                    MessageBox.Show("لا يمكن فتح الملف التالي:" + Environment.NewLine + FilePath, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("لا توجد ذاكرة كافية لفتح الملف التالي:" + Environment.NewLine + FilePath, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            if (DiaOpenFile.ShowDialog() == DialogResult.OK)
            {
                TryOpenFile(DiaOpenFile.FileName);
            }
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.SaveCurrentFile();
            }
        }

        private void FdMain_Apply(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ActiveDocument.TextFont = MainFontDialog.Font;
            }
        }

        private void MnuFormat_DropDownOpening(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is FrmCanvas ActiveDocument)
            {
                ItmWordWrap.Checked = ActiveDocument.WordWrap;
                ItmRtlLtr.Text =
                    ActiveDocument.IsRTL ? "من اليسار إلى اليمين" : "من اليمين إلى اليسار";
            }
        }

        private void ToolStripMenuItemNewFile_Click(object sender, EventArgs e)
        {
            FrmCanvas NewFile = FrmCanvas.OpenNewFile();

            NewFile.MdiParent = this;
            NewFile.Show();
        }

        private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        {
            bool Enabled;

            if (this.ActiveMdiChild is FrmCanvas)
                Enabled = true;
            else
                Enabled = false;

            MnuFormat.Enabled = Enabled;
            MnuEdit.Enabled = Enabled;
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            if (_FilesToOpenAtStartup != null)
            {
                foreach (string FilePath in _FilesToOpenAtStartup)
                    TryOpenFile(FilePath);

                _FilesToOpenAtStartup = null;
            }
        }
    }
}
