namespace simlab.GUI
{
    partial class Menu_Utama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tabel = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_labTumbuhan = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_permohonan = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_TterimaSampel = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_KajiUlang = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_resPermohonan = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_SuratPengantarUji = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_kartSampel = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_TandaTerimaDist = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_SuratTugas = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_hasilUji = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_sertifikat = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_surahHasilUji = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_tabel,
            this.menu_labTumbuhan,
            this.menu_laporan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_login,
            this.Submenu_logout,
            this.exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(40, 20);
            this.menu_file.Text = "&FILE";
            this.menu_file.Click += new System.EventHandler(this.menu_file_Click);
            // 
            // Submenu_login
            // 
            this.Submenu_login.Image = ((System.Drawing.Image)(resources.GetObject("Submenu_login.Image")));
            this.Submenu_login.Name = "Submenu_login";
            this.Submenu_login.Size = new System.Drawing.Size(152, 22);
            this.Submenu_login.Text = "&LOGIN";
            this.Submenu_login.Click += new System.EventHandler(this.Submenu_login_Click);
            // 
            // Submenu_logout
            // 
            this.Submenu_logout.Name = "Submenu_logout";
            this.Submenu_logout.Size = new System.Drawing.Size(152, 22);
            this.Submenu_logout.Text = "&LOGOUT";
            this.Submenu_logout.Click += new System.EventHandler(this.Submenu_logout_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(152, 22);
            this.exit.Text = "&EXIT";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menu_tabel
            // 
            this.menu_tabel.Name = "menu_tabel";
            this.menu_tabel.Size = new System.Drawing.Size(52, 20);
            this.menu_tabel.Text = "&TABEL";
            this.menu_tabel.Click += new System.EventHandler(this.tabelToolStripMenuItem_Click);
            // 
            // menu_labTumbuhan
            // 
            this.menu_labTumbuhan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_permohonan,
            this.Submenu_TterimaSampel,
            this.Submenu_KajiUlang,
            this.Submenu_resPermohonan,
            this.Submenu_SuratPengantarUji,
            this.Submenu_kartSampel,
            this.Submenu_TandaTerimaDist,
            this.Submenu_SuratTugas,
            this.Submenu_hasilUji,
            this.Submenu_sertifikat,
            this.Submenu_surahHasilUji});
            this.menu_labTumbuhan.Name = "menu_labTumbuhan";
            this.menu_labTumbuhan.Size = new System.Drawing.Size(113, 20);
            this.menu_labTumbuhan.Text = "LAB. TUMBUHAN";
            // 
            // Submenu_permohonan
            // 
            this.Submenu_permohonan.Name = "Submenu_permohonan";
            this.Submenu_permohonan.Size = new System.Drawing.Size(205, 22);
            this.Submenu_permohonan.Text = "Permohonan";
            this.Submenu_permohonan.Click += new System.EventHandler(this.Submenu_permohonan_Click);
            // 
            // Submenu_TterimaSampel
            // 
            this.Submenu_TterimaSampel.Name = "Submenu_TterimaSampel";
            this.Submenu_TterimaSampel.Size = new System.Drawing.Size(205, 22);
            this.Submenu_TterimaSampel.Text = "Tanda Terima Sampel";
            // 
            // Submenu_KajiUlang
            // 
            this.Submenu_KajiUlang.Name = "Submenu_KajiUlang";
            this.Submenu_KajiUlang.Size = new System.Drawing.Size(205, 22);
            this.Submenu_KajiUlang.Text = "Kaji Ulang";
            // 
            // Submenu_resPermohonan
            // 
            this.Submenu_resPermohonan.Name = "Submenu_resPermohonan";
            this.Submenu_resPermohonan.Size = new System.Drawing.Size(205, 22);
            this.Submenu_resPermohonan.Text = "Respon Permohonan";
            // 
            // Submenu_SuratPengantarUji
            // 
            this.Submenu_SuratPengantarUji.Name = "Submenu_SuratPengantarUji";
            this.Submenu_SuratPengantarUji.Size = new System.Drawing.Size(205, 22);
            this.Submenu_SuratPengantarUji.Text = "Surat Pengantar Uji";
            // 
            // Submenu_kartSampel
            // 
            this.Submenu_kartSampel.Name = "Submenu_kartSampel";
            this.Submenu_kartSampel.Size = new System.Drawing.Size(205, 22);
            this.Submenu_kartSampel.Text = "Kartu Sample";
            // 
            // Submenu_TandaTerimaDist
            // 
            this.Submenu_TandaTerimaDist.Name = "Submenu_TandaTerimaDist";
            this.Submenu_TandaTerimaDist.Size = new System.Drawing.Size(205, 22);
            this.Submenu_TandaTerimaDist.Text = "Tanda Terima Distribusi";
            // 
            // Submenu_SuratTugas
            // 
            this.Submenu_SuratTugas.Name = "Submenu_SuratTugas";
            this.Submenu_SuratTugas.Size = new System.Drawing.Size(205, 22);
            this.Submenu_SuratTugas.Text = "Surat Tugas";
            // 
            // Submenu_hasilUji
            // 
            this.Submenu_hasilUji.Name = "Submenu_hasilUji";
            this.Submenu_hasilUji.Size = new System.Drawing.Size(205, 22);
            this.Submenu_hasilUji.Text = "Hasil Pengujian Lab.";
            // 
            // Submenu_sertifikat
            // 
            this.Submenu_sertifikat.Name = "Submenu_sertifikat";
            this.Submenu_sertifikat.Size = new System.Drawing.Size(205, 22);
            this.Submenu_sertifikat.Text = "Sertifikat Hasil Pengujian";
            // 
            // Submenu_surahHasilUji
            // 
            this.Submenu_surahHasilUji.Name = "Submenu_surahHasilUji";
            this.Submenu_surahHasilUji.Size = new System.Drawing.Size(205, 22);
            this.Submenu_surahHasilUji.Text = "Surat Hasil Pengujian";
            // 
            // menu_laporan
            // 
            this.menu_laporan.Name = "menu_laporan";
            this.menu_laporan.Size = new System.Drawing.Size(73, 20);
            this.menu_laporan.Text = "LAPORAN";
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEM LAB. BALAI KARANTINA PERTANIAN KELAS I BANDAR LAMPUNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Utama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menu_file;
        public System.Windows.Forms.ToolStripMenuItem Submenu_login;
        public System.Windows.Forms.ToolStripMenuItem Submenu_logout;
        public System.Windows.Forms.ToolStripMenuItem exit;
        public System.Windows.Forms.ToolStripMenuItem menu_tabel;
        public System.Windows.Forms.ToolStripMenuItem Submenu_permohonan;
        public System.Windows.Forms.ToolStripMenuItem Submenu_TterimaSampel;
        public System.Windows.Forms.ToolStripMenuItem Submenu_KajiUlang;
        public System.Windows.Forms.ToolStripMenuItem Submenu_resPermohonan;
        public System.Windows.Forms.ToolStripMenuItem Submenu_SuratPengantarUji;
        public System.Windows.Forms.ToolStripMenuItem Submenu_kartSampel;
        public System.Windows.Forms.ToolStripMenuItem Submenu_TandaTerimaDist;
        public System.Windows.Forms.ToolStripMenuItem Submenu_SuratTugas;
        public System.Windows.Forms.ToolStripMenuItem Submenu_hasilUji;
        public System.Windows.Forms.ToolStripMenuItem Submenu_sertifikat;
        public System.Windows.Forms.ToolStripMenuItem Submenu_surahHasilUji;
        public System.Windows.Forms.ToolStripMenuItem menu_labTumbuhan;
        public System.Windows.Forms.ToolStripMenuItem menu_laporan;
    }
}