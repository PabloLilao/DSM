
using System;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string email);

string Nuevo (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Borrar (string email);
}
}
