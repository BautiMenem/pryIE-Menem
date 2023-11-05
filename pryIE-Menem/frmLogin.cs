using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryIE_Menem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEntrar_Click(object sender, EventArgs e)
        {

            StreamWriter AD = new StreamWriter("logInicio", false);

            AD.WriteLine(txtUsuario.Text + "- Fecha -" + DateTime.Now );
            AD.Close();

            clsUsuarios clsUsuarios = new clsUsuarios();

            if (clsUsuarios.Validarusuarios(txtUsuario.Text, txtContraseña.Text))
            {
                this.Hide();
                frmInicio frminicio = new frmInicio();
                frminicio.lblUser.Text = txtUsuario.Text;
                frminicio.ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
