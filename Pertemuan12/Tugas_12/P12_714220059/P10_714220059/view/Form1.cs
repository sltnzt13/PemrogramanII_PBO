using P10_714220059.controller;
using P10_714220059.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714220059
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        public Form1()
        {
            InitializeComponent();
        }
        public void ResetForm()
        {
            npm.Text = "";
            nama.Text = "";
            angkatan.SelectedIndex = -1;
            alamat.Text = "";
            email.Text = "";
            nohp.Text = "";
            tbCariData.Text = "";
        }

        public void Tampil()
        {
            //Query DB Get MGS 
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_Mahasiswa");
            //Mengubah Nama Kolom Tabel 
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil method Tampil 
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 ||alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }

        }

        private void DataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            npm.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            angkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            email.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            nohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 || alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Update(m_mhs,npm.Text);


                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(npm.Text);
                ResetForm();
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB search data
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE npm LIKE '%' '" + tbCariData.Text + "' '%' OR nama LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
