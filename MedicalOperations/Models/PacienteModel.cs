using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Models
{
    public class PacienteModel
    {
        public int IdClient { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int NumeroDocumento { get; set; }
        public int TipDocumento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }
    }
}
