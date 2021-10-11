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

        public int insertBook(String parCodigo, String parTitulo, String parNumPag, String parCategoria, String parFecha, float parPrecio, String parNitLibreria)
        {
            return objectDatos.insertBook(parCodigo,parTitulo,parNumPag,parCategoria,parFecha,parPrecio,parNitLibreria);
        }

        public int deleteBook(String parCodigo)
        {
            return objectDatos.deleteBook(parCodigo);
        }

        public DataSet searchBook(String parCodigo)
        {
            DataSet objectLibro;
            return objectLibro = objectDatos.getBook(parCodigo);
        }
    }
}
