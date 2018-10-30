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
    public partial class view_provinsi_asal : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string kd_prov_A, nm_prov_A = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_prov_asal()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_master_provinsi_asal", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_master_provinsi_asal");
                dtg_view_provinsi.DataSource = ds;
                dtg_view_provinsi.DataMember = "tblD_master_provinsi_asal";
                dtg_view_provinsi.Refresh();
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

        public view_provinsi_asal()
        {
            InitializeComponent();
            txt_cari_provinsi.Clear();
            refresh_view_prov_asal();
        }

        private void txt_cari_provinsi_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_master_provinsi_asal where kode_provinsi_asal Like '%"
                + txt_cari_provinsi.Text + "%' OR nama_provinsi_asal Like'%"
                + txt_cari_provinsi.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_master_provinsi_asal");
            dtg_view_provinsi.DataSource = ds;
            dtg_view_provinsi.DataMember = "tblD_master_provinsi_asal";
            dtg_view_provinsi.Refresh();
            conn.Close();
        }

        private void dtg_view_provinsi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_provinsi.Rows[e.RowIndex];
                kd_prov_A = rows.Cells["kode_provinsi_asal"].Value.ToString();
                nm_prov_A = rows.Cells["nama_provinsi_asal"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_kd_prov_asal
        {
            get
            {
                return kd_prov_A;
            }
        }

        public String ambil_nm_prov_asal
        {
            get
            {
                return nm_prov_A;
            }
        }
    }
}
