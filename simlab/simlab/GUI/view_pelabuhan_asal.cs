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
    public partial class view_pelabuhan_asal : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string id_pelabuhan_A, nm_pelabuhan_A = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_pelabuhan_A()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_pelabuhan_asal", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_pelabuhan_asal");
                dtg_view_pelabuhan.DataSource = ds;
                dtg_view_pelabuhan.DataMember = "tblD_pelabuhan_asal";
                dtg_view_pelabuhan.Refresh();
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

        public view_pelabuhan_asal()
        {
            InitializeComponent();
            txt_cari_pelabuhan.Clear();
            refresh_view_pelabuhan_A();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cari_pelabuhan_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_pelabuhan_asal where id_pelabuhan_asal Like '%"
                + txt_cari_pelabuhan.Text + "%' OR kode_pelabuhan_asal Like'%"
                + txt_cari_pelabuhan.Text + "%' OR nama_pelabuhan_asal Like '%" +txt_cari_pelabuhan.Text+ "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_pelabuhan_asal");
            dtg_view_pelabuhan.DataSource = ds;
            dtg_view_pelabuhan.DataMember = "tblD_pelabuhan_asal";
            dtg_view_pelabuhan.Refresh();
            conn.Close();
        }

        private void dtg_view_pelabuhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_pelabuhan.Rows[e.RowIndex];
                id_pelabuhan_A= rows.Cells["id_pelabuhan_asal"].Value.ToString();
                nm_pelabuhan_A = rows.Cells["nama_pelabuhan_asal"].Value.ToString();
 
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_id_pelabuhan_asal
        {
            get
            {
                return id_pelabuhan_A;
            }
        }

        public String ambil_nm_pelabuhan_asal
        {
            get
            {
                return nm_pelabuhan_A;
            }
        }
    }
 }

