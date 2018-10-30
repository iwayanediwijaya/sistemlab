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
    public partial class view_pelabuhan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string id_pelabuhanN, nm_pelabuhanN = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_pelabuhanN()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_pelabuhan_oke", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_pelabuhan_oke");
                dtg_view_pelabuhan.DataSource = ds;
                dtg_view_pelabuhan.DataMember = "tblD_pelabuhan_oke";
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

        public view_pelabuhan()
        {
            InitializeComponent();
            txt_cari_pelabuhan.Clear();
            refresh_view_pelabuhanN();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cari_pelabuhan_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_pelabuhan_oke where id_pelabuhan Like '%"
                + txt_cari_pelabuhan.Text + "%' OR kode_pelabuhan Like'%"
                + txt_cari_pelabuhan.Text + "%' OR nama_pelabuhan Like '%" +txt_cari_pelabuhan.Text+ "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_pelabuhan_oke");
            dtg_view_pelabuhan.DataSource = ds;
            dtg_view_pelabuhan.DataMember = "tblD_pelabuhan_oke";
            dtg_view_pelabuhan.Refresh();
            conn.Close();
        }

        private void dtg_view_pelabuhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_pelabuhan.Rows[e.RowIndex];
                id_pelabuhanN= rows.Cells["id_pelabuhan"].Value.ToString();
                nm_pelabuhanN = rows.Cells["nama_pelabuhan"].Value.ToString();
 
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_id_pelabuhan
        {
            get
            {
                return id_pelabuhanN;
            }
        }

        public String ambil_nm_pelabuhan
        {
            get
            {
                return nm_pelabuhanN;
            }
        }
    }
 }

