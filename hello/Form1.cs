using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class textboxname : Form
    {
        public textboxname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome to " + txtBxName.Text + "program");
            MessageBox.Show("hello " + txtBxName.Text + txtBxName2);
        }
    }
}