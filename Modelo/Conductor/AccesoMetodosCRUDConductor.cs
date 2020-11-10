using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo.Vehiculo
{
   public class AccesoMetodosCRUDConductor
    {

        //operacion insert

        public int InsertConductor(int id, string nombre) 
        {

            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcedimientoAlmacInsert_c();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacINwsert_v(_comando);

        }
        //operacion SELECT
        public static DataTable ListConductor() 
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoSelect_c();
            _comando.CommandText = "select * From Tipo_Conductor";

            return MetodosCRUDConductor.EjecutarComandoSelect_c(_comando);
        
        }
        //operacion update

        public int UpdateConductor(int id, string nombre)
        {

            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcedimientoAlmacUpdate_c();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacUpdate_c(_comando);

        }

        public int DeleteConductor(int id)
        {

            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcedimientoAlmacDelete_c();
            _comando.Parameters.AddWithValue("@id", id);
           

            return MetodosCRUDConductor.EjecutarComandoProcAlmacDelete_c(_comando);

        }
    }
}
