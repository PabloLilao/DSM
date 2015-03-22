using System;
using System.Data;
using LugaresInteresGenNHibernate.EN.LugaresInteres;
using System.Collections.Generic;
/// <summary>
/// Descripción breve de IVistaProductos
/// </summary>

namespace LugaresInteresGen_MVP.code
{
    public interface IVistaUsuario
    {
        IList<UsuarioEN> DameUsuarios { set; }

    }
}