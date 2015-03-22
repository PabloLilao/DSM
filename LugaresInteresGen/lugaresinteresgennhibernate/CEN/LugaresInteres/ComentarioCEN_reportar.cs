
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
public bool Reportar (int p_oid)
{
        /*PROTECTED REGION ID(LugaresInteresGenNHibernate.CEN.LugaresInteres_Comentario_reportar) ENABLED START*/

        // Write here your custom code...
        Boolean reportado = false;

        if (p_oid != null) {
                ComentarioEN en = _IComentarioCAD.ReadOIDDefault (p_oid);
                if (en.State == Enumerated.LugaresInteres.ReporteEnum.Publicado) {
                        en.State = Enumerated.LugaresInteres.ReporteEnum.Reportado;
                        reportado = true;
                        _IComentarioCAD.Modificar (en);
                }
        }
        return reportado;


        throw new NotImplementedException ("Method Reportar() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
