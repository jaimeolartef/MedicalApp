using MedicalBusiness.Database;
using MedicalOperations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Business
{
    public class MedicalProcess
    {
        MedicalAppEntitiesDev db = new MedicalAppEntitiesDev();
        CitasMedicasOperations citasMedicas = new CitasMedicasOperations();

        public CitasMedicas CrearCitaMedica(CitasMedicasModel medicasModel)
        {
            CitasMedicas result = new CitasMedicas();
            if(medicasModel!=null)
            {
              result = citasMedicas.CrearCita(medicasModel);
             
            }
            return result;
        }
        public CitasMedicas ActualizarCitaMedica(CitasMedicasModel medicasModel)
        {
            CitasMedicas result = new CitasMedicas();
            if (medicasModel != null)
            {
                result = citasMedicas.ActualizarCita(medicasModel);

            }
            return result;
        }
        public List<CitasMedicas>  ObtenerCitas()
        {
            return citasMedicas.GetMedicasAll().ToList();
        }

        public bool CrearCitaMedicalApp (CitasMedicasModel citasMedicas, PacienteModel pacienteModel)
        {
            bool result = false;
            PacienteOperations pacienteOperations = new PacienteOperations();
           
            if (citasMedicas!=null)
            {
                var paciente = pacienteOperations.CrearPaciente(pacienteModel);
                var cita = CrearCitaMedica(citasMedicas);
                //proceso de notificacion email
                result = true;
            }
            return result;
        }
    }
}
