using LibraryProject.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.logica
{
    class Libreria
    {

        Datos objectDatos = new Datos();

        public DataSet getLibrarys()
        {
            DataSet objLibreria;
            objLibreria = objectDatos.getNit_Library();
            return objLibreria;
        }

        public int insertLibrary(String parNit, String parNombre, String parDir)
        {
            return objectDatos.insertLibrary(parNit,parNombre,parDir);
        }
    }
}
