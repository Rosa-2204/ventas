using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class Registrar_VueloBL
    {
        public BindingList<RegistrarVuelo> ListaRegistrarVuelo { get; set; }

        public Registrar_VueloBL()
        {
            ListaRegistrarVuelo = new BindingList<RegistrarVuelo>();

            var RegistrarVuelo1 = new RegistrarVuelo();
            RegistrarVuelo1.IdVuelo = 123;
            RegistrarVuelo1.Clase = "Económica";
            RegistrarVuelo1.Horasdevuelo = 12;
            RegistrarVuelo1.Ciudaddeorigen = "San Pedro Sula";
            RegistrarVuelo1.Destino = "Houston,Texas";
            RegistrarVuelo1.FechadeVuelo = new DateTime(2021, 01, 20);
            RegistrarVuelo1.Activo = true;

            ListaRegistrarVuelo.Add(RegistrarVuelo1);

            var RegistrarVuelo2 = new RegistrarVuelo();
            RegistrarVuelo2.IdVuelo = 456;
            RegistrarVuelo2.Clase = "VIP";
            RegistrarVuelo2.Horasdevuelo = 16;
            RegistrarVuelo2.Ciudaddeorigen = "Tegucigalpa";
            RegistrarVuelo2.Destino = "España";
            RegistrarVuelo2.FechadeVuelo = new DateTime(2021, 2, 25);
            RegistrarVuelo2.Activo = true;

            ListaRegistrarVuelo.Add(RegistrarVuelo2);

            var RegistrarVuelo3 = new RegistrarVuelo();
            RegistrarVuelo3.IdVuelo = 789;
            RegistrarVuelo3.Clase = "VIP";
            RegistrarVuelo3.Horasdevuelo = 12;
            RegistrarVuelo3.Ciudaddeorigen = "San Pedro Sula";
            RegistrarVuelo3.Destino = "California";
            RegistrarVuelo3.FechadeVuelo = new DateTime(2021, 2, 15);
            RegistrarVuelo3.Activo = true;

            ListaRegistrarVuelo.Add(RegistrarVuelo3);
        }

        public BindingList<RegistrarVuelo> ObtenerRegistarVuelo()
        {
            return ListaRegistrarVuelo;
        }

        public Resultado GuardarVuelo(RegistrarVuelo vuelo)
        {
            var resultado = Validar(vuelo);
            if (resultado.Exitoso == false)
            {
                return resultado;
            } 

            if (vuelo.IdVuelo == 0)
            {
                vuelo.IdVuelo = ListaRegistrarVuelo.Max(item => item.IdVuelo) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarVuelo()
        {
            var nuevoVuelo = new RegistrarVuelo();
            ListaRegistrarVuelo.Add(nuevoVuelo);
        }

        public bool EliminarVuelo(int Id)
        {
            foreach (var item in ListaRegistrarVuelo)
            {
                if (item.IdVuelo == Id)
                {
                    ListaRegistrarVuelo.Remove(item);
                    return true;
                }

            }

            return false;
        }

        private Resultado Validar(RegistrarVuelo vuelo)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(vuelo.Clase) == true)
            {
                resultado.Mensaje = "Ingrese una clase, Ejem. Económica, VIP";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(vuelo.Ciudaddeorigen) == true)
            {
                resultado.Mensaje = "Ingrese una Ciudad de Origen";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(vuelo.Destino) == true)
            {
                resultado.Mensaje = "Ingrese una Ciudad de Destino";
                resultado.Exitoso = false;
            }

            if (vuelo.Horasdevuelo < 0)
            {
                resultado.Mensaje = "La horas de vuelo debe ser mayor que cero ";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
        public class RegistrarVuelo
        {
            public int IdVuelo { get; set; }
            public string Clase { get; set; }
            public int Horasdevuelo { get; set; }
            public string Ciudaddeorigen { get; set; }
            public string Destino { get; set; }
            public DateTime FechadeVuelo { get; set; }
            public bool Activo { get; set; }

        }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }
    
}

 
