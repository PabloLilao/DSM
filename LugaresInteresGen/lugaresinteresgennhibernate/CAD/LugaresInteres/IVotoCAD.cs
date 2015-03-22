
using System;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial interface IVotoCAD
{
VotoEN ReadOIDDefault (int id);

int Votacion (VotoEN voto);

void Cambiarvoto (VotoEN voto);


void Borrar (int id);
}
}
