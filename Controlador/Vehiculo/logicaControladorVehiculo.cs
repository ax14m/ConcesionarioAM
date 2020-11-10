using Modelo.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoVehiculo
{
    public class logicaControladorVehiculo
    {
        //negociar la inserccion INSERT
        public int NegociarInsertVehiculo(int id,string name)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();

                return negociarAcceso.InsertVehiculo(id, name);
        }
        //negociar SELECT

        public static DataTable NegociarSelectVehiculo()

        {
            return AccesoMetodosCRUDVehiculo.ListVehiculo();
        }
        //negociar la inserccion UPDATE
        public int NegociarUpdatetVehiculo(int id, string name)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();

            return negociarAcceso.UpdateVehiculo(id, name);
        }


        //negociar la inserccion DELETE
        public int NegociarDeleteVehiculo(int id)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();

            return negociarAcceso.DeleteVehiculo(id);
        }
    }
}
