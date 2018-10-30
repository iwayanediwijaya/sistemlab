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
    public partial class btn_view_permohonan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
//      public string 
     // private SqlDataReader dr;

        kelas.koneksi konn = new kelas.koneksi();


        public btn_view_permohonan()
        {
            InitializeComponent();
        }

       
        

        private void auto_number()
        {
          //  long hitung;
          //  string urut;
          //  SqlConnection conn; 
        }
        private void Bersih()
        {
            txt_noPermohonan.Text = "";
            dtp_tanggal.Value = DateTime.Now;
            cmb_Jkegiatan.Text = "--Pilih Kegiatan--";
            txt_nama_pemohon.Text = "";
            txt_alamat_pemohon.Text = "";
            cb_komoditi.Checked = false;
            cb_opt.Checked = false;
            txt_kode_komoditi.Text = "";
            txt_nmKomoditi.Text = "";
            txt_kode_opt.Text = "";
            txt_nm_opt.Text = "";
            txt_ilmiah_komod.Text = "";
            txt_ilmiah_opt.Text = "";
            txt_jml_sampel.Text = "0";
            cmb_satuan.Text = "--Pilih Satuan--";
            txt_perbks.Text = "0";
            cb_js_akar.Checked = false;
            cb_js_batang.Checked = false;
            cb_js_daun.Checked = false;
            cb_js_biji.Checked = false;
            cb_js_umbi.Checked = false;
            cb_js_buah.Checked = false;
            cb_js_lain.Checked = false;
            cb_js_all.Checked = false;
            cmb_jenisMedia.Text = "--Pilih Jenis Media--";
            
            txt_negara_asal.Text = "";
            txt_idnegara_asal.Text = "";
            txt_idnegara_asal.Enabled = true;
            txt_negara_asal.Enabled = true;
            btn_cari_Nasal.Enabled = true;
             
            txt_negara_tujuan.Text = "";
            txt_idnegara_tujuan.Text = "";
            txt_idnegara_tujuan.Enabled = true;
            txt_negara_tujuan.Enabled = true;
            btn_cari_Ntujuan.Enabled = true; 
           
            txt_kdprov_asal.Text = "";
            txt_prov_asal.Text = "";
            txt_kdprov_asal.Enabled = true;
            txt_prov_asal.Enabled = true;
            btn_cari_Pasal.Enabled = true;
            
            txt_kdprov_tujuan.Text = "";
            txt_prov_tujuan.Text = "";
            txt_kdprov_tujuan.Enabled = true;
            txt_prov_tujuan.Enabled = true;
            btn_cari_Ptujuan.Enabled = true;

            txt_kode_pelabuhanA.Text = "";
            txt_nm_pelabuhanA.Text = "";


            txt_kode_pelabuhanT.Text = "";
            txt_nm_pelabuhanT.Text = "";

            cb_tp_serangga.Checked = false;
            cb_tp_virus.Checked = false;
            cb_tp_cendawan.Checked = false;
            cb_tp_biotek.Checked = false;
            cb_tp_bakteri.Checked = false;
            cb_tp_nematoda.Checked = false;
            cb_tp_gulma.Checked = false;
            txt_kd_targetpest.Text = "";
            txt_target_pest.Text = "";
            cb_mp_agar.Checked = false;
            cb_mp_blotter.Checked = false;
            cb_mp_elisa.Checked = false;
            cb_mp_pcr.Checked = false;
            cb_mp_pLangsung.Checked = false;
            txt_kd_PP.Text = "";
            txt_nm_pemilik.Text = "";
            txt_alamat_pemiik.Text = "";
            txt_dp1.Text = "";
            txt_dp2.Text = "";
            txt_dp3.Text = "";

        }

        private void f_permohonan_Load(object sender, EventArgs e)
        {
            dtp_tanggal.Value = DateTime.Now;
            cmb_Jkegiatan.Text = "--Pilih Kegiatan--";
            txt_jml_sampel.Text = "0";
            cmb_satuan.Text = "--Pilih Satuan--";
            txt_perbks.Text = "0";
            cmb_jenisMedia.Text = "--Pilih Jenis Media--";

           // string pilihan1 = "";
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmb_Jkegiatan.Text == "EKSPOR") || (cmb_Jkegiatan.Text == "IMPOR"))
            {
                txt_kdprov_asal.Enabled = false;
                txt_kdprov_asal.Text = "";
                txt_prov_asal.Enabled = false;
                txt_prov_asal.Text = "";
                txt_kdprov_tujuan.Enabled = false;
                txt_kdprov_tujuan.Text = "";
                txt_prov_tujuan.Enabled = false;
                txt_prov_tujuan.Text = "";
                btn_cari_Pasal.Enabled = false;
                btn_cari_Ptujuan.Enabled = false;
                txt_idnegara_asal.Enabled = true;
                txt_negara_asal.Enabled = true;
                txt_idnegara_tujuan.Enabled = true;
                txt_negara_tujuan.Enabled = true;
                btn_cari_Nasal.Enabled = true;
                btn_cari_Ntujuan.Enabled = true;

           }

            else if ((cmb_Jkegiatan.Text == "DOMAS") || (cmb_Jkegiatan.Text == "DOKEL"))
            {
                txt_kdprov_asal.Enabled = true;
                txt_prov_asal.Enabled = true;
                txt_kdprov_tujuan.Enabled = true;
                txt_prov_tujuan.Enabled = true;
                btn_cari_Pasal.Enabled = true;
                btn_cari_Ptujuan.Enabled = true;
                txt_idnegara_asal.Enabled = false;
                txt_idnegara_asal.Text = "";
                txt_negara_asal.Enabled = false;
                txt_negara_asal.Text = "";
                txt_idnegara_tujuan.Enabled = false;
                txt_idnegara_tujuan.Text = "";
                txt_negara_tujuan.Enabled = false;
                txt_negara_tujuan.Text = "";
                btn_cari_Nasal.Enabled = false;
                btn_cari_Ntujuan.Enabled = false;
            }
            else
            {
                txt_kdprov_asal.Enabled = true;
                txt_prov_asal.Enabled = true;
                txt_kdprov_tujuan.Enabled = true;
                txt_prov_tujuan.Enabled = true;
                btn_cari_Pasal.Enabled = true;
                btn_cari_Ptujuan.Enabled = true;
                txt_idnegara_asal.Enabled = true;
                txt_negara_asal.Enabled = true;
                txt_idnegara_tujuan.Enabled = true;
                txt_negara_tujuan.Enabled = true;
                btn_cari_Nasal.Enabled = true;
                btn_cari_Ntujuan.Enabled = true;
            }
     }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txt_dp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txt_dp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void view_permohonan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // try
            //{
              //  DataGridViewRow row = this.view_permohonan.Rows[e.RowIndex];

//            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click_1(object sender, EventArgs e)
        {
            {
               // long hitung;
               // string urut;
                
                //jika data ada yg blm terisikan
                if (txt_noPermohonan.Text.Trim() == "" ||
                cmb_Jkegiatan.Text.Trim() == "--Pilih Kegiatan--")
                //||
                //txt_nama_pemohon.Text.Trim() == "" ||
                // txt_alamat_pemohon.Text.Trim() == "" ||

                //  txt_jml_sampel.Text == "0" ||
                //  cmb_satuan.Text.Trim() == "--Pilih Satuan--" ||

                //  txt_negara_asal.Text.Trim() == "" ||
                //  txt_negara_Tujuan.Text.Trim() == "" ||
                //  txt_target_pest.Text.Trim() == "" ||
                //  txt_nm_pemilik.Text.Trim() == "" ||
                //  txt_alamat_pemiik.Text.Trim() == "")
                {
                    MessageBox.Show("Mohon Lengkapi Data Permohonan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
               //Simpan data ke database
                    //view_permohonan.Enabled = true; 
                    SqlConnection conn = konn.GetConn();
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO tblF_permohonan (no_permohonan, tgl_permohonan, jenis_kegiatan, nama_pemohon, alamat_pemohon, jenis_media1, jenis_media2, kode_komoditi, nama_umum_komoditi, nama_latin_komoditi, kode_opt, nama_umum_opt, nama_latin_opt, jumlah_sampel ,satuan, jenis_sampel_1, jenis_sampel_2, jenis_sampel_3, jenis_sampel_4, jenis_sampel_5, jenis_sampel_6, jenis_sampel_7, jenis_sampel_All, media_pembawa, id_negara_asal, nama_en_negara_asal, id_negara_tujuan, nama_en_negara_tujuan, kode_provinsi_asal, nama_provinsi_asal, kode_provinsi_tujuan, nama_provinsi_tujuan, id_pelabuhan_asal, nama_pelabuhan_asal, id_pelabuhan_tujuan, nama_pelabuhan_tujuan, target_uji1, target_uji2, target_uji3, target_uji4, target_uji5, target_uji6, target_uji7, kode_targetpest, metode_periksa1, metode_periksa2, metode_periksa3, metode_periksa4, metode_periksa5, id_PP) VALUES  (@no_permohonan, @tgl_permohonan, @jenis_kegiatan, @nama_pemohon, @alamat_pemohon, @jenis_media1, @jenis_media2, @kode_komoditi, @nama_umum_komoditi, @nama_latin_komoditi, @kode_opt, @nama_umum_opt, @nama_latin_opt, @jumlah_sampel, @satuan, @jenis_sampel_1, @jenis_sampel_2, @jenis_sampel_3, @jenis_sampel_4, @jenis_sampel_5, @jenis_sampel_6, @jenis_sampel_7, @jenis_sampel_All, @media_pembawa, @id_negara_asal, @nama_en_negara_asal , @id_negara_tujuan, @nama_en_negara_tujuan , @kode_provinsi_asal, @nama_provinsi_asal, @kode_provinsi_tujuan, @nama_provinsi_tujuan, @id_pelabuhan_asal, @nama_pelabuhan_asal, @id_pelabuhan_tujuan, @nama_pelabuhan_tujuan, @target_uji1, @target_uji2, @target_uji3, @target_uji4, @target_uji5, @target_uji6, @target_uji7, @kode_targetpest, @metode_periksa1, @metode_periksa2, @metode_periksa3, @metode_periksa4, @metode_periksa5, @id_PP)", conn); 
                        conn.Open();

                        //urut = DateTime.Now.ToString("yyyyMMdd");
                       // hitung = Convert.ToInt64(["no_permohonan"].ToString());
                        cmd.Parameters.AddWithValue("@no_permohonan", txt_noPermohonan.Text);
                        cmd.Parameters.AddWithValue("@tgl_permohonan", dtp_tanggal.Value.Date);
                        cmd.Parameters.AddWithValue("@jenis_kegiatan", cmb_Jkegiatan.Text );
                        cmd.Parameters.AddWithValue("@nama_pemohon", txt_nama_pemohon.Text);
                        cmd.Parameters.AddWithValue("@alamat_pemohon", txt_alamat_pemohon.Text);
                        
                        cmd.Parameters.AddWithValue("@jenis_media1", cb_komoditi.Text);
                        cmd.Parameters.AddWithValue("@jenis_media2", cb_opt.Text);
                        
                        cmd.Parameters.AddWithValue("@kode_komoditi", txt_kode_komoditi.Text);
                        cmd.Parameters.AddWithValue("@nama_umum_komoditi", txt_nmKomoditi.Text);
                        cmd.Parameters.AddWithValue("@nama_latin_komoditi", txt_ilmiah_komod.Text);
                        
                        cmd.Parameters.AddWithValue("@kode_opt", txt_kode_opt.Text);
                        cmd.Parameters.AddWithValue("@nama_umum_opt", txt_nm_opt.Text);
                        cmd.Parameters.AddWithValue("@nama_latin_opt", txt_ilmiah_opt.Text);
                        
                        cmd.Parameters.AddWithValue("@jumlah_sampel", txt_jml_sampel.Text);
                        cmd.Parameters.AddWithValue("@satuan", cmb_satuan.Text);
                        cmd.Parameters.AddWithValue("@per_bungkus", txt_perbks.Text);

                        cmd.Parameters.AddWithValue("@jenis_sampel_1", cb_js_akar.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_2", cb_js_batang.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_3", cb_js_daun.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_4", cb_js_umbi.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_5", cb_js_biji.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_6", cb_js_buah.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_7", cb_js_lain.Text);
                        cmd.Parameters.AddWithValue("@jenis_sampel_All", cb_js_all.Text);

                    //    string check1 = "";

//                        if(cb_js_akar.Checked)
    //                    {
  //                          check1 = check1 +"; "+ cb_js_akar.Text;
      //                  }
                        
        //                if(cb_js_batang.Checked)
            //            {
          //                  check1 = check1 +"; "+ cb_js_batang.Text;
              //          }

                //        if(cb_js_biji.Checked)
                  //      {
                      //       check1 = check1 +"; "+ cb_js_biji.Text;
                    //    }

                      //  if (cb_js_buah.Checked)
                       // {
                       //      check1 = check1 +"; "+cb_js_buah.Text;
                       // }

//                        if(cb_js_daun.Checked)
  //                      {
    //                         check1 = check1 +"; "+ cb_js_daun.Text;

      //                  }

        //                if(cb_js_umbi.Checked)
          //              {
            //                 check1 = check1 +"; "+ cb_js_umbi.Text;
              //          }

                //        if (cb_js_lain.Checked)
                  //      {
                    //         check1 = check1 +"; "+cb_js_lain.Text;
                      //  }

                      //  if(cb_js_all.Checked)
                       // {
                         //   check1 = check1 + "; " +cb_js_all.Text;
                       // }


///                        check1 = check1.TrimStart(';');
                      //  cmd.Parameters.AddWithValue("@jenis_sampel_komoditi", check1);
                        cmd.Parameters.AddWithValue("@media_pembawa", cmb_jenisMedia.Text);
                        
                        cmd.Parameters.AddWithValue("@id_negara_asal", txt_idnegara_asal.Text);
                        cmd.Parameters.AddWithValue("@nama_en_negara_asal", txt_negara_asal.Text);
                        
                        cmd.Parameters.AddWithValue("@id_negara_tujuan", txt_idnegara_tujuan.Text);
                        cmd.Parameters.AddWithValue("@nama_en_negara_tujuan", txt_negara_tujuan.Text);
                        
                        cmd.Parameters.AddWithValue("@kode_provinsi_asal", txt_kdprov_asal.Text);
                        cmd.Parameters.AddWithValue("@nama_provinsi_asal", txt_prov_asal.Text);
                        
                        cmd.Parameters.AddWithValue("@kode_provinsi_tujuan", txt_kdprov_tujuan.Text);
                        cmd.Parameters.AddWithValue("@nama_provinsi_tujuan", txt_prov_tujuan.Text);
                        
                        cmd.Parameters.AddWithValue("@id_pelabuhan_asal", txt_kode_pelabuhanA.Text);
                        cmd.Parameters.AddWithValue("@nama_pelabuhan_asal", txt_nm_pelabuhanA.Text);
                        
                        cmd.Parameters.AddWithValue("@id_pelabuhan_tujuan", txt_kode_pelabuhanT.Text);
                        cmd.Parameters.AddWithValue("@nama_pelabuhan_tujuan", txt_nm_pelabuhanT.Text);                        
                        
                        cmd.Parameters.AddWithValue("@target_uji1", cb_tp_virus.Text);
                        cmd.Parameters.AddWithValue("@target_uji2", cb_tp_cendawan.Text);
                        cmd.Parameters.AddWithValue("@target_uji3", cb_tp_bakteri.Text);
                        cmd.Parameters.AddWithValue("@target_uji4", cb_tp_biotek.Text);
                        cmd.Parameters.AddWithValue("@target_uji5", cb_tp_serangga.Text);
                        cmd.Parameters.AddWithValue("@target_uji6", cb_tp_nematoda.Text);
                        cmd.Parameters.AddWithValue("@target_uji7", cb_tp_gulma.Text);
                        
                        cmd.Parameters.AddWithValue("@kode_targetpest", txt_kd_targetpest.Text);
                        
                        cmd.Parameters.AddWithValue("@metode_periksa1", cb_mp_pLangsung.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa2", cb_mp_agar.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa3", cb_mp_pcr.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa4", cb_mp_blotter.Text);
                        cmd.Parameters.AddWithValue("@metode_periksa5", cb_mp_elisa.Text);
                        
                        cmd.Parameters.AddWithValue("@id_PP", txt_kd_PP.Text);

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
              }
        }

        private void btn_tmbhKomoditi_Click(object sender, EventArgs e)
        {
            
            GUI.view_komoditi v_komoditi = new GUI.view_komoditi();
            v_komoditi.ShowDialog();

            txt_kode_komoditi.Text = v_komoditi.ambil_kode_komoditi;
            txt_nmKomoditi.Text = v_komoditi.ambil_nama_komoditi;
            txt_ilmiah_komod.Text = v_komoditi.ambil_IL_komoditi;
            txt_kode_komoditi.Focus();
        }

        private void btn_tmbhOPT_Click(object sender, EventArgs e)
        {
            GUI.view_opt v_opt = new GUI.view_opt();
            v_opt.ShowDialog();

            txt_kode_opt.Text = v_opt.ambil_kd_opt;
            txt_nm_opt.Text = v_opt.ambil_nm_umum_opt;
            txt_ilmiah_opt.Text = v_opt.ambil_nm_latin_opt;
            txt_kode_opt.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GUI.view_permohonan v_permohonan = new GUI.view_permohonan();
            v_permohonan.ShowDialog();


            txt_noPermohonan.Text = v_permohonan.ambil_no_permohonan;
            dtp_tanggal.Text = v_permohonan.ambil_tgl_permohonan;
            cmb_Jkegiatan.Text = v_permohonan.ambil_jenis_kegiatan;
            txt_nama_pemohon.Text = v_permohonan.ambil_nama_pemohon;
            txt_alamat_pemohon.Text = v_permohonan.ambil_alamat_pemohon;
            cb_komoditi.Text = v_permohonan.ambil_jenis_media1;
            cb_opt.Text = v_permohonan.ambil_jenis_media2;
            txt_kode_komoditi.Text = v_permohonan.ambil_kode_komoditi;
            txt_nmKomoditi.Text = v_permohonan.ambil_nama_umum_komoditi;
            txt_ilmiah_komod.Text = v_permohonan.ambil_nama_latin_komoditi;
            txt_kode_opt.Text = v_permohonan.ambil_kode_opt;
            txt_nm_opt.Text = v_permohonan.ambil_nama_umum_opt;
            txt_ilmiah_opt.Text = v_permohonan.ambil_nama_latin_opt;
            txt_jml_sampel.Text = v_permohonan.ambil_jumlah_sampel;
            cmb_satuan.Text = v_permohonan.ambil_satuan;
            txt_perbks.Text = v_permohonan.ambil_per_bungkus;
            cb_js_akar.Text = v_permohonan.ambil_jenis_sampel1;
            cb_js_batang.Text = v_permohonan.ambil_jenis_sampel2;
            cb_js_daun.Text = v_permohonan.ambil_jenis_sampel3;
            cb_js_umbi.Text = v_permohonan.ambil_jenis_sampel4;
            cb_js_biji.Text = v_permohonan.ambil_jenis_sampel5;
            cb_js_buah.Text = v_permohonan.ambil_jenis_sampel6;
            cb_js_lain.Text = v_permohonan.ambil_jenis_sampel7;
            cb_js_all.Text = v_permohonan.ambil_jenis_sampel_all;
            cmb_jenisMedia.Text = v_permohonan.ambil_media_pembawa;
            txt_idnegara_asal.Text = v_permohonan.ambil_id_negara_asal;
            txt_negara_asal.Text = v_permohonan.ambil_nama_negara_asal;
            txt_idnegara_tujuan.Text = v_permohonan.ambil_id_negara_tujuan;
            txt_negara_tujuan.Text = v_permohonan.ambil_nama_negara_tujuan;
            txt_kdprov_asal.Text = v_permohonan.ambil_kode_provinsi_asal;
            txt_prov_asal.Text = v_permohonan.ambil_nama_provinsi_asal;
            txt_kdprov_tujuan.Text = v_permohonan.ambil_kode_provinsi_tujuan;
            txt_prov_tujuan.Text = v_permohonan.ambil_nama_provinsi_tujuan;
            txt_kode_pelabuhanA.Text = v_permohonan.ambil_id_pelabuhan_asal;
            txt_nm_pelabuhanA.Text = v_permohonan.ambil_nama_pelabuhan_asal;
            txt_kode_pelabuhanT.Text = v_permohonan.ambil_id_pelabuhan_tujuan;
            txt_nm_pelabuhanT.Text = v_permohonan.ambil_nama_pelabuhan_tujuan;
            cb_tp_virus.Text = v_permohonan.ambil_target_uji1;
            cb_tp_cendawan.Text = v_permohonan.ambil_target_uji2;
            cb_tp_bakteri.Text = v_permohonan.ambil_target_uji3;
            cb_tp_biotek.Text = v_permohonan.ambil_target_uji4;
            cb_tp_serangga.Text = v_permohonan.ambil_target_uji5;
            cb_tp_nematoda.Text = v_permohonan.ambil_target_uji6;
            cb_tp_gulma.Text = v_permohonan.ambil_target_uji7;
            cb_mp_pLangsung.Text = v_permohonan.ambil_metode_periksa1;
            cb_mp_agar.Text = v_permohonan.ambil_metode_periksa2;
            cb_mp_pcr.Text = v_permohonan.ambil_metode_periksa3;
            cb_mp_blotter.Text = v_permohonan.ambil_metode_periksa4;
            cb_mp_elisa.Text = v_permohonan.ambil_metode_periksa5;
            txt_kd_PP.Text = v_permohonan.ambil_id_pp;
            txt_noPermohonan.Focus();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cari_areaAsal_Click(object sender, EventArgs e)
        {
        }

        private void btn_cari_Nasal_Click(object sender, EventArgs e)
        {
            GUI.view_negara_asal v_negara_asal= new GUI.view_negara_asal();
            v_negara_asal.ShowDialog();

            txt_idnegara_asal.Text = v_negara_asal.ambil_id_ngr_asal;
            txt_negara_asal.Text = v_negara_asal.ambil_nama_ngr_asal;
            txt_negara_asal.Focus();
        }

        private void btn_cari_Ntujuan_Click(object sender, EventArgs e)
        {
            GUI.view_negara_tujuan v_negara_tujuan = new GUI.view_negara_tujuan();
            v_negara_tujuan.ShowDialog();

            txt_idnegara_tujuan.Text = v_negara_tujuan.ambil_id_ngr_tujuan;
            txt_negara_tujuan.Text = v_negara_tujuan.ambil_nama_ngr_tujuan;
            txt_negara_tujuan.Focus();
        }

        private void btn_cari_areaTuju_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cari_pemilik_Click(object sender, EventArgs e)
        {
            GUI.view_pemilik v_pemilik = new GUI.view_pemilik();
            v_pemilik.ShowDialog();

            txt_kd_PP.Text = v_pemilik.ambil_id_PP;
            txt_nm_pemilik.Text = v_pemilik.ambil_nm_PP;
            txt_alamat_pemiik.Text = v_pemilik.ambil_alamat_PP;
            txt_kd_PP.Focus();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void txt_kode_pelabuhanTe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nm_pelabuhanT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pelabuhanT_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txt_kd_NegaraOrArea_Tujuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NegaraOrArea_Tujuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.view_provinsi_tujuan v_provinsi_tujuan = new GUI.view_provinsi_tujuan();
            v_provinsi_tujuan.ShowDialog();

            txt_kdprov_tujuan.Text = v_provinsi_tujuan.ambil_kd_prov_tujuan;
            txt_prov_tujuan.Text = v_provinsi_tujuan.ambil_nm_prov_tujuan;
            txt_prov_tujuan.Focus();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void txt_kdprov_asal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prov_asal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cari_Pasal_Click(object sender, EventArgs e)
        {
            GUI.view_provinsi_asal v_provinsi_asal = new GUI.view_provinsi_asal();
            v_provinsi_asal.ShowDialog();

            txt_kdprov_asal.Text = v_provinsi_asal.ambil_kd_prov_asal;
            txt_prov_asal.Text = v_provinsi_asal.ambil_nm_prov_asal;
            txt_prov_asal.Focus();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btn_pelabuhanA_Click(object sender, EventArgs e)
        {
            GUI.view_pelabuhan_asal v_pelabuhan_asal = new GUI.view_pelabuhan_asal();
            v_pelabuhan_asal.ShowDialog();
            txt_kode_pelabuhanA.Text = v_pelabuhan_asal.ambil_id_pelabuhan_asal;
            txt_nm_pelabuhanA.Text = v_pelabuhan_asal.ambil_nm_pelabuhan_asal;
            txt_kode_pelabuhanA.Focus();
        }

        private void btn_pelabuhanT_Click_1(object sender, EventArgs e)
        {
            GUI.view_pelabuhan_tujuan v_pelabuhan_tujuan = new GUI.view_pelabuhan_tujuan();
            v_pelabuhan_tujuan.ShowDialog();
            txt_kode_pelabuhanT.Text = v_pelabuhan_tujuan.ambil_id_pelabuhan_tujuan;
            txt_nm_pelabuhanT.Text = v_pelabuhan_tujuan.ambil_nm_pelabuhan_tujuan;
            txt_kode_pelabuhanT.Focus();
        }

        private void label32_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_kode_pelabuhanA_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_tmbhT_Pest_Click(object sender, EventArgs e)
        {
            GUI.view_target_pest v_targetpest = new GUI.view_target_pest();
            v_targetpest.ShowDialog();
            txt_kd_targetpest.Text = v_targetpest.ambil_kd_Tpest;
            txt_target_pest.Text = v_targetpest.ambil_nm_latin_Tpest;
            txt_target_pest.Focus();
        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
        }
    }
}
