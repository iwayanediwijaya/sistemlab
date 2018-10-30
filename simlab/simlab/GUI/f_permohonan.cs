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
            
            txt_negara_tujuan.Text = "";
            txt_idnegara_tujuan.Text = "";
            
            txt_kdprov_asal.Text = "";
            txt_prov_asal.Text = "";
            
            txt_kdprov_tujuan.Text = "";
            txt_prov_tujuan.Text = "";


            cb_tp_serangga.Checked = false;
            cb_tp_virus.Checked = false;
            cb_tp_cendawan.Checked = false;
            cb_tp_biotek.Checked = false;
            cb_tp_bakteri.Checked = false;
            cb_tp_nematoda.Checked = false;
            cb_tp_gulma.Checked = false;
            txt_target_pest.Text = "";
            cb_mp_agar.Checked = false;
            cb_mp_blotter.Checked = false;
            cb_mp_elisa.Checked = false;
            cb_mp_pcr.Checked = false;
            cb_mp_pLangsung.Checked = false;
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
                txt_prov_asal.Enabled = false;
                txt_kdprov_tujuan.Enabled = false;
                txt_prov_tujuan.Enabled = false;
                btn_cari_Pasal.Enabled = false;
                btn_cari_Ptujuan.Enabled = false;
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
                txt_negara_asal.Enabled = false;
                txt_idnegara_tujuan.Enabled = false;
                txt_negara_tujuan.Enabled = false;

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
                        cmd = new SqlCommand("INSERT INTO tblF_permohonan (no_permohonan, tgl_permohonan, jenis_kegiatan, nama_pemohon, alamat_pemohon, jenis_media1, jenis_media2, kode_komoditi, kode_opt, jumlah_sampel ,satuan, jenis_sampel_komoditi, media_pembawa, id_negara_asal, id_negara_tujuan, kode_provinsi_asal, kode_provinsi_tujuan, target_uji1, target_uji2, target_uji3, target_uji4, target_uji5, target_uji6, target_uji7, metode_periksa1, metode_periksa2, metode_periksa3, metode_periksa4, metode_periksa5, id_PP) VALUES  (@no_permohonan, @tgl_permohonan, @jenis_kegiatan, @nama_pemohon, @alamat_pemohon, @jenis_media1, @jenis_media2, @kode_komoditi, @kode_opt, @jumlah_sampel, @satuan, @jenis_sampel_komoditi, @media_pembawa, @id_negara_asal, @id_negara_tujuan, @kode_provinsi_asal, @kode_provinsi_tujuan, @target_uji1, @target_uji2, @target_uji3, @target_uji4, @target_uji5, @target_uji6, @target_uji7, @metode_periksa1, @metode_periksa2, @metode_periksa3, @metode_periksa4, @metode_periksa5, @id_PP)", conn); 
                        conn.Open();
                        cmd.Parameters.AddWithValue("@no_permohonan", txt_noPermohonan.Text);
                        cmd.Parameters.AddWithValue("@tgl_permohonan", dtp_tanggal.Value.Date);
                        cmd.Parameters.AddWithValue("@jenis_kegiatan", cmb_Jkegiatan.Text );
                        cmd.Parameters.AddWithValue("@nama_pemohon", txt_nama_pemohon.Text);
                        cmd.Parameters.AddWithValue("@alamat_pemohon", txt_alamat_pemohon.Text);
                        cmd.Parameters.AddWithValue("@jenis_media1", cb_komoditi.Text);
                        cmd.Parameters.AddWithValue("@jenis_media2", cb_opt.Text);
                        cmd.Parameters.AddWithValue("@kode_komoditi", txt_kode_komoditi.Text);
                        cmd.Parameters.AddWithValue("@kode_opt", txt_kode_opt.Text);
                        cmd.Parameters.AddWithValue("@jumlah_sampel", txt_jml_sampel.Text);
                        cmd.Parameters.AddWithValue("@satuan", cmb_satuan.Text);

                        string check1 = "";

                        if(cb_js_akar.Checked)
                        {
                            check1 = check1 +"; "+ cb_js_akar.Text;
                        }
                        
                        if(cb_js_batang.Checked)
                        {
                            check1 = check1 +"; "+ cb_js_batang.Text;
                        }

                        if(cb_js_biji.Checked)
                        {
                             check1 = check1 +"; "+ cb_js_biji.Text;
                        }

                        if (cb_js_buah.Checked)
                        {
                             check1 = check1 +"; "+cb_js_buah.Text;
                        }

                        if(cb_js_daun.Checked)
                        {
                             check1 = check1 +"; "+ cb_js_daun.Text;

                        }

                        if(cb_js_umbi.Checked)
                        {
                             check1 = check1 +"; "+ cb_js_umbi.Text;
                        }

                        if (cb_js_lain.Checked)
                        {
                             check1 = check1 +"; "+cb_js_lain.Text;
                        }

                        if(cb_js_all.Checked)
                        {
                            check1 = check1 + "; " +cb_js_all.Text;
                        }


                        check1 = check1.TrimStart(';');
                        cmd.Parameters.AddWithValue("@jenis_sampel_komoditi", check1);
                        cmd.Parameters.AddWithValue("@media_pembawa", cmb_jenisMedia.Text);
                        cmd.Parameters.AddWithValue("@id_negara_asal", txt_idnegara_asal.Text);
                        cmd.Parameters.AddWithValue("@id_negara_tujuan", txt_idnegara_tujuan.Text);
                        cmd.Parameters.AddWithValue("@kode_provinsi_asal", txt_kdprov_asal.Text);
                        cmd.Parameters.AddWithValue("@kode_provinsi_tujuan", txt_kdprov_tujuan.Text);
                        cmd.Parameters.AddWithValue("@id_pelabuhan_asal", txt_kode_pelabuhanA.Text);
                        cmd.Parameters.AddWithValue("@id_pelabuhan_tujuan", txt_kode_pelabuhanT.Text);
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
                        cmd.Parameters.AddWithValue("@id_PP", txt_id_pemilik.Text);

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

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cari_areaAsal_Click(object sender, EventArgs e)
        {
            GUI.view_provinsi v_provinsi = new GUI.view_provinsi();
            v_provinsi.ShowDialog();

            txt_idnegara_asal.Text = v_provinsi.ambil_kd_prov;
            txt_negara_asal.Text = v_provinsi.ambil_nm_prov;
            txt_negara_asal.Focus();
        }

        private void btn_cari_Nasal_Click(object sender, EventArgs e)
        {
            GUI.view_negara v_negara = new GUI.view_negara();
            v_negara.ShowDialog();

            txt_idnegara_asal.Text = v_negara.ambil_id_ngr;
            txt_negara_asal.Text = v_negara.ambil_nama_ngr;
            txt_negara_asal.Focus();
        }

        private void btn_cari_Ntujuan_Click(object sender, EventArgs e)
        {
            GUI.view_negara v_negara = new GUI.view_negara();
            v_negara.ShowDialog();

            txt_idnegara_tujuan.Text = v_negara.ambil_id_ngr;
            txt_negara_tujuan.Text = v_negara.ambil_nama_ngr;
            txt_negara_tujuan.Focus();
        }

        private void btn_cari_areaTuju_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cari_pemilik_Click(object sender, EventArgs e)
        {
            GUI.view_pemilik v_pemilik = new GUI.view_pemilik();
            v_pemilik.ShowDialog();

            txt_id_pemilik.Text = v_pemilik.ambil_id_PP;
            txt_nm_pemilik.Text = v_pemilik.ambil_nm_PP;
            txt_alamat_pemiik.Text = v_pemilik.ambil_alamat_PP;
            txt_id_pemilik.Focus();
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
            GUI.view_provinsi v_provinsi = new GUI.view_provinsi();
            v_provinsi.ShowDialog();

            txt_kdprov_tujuan.Text = v_provinsi.ambil_kd_prov;
            txt_prov_tujuan.Text = v_provinsi.ambil_nm_prov;
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
            GUI.view_provinsi v_provinsi = new GUI.view_provinsi();
            v_provinsi.ShowDialog();

            txt_kdprov_asal.Text = v_provinsi.ambil_kd_prov;
            txt_prov_asal.Text = v_provinsi.ambil_nm_prov;
            txt_prov_asal.Focus();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btn_pelabuhanA_Click(object sender, EventArgs e)
        {
            GUI.view_pelabuhan v_pelabuhan = new GUI.view_pelabuhan();
            v_pelabuhan.ShowDialog();
            txt_kode_pelabuhanA.Text = v_pelabuhan.ambil_id_pelabuhan;
            txt_nm_pelabuhanA.Text = v_pelabuhan.ambil_nm_pelabuhan;
            txt_kode_pelabuhanA.Focus();
        }

        private void btn_pelabuhanT_Click_1(object sender, EventArgs e)
        {
            GUI.view_pelabuhan v_pelabuhan = new GUI.view_pelabuhan();
            v_pelabuhan.ShowDialog();
            txt_kode_pelabuhanT.Text = v_pelabuhan.ambil_id_pelabuhan;
            txt_nm_pelabuhanT.Text = v_pelabuhan.ambil_nm_pelabuhan;
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
            GUI.view_opt v_opt = new GUI.view_opt();
            v_opt.ShowDialog();

            //txt_kode_opt.Text = v_opt.ambil_kd_opt;
           // txt_nm_opt.Text = v_opt.ambil_nm_umum_opt;
            txt_target_pest.Text = v_opt.ambil_nm_latin_opt;
            txt_target_pest.Focus();
        }

    }
}
