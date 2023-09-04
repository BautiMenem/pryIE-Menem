using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIE_Menem
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont += 1000;
            if (cont > 3000)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                timer1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
