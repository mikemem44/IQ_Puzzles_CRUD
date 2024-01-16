﻿using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_UsuarioPermiso
    {
        public static short getPermisoID(short Id_Usuario)
        {
            using (IqPuzzlesContext bd = new IqPuzzlesContext())
            {
                var userMatch = bd.UsuarioPermsisos.Where(a => a.UsuarioID == Id_Usuario).FirstOrDefault();

                if (userMatch != null)
                {
                    return userMatch.PermisoID;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}