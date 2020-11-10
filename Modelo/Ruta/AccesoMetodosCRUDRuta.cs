using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo.Ruta
{
   public class AccesoMetodosCRUDRuta
    {

        //operacion insert

        public int InsertRuta(int id, string nombre) 
        {

            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcedimientoAlmacInsert_R();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacINwsert_R(_comando);

        }
        //operacion SELECT
        public static DataTable ListRuta() 
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoSelect_R();
            _comando.CommandText = "select * From Tipo_Vehiculo";

            return MetodosCRUDRuta.EjecutarComandoSelect_R(_comando);
        
        }
        //operacion update

        public int UpdateRuta(int id, string nombre)
        {

            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcedimientoAlmacUpdate_R();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacUpdate_R(_comando);

        }

        public int DeleteRuta(int id)
        {

            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcedimientoAlmacDelete_R();
            _comando.Parameters.AddWithValue("@id", id);
           

            return MetodosCRUDRuta.EjecutarComandoProcAlmacDelete_R(_comando);

        }
    }
}
