using LibraryProject.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class RegistrarLibro : Form
    {

        Libro objectLibro = new Libro();
        Libreria objectLibreria = new Libreria();

        private static String varNitLibreria = "";

        public RegistrarLibro()
        {
            InitializeComponent();
            consultarLibrerias();
        }

        private void consultarLibrerias()
        {
            DataSet dt = new DataSet();
            dt = objectLibreria.getLibrarys();
            dgvLibrerias_RegistroLibro.DataSource = dt;
            dgvLibrerias_RegistroLibro.DataMember = "Librerias";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String varCodigo = txtCodigo.Text;
            String varNombre = txtTitulo.Text;
            String varFecha = dtpFecha.Value.ToShortDateString();
            String varNumPag = txtNumPag.Text;
            String varCategoria = cmbCategoria.Text;
            String varAux = txtPrecio.Text;
            float varPrecio = 0;
            try
            {
                varPrecio = float.Parse(varAux);
            }
            catch (Exception)
            {

            }
            int varFilasAfectadas = 0;

            if (varCodigo != "" && varNombre != "" && varFecha != "" && varNumPag != "" && varCategoria != "" && varAux != "" && varPrecio != 0 && varNitLibreria != "")
            {
                varFilasAfectadas = objectLibro.insertBook(varCodigo, varNombre, varNumPag, varCategoria, varFecha, varPrecio, varNitLibreria);
                if (varFilasAfectadas == -1)
                {
                    MessageBox.Show("Libro registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("LLena todos los campos obligatorios.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvLibrerias_RegistroLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            varNitLibreria = dgvLibrerias_RegistroLibro.CurrentRow.Cells[0].Value.ToString();
            lblNitSeleccionado.Text = varNitLibreria;

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo Numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo Letras
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtNumPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            consultarLibrerias();
        }
    }
}
