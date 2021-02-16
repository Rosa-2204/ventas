using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class VueloBL
    {
       public BindingList<Vuelo> ListaVuelo { get; set; }

        public VueloBL()
        {
            ListaVuelo = new BindingList<Vuelo>();

            var vuelo1 = new Vuelo();
            vuelo1.IdAvion = 1;
            vuelo1.matriculaavion = "ABC123";
            vuelo1.capacidadpasajero = 800;
            vuelo1.capacidadcarga = 500;
            vuelo1.Activo = true;

            ListaVuelo.Add(vuelo1);

            var vuelo2 = new Vuelo();
            vuelo2.IdAvion = 2;
            vuelo2.matriculaavion = "DEF456";
            vuelo2.capacidadpasajero = 900;
            vuelo2.capacidadcarga = 5000;
            vuelo2.Activo = true;

            ListaVuelo.Add(vuelo2);

            var vuelo3 = new Vuelo();
            vuelo3.IdAvion = 3;
            vuelo3.matriculaavion = "GHI789";
            vuelo3.capacidadpasajero = 200;
            vuelo3.capacidadcarga = 1000;
            vuelo3.Activo = true;

            ListaVuelo.Add(vuelo3);
        }

        public BindingList<Vuelo> ObtenerVuelo()
        {
            return ListaVuelo;
        }

    }

    public class Vuelo
    {
        public int IdAvion { get; set; }
        public string matriculaavion { get; set; }
        public double capacidadpasajero { get; set; }
        public int capacidadcarga  { get; set; }
        public bool Activo { get; set; }

    }
}
