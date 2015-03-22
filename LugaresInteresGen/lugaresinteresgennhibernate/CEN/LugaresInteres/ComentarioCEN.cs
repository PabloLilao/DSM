

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
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int Crear (string p_texto, Nullable<DateTime> p_fecha, string p_usuario, LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ReporteEnum p_state)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Texto = p_texto;

        comentarioEN.Fecha = p_fecha;


        if (p_usuario != null) {
                comentarioEN.Usuario = new LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN ();
                comentarioEN.Usuario.Email = p_usuario;
        }

        comentarioEN.State = p_state;

        //Call to ComentarioCAD

        oid = _IComentarioCAD.Crear (comentarioEN);
        return oid;
}

public void Modificar (int p_Comentario_OID, string p_texto, Nullable<DateTime> p_fecha, LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ReporteEnum p_state)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Texto = p_texto;
        comentarioEN.Fecha = p_fecha;
        comentarioEN.State = p_state;
        //Call to ComentarioCAD

        _IComentarioCAD.Modificar (comentarioEN);
}

public void Borrar (int id)
{
        _IComentarioCAD.Borrar (id);
}

public void Asignargrupo (int p_Comentario_OID, string p_grupo_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.Asignargrupo (p_Comentario_OID, p_grupo_OID);
}
public void Asignarlugar (int p_Comentario_OID, string p_lugar_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.Asignarlugar (p_Comentario_OID, p_lugar_OID);
}
}
}
