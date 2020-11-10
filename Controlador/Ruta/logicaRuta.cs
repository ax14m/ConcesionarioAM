using Modelo.Ruta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Ruta

{
    public class logicaControladorRuta
    {
        //negociar la inserccion INSERT
        public int NegociarInsertRuta(int id,string name)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

                return negociarAcceso.InsertRuta(id, name);
        }
        //negociar SELECT

        public static DataTable NegociarSelectRuta()

        {
            return AccesoMetodosCRUDRuta.ListRuta();
        }
        //negociar la inserccion UPDATE
        public int NegociarUpdateRuta(int id, string name)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.UpdateRuta(id, name);
        }


        //negociar la inserccion DELETE
        public int NegociarDeleteRuta(int id)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.DeleteRuta(id);
        }
    }
}
