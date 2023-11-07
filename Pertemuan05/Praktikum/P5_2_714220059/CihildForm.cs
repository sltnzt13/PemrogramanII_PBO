using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_714220059
{
    public partial class CihildForm : Form
    {
        public CihildForm()
        {
            InitializeComponent();
        }

        private void CihildForm_Load(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLabel.text = outputText;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
