using LibraryProject.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibraryProject.logica
{
    class Libro
    {
        Datos objectDatos = new Datos();

        public DataSet getAllBooks()
        {
            DataSet objectLibros;
            objectLibros = objectDatos.getAllBooks();
            return objectLibros;

        }
    }
}
