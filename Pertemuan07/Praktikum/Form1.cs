using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220059.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Size = new Size(617, 332);
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            string errorMessage = ""; 

            if (string .IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage += "Nama belum diisi\n";    
            }
            if (string.IsNullOrWhiteSpace(textBoxProdi.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }
            if(Regex.IsMatch(textBoxProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }
            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Sumbit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    errorMessage,
                    "Informasi Data Sumbit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButtonSenin_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSenin.Checked)
            {
                checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = true;
                checkBoxTraveling.Enabled = false; checkBoxTraveling.Checked = false;
                checkBoxTidur.Enabled = false;  checkBoxTidur.Checked = false;
            }
        }

        private void radioButtonMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinggu.Checked)
            {
                checkBoxKuliah.Enabled = false;
                checkBoxTraveling.Enabled = false;
                checkBoxTidur.Enabled = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = string.Empty;
            textBoxProdi.Text = string.Empty;
            textBoxKelas.Text = string.Empty;
        }
        private void buttonTutup_Click(object sender, EventArgs e)
        {
            //textBoxNama.Text = null;
            //textBoxProdi.Text = null;
            //textBoxKelas.Text = null;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }
            this.Size = new Size(617, 332);
        }

    }
}
