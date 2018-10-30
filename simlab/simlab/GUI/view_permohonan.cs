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
        public string no_perm, tgl_perm, jenis_keg, nama_pem, alamat_pem, jenis_med1, jenis_med2, kode_kom, nama_umum_kom, nama_latin_kom, kode_op, nama_umum_op, nama_latin_op, jumlah_semp, satuan, per_bngkus, jenis_smpl1, jenis_smpl2, jenis_smpl3, jenis_smpl4, jenis_smpl5, jenis_smpl6, jenis_smpl7, jenis_smpl_all, media_pemb, jenis_smpl_opt, id_ngr_asl, nama_negara_asal, id_ngr_tjn, nama_negara_tjn, kode_prov_asl, nama_prov_asal, kode_prov_tjn, nama_prov_tjn, id_plbhn_asl, nama_plbhn_asl, id_plbhn_tjn, nama_plbhn_tjn, target_uj1, target_uj2, target_uj3, target_uj4, target_uj5, target_uj6, target_uj7, target_pet, metode_per1, metode_per2, metode_per3, metode_per4, metode_per5, id_pemilik, dokumen_pend = "";


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

        private void txt_cari_permohonan_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tblF_permohonan where no_permohonan Like '%"
                + txt_cari_permohonan.Text + "%' OR tgl_permohonan Like'%"
                + txt_cari_permohonan.Text + "%' OR nama_pemohon Like'%"
                + txt_cari_permohonan.Text + "%' OR jenis_kegiatan Like'%"
                + txt_cari_permohonan.Text + "%'", conn);

            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "tblF_permohonan");
            dtg_view_permohonan.DataSource = ds;
            dtg_view_permohonan.DataMember = "tblF_permohonan";
            dtg_view_permohonan.Refresh();
            conn.Close();
        }

        private void dtg_view_permohonan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              try
            {
                DataGridViewRow rows = this.dtg_view_permohonan.Rows[e.RowIndex];
                no_perm = rows.Cells["no_permohonan"].Value.ToString();
                tgl_perm = rows.Cells["tgl_permohonan"].Value.ToString();
                jenis_keg = rows.Cells["jenis_kegiatan"].Value.ToString();
                nama_pem = rows.Cells["nama_pemohon"].Value.ToString();
                alamat_pem = rows.Cells["alamat_pemohon"].Value.ToString();
                jenis_med1 = rows.Cells["jenis_media1"].Value.ToString();
                jenis_med2 = rows.Cells["jenis_media2"].Value.ToString();
                kode_kom = rows.Cells["kode_komoditi"].Value.ToString();
                nama_umum_kom = rows.Cells["nama_umum_komoditi"].Value.ToString();
                nama_latin_kom = rows.Cells["nama_latin_komoditi"].Value.ToString();
                kode_op = rows.Cells["kode_opt"].Value.ToString();
                nama_umum_op = rows.Cells["nama_umum_opt"].Value.ToString();
                nama_latin_op = rows.Cells["nama_latin_opt"].Value.ToString();
                jumlah_semp = rows.Cells["jumlah_sampel"].Value.ToString();
                satuan = rows.Cells["satuan"].Value.ToString();
                per_bngkus = rows.Cells["per_bungkus"].Value.ToString();
                jenis_smpl1 = rows.Cells["jenis_sampel_1"].Value.ToString();
                jenis_smpl2 = rows.Cells["jenis_sampel_2"].Value.ToString();
                jenis_smpl3 = rows.Cells["jenis_sampel_3"].Value.ToString();
                jenis_smpl4 = rows.Cells["jenis_sampel_4"].Value.ToString();
                jenis_smpl5 = rows.Cells["jenis_sampel_5"].Value.ToString();
                jenis_smpl6 = rows.Cells["jenis_sampel_6"].Value.ToString();
                jenis_smpl7 = rows.Cells["jenis_sampel_7"].Value.ToString();
                jenis_smpl_all = rows.Cells["jenis_sampel_all"].Value.ToString();
                media_pemb = rows.Cells["media_pembawa"].Value.ToString();
                jenis_smpl_opt = rows.Cells["jenis_sampel_opt"].Value.ToString();
                id_ngr_asl = rows.Cells["id_negara_asal"].Value.ToString();
                nama_negara_tjn = rows.Cells["nama_en_negara_asal"].Value.ToString();
                id_ngr_tjn = rows.Cells["id_negara_tujuan"].Value.ToString();
                nama_negara_tjn = rows.Cells["nama_en_negara_asal"].Value.ToString();
                kode_prov_asl = rows.Cells["kode_provinsi_asal"].Value.ToString();
                nama_prov_asal = rows.Cells["nama_provinsi_asal"].Value.ToString();
                kode_prov_tjn = rows.Cells["kode_provinsi_tujuan"].Value.ToString();
                nama_prov_tjn = rows.Cells["nama_provinsi_asal"].Value.ToString();
                id_plbhn_asl = rows.Cells["id_pelabuhan_asal"].Value.ToString();
                nama_plbhn_asl = rows.Cells["nama_pelabuhan_asal"].Value.ToString();
                id_plbhn_tjn = rows.Cells["id_pelabuhan_tujuan"].Value.ToString();
                nama_plbhn_tjn = rows.Cells["nama_pelabuhan_asal"].Value.ToString();
                target_uj1 = rows.Cells["target_uji1"].Value.ToString();
                target_uj2 = rows.Cells["target_uji2"].Value.ToString();
                target_uj3 = rows.Cells["target_uji3"].Value.ToString();
                target_uj4 = rows.Cells["target_uji4"].Value.ToString();
                target_uj5 = rows.Cells["target_uji5"].Value.ToString();
                target_uj6 = rows.Cells["target_uji6"].Value.ToString();
                target_uj7 = rows.Cells["target_uji7"].Value.ToString();
                target_pet = rows.Cells["kode_targetpest"].Value.ToString();
                metode_per1 = rows.Cells["metode_periksa1"].Value.ToString();
                metode_per2 = rows.Cells["metode_periksa2"].Value.ToString();
                metode_per3 = rows.Cells["metode_periksa3"].Value.ToString();
                metode_per4 = rows.Cells["metode_periksa4"].Value.ToString();
                metode_per5 = rows.Cells["metode_periksa5"].Value.ToString();
                id_pemilik = rows.Cells["id_pp"].Value.ToString();
                dokumen_pend = rows.Cells["dok_pendukung"].Value.ToString();
                this.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.ToString());
            }
        }



        public String ambil_no_permohonan
        {
            get
            {
                return no_perm;
            }
        }

        public String ambil_tgl_permohonan
        {
            get
            {
                return tgl_perm;
            }
        }

        public String ambil_jenis_kegiatan
        {
            get
            {
                return jenis_keg;
            }
        }

        public String ambil_nama_pemohon
        {
            get
            {
                return nama_pem;
            }
        }

        public String ambil_alamat_pemohon
        {
            get
            {
                return alamat_pem;
            }
        }

        public String ambil_jenis_media1
        {
            get
            {
                return jenis_med1;
            }
        }

        public String ambil_jenis_media2
        {
            get
            {
                return jenis_med2;
            }
        }

        public String ambil_kode_komoditi
        {
            get
            {
                return kode_kom;
            }
        }

        public String ambil_nama_umum_komoditi
        {
            get
            {
                return nama_umum_kom;
            }
        }

        public String ambil_nama_latin_komoditi
        {
            get
            {
                return nama_latin_kom;
            }
        }

        public String ambil_kode_opt
        {
            get
            {
                return kode_op;
            }
        }

        public String ambil_nama_umum_opt
        {
            get
            {
                return nama_umum_op;
            }
        }

        public String ambil_nama_latin_opt
        {
            get
            {
                return nama_latin_op;
            }
        }

        public String ambil_jumlah_sampel
        {
            get
            {
                return jumlah_semp;
            }
        }

        public String ambil_satuan
        {
            get
            {
                return satuan;
            }
        }

        public String ambil_per_bungkus
        {
            get
            {
                return per_bngkus;
            }
        }

        public String ambil_jenis_sampel1
        {
            get
            {
                return jenis_smpl1;
            }
        }

        public String ambil_jenis_sampel2
        {
            get
            {
                return jenis_smpl2;
            }
        }

        public String ambil_jenis_sampel3
        {
            get
            {
                return jenis_smpl3;
            }
        }

        public String ambil_jenis_sampel4
        {
            get
            {
                return jenis_smpl4;
            }
        }

        public String ambil_jenis_sampel5
        {
            get
            {
                return jenis_smpl5;
            }
        }

        public String ambil_jenis_sampel6
        {
            get
            {
                return jenis_smpl6;
            }
        }

        public String ambil_jenis_sampel7
        {
            get
            {
                return jenis_smpl7;
            }
        }

        public String ambil_jenis_sampel_all
        {
            get
            {
                return jenis_smpl_all;
            }
        }

        public String ambil_media_pembawa
        {
            get
            {
                return media_pemb;
            }
        }

        public String ambil_jenis_sampel_opt
        {
            get
            {
                return jenis_smpl_opt;
            }
        }

        public String ambil_id_negara_asal
        {
            get
            {
                return id_ngr_asl;
            }
        }

        public String ambil_nama_negara_asal
        {
            get
            {
                return nama_negara_asal;
            }
        }

        public String ambil_id_negara_tujuan
        {
            get
            {
                return id_ngr_tjn;
            }
        }

        public String ambil_nama_negara_tujuan
        {
            get
            {
                return nama_negara_tjn;
            }
        }

        public String ambil_kode_provinsi_asal
        {
            get
            {
                return kode_prov_asl;
            }
        }

        public String ambil_nama_provinsi_asal
        {
            get
            {
                return nama_prov_asal;
            }
        }

        public String ambil_kode_provinsi_tujuan
        {
            get
            {
                return kode_prov_tjn;
            }
        }

        public String ambil_nama_provinsi_tujuan
        {
            get
            {
                return nama_prov_tjn;
            }
        }

        public String ambil_id_pelabuhan_asal
        {
            get
            {
                return id_plbhn_asl;
            }
        }

        public String ambil_nama_pelabuhan_asal
        {
            get
            {
                return nama_plbhn_asl;
            }
        }

        public String ambil_id_pelabuhan_tujuan
        {
            get
            {
                return id_plbhn_tjn;
            }
        }

        public String ambil_nama_pelabuhan_tujuan
        {
            get
            {
                return nama_plbhn_tjn;
            }
        }

        public String ambil_target_uji1
        {
            get
            {
                return target_uj1;
            }
        }

        public String ambil_target_uji2
        {
            get
            {
                return target_uj2;
            }
        }

        public String ambil_target_uji3
        {
            get
            {
                return target_uj3;
            }
        }

        public String ambil_target_uji4
        {
            get
            {
                return target_uj4;
            }
        }

        public String ambil_target_uji5
        {
            get
            {
                return target_uj5;
            }
        }

        public String ambil_target_uji6
        {
            get
            {
                return target_uj6;
            }
        }

        public String ambil_target_uji7
        {
            get
            {
                return target_uj7;
            }
        }

        public String ambil_target_pest
        {
            get
            {
                return target_pet;
            }
        }

        public String ambil_metode_periksa1
        {
            get
            {
                return metode_per1;
            }
        }

        public String ambil_metode_periksa2
        {
            get
            {
                return metode_per2;
            }
        }

        public String ambil_metode_periksa3
        {
            get
            {
                return metode_per3;
            }
        }

        public String ambil_metode_periksa4
        {
            get
            {
                return metode_per4;
            }
        }

        public String ambil_metode_periksa5
        {
            get
            {
                return metode_per5;
            }
        }

        public String ambil_id_pp
        {
            get
            {
                return id_pemilik;
            }
        }

        public String ambil_dok_pendukung
        {
            get
            {
                return dokumen_pend;
            }
        
        }
    }
}
