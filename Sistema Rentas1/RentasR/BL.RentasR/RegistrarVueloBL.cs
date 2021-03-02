using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.RentasR
{
    public class RegistrarVueloBL
    {
        Contexto _contexto;

        public BindingList<RegistrarVuelo> ListaRegistrarVuelo { get; set; }

        public RegistrarVueloBL()
        {
            _contexto = new Contexto();

            ListaRegistrarVuelo = new BindingList<RegistrarVuelo>();
        }

        public BindingList<RegistrarVuelo> ObtenerRegistrarVuelo()
        {
            _contexto.RegistrarVuelo.Load();
            ListaRegistrarVuelo = _contexto.RegistrarVuelo.Local.ToBindingList();

            return ListaRegistrarVuelo;
        }

        public Resultado GuardarRegistrarVuelo(RegistrarVuelo vuelo)
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

        public void AgregrarVuelo()
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

            if(string.IsNullOrEmpty(vuelo.Clase) == true)
            {
                resultado.Mensaje = "Ingrese una clase, Ejem. Económica, VIP";
                resultado.Exitoso = false;
            }

            if (vuelo.Horasdevuelo < 0)
            {
                resultado.Mensaje = "La horas de vuelo debe ser mayor que cero ";
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
