namespace BüyükUygulamaOopGenerics
{
    partial class Form2
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
            this.girişEkranlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekhaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişEkranlarıToolStripMenuItem,
            this.yemekhaneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişEkranlarıToolStripMenuItem
            // 
            this.girişEkranlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciGirişToolStripMenuItem,
            this.dersleriListeleToolStripMenuItem});
            this.girişEkranlarıToolStripMenuItem.Name = "girişEkranlarıToolStripMenuItem";
            this.girişEkranlarıToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.girişEkranlarıToolStripMenuItem.Text = "Dersler";
            // 
            // öğrenciGirişToolStripMenuItem
            // 
            this.öğrenciGirişToolStripMenuItem.Name = "öğrenciGirişToolStripMenuItem";
            this.öğrenciGirişToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.öğrenciGirişToolStripMenuItem.Text = "Derse Kaydol";
            this.öğrenciGirişToolStripMenuItem.Click += new System.EventHandler(this.öğrenciGirişToolStripMenuItem_Click);
            // 
            // dersleriListeleToolStripMenuItem
            // 
            this.dersleriListeleToolStripMenuItem.Name = "dersleriListeleToolStripMenuItem";
            this.dersleriListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dersleriListeleToolStripMenuItem.Text = "Dersleri Listele";
            this.dersleriListeleToolStripMenuItem.Click += new System.EventHandler(this.dersleriListeleToolStripMenuItem_Click);
            // 
            // yemekhaneToolStripMenuItem
            // 
            this.yemekhaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletAlToolStripMenuItem,
            this.paraYükleToolStripMenuItem});
            this.yemekhaneToolStripMenuItem.Name = "yemekhaneToolStripMenuItem";
            this.yemekhaneToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.yemekhaneToolStripMenuItem.Text = "Yemekhane";
            // 
            // biletAlToolStripMenuItem
            // 
            this.biletAlToolStripMenuItem.Name = "biletAlToolStripMenuItem";
            this.biletAlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.biletAlToolStripMenuItem.Text = "Bilet Al";
            this.biletAlToolStripMenuItem.Click += new System.EventHandler(this.biletAlToolStripMenuItem_Click);
            // 
            // paraYükleToolStripMenuItem
            // 
            this.paraYükleToolStripMenuItem.Name = "paraYükleToolStripMenuItem";
            this.paraYükleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paraYükleToolStripMenuItem.Text = "Para yükle";
            this.paraYükleToolStripMenuItem.Click += new System.EventHandler(this.paraYükleToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişEkranlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekhaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYükleToolStripMenuItem;
    }
}