﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.RentasR
{
    public class Contexto: DbContext
    {
        public Contexto(): base()
        {

        }

        public DbSet<RegistrarVuelo> RegistrarVuelo { get; set; }
    }
}
