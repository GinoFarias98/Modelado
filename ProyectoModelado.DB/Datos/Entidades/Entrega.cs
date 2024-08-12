using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos.Entidades
{
    public class Entrega: EntityBase
    {

        public int IdSocio { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("IdSocio")]
        public Socio Socio { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
