using System;
using System.IO;
using System.Windows.Forms;

namespace pryIE_Menem
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void hora_Tick(object sender, EventArgs e)
        {
           
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }
        
        private void hora_Tick_1(object sender, EventArgs e)
        {
                lblHora.Text = DateTime.Now.ToString();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            StreamWriter AD = new StreamWriter("logInicio", false);

            AD.WriteLine(lblUser.Text + "- Fecha -" + DateTime.Now + " - Accede:" + Gestion.Text + ", "+ ListadoRep.Text);
            AD.Close();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
           
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivo A = new frmArchivo();
            A.ShowDialog();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro R = new frmRegistro();
            R.ShowDialog();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CrearUsuarios c = new CrearUsuarios();
            c.ShowDialog();
        }
    }

}
