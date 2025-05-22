using System;
using System.Windows.Forms;
using EVFS.OS;

namespace Program
{
    public class Program
    {
        public static void Invoke(EVFSManager manager) {
            Application.EnableVisualStyles();

            new FileConverter.Window(manager).ShowDialog();
        }
    }
}
