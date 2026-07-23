using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace EasyEdit.GUI
{
    public partial class FrmCanvas : Form
    {
        public readonly bool IsValid;
        private bool _IsNewFile;
        private string _FilePath;
        private bool _IsUnsaved = false;
        private bool _IsFileLoaded = false;
        public static readonly string FileDialogsFilter =
                "All Text Files|*.txt;*.log;*.csv;*.xml;*.json;*.yaml;*.yml;*.ini;*.cfg;*.config;*.md;*.rtf;*.html;*.htm;*.css;*.js;*.ts;*.cs;*.c;*.cpp;*.h;*.hpp;*.java;*.py;*.php;*.sql;*.bat;*.cmd;*.ps1;*.sh;*.vb;*.xaml;*.resx;*.csproj;*.sln;*.gitignore;*.editorconfig;*.properties;*.tex|" +
                "All Files (*.*)|*.*|" +
                "Text Files (*.txt)|*.txt|" +
                "Log Files (*.log)|*.log|" +
                "CSV Files (*.csv)|*.csv|" +
                "XML Files (*.xml)|*.xml|" +
                "JSON Files (*.json)|*.json|" +
                "YAML Files (*.yaml;*.yml)|*.yaml;*.yml|" +
                "INI Files (*.ini)|*.ini|" +
                "Configuration Files (*.cfg;*.config)|*.cfg;*.config|" +
                "Markdown Files (*.md)|*.md|" +
                "Rich Text Files (*.rtf)|*.rtf|" +
                "HTML Files (*.html;*.htm)|*.html;*.htm|" +
                "CSS Files (*.css)|*.css|" +
                "JavaScript Files (*.js)|*.js|" +
                "TypeScript Files (*.ts)|*.ts|" +
                "C# Files (*.cs)|*.cs|" +
                "C Files (*.c)|*.c|" +
                "C++ Files (*.cpp)|*.cpp|" +
                "Header Files (*.h;*.hpp)|*.h;*.hpp|" +
                "Java Files (*.java)|*.java|" +
                "Python Files (*.py)|*.py|" +
                "PHP Files (*.php)|*.php|" +
                "SQL Files (*.sql)|*.sql|" +
                "Batch Files (*.bat;*.cmd)|*.bat;*.cmd|" +
                "PowerShell Scripts (*.ps1)|*.ps1|" +
                "Shell Scripts (*.sh)|*.sh|" +
                "Visual Basic Files (*.vb)|*.vb|" +
                "XAML Files (*.xaml)|*.xaml|" +
                "RESX Files (*.resx)|*.resx|" +
                "C# Project Files (*.csproj)|*.csproj|" +
                "Solution Files (*.sln)|*.sln|" +
                "Git Ignore Files (*.gitignore)|*.gitignore|" +
                "EditorConfig Files (*.editorconfig)|*.editorconfig|" +
                "Properties Files (*.properties)|*.properties|" +
                "LaTeX Files (*.tex)|*.tex";

        public bool WordWrap
        {
            set
            {
                TxtMainCanvas.WordWrap = value;
            }

            get
            {
                return TxtMainCanvas.WordWrap;
            }

        }
        public Font TextFont
        {
            set
            {
                if (value != null)
                    TxtMainCanvas.Font = value;
            }

            get
            {
                return TxtMainCanvas.Font;
            }

        }
        public Color FontColor
        {
            set
            {
                TxtMainCanvas.ForeColor = value;
            }

            get
            {
                return TxtMainCanvas.ForeColor;
            }
        }
        public bool IsRTL
        {
            get
            {
                return TxtMainCanvas.RightToLeft == RightToLeft.Yes;
            }
        }

        public static FrmCanvas OpenFile(string FilePath)
        {
            if (File.Exists(FilePath))
                return new FrmCanvas(FilePath);
            else
                return null;
        }

        public static FrmCanvas OpenNewFile()
        {
            return new FrmCanvas(null, true);
        }

        // the file path has no effect when the IsNewFile is true
        private FrmCanvas(string FilePath, bool IsNewFile = false)
        {
            InitializeComponent();
            _IsNewFile = IsNewFile;

            SfdSaveAs.Filter = FileDialogsFilter;
                
            if (!IsNewFile)
            {
                if (File.Exists(FilePath))
                {
                    TxtMainCanvas.Text = File.ReadAllText(FilePath);
                    _FilePath = FilePath;
                    IsValid = true;
                }
                else
                {
                    IsValid = false;
                }
            }
            else
            {
                _FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NewFile_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt");
                _IsUnsaved = true;
                IsValid = true;
            }

            _IsFileLoaded = true;
            UpdateFormTitle();
        }

        private void UpdateFormTitle()
        {
            if (_IsUnsaved)
                this.Text = "*" + Path.GetFileName(_FilePath);
            else
                this.Text = Path.GetFileName(_FilePath);
        }

        private void TxtMainCanvas_TextChanged(object sender, System.EventArgs e)
        {
            if (!_IsFileLoaded) return;

            // TODO needs improvement
            _IsUnsaved = true;
            UpdateFormTitle();
        }
    
        private void Save(string FilePath)
        {
            File.WriteAllText(FilePath, TxtMainCanvas.Text);
            _IsUnsaved = false;
            UpdateFormTitle();
        }

        public void SaveCurrentFile()
        {
            if (_IsNewFile)
            {
                SaveAs();
                return;
            }

            if (!_IsUnsaved) return;

            Save(_FilePath);
        }

        public void SaveAs()
        {
            SfdSaveAs.FileName = Path.GetFileName(_FilePath);
            if (SfdSaveAs.ShowDialog() == DialogResult.OK)
            {
                Save(SfdSaveAs.FileName);

                _IsNewFile = false;
                _FilePath = SfdSaveAs.FileName;
                UpdateFormTitle();
            }
        }

        private void FrmCanvas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_IsUnsaved) return;

            DialogResult SaveMessageBoxResult =
                MessageBox.Show(
                    "توجد بعض التعديلات التي لم يتم حفظها هل تريد حفظ هذه التعديلات؟",
                    Path.GetFileName(_FilePath),
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                    );

            switch (SaveMessageBoxResult)
            {
                case DialogResult.Yes:
                    SaveCurrentFile();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void FrmCanvas_Load(object sender, EventArgs e)
        {
            if (!IsValid)
                this.Close();

            TxtMainCanvas.SelectionStart = TxtMainCanvas.TextLength;
            TxtMainCanvas.SelectionLength = 0;

        }
    
        public void Undo()
        {
            TxtMainCanvas.Undo();
        }

        public void Cut()
        {
            TxtMainCanvas.Cut();
        }

        public void Copy()
        {
            TxtMainCanvas.Copy();
        }

        public void Paste()
        {
            TxtMainCanvas.Paste();
        }

        public void Delete()
        {
            TxtMainCanvas.SelectedText = "";
        }

        public void SelectAll()
        {
            TxtMainCanvas.SelectAll();
        }

        public void AlignTextRigth()
        {
            // note that this is because the left and right direction
            // is not a phisical direction any more because of the
            // RTL Mode, so now Left = Start of Text
            // while Right = End Of Text

            if (IsRTL)
                TxtMainCanvas.TextAlign = HorizontalAlignment.Left;
            else
                TxtMainCanvas.TextAlign = HorizontalAlignment.Right;
        }

        public void AlignTextLeft()
        {
            // note that this is because the left and right direction
            // is not a phisical direction any more because of the
            // RTL Mode, so now Left = Start of Text
            // while Right = End Of Text

            if (IsRTL)
                TxtMainCanvas.TextAlign = HorizontalAlignment.Right;
            else
                TxtMainCanvas.TextAlign = HorizontalAlignment.Left;
        }

        public void AlignTextCenter()
        {
            TxtMainCanvas.TextAlign = HorizontalAlignment.Center;
        }

        public void Toggle_Rtl_LTR()
        {
            if (IsRTL)
                TxtMainCanvas.RightToLeft = RightToLeft.No;
            else
                TxtMainCanvas.RightToLeft = RightToLeft.Yes;
        }

        public bool CanUndo()
        {
            return TxtMainCanvas.CanUndo;
        }

        public bool IsTextSelected()
        {
            return TxtMainCanvas.SelectionLength > 0;
        }

    }
}
