
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
public partial class VotoCAD : BasicCAD, IVotoCAD
{
public VotoCAD() : base ()
{
}

public VotoCAD(ISession sessionAux) : base (sessionAux)
{
}



public VotoEN ReadOIDDefault (int id)
{
        VotoEN votoEN = null;

        try
        {
                SessionInitializeTransaction ();
                votoEN = (VotoEN)session.Get (typeof(VotoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in VotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return votoEN;
}


public int Votacion (VotoEN voto)
{
        try
        {
                SessionInitializeTransaction ();
                if (voto.Usuario != null) {
                        voto.Usuario = (LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN), voto.Usuario.Email);

                        voto.Usuario.Voto.Add (voto);
                }
                if (voto.Lugar != null) {
                        voto.Lugar = (LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN)session.Load (typeof(LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN), voto.Lugar.Nombre);

                        voto.Lugar.Voto.Add (voto);
                }

                session.Save (voto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in VotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return voto.Id;
}

public void Cambiarvoto (VotoEN voto)
{
        try
        {
                SessionInitializeTransaction ();
                VotoEN votoEN = (VotoEN)session.Load (typeof(VotoEN), voto.Id);

                votoEN.Puntuacion = voto.Puntuacion;

                session.Update (votoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in VotoCAD.", ex);
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
                VotoEN votoEN = (VotoEN)session.Load (typeof(VotoEN), id);
                session.Delete (votoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LugaresInteresGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LugaresInteresGenNHibernate.Exceptions.DataLayerException ("Error in VotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
