namespace simlab.GUI
{
    partial class view_opt
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
            this.txt_cari_opt = new System.Windows.Forms.TextBox();
            this.dtg_view_opt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_opt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cari ";
            // 
            // txt_cari_opt
            // 
            this.txt_cari_opt.Location = new System.Drawing.Point(403, 19);
            this.txt_cari_opt.Name = "txt_cari_opt";
            this.txt_cari_opt.Size = new System.Drawing.Size(146, 20);
            this.txt_cari_opt.TabIndex = 6;
            this.txt_cari_opt.TextChanged += new System.EventHandler(this.txt_cari_opt_TextChanged);
            // 
            // dtg_view_opt
            // 
            this.dtg_view_opt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_view_opt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_opt.Location = new System.Drawing.Point(10, 45);
            this.dtg_view_opt.Name = "dtg_view_opt";
            this.dtg_view_opt.Size = new System.Drawing.Size(539, 298);
            this.dtg_view_opt.TabIndex = 5;
            this.dtg_view_opt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_opt_CellClick);
            // 
            // view_opt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cari_opt);
            this.Controls.Add(this.dtg_view_opt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "view_opt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Master OPT";
            this.Load += new System.EventHandler(this.view_opt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_opt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cari_opt;
        private System.Windows.Forms.DataGridView dtg_view_opt;
    }
}