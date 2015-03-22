
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using LugaresInteresGenNHibernate.EN.LugaresInteres;
using LugaresInteresGenNHibernate.CAD.LugaresInteres;

namespace LugaresInteresGenNHibernate.CEN.LugaresInteres
{
public partial class LugarCEN
{
public LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN CrearLugar (string p_nombre, string p_tipo, string p_ubicacion, string p_descripcion, string p_poblacion, System.Collections.Generic.IList<string> p_foto)
{
        /*PROTECTED REGION ID(LugaresInteresGenNHibernate.CEN.LugaresInteres_Lugar_crearLugar) ENABLED START*/

        // Write here your custom code...
        string oid = null;


        if (p_nombre != null && p_nombre != "" && p_nombre != " "
            && p_tipo != null && p_tipo != "" && p_tipo != " "
            && p_poblacion != null && p_poblacion != "" && p_poblacion != " "
            /*&& p_foto != null && p_foto != "" && p_foto != " "*/
            && p_ubicacion != null && p_ubicacion != "" && p_ubicacion != " "
            && p_descripcion != null && p_descripcion != "" && p_descripcion != " ") {
                LugarCEN aCEN = new LugarCEN (_ILugarCAD);

                //System.Collections.Generic.IList<String> fotos = new System.Collections.Generic.List<String>();

                oid = aCEN.Nuevo (p_nombre, p_tipo, p_ubicacion, p_descripcion, p_poblacion, p_foto, false);
        }


        if (oid != null) {
                return _ILugarCAD.ReadOIDDefault (oid);
        }
        else return null;



        throw new NotImplementedException ("Method CrearLugar() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
