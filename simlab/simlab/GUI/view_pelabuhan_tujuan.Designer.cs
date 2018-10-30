namespace simlab.GUI
{
    partial class view_pelabuhan_tujuan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cari_pelabuhan = new System.Windows.Forms.TextBox();
            this.dtg_view_pelabuhan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_pelabuhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cari ";
            // 
            // txt_cari_pelabuhan
            // 
            this.txt_cari_pelabuhan.Location = new System.Drawing.Point(403, 17);
            this.txt_cari_pelabuhan.Name = "txt_cari_pelabuhan";
            this.txt_cari_pelabuhan.Size = new System.Drawing.Size(146, 20);
            this.txt_cari_pelabuhan.TabIndex = 18;
            this.txt_cari_pelabuhan.TextChanged += new System.EventHandler(this.txt_cari_pelabuhan_TextChanged);
            // 
            // dtg_view_pelabuhan
            // 
            this.dtg_view_pelabuhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_view_pelabuhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_pelabuhan.Location = new System.Drawing.Point(10, 43);
            this.dtg_view_pelabuhan.Name = "dtg_view_pelabuhan";
            this.dtg_view_pelabuhan.Size = new System.Drawing.Size(539, 298);
            this.dtg_view_pelabuhan.TabIndex = 17;
            this.dtg_view_pelabuhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_pelabuhan_CellClick);
            // 
            // view_pelabuhan_tujuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cari_pelabuhan);
            this.Controls.Add(this.dtg_view_pelabuhan);
            this.Name = "view_pelabuhan_tujuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "view pelabuhan";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_pelabuhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cari_pelabuhan;
        private System.Windows.Forms.DataGridView dtg_view_pelabuhan;
    }
}