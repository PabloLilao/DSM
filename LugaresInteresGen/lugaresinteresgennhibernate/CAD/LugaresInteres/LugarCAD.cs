
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
public partial class LugarCAD : BasicCAD, ILugarCAD
{
public LugarCAD() : base ()
{
}

public LugarCAD(ISession sessionAux) : base (sessionAux)
{
}



public LugarEN ReadOIDDefault (string nombre)
{
        LugarEN lugarEN = null;

        try
        {
                SessionInitializeTransaction ();
                lugarEN = (LugarEN)session.Get (typeof(LugarEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lugarEN;
}


public string Nuevo (LugarEN lugar)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (lugar);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lugar.Nombre;
}

public void Modificar (LugarEN lugar)
{
        try
        {
                SessionInitializeTransaction ();
                LugarEN lugarEN = (LugarEN)session.Load (typeof(LugarEN), lugar.Nombre);

                lugarEN.Tipo = lugar.Tipo;


                lugarEN.Ubicacion = lugar.Ubicacion;


                lugarEN.Descripcion = lugar.Descripcion;


                lugarEN.Poblacion = lugar.Poblacion;


                lugarEN.Foto = lugar.Foto;


                lugarEN.Validar = lugar.Validar;

                session.Update (lugarEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (string nombre)
{
        try
        {
                SessionInitializeTransaction ();
                LugarEN lugarEN = (LugarEN)session.Load (typeof(LugarEN), nombre);
                session.Delete (lugarEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarLugarNombre (string p_nombre)
{
        System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LugarEN self where from LugarEN as lu where lu.Nombre = :p_nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LugarENbuscarLugarNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarLugarLocalidad (string p_poblacion)
{
        System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LugarEN self where from LugarEN as lu where lu.Poblacion = :p_poblacion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LugarENbuscarLugarLocalidadHQL");
                query.SetParameter ("p_poblacion", p_poblacion);

                result = query.List<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> BuscarNoValidados ()
{
        System.Collections.Generic.IList<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LugarEN self where from LugarEN as l where l.Validar=false";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LugarENbuscarNoValidadosHQL");

                result = query.List<LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<LugarEN> DameTodos (int first, int size)
{
        System.Collections.Generic.IList<LugarEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LugarEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<LugarEN>();
                else
                        result = session.CreateCriteria (typeof(LugarEN)).List<LugarEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in LugarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
