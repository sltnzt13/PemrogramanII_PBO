using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220059_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsNumber))
            {
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "Betul!");
                epWarning.SetError(txtAngka, "");
            }
            else
            {
                epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                epCorrect.SetError(txtAngka, "");
                epWarning.SetError(txtAngka, "");
            }
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Inputan tidak boleh kosong!");
                epCorrect.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
            }

            int tinggi;
            if (int.TryParse(txtAngka.Text, out tinggi))
            {
                if (tinggi >= 220)
                {
                    epWarning.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Terlalu tinggi bang");
                }
            }
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text).All(Char.IsLetter))
            {
                epCorrect.SetError(txtHuruf, "Betul!");
                epWarning.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "");
            }
            else
            {
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
            }
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Inputan tidak boleh kosong!");
                epCorrect.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "");
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string vPosisi = comboPosisi.SelectedItem.ToString();
            int tinggi;
            bool validTinggi = int.TryParse(txtAngka.Text, out tinggi);
            bool validasiTinggi = tinggi <= 220;

            if (txtHuruf.Text != "" && (txtHuruf.Text).All(Char.IsLetter) && txtAngka.Text != "" && (txtAngka.Text).All(Char.IsNumber) && vPosisi != "" && validasiTinggi && (txtOutput1.Text).All(Char.IsUpper) && (txtOutput1.Text == "DAFTAR") && (txtOutput2.Text).All(Char.IsLower) && (txtOutput2.Text == "daftar"))
            {
                MessageBox.Show("Nama: " + txtHuruf.Text + "\nTinggi: " + txtAngka.Text + "\nPosisi: " + vPosisi, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Benerin dulu form diatas, ada yang salah!", "Gagal Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendaftaran Dibatalkan!", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void comboPosisi_Leave(object sender, EventArgs e)
        {
            string vPosisi = comboPosisi.SelectedItem.ToString();
            if (vPosisi != "")
            {
                epCorrect.SetError(comboPosisi, "Betul!");
                epWarning.SetError(comboPosisi, "");
                epWrong.SetError(comboPosisi, "");
            }
            else
            {
                epCorrect.SetError(comboPosisi, "");
                epWarning.SetError(comboPosisi, "Pilih salah satu pilihan disini!");
                epWrong.SetError(comboPosisi, "");
            }
        }

        private void txtOutput1_Leave(object sender, EventArgs e)
        {
            if ((txtOutput1.Text).All(Char.IsUpper) && (txtOutput1.Text == "DAFTAR"))
            {
                epCorrect.SetError(txtOutput1, "Betul!");
                epWarning.SetError(txtOutput1, "");
                epWrong.SetError(txtOutput1, "");
            }
            if ((txtOutput1.Text).Any(Char.IsLower))
            {
                epCorrect.SetError(txtOutput1, "");
                epWarning.SetError(txtOutput1, "");
                epWrong.SetError(txtOutput1, "Pakai UPPERCASE dan kata 'DAFTAR'");
            }
   
            if ((txtOutput1.Text == ""))
            {
                epCorrect.SetError(txtOutput1, "");
                epWarning.SetError(txtOutput1, "Kosong");
                epWrong.SetError(txtOutput1, "");
            }
        }

        private void txtOutput2_Leave(object sender, EventArgs e)
        {
            if ((txtOutput2.Text).All(Char.IsLower) && (txtOutput2.Text == "daftar"))
            {
                epCorrect.SetError(txtOutput2, "Betul!");
                epWarning.SetError(txtOutput2, "");
                epWrong.SetError(txtOutput2, "");
            }
            if ((txtOutput2.Text).Any(Char.IsUpper))
            {
                epCorrect.SetError(txtOutput2, "");
                epWarning.SetError(txtOutput2, "");
                epWrong.SetError(txtOutput2, "Pakai lowercase dan kata 'daftar'");
            }

            if ((txtOutput2.Text == ""))
            {
                epCorrect.SetError(txtOutput2, "");
                epWarning.SetError(txtOutput2, "Kosong");
                epWrong.SetError(txtOutput2, "");
            }
        }
    }
}
