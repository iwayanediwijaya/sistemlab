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
    public partial class view_negara_tujuan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string id_ngr_T, nm_ngr_T = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_negara_tujuan()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_master_negara_tujuan", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_master_negara_tujuan");
                dtg_view_negara.DataSource = ds;
                dtg_view_negara.DataMember = "tblD_master_negara_tujuan";
                dtg_view_negara.Refresh();
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

        public view_negara_tujuan()
        {
            InitializeComponent();
            txt_cari_negara.Clear();
            refresh_view_negara_tujuan();
        }

        private void txt_cari_negara_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_master_negara_tujuan where id_negara_tujuan Like '%"
                + txt_cari_negara.Text + "%' OR nama_negara_tujuan Like'%"
                + txt_cari_negara.Text + "%' OR nama_en_negara_tujuan Like '%" + txt_cari_negara.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_master_negara_tujuan");
            dtg_view_negara.DataSource = ds;
            dtg_view_negara.DataMember = "tblD_master_negara_tujuan";
            dtg_view_negara.Refresh();
            conn.Close();
        }

        private void dtg_view_negara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                DataGridViewRow rows = this.dtg_view_negara.Rows[e.RowIndex];
                id_ngr_T = rows.Cells["id_negara_tujuan"].Value.ToString();
                nm_ngr_T = rows.Cells["nama_en_negara_tujuan"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_id_ngr_tujuan
        {
            get
            {
                return id_ngr_T;
            }
        }

        public String ambil_nama_ngr_tujuan
        {
            get
            {
                return nm_ngr_T;
            }
        }
    }
}
