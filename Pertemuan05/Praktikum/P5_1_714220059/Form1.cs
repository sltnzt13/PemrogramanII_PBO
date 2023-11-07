using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_714220059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Out(object sender, EventArgs e)
        {
            OutputLabel.Text = "Hello Word";
        }

        private void Hellobutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void x(object sender, EventArgs e)
        {

        }
    }
}
