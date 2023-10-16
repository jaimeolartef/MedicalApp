using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Models
{
    public class ProfesionalSaludModel
    {
        public int Id { get; set; }
        public Nullable<int> NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<int> TipoDocumento { get; set; }
        public string Especialidad { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<System.DateTime> FecharCreacion { get; set; }
        public string NumeroLicencia { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
