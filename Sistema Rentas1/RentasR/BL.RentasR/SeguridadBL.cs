﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.RentasR
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasena)
        {
            if (usuario == "Rosa" && contrasena == "123")
            {
                return true;
            }
            else
            {
                if (usuario == "Limny" && contrasena == "456")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
