
using System;

namespace LugaresInteresGenNHibernate.EN.LugaresInteres
{
public partial class LugarEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string tipo;

/**
 *
 */

private string ubicacion;

/**
 *
 */

private string descripcion;

/**
 *
 */

private string poblacion;

/**
 *
 */

private System.Collections.Generic.IList<string> foto;

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

private LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN administrador;

/**
 *
 */

private bool validar;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}


public virtual string Ubicacion {
        get { return ubicacion; } set { ubicacion = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual string Poblacion {
        get { return poblacion; } set { poblacion = value;  }
}


public virtual System.Collections.Generic.IList<string> Foto {
        get { return foto; } set { foto = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN> Voto {
        get { return voto; } set { voto = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}


public virtual bool Validar {
        get { return validar; } set { validar = value;  }
}





public LugarEN()
{
        voto = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN>();
        comentario = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN>();
}



public LugarEN(string nombre, string tipo, string ubicacion, string descripcion, string poblacion, System.Collections.Generic.IList<string> foto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN> voto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario, LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN administrador, bool validar)
{
        this.init (nombre, tipo, ubicacion, descripcion, poblacion, foto, voto, comentario, administrador, validar);
}


public LugarEN(LugarEN lugar)
{
        this.init (lugar.Nombre, lugar.Tipo, lugar.Ubicacion, lugar.Descripcion, lugar.Poblacion, lugar.Foto, lugar.Voto, lugar.Comentario, lugar.Administrador, lugar.Validar);
}

private void init (string nombre, string tipo, string ubicacion, string descripcion, string poblacion, System.Collections.Generic.IList<string> foto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.VotoEN> voto, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN> comentario, LugaresInteresGenNHibernate.EN.LugaresInteres.AdministradorEN administrador, bool validar)
{
        this.Nombre = nombre;


        this.Tipo = tipo;

        this.Ubicacion = ubicacion;

        this.Descripcion = descripcion;

        this.Poblacion = poblacion;

        this.Foto = foto;

        this.Voto = voto;

        this.Comentario = comentario;

        this.Administrador = administrador;

        this.Validar = validar;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LugarEN t = obj as LugarEN;
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
