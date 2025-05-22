using System;
using System.IO;
using System.Windows.Forms;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileConverter {
    public partial class Window : Form {
        private EVFSManager Manager { get; set; }

        public Window(EVFSManager manager)
        {
            InitializeComponent();

            Manager = manager;

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.ShowDialog();

            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(PathTextBox.Text)) return;

            Convert(PathTextBox.Text);
        }

        private void Convert(string path) {
            VDirectory directory = EvfsConverter.ConvertDirectory(PathTextBox.Text);

            Manager.FileSystem.RootDirectory.AppendChild(directory);
            
            Manager.Save();
        }
    }
}
