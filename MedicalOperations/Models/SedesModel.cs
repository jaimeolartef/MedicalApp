using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Models
{
    public class SedesModel
    {
        public int IdSede { get; set; }
        public string NombreSede { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> Telefono { get; set; }
        public Nullable<bool> EstadoSede { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string Email { get; set; }
        public Nullable<int> CodigoSede { get; set; }
    }
}
