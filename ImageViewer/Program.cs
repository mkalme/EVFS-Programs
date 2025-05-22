using System;
using EVFS.OS;
using EncryptedVirtualFileSystem;
using System.Windows.Forms;

namespace Program
{
    public class Program
    {
        [STAThread]
        public static void Invoke(EVFSManager manager, VFile file)
        {
            Application.EnableVisualStyles();

            new ImageViewer.Window(manager, file).ShowDialog();
        }
    }
}
