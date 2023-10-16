using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Utils
{
    public class UtilsGeneral
    {
        public string GenerarCodigoCita (){
         string CodigoCita = "";
        Guid g = Guid.NewGuid();
        return CodigoCita = g.ToString();
        }
}
}
