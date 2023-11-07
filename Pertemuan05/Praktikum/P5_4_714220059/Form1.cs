using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime getTanggal = dateTimePicker1.Value;
            string Tanggal = getTanggal.ToString("dd / MMMM / yyyy ");
            string kelamin = comboBox1.GetItemText("getkelamin.SelectedItem");
            string Kelas = "";
            string Jadwal = "";

            if(Biola.Checked)
            {
                Kelas += "Biola, ";   
            }

            if(Gitar.Checked)
            {
                Kelas += "Gitar, ";
            }

            if (sex.Checked)
            {
                Kelas += "sex, ";
            }

            if(konduk.Checked)
            {
                Kelas += "konduk, ";
            }

            if(piano.Checked)
            {
                Kelas += "Piano, ";
            }

            if(Drum.Checked)
            {
                Kelas += "Drum, ";
            }

            if(Vokal.Checked)
            {
                Kelas += "Kelas, ";
            }

            if(Senin.Checked)
            {
                Jadwal = "Senin dan Rabu, 14.00 - 16.00";
            }

            else if (Selasa.Checked)
            {
                Jadwal = "Selasa dan Kamis, 14.00 - 16.00";
            }

            else if (Sabtu.Checked)
            {
                Jadwal = "Sabtu dan Minggu, 09.00 -11.00";
            }

            else if(Minggu.Checked)
            {
                Jadwal = "Minggu, 13.00 - 17.00";   
            }

            if (Kelas != "" && Jadwal != "" )
            {
                MessageBox.Show("Nama : " + TeksPesan.Text + "\nJenis Kelamin : " + "\nTanggal Lahir :" + Tanggal + "\nPilihan Kelas : " + Kelas + "\nPilihan Jadwal  : " + Jadwal, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon_Information);
                    
            }
            else if (TeksPesan.Text == "")
            {
                MessageBox.Show("Masukkan nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK);
            }

            else if (kelamin == "")n
            {
                MessageBox.Show("Harus memilih satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK);
            }

        } 

        private void Biola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MessageBoxIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

