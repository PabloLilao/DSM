
using System;

namespace LugaresInteresGenNHibernate.EN.LugaresInteres
{
public partial class GrupoEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string descripcion;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario;

/**
 *
 */

private System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN actividad;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN Actividad {
        get { return actividad; } set { actividad = value;  }
}





public GrupoEN()
{
        comentario = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN>();
}



public GrupoEN(string nombre, string descripcion, LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario, LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN actividad)
{
        this.init (nombre, descripcion, usuario, comentario, actividad);
}


public GrupoEN(GrupoEN grupo)
{
        this.init (grupo.Nombre, grupo.Descripcion, grupo.Usuario, grupo.Comentario, grupo.Actividad);
}

private void init (string nombre, string descripcion, LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario, LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN actividad)
{
        this.Nombre = nombre;


        this.Descripcion = descripcion;

        this.Usuario = usuario;

        this.Comentario = comentario;

        this.Actividad = actividad;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        GrupoEN t = obj as GrupoEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
