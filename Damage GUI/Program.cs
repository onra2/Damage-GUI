using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damage_GUI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\UnmanagedDMG.dll"))
            {
                try
                {
                    File.WriteAllBytes(Environment.CurrentDirectory + "\\UnmanagedDMG.dll", Properties.Resources.UnmanagedDMG);
                }
                catch
                {
                    MessageBox.Show("Error writing resources to disk.");
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
