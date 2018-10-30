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
    public partial class view_komoditi : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string kd_komoditi, nama_komoditi, nama_IL_komoditi = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_komoditi()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_komoditi", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_komoditi");
                dtg_view_komoditas.DataSource = ds;
                dtg_view_komoditas.DataMember = "tblD_komoditi";
                dtg_view_komoditas.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public view_komoditi()
        {
            InitializeComponent();
            txt_cari_komoditas.Clear();
            refresh_view_komoditi();
        }


        private void dtg_view_komoditas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_komoditas.Rows[e.RowIndex];
                kd_komoditi = rows.Cells["kode_komoditi"].Value.ToString();
                nama_komoditi = rows.Cells["nama_umum_komoditi"].Value.ToString();
                nama_IL_komoditi = rows.Cells["nama_latin_komoditi"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }

        }

        public String ambil_kode_komoditi
        {
            get
            {
                return kd_komoditi;
            }
        }

        public String ambil_nama_komoditi
        {
            get
            {
                return nama_komoditi;
            }
        }

        public String ambil_IL_komoditi
        {
            get
            {

                return nama_IL_komoditi;
            }
        }

        private void txt_cari_komoditas_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_komoditi where kode_komoditi Like '%"
                +txt_cari_komoditas.Text + "%' OR nama_umum_komoditi Like'%" 
                + txt_cari_komoditas.Text + "%' OR nama_latin_komoditi Like '%" + txt_cari_komoditas.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_komoditi");
            dtg_view_komoditas.DataSource = ds;
            dtg_view_komoditas.DataMember = "tblD_komoditi";
            dtg_view_komoditas.Refresh();
            conn.Close();
        }
    }
}
