
using System;

namespace LugaresInteresGenNHibernate.EN.LugaresInteres
{
public partial class UsuarioEN
{
/**
 *
 */

private string email;

/**
 *
 */

private string nombre;

/**
 *
 */

private string apellidos;

/**
 *
 */

private String contrasenya;

/**
 *
 */

private string poblacion;

/**
 *
 */

private string foto;

/**
 *
 */

private System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN> voto;

/**
 *
 */

private System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario;

/**
 *
 */

private System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> grupo;





public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}


public virtual String Contrasenya {
        get { return contrasenya; } set { contrasenya = value;  }
}


public virtual string Poblacion {
        get { return poblacion; } set { poblacion = value;  }
}


public virtual string Foto {
        get { return foto; } set { foto = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN> Voto {
        get { return voto; } set { voto = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> Grupo {
        get { return grupo; } set { grupo = value;  }
}





public UsuarioEN()
{
        voto = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN>();
        comentario = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN>();
        grupo = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN>();
}



public UsuarioEN(string email, string nombre, string apellidos, String contrasenya, string poblacion, string foto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN> voto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> grupo)
{
        this.init (email, nombre, apellidos, contrasenya, poblacion, foto, voto, comentario, grupo);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Email, usuario.Nombre, usuario.Apellidos, usuario.Contrasenya, usuario.Poblacion, usuario.Foto, usuario.Voto, usuario.Comentario, usuario.Grupo);
}

private void init (string email, string nombre, string apellidos, String contrasenya, string poblacion, string foto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN> voto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> grupo)
{
        this.Email = email;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Contrasenya = contrasenya;

        this.Poblacion = poblacion;

        this.Foto = foto;

        this.Voto = voto;

        this.Comentario = comentario;

        this.Grupo = grupo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
