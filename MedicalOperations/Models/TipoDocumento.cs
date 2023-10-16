using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Models
{
    public class TipoDocumento
    {
        public enum TipDoc
        {
            Cedula = 1,
            NIT = 2,
            Pasaporte = 3,
            CedulaExtranjeria = 4
        }

        public TipDoc TidDocs { get; set; }



        public enum Especialidades
        {
            MedicinaGeneral = 1,
            Cardiologia = 2,
            Pediatria = 3,
            MedicinaFamiliar = 4,
            MedicinaInterna = 5,
            Ortopedia = 6,
            Neurologia = 7
        }

        public Especialidades TidEspe { get; set; }
    }
}
