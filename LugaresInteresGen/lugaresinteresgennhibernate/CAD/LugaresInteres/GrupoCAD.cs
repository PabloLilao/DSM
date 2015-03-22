
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
public partial class GrupoCAD : BasicCAD, IGrupoCAD
{
public GrupoCAD() : base ()
{
}

public GrupoCAD(ISession sessionAux) : base (sessionAux)
{
}



public GrupoEN ReadOIDDefault (string nombre)
{
        GrupoEN grupoEN = null;

        try
        {
                SessionInitializeTransaction ();
                grupoEN = (GrupoEN)session.Get (typeof(GrupoEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in GrupoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return grupoEN;
}


public string Crear (GrupoEN grupo)
{
        try
        {
                SessionInitializeTransaction ();
                if (grupo.Usuario != null) {
                        grupo.Usuario = (LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN), grupo.Usuario.Email);

                        grupo.Usuario.Grupo.Add (grupo);
                }
                if (grupo.Actividad != null) {
                        grupo.Actividad = (LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.ActividadEN), grupo.Actividad.Tipo);

                        grupo.Actividad.Grupo.Add (grupo);
                }

                session.Save (grupo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in GrupoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return grupo.Nombre;
}

public void Modificar (GrupoEN grupo)
{
        try
        {
                SessionInitializeTransaction ();
                GrupoEN grupoEN = (GrupoEN)session.Load (typeof(GrupoEN), grupo.Nombre);

                grupoEN.Descripcion = grupo.Descripcion;

                session.Update (grupoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in GrupoCAD.", ex);
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
                GrupoEN grupoEN = (GrupoEN)session.Load (typeof(GrupoEN), nombre);
                session.Delete (grupoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in GrupoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Unirgrupo (string p_Grupo_OID, string p_usuario_OID)
{
        LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN grupoEN = null;
        try
        {
                SessionInitializeTransaction ();
                grupoEN = (GrupoEN)session.Load (typeof(GrupoEN), p_Grupo_OID);
                grupoEN.Usuario = (LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN), p_usuario_OID);

                grupoEN.Usuario.Grupo.Add (grupoEN);



                session.Update (grupoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in GrupoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Salirgrupo (string p_Grupo_OID, string p_usuario_OID)
{
        try
        {
                SessionInitializeTransaction ();
                LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN grupoEN = null;
                grupoEN = (GrupoEN)session.Load (typeof(GrupoEN), p_Grupo_OID);

                if (grupoEN.Usuario.Email == p_usuario_OID) {
                        grupoEN.Usuario = null;
                }
                else
                        throw new ModelException ("The identifier " + p_usuario_OID + " in p_usuario_OID you are trying to unrelationer, doesn't exist in GrupoEN");

                session.Update (grupoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in GrupoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
