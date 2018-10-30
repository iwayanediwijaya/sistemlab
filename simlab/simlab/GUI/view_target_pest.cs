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
    public partial class view_target_pest : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string kd_Tpest, nm_latin_Tpest = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_Tpest()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_targetpest", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_targetpest");
                dtg_view_pest.DataSource = ds;
                dtg_view_pest.DataMember = "tblD_targetpest";
                dtg_view_pest.Refresh();
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

        public view_target_pest()
        {
            InitializeComponent();
            txt_cari_pest.Clear();
            refresh_view_Tpest();
        }

        private void dtg_view_pest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_pest.Rows[e.RowIndex];
                kd_Tpest = rows.Cells["kode_targetpest"].Value.ToString();
                nm_latin_Tpest = rows.Cells["nama_latin_targetpest"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_kd_Tpest
        {
            get
            {
                return kd_Tpest;
            }
        }

        public String ambil_nm_latin_Tpest
        {
            get
            {
                return nm_latin_Tpest;
            }
        }

        private void txt_cari_pest_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_targetpest where kode_targetpest Like '%"
                + txt_cari_pest.Text + "%' OR nama_targetpest Like'%"
                + txt_cari_pest.Text + "%' OR nama_latin_targetpest Like '%" + txt_cari_pest.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_targetpest");
            dtg_view_pest.DataSource = ds;
            dtg_view_pest.DataMember = "tblD_targetpest";
            dtg_view_pest.Refresh();
            conn.Close();
        }
    }
}
