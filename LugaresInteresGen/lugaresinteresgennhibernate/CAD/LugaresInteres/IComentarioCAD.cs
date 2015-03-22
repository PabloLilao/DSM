
using System;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id);

int Crear (ComentarioEN comentario);

void Modificar (ComentarioEN comentario);


void Borrar (int id);


void Asignargrupo (int p_Comentario_OID, string p_grupo_OID);

void Asignarlugar (int p_Comentario_OID, string p_lugar_OID);
}
}
