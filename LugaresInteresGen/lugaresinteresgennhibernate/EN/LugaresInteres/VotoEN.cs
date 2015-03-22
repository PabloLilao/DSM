
using System;

namespace LugaresInteresGenNHibernate.EN.LugaresInteres
{
public partial class VotoEN
{
/**
 *
 */

private int id;

/**
 *
 */

private int puntuacion;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario;

/**
 *
 */

private LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN lugar;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN Lugar {
        get { return lugar; } set { lugar = value;  }
}





public VotoEN()
{
}



public VotoEN(int id, int puntuacion, LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario, LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN lugar)
{
        this.init (id, puntuacion, usuario, lugar);
}


public VotoEN(VotoEN voto)
{
        this.init (voto.Id, voto.Puntuacion, voto.Usuario, voto.Lugar);
}

private void init (int id, int puntuacion, LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN usuario, LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN lugar)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.Usuario = usuario;

        this.Lugar = lugar;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VotoEN t = obj as VotoEN;
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
