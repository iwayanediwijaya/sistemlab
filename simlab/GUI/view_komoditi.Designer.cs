namespace simlab.GUI
{
    partial class view_komoditi
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
            this.dtg_view_komoditas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cari_komoditas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_komoditas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_view_komoditas
            // 
            this.dtg_view_komoditas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_view_komoditas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_komoditas.Location = new System.Drawing.Point(12, 49);
            this.dtg_view_komoditas.Name = "dtg_view_komoditas";
            this.dtg_view_komoditas.Size = new System.Drawing.Size(539, 298);
            this.dtg_view_komoditas.TabIndex = 0;
            this.dtg_view_komoditas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_komoditas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cari ";
            // 
            // txt_cari_komoditas
            // 
            this.txt_cari_komoditas.Location = new System.Drawing.Point(387, 23);
            this.txt_cari_komoditas.Name = "txt_cari_komoditas";
            this.txt_cari_komoditas.Size = new System.Drawing.Size(164, 20);
            this.txt_cari_komoditas.TabIndex = 3;
            this.txt_cari_komoditas.TextChanged += new System.EventHandler(this.txt_cari_komoditas_TextChanged);
            // 
            // view_komoditi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cari_komoditas);
            this.Controls.Add(this.dtg_view_komoditas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "view_komoditi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Master Komoditas";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_komoditas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_view_komoditas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cari_komoditas;
    }
}