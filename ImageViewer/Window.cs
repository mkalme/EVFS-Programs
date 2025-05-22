using System;
using System.Drawing;
using System.Windows.Forms;
using EncryptedVirtualFileSystem;
using EVFS.OS;

namespace ImageViewer {
    public partial class Window : Form {
        private EVFSManager Manager { get; set; }
        private VFile File { get; set; }

        private Image _image;
        private Image Image {
            get {
                return _image;
            } set {
                if (value == null) return; 

                _image = value;
                PictureBox.Image = _image.Resize(PictureBox.Size);
            }
        }

        public Window(EVFSManager manager, VFile file)
        {
            InitializeComponent();

            Manager = manager;
            File = file;

            Image = ImageHelper.ImageFromBytes(file.Bytes);
        }

        private void Save() {
            if (Image == null) return;

            File.Bytes = Image.ToBytes();

            Manager.Save();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            Image = Image.FromFile(OpenFileDialog.FileName);
        }

        private void PictureBox_SizeChanged(object sender, EventArgs e)
        {
            Image = _image;
        }
    }
}
