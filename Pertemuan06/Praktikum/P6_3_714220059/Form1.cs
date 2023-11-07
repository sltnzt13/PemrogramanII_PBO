using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220059
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            txtAngka1.TextChanged += txtAngka1_TextChanged;
            txtAngka2.TextChanged += txtAngka2_TextChanged;
            txtAngka2.Leave += txtAngka2_Leave;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Textbox Angka 1 tidak boleh kosong!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");
                }
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
            {
                if (angka1 > angka2)
                {
                    epCorrect.SetError(txtAngka1, "Angka 1 lebih besar dari Angka 2");
                    epWrong.SetError(txtAngka1, "");
                }
                else
                {
                    epWrong.SetError(txtAngka1, "Angka 1 tidak lebih besar dari Angka 2");
                    epCorrect.SetError(txtAngka1, "");
                }
            }

            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Textbox Angka 2 tidak boleh kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka2.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            txtAngka2_TextChanged(sender, e);
        }

        private void txtHuruf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

