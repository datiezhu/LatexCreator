using System;
using System.Windows.Forms;

namespace FolderBrowser
{
    public partial class MainForm : Form
    {
        private int _numberOfAssignments = 1;
        private string _mainPath = "";
        private string _preamblePath = "";
        private string _status = "";

        public MainForm()
        {
            InitializeComponent();
            this.KeyPress += MainForm_KeyPress;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Create_Button_Click(sender, e);
            }
        }

        private string GetFolder()
        {
            string path = _mainPath;
            FolderBrowserDialog _FolderDialog = new FolderBrowserDialog
            {
                Description = "Browse folder"
            };
            _FolderDialog.ShowDialog();

            if (_FolderDialog.SelectedPath != "")
            {
                path = _FolderDialog.SelectedPath;
            }

            _FolderDialog.Dispose();
            return path;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            _status = new FileCreator().CreateFiles(_mainPath, _numberOfAssignments, _preamblePath);

            if (_status!= "Files created successfully")
            {
                Status_Lbl.Text = "Error. Check path";
            }
            else
            {
                Status_Lbl.Text = _status;
            }
        }

        private void Browse_Button_Click(object sender, EventArgs e)
        {
            _mainPath = GetFolder();
            PathBox.Text = _mainPath;
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            _mainPath = PathBox.Text;
        }

        private void NumberPicker_ValueChanged(object sender, EventArgs e)
        {
            _numberOfAssignments = Convert.ToInt32(NumberPicker.Value);
        }

        private void Preamble_Click(object sender, EventArgs e)
        {
            _preamblePath = GetPath();
            preambleBox.Text = _preamblePath;
        }

        private string GetPath()
        {
            string path = _preamblePath;
            OpenFileDialog _FileDialog = new OpenFileDialog
            {
                Title = "Browse preamble"
            };
            _FileDialog.ShowDialog();

            if (_FileDialog.FileName != "")
            {
                path = _FileDialog.FileName;
            }

            _FileDialog.Dispose();
            return path;
        }

        private void PreambleBox_TextChanged(object sender, EventArgs e)
        {
            _preamblePath = preambleBox.Text;
        }
    }
}
