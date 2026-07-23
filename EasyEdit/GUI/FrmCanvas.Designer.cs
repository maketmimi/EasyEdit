namespace EasyEdit.GUI
{
    partial class FrmCanvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCanvas));
            this.TxtMainCanvas = new System.Windows.Forms.TextBox();
            this.SfdSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // TxtMainCanvas
            // 
            this.TxtMainCanvas.AcceptsTab = true;
            this.TxtMainCanvas.BackColor = System.Drawing.Color.White;
            this.TxtMainCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMainCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMainCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtMainCanvas.ForeColor = System.Drawing.Color.Black;
            this.TxtMainCanvas.Location = new System.Drawing.Point(0, 0);
            this.TxtMainCanvas.MaxLength = 0;
            this.TxtMainCanvas.Multiline = true;
            this.TxtMainCanvas.Name = "TxtMainCanvas";
            this.TxtMainCanvas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtMainCanvas.Size = new System.Drawing.Size(800, 450);
            this.TxtMainCanvas.TabIndex = 1;
            this.TxtMainCanvas.WordWrap = false;
            this.TxtMainCanvas.TextChanged += new System.EventHandler(this.TxtMainCanvas_TextChanged);
            // 
            // SfdSaveAs
            // 
            this.SfdSaveAs.DefaultExt = "txt";
            this.SfdSaveAs.SupportMultiDottedExtensions = true;
            this.SfdSaveAs.Title = "حفظ باسم";
            // 
            // FrmCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtMainCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCanvas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCanvas_FormClosing);
            this.Load += new System.EventHandler(this.FrmCanvas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMainCanvas;
        private System.Windows.Forms.SaveFileDialog SfdSaveAs;
    }
}