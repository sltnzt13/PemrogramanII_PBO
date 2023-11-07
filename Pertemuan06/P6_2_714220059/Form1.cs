﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_2_714220059
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //show the OpenFileDialog and check DialogResult
                DialogResult userResponse = openFileDialog1.ShowDialog();
                if (userResponse == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName.ToString();
                    MessageBox.Show("You successfully opened: '" + filePath + "'", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}