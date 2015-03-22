
using System;

namespace LugaresInteresGenNHibernate.EN.LugaresInteres
{
public partial class ComentarioEN
{
/**
 *
 */

private int id;

/**
 *
 */

private string texto;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN lugar;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN grupo;

/**
 *
 */

private LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ReporteEnum state;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN administrador;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string Texto {
        get { return texto; } set { texto = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN Lugar {
        get { return lugar; } set { lugar = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN Grupo {
        get { return grupo; } set { grupo = value;  }
}


public virtual LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ReporteEnum State {
        get { return state; } set { state = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}





public ComentarioEN()
{
}



public ComentarioEN(int id, string texto, Nullable<DateTime> fecha, LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN lugar, LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario, LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN grupo, LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ReporteEnum state, LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN administrador)
{
        this.init (id, texto, fecha, lugar, usuario, grupo, state, administrador);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (comentario.Id, comentario.Texto, comentario.Fecha, comentario.Lugar, comentario.Usuario, comentario.Grupo, comentario.State, comentario.Administrador);
}

private void init (int id, string texto, Nullable<DateTime> fecha, LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN lugar, LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario, LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN grupo, LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ReporteEnum state, LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN administrador)
{
        this.Id = id;


        this.Texto = texto;

        this.Fecha = fecha;

        this.Lugar = lugar;

        this.Usuario = usuario;

        this.Grupo = grupo;

        this.State = state;

        this.Administrador = administrador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
