﻿using System;
using System.Data;
using LugaresInteresGenNHibernate.EN.LugaresInteres;
using System.Collections.Generic;
/// <summary>
/// Descripción breve de IVistaLugar
/// </summary>

namespace LugaresInteresGen_MVP.code
{
    public interface IVistaLugar
    {
        IList<LugarEN> DameLugares{ set; }
        //IList<LugarEN> DameLugaresNombre { set; }
       
        
    }
}
