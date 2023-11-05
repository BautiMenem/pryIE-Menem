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
    public partial class CrearUsuarios : Form
    {

        private bool dibujando = false;
        private Point puntoAnterior;
        private Pen lapiz = new Pen(Color.Black, 2);
        private Bitmap lienzo;
        public CrearUsuarios()
        {
            InitializeComponent();
            lienzo = new Bitmap(pbFirmas.Width, pbFirmas.Height);
            pbFirmas.Image = lienzo;

            pbFirmas.MouseDown += pbFirmas_MouseDown;
            pbFirmas.MouseMove += pbFirmas_MouseMove;
            pbFirmas.MouseUp += pbFirmas_MouseUp;

        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtPass.PasswordChar = '*';
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            
        }


        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
        private void pbFirma_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void pbFirma_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            clsUsuarios us = new clsUsuarios();
            us.RegistrarUsuario(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtPass.Text, pbFirmas);

        }

        private void pbFirmas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = false;
            }
        }

        private void pbFirmas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics g = Graphics.FromImage(lienzo))
                {
                    g.DrawLine(lapiz, puntoAnterior, e.Location);
                }
                puntoAnterior = e.Location;
                pbFirmas.Invalidate();
            }
        }

        private void pbFirmas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(lienzo, Point.Empty);
        }

        private void pbFirmas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = true;
                puntoAnterior = e.Location;
            }
        }
    }
}
