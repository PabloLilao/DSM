
using System;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string email);

string Registro (UsuarioEN usuario);


void Modificar (UsuarioEN usuario);


void Borrarcuenta (string email);



System.Collections.Generic.IList<UsuarioEN> DameTodos (int first, int size);
}
}
