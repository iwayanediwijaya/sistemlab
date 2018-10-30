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
    public partial class view_permohonan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;

        kelas.koneksi konn = new kelas.koneksi();

        private void refresh_view_permohonan()
        {
            // Bersih();
            //  view_permohonan.Enabled = false;
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM tblF_permohonan order by no_permohonan ASC", conn);
                    ds = new DataSet();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds, "tblF_permohonan");
                    dtg_view_permohonan.DataSource = ds;
                    dtg_view_permohonan.DataMember = "tblF_permohonan";
                    dtg_view_permohonan.Refresh();
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
        }

        public view_permohonan()
        {
            InitializeComponent();
            txt_cari_permohonan.Clear();
            refresh_view_permohonan();
        }
    }
}
