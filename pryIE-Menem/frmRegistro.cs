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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        clsProveedor ObjP = new clsProveedor();
        private void lblLiquidador_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = txtNExp.Text;
            string juzgado = cboJusg.Text;
            string juris = cboJurisdiccion.Text;
            string liqui = cboLiquidador.Text;
            string direccion = txtDireccion.Text;


            try
            {
                ObjP.Registrar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                limpiarGrilla();
                ObjP.CargarCombo(dgvProveedores, cboJusg, cboJurisdiccion, cboLiquidador);
                btnCargar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            ObjP.CargarCombo(dgvProveedores, cboJusg, cboJurisdiccion, cboLiquidador);
        }

        private void dgvProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProveedores.Rows[e.RowIndex];

                string numeroRegistro = selectedRow.Cells[0].Value.ToString();
                string entidad = selectedRow.Cells[1].Value.ToString();
                DateTime apertura = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                string numExpediente = selectedRow.Cells[3].Value.ToString();
                string juzgado = selectedRow.Cells[4].Value.ToString();
                string jurisdiccion = selectedRow.Cells[5].Value.ToString();
                string direccion = selectedRow.Cells[6].Value.ToString();
                string responsable = selectedRow.Cells[7].Value.ToString();

                txtNumero.Text = numeroRegistro;
                txtEntidad.Text = entidad;
                dtpApertura.Value = apertura;
                txtNExp.Text = numExpediente;
                cboJusg.Text = juzgado;
                cboJurisdiccion.Text = jurisdiccion;
                txtDireccion.Text = direccion;
                cboLiquidador.Text = responsable;

                txtNumero.ReadOnly = true;
                btnEditar.Enabled = true;
                btnCargar.Enabled = false;
                btnEliminar.Enabled = true;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != null && txtEntidad.Text != null && txtNExp.Text != null && txtDireccion.Text != null && cboLiquidador.SelectedIndex != -1 && cboJusg.SelectedIndex != -1 && cboJurisdiccion.SelectedIndex != -1)
            {
                btnCargar.Enabled = true;
            }
        }

        private void Limpiar()
        {
            txtDireccion.Text = "";
            txtEntidad.Text = "";
            txtNExp.Text = "";
            txtNumero.Text = "";
            cboJurisdiccion.SelectedIndex = -1;
            cboJusg.SelectedIndex = -1;
            cboLiquidador.SelectedIndex = -1;
        }

        private void limpiarGrilla()
        {
            dgvProveedores.Rows.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmación", MessageBoxButtons.YesNo);
            int numero = Convert.ToInt32(txtNumero.Text);

            if (pregunta == DialogResult.Yes)
            {
                ObjP.Eliminar(numero);
                limpiarGrilla();
                ObjP.CargarCombo(dgvProveedores, cboJusg, cboJurisdiccion, cboLiquidador);
                Limpiar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = txtNExp.Text;
            string juzgado = cboJusg.Text;
            string juris = cboJurisdiccion.Text;
            string liqui = cboLiquidador.Text;
            string direccion = txtDireccion.Text;


            try
            {
                ObjP.Modificar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                limpiarGrilla();
                ObjP.CargarCombo(dgvProveedores, cboJusg, cboJurisdiccion, cboLiquidador);
                btnCargar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
        }
    }
}
