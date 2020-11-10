using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo.TipoConductor
{
   public class AccesoMetodosCRUDtipoConductor
    {

        //operacion insert

        public int InsertTipoConductor(int id, string nombre) 
        {

            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcedimientoAlmacInsert_tc();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacINwsert_tc(_comando);

        }
        //operacion SELECT
        public static DataTable ListTipoConductor() 
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoSelect_tc();
            _comando.CommandText = "select * From Tipo_Vehiculo";

            return MetodosCRUDtipoConductor.EjecutarComandoSelect_tc(_comando);
        
        }
        //operacion update

        public int UpdateTipoConductor(int id, string nombre)
        {

            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcedimientoAlmacUpdate_tc();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacUpdate_tc(_comando);

        }

        public int DeleteTipoVehiculo(int id)
        {

            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcedimientoAlmacDelete_tv();
            _comando.Parameters.AddWithValue("@id", id);
           

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacDelete_tc(_comando);

        }
    }
}
