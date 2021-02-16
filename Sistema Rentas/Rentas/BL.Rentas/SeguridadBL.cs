using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contra)
        {
            if (usuario == "Rosa" && contra == "123")

            {
                return true;
            }
            else
            {
                if (usuario == "Limny" && contra == "456")
                {
                    return true;
                }
            }

            return false;
        }

    }
}
