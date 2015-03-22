
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
public partial class UsuarioCEN
{
public bool Login (string p_oid, String p_contrasenya)
{
        /*PROTECTED REGION ID(LugaresInteresGenNHibernate.CEN.LugaresInteres_Usuario_login) ENABLED START*/

        // Write here your custom code...
        bool resultado = false;

        UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (p_oid);

        if (en != null) {
                if (en.Contrasenya.Equals (Utils.Util.GetEncondeMD5 (p_contrasenya)))
                        resultado = true;
        }

        return resultado;


        //throw new NotImplementedException ("Method Login() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
