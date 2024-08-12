using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos.Entidades
{
    public class Vehiculo : EntityBase
    {
        public string Tipo { get; set; }
        public int CapMaxima { get; set; }
        public string Detalle { get; set; }
        public string Dominio { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int IdSocio { get; set; }

        public ICollection<Socio> Socios { get; set; }
    }
}
