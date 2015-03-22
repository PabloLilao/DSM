
using System;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial interface ILugarCAD
{
LugarEN ReadOIDDefault (string nombre);

string Nuevo (LugarEN lugar);

void Modificar (LugarEN lugar);


void Borrar (string nombre);



System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarLugarNombre (string p_nombre);


System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarLugarLocalidad (string p_poblacion);


System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarNoValidados ();


System.Collections.Generic.IList<LugarEN> DameTodos (int first, int size);
}
}
