using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos.Entidades
{
    public class CuotaPrestamo : EntityBase
    {
        public int IdSocio { get; set; }
        public int IdPrestamo{ get; set; }
        public int MontoCuota { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool CuotaAdeudada { get; set; }

        [ForeignKey("IdSocio")]
        public Socio Socio { get; set; }

        [ForeignKey("IdPrestamo")]
        public Prestamo Prestamo { get; set; }
    }
}
