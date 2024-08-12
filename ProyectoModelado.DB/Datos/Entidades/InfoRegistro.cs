using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado.DB.Datos.Entidades
{
    public class InfoRegistro : EntityBase
    {
        public bool Registrado { get; set; }
        public string TipoRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
