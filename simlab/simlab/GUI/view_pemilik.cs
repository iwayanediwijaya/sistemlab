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
    public partial class view_pemilik : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string id_PemilikPenerima, nm_PemilikPenerima, alamat_PemilikPenerima = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_PP()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_pengirim_penerima", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_pengirim_penerima");
                dtg_view_PP.DataSource = ds;
                dtg_view_PP.DataMember = "tblD_pengirim_penerima";
                dtg_view_PP.Refresh();
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

        public view_pemilik()
        {
            InitializeComponent();
            txt_cari_PP.Clear();
            refresh_view_PP();
        }

        private void view_pemilik_Load(object sender, EventArgs e)
        {

        }

        private void txt_cari_PP_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_pengirim_penerima where id_PP Like '%"
                + txt_cari_PP.Text + "%' OR nama_PP Like'%"
                + txt_cari_PP.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_pengirim_penerima");
            dtg_view_PP.DataSource = ds;
            dtg_view_PP.DataMember = "tblD_pengirim_penerima";
            dtg_view_PP.Refresh();
            conn.Close();
        }

        private void dtg_view_PP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_PP.Rows[e.RowIndex];
                id_PemilikPenerima = rows.Cells["id_PP"].Value.ToString();
                nm_PemilikPenerima = rows.Cells["nama_PP"].Value.ToString();
                alamat_PemilikPenerima = rows.Cells["alamat_PP"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_id_PP
        {
            get
            {
                return id_PemilikPenerima;
            }
        }

        public String ambil_nm_PP
        {
            get
            {
                return nm_PemilikPenerima;
            }
        }

        public String ambil_alamat_PP
        {
            get
            {
                return alamat_PemilikPenerima;
            }

        }
    }
}
