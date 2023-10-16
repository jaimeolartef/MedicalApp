using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Models
{
    public class RequestCita
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipDocument { get; set; }
        public int NumeroDocumento { get; set; }
        public string Email { get;}
        public string Direccion { get; set; }
        public string DateD { get; set; }
        public int Telefono { get; set; }
        public string TipEspe { get; set; }
        public string Medical { get; set; }
        public string Hora{ get; set; }
        public string SedesN { get; set; }
       
    }
}