using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Damage_GUI
{
    public partial class Main : MaterialForm
    {
        [DllImport("UnmanagedDMG.dll")]
        public static extern void damage(int damage);

        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue500, Primary.Blue500, Accent.Cyan700, TextShade.WHITE);
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            damage(Convert.ToInt32(numericUpDown1.Value));
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