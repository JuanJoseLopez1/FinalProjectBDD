
namespace LibraryProject
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListaLibros = new System.Windows.Forms.Button();
            this.btnRegistrarLibreria = new System.Windows.Forms.Button();
            this.btnFormRegistrarLibro = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnListaLibros);
            this.panel1.Controls.Add(this.btnRegistrarLibreria);
            this.panel1.Controls.Add(this.btnFormRegistrarLibro);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 426);
            this.panel1.TabIndex = 3;
            // 
            // btnListaLibros
            // 
            this.btnListaLibros.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListaLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaLibros.Location = new System.Drawing.Point(0, 55);
            this.btnListaLibros.Name = "btnListaLibros";
            this.btnListaLibros.Size = new System.Drawing.Size(188, 23);
            this.btnListaLibros.TabIndex = 2;
            this.btnListaLibros.Text = "Libros";
            this.btnListaLibros.UseVisualStyleBackColor = false;
            this.btnListaLibros.Click += new System.EventHandler(this.btnListaLibros_Click);
            // 
            // btnRegistrarLibreria
            // 
            this.btnRegistrarLibreria.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarLibreria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarLibreria.Location = new System.Drawing.Point(3, 104);
            this.btnRegistrarLibreria.Name = "btnRegistrarLibreria";
            this.btnRegistrarLibreria.Size = new System.Drawing.Size(188, 23);
            this.btnRegistrarLibreria.TabIndex = 1;
            this.btnRegistrarLibreria.Text = "Registrar Libreria";
            this.btnRegistrarLibreria.UseVisualStyleBackColor = false;
            this.btnRegistrarLibreria.Click += new System.EventHandler(this.btnRegistrarLibreria_Click);
            // 
            // btnFormRegistrarLibro
            // 
            this.btnFormRegistrarLibro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFormRegistrarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormRegistrarLibro.Location = new System.Drawing.Point(0, 154);
            this.btnFormRegistrarLibro.Name = "btnFormRegistrarLibro";
            this.btnFormRegistrarLibro.Size = new System.Drawing.Size(188, 23);
            this.btnFormRegistrarLibro.TabIndex = 0;
            this.btnFormRegistrarLibro.Text = "Registrar Libro";
            this.btnFormRegistrarLibro.UseVisualStyleBackColor = false;
            this.btnFormRegistrarLibro.Click += new System.EventHandler(this.btnFormRegistrarLibro_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Location = new System.Drawing.Point(206, 12);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(853, 436);
            this.panelFormularios.TabIndex = 4;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panel1);
            this.Name = "formPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarLibreria;
        private System.Windows.Forms.Button btnFormRegistrarLibro;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Button btnListaLibros;
    }
}

