
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
public partial class ComentarioCEN
{
public LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN CrearComentario (string p_texto, string p_usuario)
{
        /*PROTECTED REGION ID(LugaresInteresGenNHibernate.CEN.LugaresInteres_Comentario_crearComentario) ENABLED START*/

        // Write here your custom code...

        ComentarioCEN aCEN = new ComentarioCEN (_IComentarioCAD);
        int oid = 0;

        if (p_usuario != null) { //FALTA COMPROBAR QUE EL USUARIO ESTA EN LA BD
                oid = aCEN.Crear (p_texto, DateTime.Now, p_usuario, Enumerated.LugaresInteres.ReporteEnum.Publicado);
        }
        if (oid != 0) {
                return _IComentarioCAD.ReadOIDDefault (oid);
        }
        else return null;


        throw new NotImplementedException ("Method CrearComentario() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
