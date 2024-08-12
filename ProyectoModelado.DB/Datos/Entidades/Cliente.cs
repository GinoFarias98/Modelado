using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos.Entidades
{
    public class Cliente : EntityBase
    {
        public string Rsocial { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public ICollection<Entrega> Entregas { get; set; }

    }
}
