using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo.Vehiculo
{
   public class AccesoMetodosCRUDVehiculo
    {

        //operacion insert

        public int InsertVehiculo(int id, string nombre) 
        {

            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcedimientoAlmacInsert_v();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacINwsert_v(_comando);

        }
        //operacion SELECT
        public static DataTable ListVehiculo() 
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoSelect_v();
            _comando.CommandText = "select * From Tipo_Vehiculo";

            return MetodosCRUDVehiculo.EjecutarComandoSelect_v(_comando);
        
        }
        //operacion update

        public int UpdateVehiculo(int id, string nombre)
        {

            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcedimientoAlmacUpdate_v();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacUpdate_v(_comando);

        }

        public int DeleteVehiculo(int id)
        {

            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcedimientoAlmacDelete_v();
            _comando.Parameters.AddWithValue("@id", id);
           

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacDelete_v(_comando);

        }
    }
}
