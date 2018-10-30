namespace simlab.GUI
{
    partial class view_permohonan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cari_permohonan = new System.Windows.Forms.TextBox();
            this.dtg_view_permohonan = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_permohonan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_cari_permohonan);
            this.groupBox3.Controls.Add(this.dtg_view_permohonan);
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1013, 505);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Permohonan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cari Data";
            // 
            // txt_cari_permohonan
            // 
            this.txt_cari_permohonan.Location = new System.Drawing.Point(815, 21);
            this.txt_cari_permohonan.Name = "txt_cari_permohonan";
            this.txt_cari_permohonan.Size = new System.Drawing.Size(193, 20);
            this.txt_cari_permohonan.TabIndex = 78;
            this.txt_cari_permohonan.Text = " ";
            this.txt_cari_permohonan.TextChanged += new System.EventHandler(this.txt_cari_permohonan_TextChanged);
            // 
            // dtg_view_permohonan
            // 
            this.dtg_view_permohonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_permohonan.Location = new System.Drawing.Point(6, 47);
            this.dtg_view_permohonan.Name = "dtg_view_permohonan";
            this.dtg_view_permohonan.Size = new System.Drawing.Size(1003, 452);
            this.dtg_view_permohonan.TabIndex = 46;
            this.dtg_view_permohonan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_permohonan_CellContentClick);
            // 
            // view_permohonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 514);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "view_permohonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Data Permohonan";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_permohonan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_cari_permohonan;
        private System.Windows.Forms.DataGridView dtg_view_permohonan;
        private System.Windows.Forms.Label label1;
    }
}