using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Damage_GUI
{
    public partial class Main : MaterialForm
    {
        [DllImport("Kernel32.dll")]
        private static extern IntPtr LoadLibrary(string path);

        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        public static Delegate LoadFunction<T>(string dllPath, string functionName)
        {
            var hModule = LoadLibrary(dllPath);
            var functionAddress = GetProcAddress(hModule, functionName);
            return Marshal.GetDelegateForFunctionPointer(functionAddress, typeof(T));
        }

        private delegate void damage(int damage);
        private static damage changeDamage;

        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue500, Primary.Blue500, Accent.Cyan700, TextShade.WHITE);

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

            changeDamage = (damage)LoadFunction<damage>(Environment.CurrentDirectory + "\\UnmanagedDMG.dll", "damage");
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            changeDamage(Convert.ToInt32(numericUpDown1.Value));
        }

        private void OnraIMG_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.unknowncheats.me/forum/star-wars-battlefront-2-a/368432-onra2s-damage-multiplier.html");
        }

        private void UCLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.unknowncheats.me");
        }
    }
}