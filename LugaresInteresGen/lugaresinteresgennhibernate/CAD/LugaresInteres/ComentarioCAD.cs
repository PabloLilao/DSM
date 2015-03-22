
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
public partial class ComentarioCAD : BasicCAD, IComentarioCAD
{
public ComentarioCAD() : base ()
{
}

public ComentarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ComentarioEN ReadOIDDefault (int id)
{
        ComentarioEN comentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Get (typeof(ComentarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentarioEN;
}


public int Crear (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                if (comentario.Usuario != null) {
                        comentario.Usuario = (LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN), comentario.Usuario.Email);

                        comentario.Usuario.Comentario.Add (comentario);
                }

                session.Save (comentario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comentario.Id;
}

public void Modificar (ComentarioEN comentario)
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), comentario.Id);

                comentarioEN.Texto = comentario.Texto;


                comentarioEN.Fecha = comentario.Fecha;


                comentarioEN.State = comentario.State;

                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (int id)
{
        try
        {
                SessionInitializeTransaction ();
                ComentarioEN comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), id);
                session.Delete (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Asignargrupo (int p_Comentario_OID, string p_grupo_OID)
{
        LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN comentarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), p_Comentario_OID);
                comentarioEN.Grupo = (LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.GrupoEN), p_grupo_OID);

                comentarioEN.Grupo.Comentario.Add (comentarioEN);



                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Asignarlugar (int p_Comentario_OID, string p_lugar_OID)
{
        LugaresInteresGenNHibernate.EN.LugaresInteres.ComentarioEN comentarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                comentarioEN = (ComentarioEN)session.Load (typeof(ComentarioEN), p_Comentario_OID);
                comentarioEN.Lugar = (LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN), p_lugar_OID);

                comentarioEN.Lugar.Comentario.Add (comentarioEN);



                session.Update (comentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in ComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
