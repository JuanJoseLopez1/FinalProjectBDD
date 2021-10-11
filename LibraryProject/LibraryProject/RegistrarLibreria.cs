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
    public partial class RegistrarLibreria : Form
    {
        Libreria objLibreria = new Libreria();
        public RegistrarLibreria()
        {
            InitializeComponent();
        }

        private void btnRegistrarLibreria_Click(object sender, EventArgs e)
        {
            String varNit = txtNit.Text;
            String varNombre = txtNombre.Text;
            String varDireccion = txtDireccion.Text;

            int varFilasAfectadas = 0;

            if (varNit != "" && varNombre != "" && varDireccion != "")
            {
                varFilasAfectadas = objLibreria.insertLibrary(varNit, varNombre, varDireccion);

                if (varFilasAfectadas == -1)
                {
                    MessageBox.Show("Libreria registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar la libreria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Llena todos campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {          
            // Solo letras
            if ((e.KeyChar >= 33 && e.KeyChar <= 64)  || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;                
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Letras, numeros y -,.#
            if ((e.KeyChar >= 33 && e.KeyChar <= 34) || (e.KeyChar >= 36 && e.KeyChar <= 43) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
