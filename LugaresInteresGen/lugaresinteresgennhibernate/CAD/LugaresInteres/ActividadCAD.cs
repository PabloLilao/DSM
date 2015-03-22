
using System;
using System.Text;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LugaresInteresGenNHibernate.EN.LugaresInteres;
using LugaresInteresGenNHibernate.Exceptions;

namespace LugaresInteresGenNHibernate.CAD.LugaresInteres
{
public partial class ActividadCAD : BasicCAD, IActividadCAD
{
public ActividadCAD() : base ()
{
}

public ActividadCAD(ISession sessionAux) : base (sessionAux)
{
}



public ActividadEN ReadOIDDefault (string Tipo)
{
        ActividadEN actividadEN = null;

        try
        {
                SessionInitializeTransaction ();
                actividadEN = (ActividadEN)session.Get (typeof(ActividadEN), Tipo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ActividadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return actividadEN;
}


public string Nueva (ActividadEN actividad)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (actividad);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ActividadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return actividad.Tipo;
}

public void Modify (ActividadEN actividad)
{
        try
        {
                SessionInitializeTransaction ();
                ActividadEN actividadEN = (ActividadEN)session.Load (typeof(ActividadEN), actividad.Tipo);

                actividadEN.Descripcion = actividad.Descripcion;

                session.Update (actividadEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ActividadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (string Tipo)
{
        try
        {
                SessionInitializeTransaction ();
                ActividadEN actividadEN = (ActividadEN)session.Load (typeof(ActividadEN), Tipo);
                session.Delete (actividadEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ActividadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN> BuscarActividad (LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum p_tipo)
{
        System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActividadEN self where from ActividadEN as a where a.Tipo = :p_tipo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActividadENbuscarActividadHQL");
                query.SetParameter ("p_tipo", p_tipo);

                result = query.List<LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ActividadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ActividadEN> DameTodasActividades (int first, int size)
{
        System.Collections.Generic.IList<ActividadEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ActividadEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ActividadEN>();
                else
                        result = session.CreateCriteria (typeof(ActividadEN)).List<ActividadEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ActividadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
