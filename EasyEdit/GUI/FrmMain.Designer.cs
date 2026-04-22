namespace EasyEdit
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MsrTopMenu = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItmReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ItmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmTextAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmAlignTextRight = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmAlignTextLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignTextCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmRtlLtr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ItmFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ItmHowToUse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ItmAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtMainCanvas = new System.Windows.Forms.TextBox();
            this.MsrTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsrTopMenu
            // 
            resources.ApplyResources(this.MsrTopMenu, "MsrTopMenu");
            this.MsrTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuEdit,
            this.MnuFormat,
            this.MnuHelp});
            this.MsrTopMenu.Name = "MsrTopMenu";
            this.MsrTopMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // MnuFile
            // 
            this.MnuFile.BackColor = System.Drawing.Color.White;
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmExit});
            this.MnuFile.Name = "MnuFile";
            resources.ApplyResources(this.MnuFile, "MnuFile");
            // 
            // ItmExit
            // 
            this.ItmExit.BackColor = System.Drawing.Color.White;
            this.ItmExit.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmExit, "ItmExit");
            this.ItmExit.Name = "ItmExit";
            this.ItmExit.Click += new System.EventHandler(this.ItmExit_Click);
            // 
            // MnuEdit
            // 
            this.MnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmUndo,
            this.toolStripSeparator1,
            this.ItmCut,
            this.ItmCopy,
            this.ItmPaste,
            this.ItmDelete,
            this.toolStripSeparator2,
            this.ItmReplace,
            this.toolStripSeparator3,
            this.ItmSelectAll});
            this.MnuEdit.Name = "MnuEdit";
            resources.ApplyResources(this.MnuEdit, "MnuEdit");
            this.MnuEdit.DropDownOpening += new System.EventHandler(this.MnuEdit_DropDownOpening);
            // 
            // ItmUndo
            // 
            this.ItmUndo.BackColor = System.Drawing.Color.White;
            this.ItmUndo.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmUndo, "ItmUndo");
            this.ItmUndo.Name = "ItmUndo";
            this.ItmUndo.Click += new System.EventHandler(this.ItmUndo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ItmCut
            // 
            this.ItmCut.BackColor = System.Drawing.Color.White;
            this.ItmCut.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmCut, "ItmCut");
            this.ItmCut.Name = "ItmCut";
            this.ItmCut.Click += new System.EventHandler(this.ItmCut_Click);
            // 
            // ItmCopy
            // 
            this.ItmCopy.BackColor = System.Drawing.Color.White;
            this.ItmCopy.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmCopy, "ItmCopy");
            this.ItmCopy.Name = "ItmCopy";
            this.ItmCopy.Click += new System.EventHandler(this.ItmCopy_Click);
            // 
            // ItmPaste
            // 
            this.ItmPaste.BackColor = System.Drawing.Color.White;
            this.ItmPaste.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmPaste, "ItmPaste");
            this.ItmPaste.Name = "ItmPaste";
            this.ItmPaste.Click += new System.EventHandler(this.ItmPaste_Click);
            // 
            // ItmDelete
            // 
            this.ItmDelete.BackColor = System.Drawing.Color.White;
            this.ItmDelete.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmDelete, "ItmDelete");
            this.ItmDelete.Name = "ItmDelete";
            this.ItmDelete.Click += new System.EventHandler(this.ItmDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // ItmReplace
            // 
            this.ItmReplace.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ItmReplace, "ItmReplace");
            this.ItmReplace.Name = "ItmReplace";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // ItmSelectAll
            // 
            this.ItmSelectAll.BackColor = System.Drawing.Color.White;
            this.ItmSelectAll.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmSelectAll, "ItmSelectAll");
            this.ItmSelectAll.Name = "ItmSelectAll";
            this.ItmSelectAll.Click += new System.EventHandler(this.ItmSelectAll_Click);
            // 
            // MnuFormat
            // 
            this.MnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmWordWrap,
            this.ItmTextAlignment,
            this.ItmRtlLtr,
            this.toolStripSeparator5,
            this.ItmFont,
            this.ItmForeColor});
            this.MnuFormat.Name = "MnuFormat";
            resources.ApplyResources(this.MnuFormat, "MnuFormat");
            // 
            // ItmWordWrap
            // 
            this.ItmWordWrap.CheckOnClick = true;
            resources.ApplyResources(this.ItmWordWrap, "ItmWordWrap");
            this.ItmWordWrap.Name = "ItmWordWrap";
            this.ItmWordWrap.CheckedChanged += new System.EventHandler(this.ItmWordWrap_CheckedChanged);
            // 
            // ItmTextAlignment
            // 
            this.ItmTextAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmAlignTextRight,
            this.AlignTextCenter,
            this.ItmAlignTextLeft});
            this.ItmTextAlignment.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmTextAlignment, "ItmTextAlignment");
            this.ItmTextAlignment.Name = "ItmTextAlignment";
            // 
            // ItmAlignTextRight
            // 
            this.ItmAlignTextRight.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmAlignTextRight, "ItmAlignTextRight");
            this.ItmAlignTextRight.Name = "ItmAlignTextRight";
            this.ItmAlignTextRight.Click += new System.EventHandler(this.ItmAlignTextRight_Click);
            // 
            // ItmAlignTextLeft
            // 
            this.ItmAlignTextLeft.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmAlignTextLeft, "ItmAlignTextLeft");
            this.ItmAlignTextLeft.Name = "ItmAlignTextLeft";
            this.ItmAlignTextLeft.Click += new System.EventHandler(this.ItmAlignTextLeft_Click);
            // 
            // AlignTextCenter
            // 
            this.AlignTextCenter.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.AlignTextCenter, "AlignTextCenter");
            this.AlignTextCenter.Name = "AlignTextCenter";
            this.AlignTextCenter.Click += new System.EventHandler(this.AlignTextCenter_Click);
            // 
            // ItmRtlLtr
            // 
            resources.ApplyResources(this.ItmRtlLtr, "ItmRtlLtr");
            this.ItmRtlLtr.Name = "ItmRtlLtr";
            this.ItmRtlLtr.Click += new System.EventHandler(this.ItmRtlLtr_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // ItmFont
            // 
            this.ItmFont.BackColor = System.Drawing.Color.White;
            this.ItmFont.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ItmFont, "ItmFont");
            this.ItmFont.Name = "ItmFont";
            this.ItmFont.Click += new System.EventHandler(this.ItmFont_Click);
            // 
            // ItmForeColor
            // 
            resources.ApplyResources(this.ItmForeColor, "ItmForeColor");
            this.ItmForeColor.Name = "ItmForeColor";
            this.ItmForeColor.Click += new System.EventHandler(this.ItmForeColor_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmHowToUse,
            this.toolStripSeparator4,
            this.ItmAboutProgram});
            this.MnuHelp.Name = "MnuHelp";
            resources.ApplyResources(this.MnuHelp, "MnuHelp");
            // 
            // ItmHowToUse
            // 
            resources.ApplyResources(this.ItmHowToUse, "ItmHowToUse");
            this.ItmHowToUse.Name = "ItmHowToUse";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // ItmAboutProgram
            // 
            resources.ApplyResources(this.ItmAboutProgram, "ItmAboutProgram");
            this.ItmAboutProgram.Name = "ItmAboutProgram";
            // 
            // TxtMainCanvas
            // 
            this.TxtMainCanvas.BackColor = System.Drawing.Color.White;
            this.TxtMainCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TxtMainCanvas, "TxtMainCanvas");
            this.TxtMainCanvas.ForeColor = System.Drawing.Color.Black;
            this.TxtMainCanvas.Name = "TxtMainCanvas";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TxtMainCanvas);
            this.Controls.Add(this.MsrTopMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.MsrTopMenu;
            this.Name = "FrmMain";
            this.MsrTopMenu.ResumeLayout(false);
            this.MsrTopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsrTopMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit;
        private System.Windows.Forms.ToolStripMenuItem MnuFormat;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.ToolStripMenuItem ItmExit;
        private System.Windows.Forms.ToolStripMenuItem ItmWordWrap;
        private System.Windows.Forms.ToolStripMenuItem ItmUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ItmCut;
        private System.Windows.Forms.ToolStripMenuItem ItmCopy;
        private System.Windows.Forms.ToolStripMenuItem ItmPaste;
        private System.Windows.Forms.ToolStripMenuItem ItmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ItmReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ItmSelectAll;
        private System.Windows.Forms.ToolStripMenuItem ItmHowToUse;
        private System.Windows.Forms.ToolStripMenuItem ItmAboutProgram;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TextBox TxtMainCanvas;
        private System.Windows.Forms.ToolStripMenuItem ItmTextAlignment;
        private System.Windows.Forms.ToolStripMenuItem ItmAlignTextRight;
        private System.Windows.Forms.ToolStripMenuItem ItmAlignTextLeft;
        private System.Windows.Forms.ToolStripMenuItem AlignTextCenter;
        private System.Windows.Forms.ToolStripMenuItem ItmFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ItmRtlLtr;
        private System.Windows.Forms.ToolStripMenuItem ItmForeColor;
    }
}

