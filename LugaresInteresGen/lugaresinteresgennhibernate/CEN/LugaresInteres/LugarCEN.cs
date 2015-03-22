

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
private ILugarCAD _ILugarCAD;

public LugarCEN()
{
        this._ILugarCAD = new LugarCAD ();
}

public LugarCEN(ILugarCAD _ILugarCAD)
{
        this._ILugarCAD = _ILugarCAD;
}

public ILugarCAD get_ILugarCAD ()
{
        return this._ILugarCAD;
}

public string Nuevo (string p_nombre, string p_tipo, string p_ubicacion, string p_descripcion, string p_poblacion, System.Collections.Generic.IList<string> p_foto, bool p_validar)
{
        LugarEN lugarEN = null;
        string oid;

        //Initialized LugarEN
        lugarEN = new LugarEN ();
        lugarEN.Nombre = p_nombre;

        lugarEN.Tipo = p_tipo;

        lugarEN.Ubicacion = p_ubicacion;

        lugarEN.Descripcion = p_descripcion;

        lugarEN.Poblacion = p_poblacion;

        lugarEN.Foto = p_foto;

        lugarEN.Validar = p_validar;

        //Call to LugarCAD

        oid = _ILugarCAD.Nuevo (lugarEN);
        return oid;
}

public void Modificar (string p_Lugar_OID, string p_tipo, string p_ubicacion, string p_descripcion, string p_poblacion, System.Collections.Generic.IList<string> p_foto, bool p_validar)
{
        LugarEN lugarEN = null;

        //Initialized LugarEN
        lugarEN = new LugarEN ();
        lugarEN.Nombre = p_Lugar_OID;
        lugarEN.Tipo = p_tipo;
        lugarEN.Ubicacion = p_ubicacion;
        lugarEN.Descripcion = p_descripcion;
        lugarEN.Poblacion = p_poblacion;
        lugarEN.Foto = p_foto;
        lugarEN.Validar = p_validar;
        //Call to LugarCAD

        _ILugarCAD.Modificar (lugarEN);
}

public void Borrar (string nombre)
{
        _ILugarCAD.Borrar (nombre);
}

public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarLugarNombre (string p_nombre)
{
        return _ILugarCAD.BuscarLugarNombre (p_nombre);
}
public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarLugarLocalidad (string p_poblacion)
{
        return _ILugarCAD.BuscarLugarLocalidad (p_poblacion);
}
public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarNoValidados ()
{
        return _ILugarCAD.BuscarNoValidados ();
}
public System.Collections.Generic.IList<LugarEN> DameTodos (int first, int size)
{
        System.Collections.Generic.IList<LugarEN> list = null;

        list = _ILugarCAD.DameTodos (first, size);
        return list;
}
}
}
