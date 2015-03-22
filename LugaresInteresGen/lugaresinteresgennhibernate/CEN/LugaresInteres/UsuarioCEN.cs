

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
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string Registro (string p_email, string p_nombre, string p_apellidos, String p_contrasenya, string p_poblacion, string p_foto)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_email;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);

        usuarioEN.Poblacion = p_poblacion;

        usuarioEN.Foto = p_foto;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.Registro (usuarioEN);
        return oid;
}

public void Modificar (string p_Usuario_OID, string p_nombre, string p_apellidos, String p_contrasenya, string p_poblacion, string p_foto)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);
        usuarioEN.Poblacion = p_poblacion;
        usuarioEN.Foto = p_foto;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modificar (usuarioEN);
}

public void Borrarcuenta (string email)
{
        _IUsuarioCAD.Borrarcuenta (email);
}

public System.Collections.Generic.IList<UsuarioEN> DameTodos (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.DameTodos (first, size);
        return list;
}
}
}
