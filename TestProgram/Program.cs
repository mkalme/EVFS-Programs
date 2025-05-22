using System;
using EVFS.OS;
using EncryptedVirtualFileSystem;
using System.Windows.Forms;

namespace Program
{
    public class Program
    {
        public static void Invoke(EVFSManager manager, VFile file)
        {
            Application.EnableVisualStyles();

            new TestProgram.Window(manager, file).ShowDialog();
        }
    }
}
