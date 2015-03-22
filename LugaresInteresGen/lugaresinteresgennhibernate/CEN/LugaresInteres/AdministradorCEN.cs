

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
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string Nuevo (string p_email, String p_contraseña)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Email = p_email;

        administradorEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.Nuevo (administradorEN);
        return oid;
}

public void Modify (string p_Administrador_OID, String p_contraseña)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Email = p_Administrador_OID;
        administradorEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Borrar (string email)
{
        _IAdministradorCAD.Borrar (email);
}
}
}
