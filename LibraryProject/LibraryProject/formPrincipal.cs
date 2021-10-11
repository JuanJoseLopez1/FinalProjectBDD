using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.logica;


namespace LibraryProject
{
    public partial class formPrincipal : Form
    {


        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarLibreria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistrarLibreria>();
        }

        private void btnFormRegistrarLibro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistrarLibro>();
        }

        private void btnListaLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<consultarLibros>();
            // btnListaLibros.BackColor = Color.FromArgb(236, 112, 99);
        }

        //Metodo para abrir formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["RegistrarLibro"] == null)
                btnFormRegistrarLibro.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["ConsultarLibros"] == null)
                btnListaLibros.BackColor = Color.FromArgb(4, 41, 68);
            //if (Application.OpenForms["RegistrarLibro"] == null)
            //    btnFormRegistrarLibro.BackColor = Color.FromArgb(4, 41, 68);
        }


    }
}
