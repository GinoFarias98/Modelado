using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos.Entidades
{
    public class Prestamo : EntityBase
    {
        public string Detalle { get; set; }
        public int IdSocio { get; set; }
        public bool EstadoPrestamo { get; set; }
        public int MontoPrestamo { get; set; }
        public int CuotasTotalesPrestamo { get; set; }
        public int CuotasPagadasPrestamo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdCuotaPrestamo { get; set; }

        public ICollection<CuotaPrestamo> CuotasPrestamo { get; set; }

        [ForeignKey("IdSocio")]
        public Socio Socio { get; set; }
    }
}
