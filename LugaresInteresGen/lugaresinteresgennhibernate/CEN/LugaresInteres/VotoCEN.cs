

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using LugaresInteresGenNHibernate.EN.LugaresInteres;
using LugaresInteresGenNHibernate.CAD.LugaresInteres;

namespace LugaresInteresGenNHibernate.CEN.LugaresInteres
{
public partial class VotoCEN
{
private IVotoCAD _IVotoCAD;

public VotoCEN()
{
        this._IVotoCAD = new VotoCAD ();
}

public VotoCEN(IVotoCAD _IVotoCAD)
{
        this._IVotoCAD = _IVotoCAD;
}

public IVotoCAD get_IVotoCAD ()
{
        return this._IVotoCAD;
}

public int Votacion (int p_puntuacion, string p_usuario, string p_lugar)
{
        VotoEN votoEN = null;
        int oid;

        //Initialized VotoEN
        votoEN = new VotoEN ();
        votoEN.Puntuacion = p_puntuacion;


        if (p_usuario != null) {
                votoEN.Usuario = new LugaresInteresGenNHibernate.EN.LugaresInteres.UsuarioEN ();
                votoEN.Usuario.Email = p_usuario;
        }


        if (p_lugar != null) {
                votoEN.Lugar = new LugaresInteresGenNHibernate.EN.LugaresInteres.LugarEN ();
                votoEN.Lugar.Nombre = p_lugar;
        }

        //Call to VotoCAD

        oid = _IVotoCAD.Votacion (votoEN);
        return oid;
}

public void Cambiarvoto (int p_Voto_OID, int p_puntuacion)
{
        VotoEN votoEN = null;

        //Initialized VotoEN
        votoEN = new VotoEN ();
        votoEN.Id = p_Voto_OID;
        votoEN.Puntuacion = p_puntuacion;
        //Call to VotoCAD

        _IVotoCAD.Cambiarvoto (votoEN);
}

public void Borrar (int id)
{
        _IVotoCAD.Borrar (id);
}
}
}
