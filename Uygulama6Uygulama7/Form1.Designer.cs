namespace Uygulama6Uygulama7
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Anamenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuyeni = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuYazdır = new System.Windows.Forms.ToolStripMenuItem();
            this.Anaduzen = new System.Windows.Forms.ToolStripMenuItem();
            this.DuzenKes = new System.Windows.Forms.ToolStripMenuItem();
            this.DuzenKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.DuzenYapıstır = new System.Windows.Forms.ToolStripMenuItem();
            this.Anacıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıstırToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Anamenu,
            this.Anaduzen,
            this.Anacıkıs});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // Anamenu
            // 
            this.Anamenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menuyeni,
            this.MenuAc,
            this.MenuKaydet,
            this.MenuYazdır});
            this.Anamenu.Name = "Anamenu";
            this.Anamenu.Size = new System.Drawing.Size(50, 20);
            this.Anamenu.Text = "Menu";
            // 
            // Menuyeni
            // 
            this.Menuyeni.Name = "Menuyeni";
            this.Menuyeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Menuyeni.Size = new System.Drawing.Size(180, 22);
            this.Menuyeni.Text = "Yeni";
            // 
            // MenuAc
            // 
            this.MenuAc.Name = "MenuAc";
            this.MenuAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuAc.Size = new System.Drawing.Size(180, 22);
            this.MenuAc.Text = "Aç";
            this.MenuAc.Click += new System.EventHandler(this.MenuAc_Click);
            // 
            // MenuKaydet
            // 
            this.MenuKaydet.Name = "MenuKaydet";
            this.MenuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuKaydet.Size = new System.Drawing.Size(180, 22);
            this.MenuKaydet.Text = "Kaydet";
            this.MenuKaydet.Click += new System.EventHandler(this.MenuKaydet_Click);
            // 
            // MenuYazdır
            // 
            this.MenuYazdır.Name = "MenuYazdır";
            this.MenuYazdır.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuYazdır.Size = new System.Drawing.Size(180, 22);
            this.MenuYazdır.Text = "Yazdır";
            this.MenuYazdır.Click += new System.EventHandler(this.MenuYazdır_Click);
            // 
            // Anaduzen
            // 
            this.Anaduzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuzenKes,
            this.DuzenKopyala,
            this.DuzenYapıstır});
            this.Anaduzen.Name = "Anaduzen";
            this.Anaduzen.Size = new System.Drawing.Size(52, 20);
            this.Anaduzen.Text = "Duzen";
            // 
            // DuzenKes
            // 
            this.DuzenKes.Enabled = false;
            this.DuzenKes.Name = "DuzenKes";
            this.DuzenKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.DuzenKes.Size = new System.Drawing.Size(180, 22);
            this.DuzenKes.Text = "Kes";
            this.DuzenKes.Click += new System.EventHandler(this.DuzenKes_Click);
            // 
            // DuzenKopyala
            // 
            this.DuzenKopyala.Enabled = false;
            this.DuzenKopyala.Name = "DuzenKopyala";
            this.DuzenKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.DuzenKopyala.Size = new System.Drawing.Size(180, 22);
            this.DuzenKopyala.Text = "Kopyala";
            this.DuzenKopyala.Click += new System.EventHandler(this.DuzenKopyala_Click);
            // 
            // DuzenYapıstır
            // 
            this.DuzenYapıstır.Enabled = false;
            this.DuzenYapıstır.Name = "DuzenYapıstır";
            this.DuzenYapıstır.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.DuzenYapıstır.Size = new System.Drawing.Size(180, 22);
            this.DuzenYapıstır.Text = "Yapıstır";
            this.DuzenYapıstır.Click += new System.EventHandler(this.DuzenYapıstır_Click);
            // 
            // Anacıkıs
            // 
            this.Anacıkıs.Name = "Anacıkıs";
            this.Anacıkıs.Size = new System.Drawing.Size(44, 20);
            this.Anacıkıs.Text = "Cıkıs";
            this.Anacıkıs.Click += new System.EventHandler(this.Anacıkıs_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.contextMenuStrip1;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 24);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(800, 426);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem2,
            this.yapıstırToolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 70);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.kesToolStripMenuItem1.Text = "kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem2
            // 
            this.kopyalaToolStripMenuItem2.Name = "kopyalaToolStripMenuItem2";
            this.kopyalaToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.kopyalaToolStripMenuItem2.Text = "kopyala ";
            this.kopyalaToolStripMenuItem2.Click += new System.EventHandler(this.kopyalaToolStripMenuItem2_Click);
            // 
            // yapıstırToolStripMenuItem3
            // 
            this.yapıstırToolStripMenuItem3.Name = "yapıstırToolStripMenuItem3";
            this.yapıstırToolStripMenuItem3.Size = new System.Drawing.Size(118, 22);
            this.yapıstırToolStripMenuItem3.Text = "yapıstır";
            this.yapıstırToolStripMenuItem3.Click += new System.EventHandler(this.yapıstırToolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Anamenu;
        private System.Windows.Forms.ToolStripMenuItem Anaduzen;
        private System.Windows.Forms.ToolStripMenuItem Anacıkıs;
        private System.Windows.Forms.ToolStripMenuItem Menuyeni;
        private System.Windows.Forms.ToolStripMenuItem MenuAc;
        private System.Windows.Forms.ToolStripMenuItem MenuKaydet;
        private System.Windows.Forms.ToolStripMenuItem MenuYazdır;
        private System.Windows.Forms.ToolStripMenuItem DuzenKes;
        private System.Windows.Forms.ToolStripMenuItem DuzenKopyala;
        private System.Windows.Forms.ToolStripMenuItem DuzenYapıstır;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem yapıstırToolStripMenuItem3;
        private System.Drawing.Printing.PrintDocument belge;
    }
}

