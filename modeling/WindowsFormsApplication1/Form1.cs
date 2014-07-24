using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void do_generate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("generate graphic");
        }

        private void do_build_Click(object sender, EventArgs e)
        {
            MessageBox.Show("build variable row");
        }

        private void build_histogram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("build histogram");
        }
    }
}
