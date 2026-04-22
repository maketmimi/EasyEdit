using System;
using System.Windows.Forms;

namespace EasyEdit
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItmUndo_Click(object sender, EventArgs e)
        {
            TxtMainCanvas.Undo();
        }

        private void ItmCut_Click(object sender, EventArgs e)
        {
            TxtMainCanvas.Cut();
        }

        private void ItmCopy_Click(object sender, EventArgs e)
        {
            TxtMainCanvas.Copy();
        }

        private void ItmPaste_Click(object sender, EventArgs e)
        {
            TxtMainCanvas.Paste();
        }

        private void ItmDelete_Click(object sender, EventArgs e)
        {
            TxtMainCanvas.SelectedText = "";
        }

        private void ItmSelectAll_Click(object sender, EventArgs e)
        {
            TxtMainCanvas.SelectAll();
        }

        private void MnuEdit_DropDownOpening(object sender, EventArgs e)
        {
            ItmUndo.Enabled = TxtMainCanvas.CanUndo;

            bool IsTextSelected = TxtMainCanvas.SelectionLength > 0;
            ItmCut.Enabled = IsTextSelected;
            ItmCopy.Enabled = IsTextSelected;
            ItmDelete.Enabled = IsTextSelected;

            ItmPaste.Enabled = Clipboard.ContainsText();
        }

        private void ItmWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            TxtMainCanvas.WordWrap = ItmWordWrap.Checked;
        }

        private void ItmAlignTextRight_Click(object sender, EventArgs e)
        {
            // note that this is because the left and right direction
            // is not a phisical direction any more because of the
            // RTL Mode, so now Left = Start of Text
            // while Right = End Of Text

            if (TxtMainCanvas.RightToLeft == RightToLeft.Yes)
                TxtMainCanvas.TextAlign = HorizontalAlignment.Left;
            else
                TxtMainCanvas.TextAlign = HorizontalAlignment.Right;
        }

        private void ItmAlignTextLeft_Click(object sender, EventArgs e)
        {
            // note that this is because the left and right direction
            // is not a phisical direction any more because of the
            // RTL Mode, so now Left = Start of Text
            // while Right = End Of Text
            if (TxtMainCanvas.RightToLeft == RightToLeft.Yes)
                TxtMainCanvas.TextAlign = HorizontalAlignment.Right;
            else
                TxtMainCanvas.TextAlign = HorizontalAlignment.Left;
        }

        private void AlignTextCenter_Click(object sender, EventArgs e)
        {
            TxtMainCanvas.TextAlign = HorizontalAlignment.Center;
        }

        private void ItmFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
                TxtMainCanvas.Font = fontDialog.Font;
        }

        private void ItmRtlLtr_Click(object sender, EventArgs e)
        {
            if (TxtMainCanvas.RightToLeft == RightToLeft.Yes)
            {
                TxtMainCanvas.RightToLeft = RightToLeft.No;
                ItmRtlLtr.Text = "من اليمين إلى اليسار";
            }
            else
            {
                TxtMainCanvas.RightToLeft = RightToLeft.Yes;
                ItmRtlLtr.Text = "من اليسار إلى اليمين";
            }

        }
                
        private void ItmForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                TxtMainCanvas.ForeColor = colorDialog.Color;
            }

        }
    
    }
}
