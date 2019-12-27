namespace Damage_GUI
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.Controls.MaterialLabel materialLabel2;
            MaterialSkin.Controls.MaterialLabel materialLabel3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Damage = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DamageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.About = new System.Windows.Forms.TabPage();
            this.OnraIMG = new System.Windows.Forms.PictureBox();
            this.UCLink = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.Damage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnraIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Damage);
            this.materialTabControl1.Controls.Add(this.About);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 74);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(539, 252);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Damage
            // 
            this.Damage.Controls.Add(materialLabel3);
            this.Damage.Controls.Add(materialLabel2);
            this.Damage.Controls.Add(this.numericUpDown1);
            this.Damage.Controls.Add(this.DamageButton);
            this.Damage.Controls.Add(this.materialLabel1);
            this.Damage.Location = new System.Drawing.Point(4, 22);
            this.Damage.Name = "Damage";
            this.Damage.Padding = new System.Windows.Forms.Padding(3);
            this.Damage.Size = new System.Drawing.Size(531, 226);
            this.Damage.TabIndex = 0;
            this.Damage.Text = "Damage";
            this.Damage.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(236, 94);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // DamageButton
            // 
            this.DamageButton.AutoSize = true;
            this.DamageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DamageButton.Depth = 0;
            this.DamageButton.Icon = null;
            this.DamageButton.Location = new System.Drawing.Point(319, 84);
            this.DamageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Primary = true;
            this.DamageButton.Size = new System.Drawing.Size(71, 36);
            this.DamageButton.TabIndex = 1;
            this.DamageButton.Text = "Modify";
            this.DamageButton.UseVisualStyleBackColor = true;
            this.DamageButton.Click += new System.EventHandler(this.DamageButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(95, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(135, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Damage multiplier:";
            // 
            // About
            // 
            this.About.Controls.Add(this.OnraIMG);
            this.About.Controls.Add(this.UCLink);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(531, 214);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // OnraIMG
            // 
            this.OnraIMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnraIMG.Image = global::Damage_GUI.Properties.Resources.normal_onra2;
            this.OnraIMG.Location = new System.Drawing.Point(177, 40);
            this.OnraIMG.Name = "OnraIMG";
            this.OnraIMG.Size = new System.Drawing.Size(165, 177);
            this.OnraIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OnraIMG.TabIndex = 1;
            this.OnraIMG.TabStop = false;
            this.OnraIMG.Click += new System.EventHandler(this.OnraIMG_Click);
            // 
            // UCLink
            // 
            this.UCLink.AutoSize = true;
            this.UCLink.Depth = 0;
            this.UCLink.Font = new System.Drawing.Font("Roboto", 11F);
            this.UCLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UCLink.Location = new System.Drawing.Point(37, 3);
            this.UCLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.UCLink.Name = "UCLink";
            this.UCLink.Size = new System.Drawing.Size(452, 19);
            this.UCLink.TabIndex = 0;
            this.UCLink.Text = "This tool was created by Onra2 for http://www.unknowncheats.me";
            this.UCLink.Click += new System.EventHandler(this.UCLink_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 52);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(539, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel2.Location = new System.Drawing.Point(6, 182);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(426, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Higher values have a higher chance of making the game crash.";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel3.Location = new System.Drawing.Point(6, 200);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new System.Drawing.Size(302, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "It is recommended to set it around 10 to 15.";
            // 
            // Main
            // 
            this.AcceptButton = this.DamageButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 314);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onra2\'s Damage modifier (SWBF2)";
            this.materialTabControl1.ResumeLayout(false);
            this.Damage.ResumeLayout(false);
            this.Damage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnraIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Damage;
        private System.Windows.Forms.TabPage About;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialRaisedButton DamageButton;
        private MaterialSkin.Controls.MaterialLabel UCLink;
        private System.Windows.Forms.PictureBox OnraIMG;
    }
}

