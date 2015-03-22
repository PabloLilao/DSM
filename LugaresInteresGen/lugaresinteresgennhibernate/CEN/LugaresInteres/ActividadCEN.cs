

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
public partial class ActividadCEN
{
private IActividadCAD _IActividadCAD;

public ActividadCEN()
{
        this._IActividadCAD = new ActividadCAD ();
}

public ActividadCEN(IActividadCAD _IActividadCAD)
{
        this._IActividadCAD = _IActividadCAD;
}

public IActividadCAD get_IActividadCAD ()
{
        return this._IActividadCAD;
}

public string Nueva (string p_Tipo, string p_Descripcion)
{
        ActividadEN actividadEN = null;
        string oid;

        //Initialized ActividadEN
        actividadEN = new ActividadEN ();
        actividadEN.Tipo = p_Tipo;

        actividadEN.Descripcion = p_Descripcion;

        //Call to ActividadCAD

        oid = _IActividadCAD.Nueva (actividadEN);
        return oid;
}

public void Modify (string p_Actividad_OID, string p_Descripcion)
{
        ActividadEN actividadEN = null;

        //Initialized ActividadEN
        actividadEN = new ActividadEN ();
        actividadEN.Tipo = p_Actividad_OID;
        actividadEN.Descripcion = p_Descripcion;
        //Call to ActividadCAD

        _IActividadCAD.Modify (actividadEN);
}

public void Borrar (string Tipo)
{
        _IActividadCAD.Borrar (Tipo);
}

public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN> BuscarActividad (LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum p_tipo)
{
        return _IActividadCAD.BuscarActividad (p_tipo);
}
public System.Collections.Generic.IList<ActividadEN> DameTodasActividades (int first, int size)
{
        System.Collections.Generic.IList<ActividadEN> list = null;

        list = _IActividadCAD.DameTodasActividades (first, size);
        return list;
}
}
}
