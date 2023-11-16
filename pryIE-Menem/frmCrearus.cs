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
    public partial class frmCrearus : Form
    {
        private bool drawing;
        private Point previusPoint;
        private Bitmap drawingBitMap;

        public frmCrearus()
        {
            InitializeComponent();
            InitializeDrawing();
        }

        private void InitializeDrawing()
        {
            drawingBitMap = new Bitmap(pbFirmas.Width, pbFirmas.Height);
            pbFirmas.Image = drawingBitMap;
        }

        private void pbFirmas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = Graphics.FromImage(drawingBitMap))
                {
                    g.DrawLine(new Pen(Color.Black, 2), previusPoint, e.Location);
                }

                pbFirmas.Invalidate();
                previusPoint = e.Location;
            }
        }

        private void pbFirmas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void pbFirmas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            previusPoint = e.Location;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            clsUsuarios objCls = new clsUsuarios();

            Image firma = pbFirmas.Image;

            objCls.RegistrarUsuario(txtUsuario.Text, txtApellido.Text, txtNombre.Text, txtPass.Text, firma);
        }

        private void frmCrearus_Load(object sender, EventArgs e)
        {

        }
    }
}
