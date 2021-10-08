using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace LibraryProject.datos
{
    class Datos
    {
        //Conexion a oracle
        OracleConnection ora_con = new OracleConnection(@"Data Source=LOCALHOST;User ID=bases;Password=oracle");

        public DataSet getAllBooks()
        {
            try
            {
                ora_con.Open();

                OracleCommand ora_cmd = new OracleCommand("bases.consultarlibros", ora_con);
                ora_cmd.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Libro");
                return ds;
            }
            finally {

                if (ora_con.State == ConnectionState.Open)
                {
                    ora_con.Close(); 
                }
            }

        }

    }
}
