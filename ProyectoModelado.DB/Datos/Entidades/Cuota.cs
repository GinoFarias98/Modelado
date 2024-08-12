using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos.Entidades
{
    public class Cuota : EntityBase
    {
        public int MontoCuota { get; set; }
        public bool Pagada { get; set; }
        public DateTime FechaPago { get; set; }
        public int IdSocio { get; set; }

        [ForeignKey("IdSocio")]
        public Socio Socio { get; set; }
    }
}
