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
    public partial class consultarLibros : Form
    {
        private static String varCodigoLibro = "";
        Libro objectLibro = new Libro();

        public consultarLibros()
        {
            InitializeComponent();
            actualizarListaLibros();
        }

        private void actualizarListaLibros()
        {
            DataSet dt = new DataSet();
            dt = objectLibro.getAllBooks();
            dgvLibros.DataSource = dt;
            dgvLibros.DataMember = "Libro";
        }

        private void btnConsultarLibros_Click(object sender, EventArgs e)
        {
            actualizarListaLibros();
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            varCodigoLibro = dgvLibros.CurrentRow.Cells[0].Value.ToString();
            lblCodigoLibro_Eliminar.Text = varCodigoLibro;

        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (varCodigoLibro != "")
            {
                int varFilasAfectadas = objectLibro.deleteBook(varCodigoLibro);

                if (varFilasAfectadas == -1)
                {
                    MessageBox.Show("Libro eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar un libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No haz seleccionado ningun libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNit.Text != "")
            {
                DataSet dt = new DataSet();
                dt = objectLibro.searchBook(txtNit.Text);
                dgvLibros.DataSource = dt;
                dgvLibros.DataMember = "LibroE";

            }
            else
            {
                MessageBox.Show("Ingresa un nit", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarListaLibros();
            }
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }

}


