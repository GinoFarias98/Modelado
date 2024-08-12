using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ProyectoModelado.DB.Datos.Entidades
{
    public class Socio : EntityBase
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
        public int IdVehiculo { get; set; }
        public int IdInfoRegistro { get; set; }

        [ForeignKey("IdVehiculo")]
        public Vehiculo Vehiculo { get; set; }

        [ForeignKey("IdInfoRegistro")]
        public InfoRegistro InfoRegistro { get; set; }

        // Relación uno-a-muchos con Cuotas
        public ICollection<Cuota> Cuotas { get; set; }

    }
}
