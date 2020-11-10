using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Modelo.TipoVehiculo
{
    public class MetodosCRUDtipoVehiculo
    {

        //crear tipocomando 
        public static SqlCommand CrearComandoProcedimientoAlmacInsert_tv() 
        {

            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _Conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addTipoVehiculo",_Conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }

        //ejecutar el tipo de comando INSERT

        public static int EjecutarComandoProcAlmacINwsert_tv(SqlCommand comando) 
        {
        
        try
            {
                comando.Connection.Open();
                    return comando.ExecuteNonQuery();


            }
        catch { throw; }
            finally 
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //crear tipocomando SELECT
        public static SqlCommand CrearComandoSelect_tv()
        {
            //usar la conexion
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _Conexion = new SqlConnection();
            _Conexion.ConnectionString = _cadenaConexion;

            //crear la instruccion

            SqlCommand _comando = new SqlCommand();
            
            _comando = _Conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;

            return _comando;
        }

        //ejecutar el tipo de comando SELECT

        public static DataTable EjecutarComandoSelect_tv(SqlCommand comando)
        {
            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);
               


            }
            catch (Exception Ex){ throw Ex; }
            finally
            { comando.Connection.Close(); }

            return _table;
        }


        //crear comando UPDATE
        public static SqlCommand CrearComandoProcedimientoAlmacUpdate_tv()
        {

            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _Conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateTipoVehiculo", _Conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }

        //ejecutar el tipo de comando UPDATE

        public static int EjecutarComandoProcAlmacUpdate_tv(SqlCommand comando)
        {

            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();


            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //crear comando DELETE
        public static SqlCommand CrearComandoProcedimientoAlmacDelete_tv()
        {

            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _Conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteTipoVehiculo", _Conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }

        //ejecutar el tipo de comando DELETE

        public static int EjecutarComandoProcAlmacDelete_tv(SqlCommand comando)
        {

            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();


            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

    }

}
