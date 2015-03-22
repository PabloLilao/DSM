
using System;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial interface IActividadCAD
{
ActividadEN ReadOIDDefault (string Tipo);

string Nueva (ActividadEN actividad);

void Modify (ActividadEN actividad);


void Borrar (string Tipo);


System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN> BuscarActividad (LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum p_tipo);


System.Collections.Generic.IList<ActividadEN> DameTodasActividades (int first, int size);
}
}
