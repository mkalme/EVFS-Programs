using System;
using System.Text;
using System.Windows.Forms;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace TestProgram {
    public partial class Window : Form {
        private EVFSManager Manager { get; set; }
        private VFile File { get; set; }

        public Window(EVFSManager manager, VFile file)
        {
            InitializeComponent();

            Manager = manager;
            File = file;

            Display();
        }

        private void Display() {
            RichTextBox.Text = Encoding.UTF8.GetString(File.Bytes);
        }
        private void Save() {
            File.Bytes = Encoding.UTF8.GetBytes(RichTextBox.Text);

            Manager.Save();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
