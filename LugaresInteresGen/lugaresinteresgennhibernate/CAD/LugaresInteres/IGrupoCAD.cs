
using System;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial interface IGrupoCAD
{
GrupoEN ReadOIDDefault (string nombre);

string Crear (GrupoEN grupo);

void Modificar (GrupoEN grupo);


void Borrar (string nombre);


void Unirgrupo (string p_Grupo_OID, string p_usuario_OID);

void Salirgrupo (string p_Grupo_OID, string p_usuario_OID);
}
}
