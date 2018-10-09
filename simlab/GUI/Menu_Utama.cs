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
    public partial class Menu_Utama : Form
    {
        public static GUI.Menu_Utama mdiobj;

        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Utama_Load(object sender, EventArgs e)
        {
            menu_tabel.Enabled = false;
            menu_labTumbuhan.Enabled = false;
            Submenu_logout.Enabled = false;
            Submenu_login.Enabled = true;
            menu_laporan.Enabled = false;
            mdiobj = this;

            GUI.f_login login = new GUI.f_login();
            login.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Ingin Keluar ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Submenu_login_Click(object sender, EventArgs e)
        {
            GUI.f_login login = new GUI.f_login();
            login.ShowDialog();
        }

        private void menu_file_Click(object sender, EventArgs e)
        {

        }

        private void Submenu_logout_Click(object sender, EventArgs e)
        {
            menu_tabel.Enabled = false;
            menu_labTumbuhan.Enabled = false;
            Submenu_logout.Enabled = false;
            Submenu_login.Enabled = true;
            menu_laporan.Enabled = false;
            mdiobj = this;

            GUI.f_login login = new GUI.f_login();
            login.ShowDialog();
        }

        private void Submenu_permohonan_Click(object sender, EventArgs e)
        {
            GUI.btn_view_permohonan permohonan = new GUI.btn_view_permohonan();
            permohonan.MdiParent = this;
            permohonan.Show();
        }
    }
}
