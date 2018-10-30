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
    public partial class view_opt : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string kd_opt, nm_opt, nm_latin = "";

        kelas.koneksi konn = new kelas.koneksi();

        void refresh_view_opt()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tblD_opt", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tblD_opt");
                dtg_view_opt.DataSource = ds;
                dtg_view_opt.DataMember = "tblD_opt";
                dtg_view_opt.Refresh();
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

        public view_opt()
        {
            InitializeComponent();
            txt_cari_opt.Clear();
            refresh_view_opt();
        }

        private void view_opt_Load(object sender, EventArgs e)
        {

        }

        private void dtg_view_opt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dtg_view_opt.Rows[e.RowIndex];
                kd_opt = rows.Cells["kode_opt"].Value.ToString();
                nm_opt = rows.Cells["nama_umum_opt"].Value.ToString();
                nm_latin = rows.Cells["nama_latin_opt"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }

        public String ambil_kd_opt
        {
            get
            {
                return kd_opt;
            }
        }

        public String ambil_nm_umum_opt
        {
            get
            {
                return nm_opt;
            }
        }

        public String ambil_nm_latin_opt
        {
            get
            {
                return nm_latin;
            }
        }

        private void txt_cari_opt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblD_opt where kode_opt Like '%"
                + txt_cari_opt.Text + "%' OR nama_umum_opt Like'%"
                + txt_cari_opt.Text + "%' OR nama_latin_opt Like '%" + txt_cari_opt.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblD_opt");
            dtg_view_opt.DataSource = ds;
            dtg_view_opt.DataMember = "tblD_opt";
            dtg_view_opt.Refresh();
            conn.Close();
        }
    }
}
