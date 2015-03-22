

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
public partial class GrupoCEN
{
private IGrupoCAD _IGrupoCAD;

public GrupoCEN()
{
        this._IGrupoCAD = new GrupoCAD ();
}

public GrupoCEN(IGrupoCAD _IGrupoCAD)
{
        this._IGrupoCAD = _IGrupoCAD;
}

public IGrupoCAD get_IGrupoCAD ()
{
        return this._IGrupoCAD;
}

public string Crear (string p_nombre, string p_descripcion, string p_usuario, string p_actividad)
{
        GrupoEN grupoEN = null;
        string oid;

        //Initialized GrupoEN
        grupoEN = new GrupoEN ();
        grupoEN.Nombre = p_nombre;

        grupoEN.Descripcion = p_descripcion;


        if (p_usuario != null) {
                grupoEN.Usuario = new LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN ();
                grupoEN.Usuario.Email = p_usuario;
        }


        if (p_actividad != null) {
                grupoEN.Actividad = new LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN ();
                grupoEN.Actividad.Tipo = p_actividad;
        }

        //Call to GrupoCAD

        oid = _IGrupoCAD.Crear (grupoEN);
        return oid;
}

public void Modificar (string p_Grupo_OID, string p_descripcion)
{
        GrupoEN grupoEN = null;

        //Initialized GrupoEN
        grupoEN = new GrupoEN ();
        grupoEN.Nombre = p_Grupo_OID;
        grupoEN.Descripcion = p_descripcion;
        //Call to GrupoCAD

        _IGrupoCAD.Modificar (grupoEN);
}

public void Borrar (string nombre)
{
        _IGrupoCAD.Borrar (nombre);
}

public void Unirgrupo (string p_Grupo_OID, string p_usuario_OID)
{
        //Call to GrupoCAD

        _IGrupoCAD.Unirgrupo (p_Grupo_OID, p_usuario_OID);
}
public void Salirgrupo (string p_Grupo_OID, string p_usuario_OID)
{
        //Call to GrupoCAD

        _IGrupoCAD.Salirgrupo (p_Grupo_OID, p_usuario_OID);
}
}
}
