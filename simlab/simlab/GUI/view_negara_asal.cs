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
    public partial class view_negara_asal : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string id_ngr_A, nm_ngr_A = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_negara_asal()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_master_negara_asal", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_master_negara_asal");
                dtg_view_negara.DataSource = ds;
                dtg_view_negara.DataMember = "tblD_master_negara_asal";
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

        public view_negara_asal()
        {
            InitializeComponent();
            txt_cari_negara.Clear();
            refresh_view_negara_asal();
        }

        private void txt_cari_negara_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_master_negara_asal where id_negara_asal Like '%"
                + txt_cari_negara.Text + "%' OR nama_negara_asal Like'%"
                + txt_cari_negara.Text + "%' OR nama_en_negara_asal Like '%" + txt_cari_negara.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_master_negara_asal");
            dtg_view_negara.DataSource = ds;
            dtg_view_negara.DataMember = "tblD_master_negara_asal";
            dtg_view_negara.Refresh();
            conn.Close();
        }

        private void dtg_view_negara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_negara.Rows[e.RowIndex];
                id_ngr_A = rows.Cells["id_negara_asal"].Value.ToString();
                nm_ngr_A = rows.Cells["nama_en_negara_asal"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_id_ngr_asal
        {
            get
            {
                return id_ngr_A;
            }
        }

        public String ambil_nama_ngr_asal
        {
            get
            {
                return nm_ngr_A;
            }
        }
    }
}
