﻿namespace simlab.GUI
{
    partial class view_target_pest
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
            this.txt_cari_pest = new System.Windows.Forms.TextBox();
            this.dtg_view_pest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_pest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cari ";
            // 
            // txt_cari_pest
            // 
            this.txt_cari_pest.Location = new System.Drawing.Point(403, 17);
            this.txt_cari_pest.Name = "txt_cari_pest";
            this.txt_cari_pest.Size = new System.Drawing.Size(146, 20);
            this.txt_cari_pest.TabIndex = 9;
            this.txt_cari_pest.TextChanged += new System.EventHandler(this.txt_cari_pest_TextChanged);
            // 
            // dtg_view_pest
            // 
            this.dtg_view_pest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_view_pest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_pest.Location = new System.Drawing.Point(10, 43);
            this.dtg_view_pest.Name = "dtg_view_pest";
            this.dtg_view_pest.Size = new System.Drawing.Size(539, 298);
            this.dtg_view_pest.TabIndex = 8;
            this.dtg_view_pest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_pest_CellClick);
            // 
            // view_target_pest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cari_pest);
            this.Controls.Add(this.dtg_view_pest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "view_target_pest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "view_target_pest";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_pest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cari_pest;
        private System.Windows.Forms.DataGridView dtg_view_pest;
    }
}