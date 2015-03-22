
using System;

namespace LugaresInteresGenNHibernate.EN.LugaresInteres
{
public partial class AdministradorEN
{
/**
 *
 */

private string email;

/**
 *
 */

private String contraseña;

/**
 *
 */

private System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> lugar;

/**
 *
 */

private System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario;





public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual String Contraseña {
        get { return contraseña; } set { contraseña = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> Lugar {
        get { return lugar; } set { lugar = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}





public AdministradorEN()
{
        lugar = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN>();
        comentario = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN>();
}



public AdministradorEN(string email, String contraseña, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> lugar, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario)
{
        this.init (email, contraseña, lugar, comentario);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (administrador.Email, administrador.Contraseña, administrador.Lugar, administrador.Comentario);
}

private void init (string email, String contraseña, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> lugar, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario)
{
        this.Email = email;


        this.Contraseña = contraseña;

        this.Lugar = lugar;

        this.Comentario = comentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
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
