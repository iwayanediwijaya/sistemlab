using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace simlab.GUI
{
    public partial class f_login : Form
    {
        private SqlCommand cmd;
        kelas.koneksi konn = new kelas.koneksi();

        public f_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_userLogin WHERE username = '" + txt_uname.Text + "' AND passwd = '" + txt_passwd.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Berhasil Login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menu_Utama.mdiobj.menu_tabel.Enabled = true;
                Menu_Utama.mdiobj.menu_labTumbuhan.Enabled = true;
                Menu_Utama.mdiobj.Submenu_login.Enabled = false;
                Menu_Utama.mdiobj.Submenu_logout.Enabled = true;
                Menu_Utama.mdiobj.menu_laporan.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Maaf, Username / Password Anda Salah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_uname.Text = "";
                txt_passwd.Text = "";
                txt_uname.Focus();
            }
            conn.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_uname.Text = "";
            txt_passwd.Text = "";
            this.Close();
        }
    }
}
