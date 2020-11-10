using Modelo.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoVehiculo
{
    public class logicaControladorTipoVehiculo
    {
        //negociar la inserccion INSERT
        public int NegociarInsertTipoVehiculo(int id,string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

                return negociarAcceso.InsertTipoVehiculo(id, name);
        }
        //negociar SELECT

        public static DataTable NegociarSelectTipoVehiculo()

        {
            return AccesoMetodosCRUDtipoVehiculo.ListTipoVehiculo();
        }
        //negociar la inserccion UPDATE
        public int NegociarUpdatetTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.UpdateTipoVehiculo(id, name);
        }


        //negociar la inserccion DELETE
        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.DeleteTipoVehiculo(id);
        }
    }
}
