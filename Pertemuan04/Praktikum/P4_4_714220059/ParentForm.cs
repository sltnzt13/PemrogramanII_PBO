﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220059
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMerkHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilankan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";

            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_android.Checked == true)
            {
                os = "iOs";
            }

            if (cbYa.Checked == true)
            {
                status = "Ya, sudah diperbaiki";
            }
            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text +
                "\nSistem Operasi : " + os +
                "\nStatus Perbaikan : " + status,
                "Informasi Service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
