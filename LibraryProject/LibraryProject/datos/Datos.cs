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

        private void closeConecction()
        {
            if (ora_con.State == ConnectionState.Open)
            {
                ora_con.Close();
            }
        }
        public DataSet getAllBooks()
        {
            try
            {
                ora_con.Open();

                OracleCommand ora_cmd = new OracleCommand("bases.consultar_libros", ora_con);
                ora_cmd.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Libro");
                return ds;
            }
            finally
            {
                closeConecction();
            }

        }

        public DataSet getBook(String parCodigo)
        {
            try
            {
                ora_con.Open();

                OracleCommand ora_cmd = new OracleCommand("bases.buscar_libro", ora_con);
                ora_cmd.Parameters.Add("P_CODIGO", OracleDbType.Varchar2, parCodigo, ParameterDirection.Input);
                ora_cmd.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "LibroE");
                return ds;
            }
            finally
            {
                closeConecction();
            }
        }

        public DataSet getNit_Library()
        {
            try
            {
                ora_con.Open();

                OracleCommand ora_cmd = new OracleCommand("bases.consultar_nit", ora_con);
                ora_cmd.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Librerias");
                return ds;
            }
            finally
            {
                closeConecction();
            }
        }

        public int insertBook(String parCodigo, String parTitulo, String parNumP, String parCategoria, String parFecha, float parPrecio, String parNit)
        {
            int filasAfectadas = 0;
            try
            {
                ora_con.Open();

                OracleCommand ora_cmd = new OracleCommand("bases.insertar_libro", ora_con);
                ora_cmd.CommandType = System.Data.CommandType.StoredProcedure;

                ora_cmd.Parameters.Add("P_CODIGO", OracleDbType.Varchar2, parCodigo, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_TITULO", OracleDbType.Varchar2, parTitulo, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_NPAG", OracleDbType.Varchar2, parNumP, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_CATEGORIA", OracleDbType.Varchar2, parCategoria, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_FECHA", OracleDbType.Varchar2, parFecha, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_PRECIO", OracleDbType.Decimal, parPrecio, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_NIT", OracleDbType.Varchar2, parNit, ParameterDirection.Input);

                return filasAfectadas = ora_cmd.ExecuteNonQuery();

            }
            catch
            {
                return 0;
            }

            finally
            {
                closeConecction();
            }

        }

        public int insertLibrary(String parNit, String parNombre, String parDir)
        {
            int filasAfectadas = 0;
            try
            {
                ora_con.Open();

                OracleCommand ora_cmd = new OracleCommand("bases.insertar_libreria", ora_con);
                ora_cmd.CommandType = System.Data.CommandType.StoredProcedure;

                ora_cmd.Parameters.Add("P_NIT", OracleDbType.Varchar2, parNit, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2, parNombre, ParameterDirection.Input);
                ora_cmd.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2, parDir, ParameterDirection.Input);

                return filasAfectadas = ora_cmd.ExecuteNonQuery();

            }
            catch
            {
                return 0;
            }
            finally
            {
                closeConecction();
            }
        }

        public int deleteBook(String parCodigo)
        {
            int filasAfectadas = 0;
            try
            {
                ora_con.Open();

                OracleCommand ora_cmd = new OracleCommand("bases.eliminar_libro", ora_con);
                ora_cmd.CommandType = CommandType.StoredProcedure;

                ora_cmd.Parameters.Add("P_CODIGO", OracleDbType.Varchar2, parCodigo, ParameterDirection.Input);
                //ora_cmd.Parameters.Add("P_CODIGO", OracleDbType.Varchar2).Value = parCodigo;

                return filasAfectadas = ora_cmd.ExecuteNonQuery();

            }
            catch
            {
                return 0;
            }
            finally
            {
                closeConecction();
            }
        }
    }
}
