using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Models
{
    public class CitasMedicasModel
    {
        public int IdCita { get; set; }
        public string profesionalSalud { get; set; }
        public string Especialidad { get; set; }
        public string Sede { get; set; }
        public string Direccion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Hora { get; set; }
        public string CodigoCita { get; set; }
        public Nullable<bool> Asistencia { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> PacienteDocumento { get; set; }
    }
}
