
using System;

namespace LugaresInteresGenNHibernate.EN.LugaresInteres
{
public partial class ActividadEN
{
/**
 *
 */

private string tipo;

/**
 *
 */

private string descripcion;

/**
 *
 */

private System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> grupo;





public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> Grupo {
        get { return grupo; } set { grupo = value;  }
}





public ActividadEN()
{
        grupo = new System.Collections.Generic.List<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN>();
}



public ActividadEN(string tipo, string descripcion, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> grupo)
{
        this.init (tipo, descripcion, grupo);
}


public ActividadEN(ActividadEN actividad)
{
        this.init (actividad.Tipo, actividad.Descripcion, actividad.Grupo);
}

private void init (string tipo, string descripcion, System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN> grupo)
{
        this.Tipo = Tipo;


        this.Descripcion = descripcion;

        this.Grupo = grupo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ActividadEN t = obj as ActividadEN;
        if (t == null)
                return false;
        if (Tipo.Equals (t.Tipo))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Tipo.GetHashCode ();
        return hash;
}
}
}
