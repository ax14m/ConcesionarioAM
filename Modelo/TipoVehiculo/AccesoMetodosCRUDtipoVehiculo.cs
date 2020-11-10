using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo.TipoVehiculo
{
   public class AccesoMetodosCRUDtipoVehiculo
    {

        //operacion insert

        public int InsertTipoVehiculo(int id, string nombre) 
        {

            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcedimientoAlmacInsert_tv();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacINwsert_tv(_comando);

        }
        //operacion SELECT
        public static DataTable ListTipoVehiculo() 
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tv();
            _comando.CommandText = "select * From Tipo_Vehiculo";

            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tv(_comando);
        
        }
        //operacion update

        public int UpdateTipoVehiculo(int id, string nombre)
        {

            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcedimientoAlmacUpdate_tv();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacUpdate_tv(_comando);

        }

        public int DeleteTipoVehiculo(int id)
        {

            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcedimientoAlmacDelete_tv();
            _comando.Parameters.AddWithValue("@id", id);
           

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacDelete_tv(_comando);

        }
    }
}
