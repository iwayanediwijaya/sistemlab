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
    public partial class f_tandaterima_sampel : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        private SqlDataReader sdr;

        kelas.koneksi konn = new kelas.koneksi();

        public f_tandaterima_sampel()
        {
            InitializeComponent();
        }

        private void Bersih()
        {
           // txt_no_t_terima_sampel.Text = "";
            dtp_tanggal_terima_sampel.Value = DateTime.Now;
            txt_noPermohonan.Text = "";
            dtp_tanggal_permohonan.Value = DateTime.Now;
            txt_nm_pemilik.Text = "";
            txt_alamat_pemilik.Text = "";
            txt_nm_komoditi.Text = "";
            txt_nm_opt.Text = "";

            cb_js_akar.Checked = false;
            cb_js_batang.Checked = false;
            cb_js_daun.Checked = false;
            cb_js_biji.Checked = false;
            cb_js_umbi.Checked = false;
            cb_js_buah.Checked = false;
            cb_js_lain.Checked = false;
            cb_js_all.Checked = false;

            txt_jml_sampel.Text = "";
            cmb_satuan.Text = "--Pilih Satuan--";
            txt_perbks.Text = "0";

            cb_tp_serangga.Checked = false;
            cb_tp_virus.Checked = false;
            cb_tp_cendawan.Checked = false;
            cb_tp_biotek.Checked = false;
            cb_tp_bakteri.Checked = false;
            cb_tp_nematoda.Checked = false;
            cb_tp_gulma.Checked = false;

            cb_mp_agar.Checked = false;
            cb_mp_blotter.Checked = false;
            cb_mp_elisa.Checked = false;
            cb_mp_pcr.Checked = false;
            cb_mp_pLangsung.Checked = false;

            cmb_cr_kirim_sampel.Text = "--Pilih Cara Kirim--";
            txt_nm_pemohon.Text = "";
            cmb_jasa_kirim.Text = "--Pilih Jasa Kirim--";
            txt_nip_petugas.Text = "";
            txt_nm_petugas.Text = "";

        }

       // private void otomatis()
       // {
         //   long hitung;
         // string urut;
          //  SqlConnection conn = konn.GetConn();

//            cmd = new SqlCommand("SELECT isnull (MAX(CAST(no_tanda_t_sampel) FROM tblF_tanda_t_sampel) FROM tblF_tanda_t_sampel", conn);
  //          sdr = cmd.ExecuteReader();
    //        sdr.Read();
        
        //    if (sdr.HasRows)
         //   {
           //     hitung = Convert.ToInt64(sdr[0].ToString().Substring(sdr["no_tanda_t_sampel"].ToString().Length - 4, 4)) + 1;

//                string joinstr = "0000" + hitung;
        
        //        urut = "TTS" + joinstr.Substring(joinstr.Length - 4, 4);
        //    }
          //  else
          //  {
            //    urut = "TTS0001";
           // }
          //  sdr.Close();
          //  txt_no_t_terima_sampel.Text = urut;
          //  conn.Close();
            
       // }

        private void f_tandaterima_sampel_Load(object sender, EventArgs e)
        {
            dtp_tanggal_terima_sampel.Value = DateTime.Now;
            dtp_tanggal_permohonan.Value = DateTime.Now;
            cmb_satuan.Text = "--Pilih Satuan--";
            txt_perbks.Text = "0";
            cmb_cr_kirim_sampel.Text = "--Pilih Cara Kirim--";
            cmb_jasa_kirim.Text = "--Pilih Jasa Kirim--";

        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            GUI.view_permohonan v_permohonan = new GUI.view_permohonan();
            v_permohonan.ShowDialog();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            SqlConnection conn =  konn.GetConn();
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO tblF_tanda_t_sampel(tanggal_terima_sampel, no_permohonan, tanggal_permohonan, nama_pemilik, alamat_pemilik, nama_komoditi, nama_opt, jenis_sampel_1, jenis_sampel_2, jenis_sampel_3, jenis_sampel_4, jenis_sampel_5, jenis_sampel_6, jenis_sampel_7, jenis_sampel_All, jumlah_sampel, satuan, per_bungkus, target_uji1, target_uji2, target_uji3, target_uji4, target_uji5, target_uji6, target_uji7, metode_periksa1, metode_periksa2, metode_periksa3, metode_periksa4, metode_periksa5, cara_krm_sampel, nama_pemohon, jasa_pengiriman, nip) VALUES (@tanggal_terima_sampel, @no_permohonan, @tanggal_permohonan, @nama_pemilik, @alamat_pemilik, @nama_komoditi, @nama_opt, @jenis_sampel_1, @jenis_sampel_2, @jenis_sampel_3, @jenis_sampel_4, @jenis_sampel_5, @jenis_sampel_6, @jenis_sampel_7, @jenis_sampel_All, @jumlah_sampel, @satuan, @per_bungkus, @target_uji1, @target_uji2, @target_uji3, @target_uji4, @target_uji5, @target_uji6, @target_uji7, @metode_periksa1, @metode_periksa2, @metode_periksa3, @metode_periksa4, @metode_periksa5, @cara_krm_sampel, @nama_pemohon, @jasa_pengiriman, @nip)", conn);
                        conn.Open();

                     //   cmd.Parameters.AddWithValue("@no_tanda_t_sampel", txt_no_t_terima_sampel.Text);
                        cmd.Parameters.AddWithValue("@tanggal_terima_sampel", dtp_tanggal_terima_sampel.Value.Date);
                        cmd.Parameters.AddWithValue("@no_permohonan", txt_noPermohonan.Text);
                        cmd.Parameters.AddWithValue("@tanggal_permohonan", dtp_tanggal_permohonan.Value.Date);
                        cmd.Parameters.AddWithValue("@nama_pemilik", txt_nm_pemilik.Text);
                        cmd.Parameters.AddWithValue("@alamat_pemilik", txt_alamat_pemilik.Text);
                        cmd.Parameters.AddWithValue("@nama_komoditi", txt_nm_komoditi.Text);
                        cmd.Parameters.AddWithValue("@nama_opt", txt_nm_opt.Text);

                        cmd.Parameters.AddWithValue("@jenis_sampel_1", cb_js_akar.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_2", cb_js_batang.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_3", cb_js_daun.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_4", cb_js_umbi.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_5", cb_js_biji.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_6", cb_js_buah.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_7", cb_js_lain.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_All", cb_js_all.Text);

                        cmd.Parameters.AddWithValue("@jumlah_sampel", txt_jml_sampel.Text);
                        cmd.Parameters.AddWithValue("@satuan", cmb_satuan.Text);
                        cmd.Parameters.AddWithValue("@per_bungkus", txt_perbks.Text);

                        cmd.Parameters.AddWithValue("@target_uji1", cb_tp_virus.Text);
                        cmd.Parameters.AddWithValue("@target_uji2", cb_tp_cendawan.Text);
                        cmd.Parameters.AddWithValue("@target_uji3", cb_tp_bakteri.Text);
                        cmd.Parameters.AddWithValue("@target_uji4", cb_tp_biotek.Text);
                        cmd.Parameters.AddWithValue("@target_uji5", cb_tp_serangga.Text);
                        cmd.Parameters.AddWithValue("@target_uji6", cb_tp_nematoda.Text);
                        cmd.Parameters.AddWithValue("@target_uji7", cb_tp_gulma.Text);

                        cmd.Parameters.AddWithValue("@metode_periksa1", cb_mp_pLangsung.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa2", cb_mp_agar.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa3", cb_mp_pcr.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa4", cb_mp_blotter.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa5", cb_mp_elisa.Text);

                        cmd.Parameters.AddWithValue("@cara_krm_sampel", cmb_cr_kirim_sampel.Text);
                        cmd.Parameters.AddWithValue("@nama_pemohon", txt_nm_pemohon.Text);
                        cmd.Parameters.AddWithValue("@jasa_pengiriman", cmb_jasa_kirim.Text);
                        cmd.Parameters.AddWithValue("@nip", txt_nip_petugas.Text);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Berhasil Disimpan");
                       // awal();
                        Bersih();
                        conn.Close();
                    }
                    catch (Exception z)
                    {
                        MessageBox.Show(z.ToString());
                    }
               }

        private void btn_new_Click(object sender, EventArgs e)
        {
          //  otomatis();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Ingin Keluar ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            Bersih();
        }
        }
   }
