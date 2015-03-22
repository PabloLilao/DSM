
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
public bool Validar (string p_oid)
{
        /*PROTECTED REGION ID(LugaresInteresGenNHibernate.CEN.LugaresInteres_Lugar_validar) ENABLED START*/

        // Write here your custom code...

        Boolean validado = false;

        if (p_oid != null && p_oid != "" && p_oid != " ") {
                LugarEN en = _ILugarCAD.ReadOIDDefault (p_oid);
                if (en.Validar == false && en != null) {
                        Console.WriteLine (en.Validar);
                        validado = true;
                        en.Validar = true;
                        _ILugarCAD.Modificar (en);
                        Console.WriteLine (en.Validar);
                }
        }
        return validado;

        throw new NotImplementedException ("Method Validar() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
