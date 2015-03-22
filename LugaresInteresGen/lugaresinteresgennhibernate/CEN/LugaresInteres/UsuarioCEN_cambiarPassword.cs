
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
public bool CambiarPassword (string p_oid, String antiguoPassword, String nuevoPassword, String repitePassword)
{
        /*PROTECTED REGION ID(LugaresInteresGenNHibernate.CEN.LugaresInteres_Usuario_cambiarPassword) ENABLED START*/

        // Write here your custom code...


        UsuarioEN usuario = _IUsuarioCAD.ReadOIDDefault (p_oid);
        String passvieja = Utils.Util.GetEncondeMD5 (antiguoPassword);

        bool cambiado = false;

        if (usuario != null) {
                if (!usuario.Contrasenya.Equals (passvieja)) {
                        Console.WriteLine ("\n LAS CONTRASEÑAS NO COINCIDEN \n");
                }
                if (usuario.Contrasenya.Equals (passvieja)) {
                        if (nuevoPassword.Equals (repitePassword)) {
                                usuario.Contrasenya = Utils.Util.GetEncondeMD5 (nuevoPassword);
                                cambiado = true;
                                _IUsuarioCAD.Modificar (usuario);
                        }
                }
                else { Console.WriteLine ("\n La nueva contraseña no coincide \n"); }
        }

        return cambiado;



        throw new NotImplementedException ("Method CambiarPassword() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
