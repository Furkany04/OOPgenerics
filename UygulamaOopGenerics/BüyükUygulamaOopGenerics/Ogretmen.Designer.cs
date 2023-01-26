namespace BüyükUygulamaOopGenerics
{
    partial class Ogretmen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKaydetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKaydetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciKaydetToolStripMenuItem
            // 
            this.öğrenciKaydetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKaydetToolStripMenuItem1,
            this.öğrenciListeleToolStripMenuItem});
            this.öğrenciKaydetToolStripMenuItem.Name = "öğrenciKaydetToolStripMenuItem";
            this.öğrenciKaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.öğrenciKaydetToolStripMenuItem.Text = "Öğrenci İşleri";
            // 
            // öğrenciKaydetToolStripMenuItem1
            // 
            this.öğrenciKaydetToolStripMenuItem1.Name = "öğrenciKaydetToolStripMenuItem1";
            this.öğrenciKaydetToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.öğrenciKaydetToolStripMenuItem1.Text = "Öğrenci Kaydet";
            this.öğrenciKaydetToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciKaydetToolStripMenuItem1_Click);
            // 
            // öğrenciListeleToolStripMenuItem
            // 
            this.öğrenciListeleToolStripMenuItem.Name = "öğrenciListeleToolStripMenuItem";
            this.öğrenciListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.öğrenciListeleToolStripMenuItem.Text = "Öğrenci Listele";
            this.öğrenciListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListeleToolStripMenuItem_Click);
            // 
            // Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ogretmen";
            this.Text = "Ogretmen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ogretmen_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKaydetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeleToolStripMenuItem;
    }
}