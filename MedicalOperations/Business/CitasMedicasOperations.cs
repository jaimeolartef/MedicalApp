using MedicalBusiness.Database;
using MedicalOperations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOperations.Business
{
    public class CitasMedicasOperations
    {
        MedicalAppEntitiesDev db = new MedicalAppEntitiesDev();

        public CitasMedicas CrearCita(CitasMedicasModel citasMedicasM)
        {

            CitasMedicas citasMedicas = new CitasMedicas();
            var citasNewS = new CitasMedicas
            {
             ProfesionalSalud= citasMedicasM.profesionalSalud,
             Especialidad= citasMedicasM.Especialidad,
             Sede= citasMedicasM.Sede,
             Direccion= citasMedicasM.Direccion,
             Fecha= citasMedicasM.Fecha,
             Hora= citasMedicasM.Hora,
             CodigoCita = citasMedicasM.CodigoCita,
             Asistencia = citasMedicasM.Asistencia,
             Observaciones = citasMedicasM.Observaciones,
             PacienteDocumento = citasMedicasM.PacienteDocumento,
            };

            db.Entry(citasNewS).State = EntityState.Added;
            db.SaveChanges();
            citasMedicas = citasNewS;
            return citasMedicas;
        }

        public CitasMedicas GetCita(CitasMedicasModel medicasModel)
        {
            CitasMedicas citas = new CitasMedicas();
            citas = db.CitasMedicas?.Where(c => c.PacienteDocumento.Equals(medicasModel.PacienteDocumento) && c.CodigoCita.Equals(medicasModel.CodigoCita)).SingleOrDefault();
            return citas;
        }

        public List<CitasMedicas> GetMedicasAll()
        {
            List<CitasMedicas> citasMedicas = db.CitasMedicas?.ToList();
            return citasMedicas;
        }

        public CitasMedicas ActualizarCita(CitasMedicasModel citasMedicas)
        {
            CitasMedicas citasMedicasN = new CitasMedicas();
            citasMedicasN = db.CitasMedicas?.Where(c => c.PacienteDocumento.Equals(citasMedicas.PacienteDocumento) && c.CodigoCita.Equals(citasMedicas.CodigoCita)).SingleOrDefault();

            citasMedicasN = new CitasMedicas
            {
                ProfesionalSalud = citasMedicas.profesionalSalud,
                Especialidad = citasMedicas.Especialidad,
                Sede = citasMedicas.Sede,
                Direccion = citasMedicas.Direccion,
                Fecha = citasMedicas.Fecha,
                Hora = citasMedicas.Hora,
                CodigoCita = citasMedicas.CodigoCita,
                Asistencia = citasMedicas.Asistencia,
                Observaciones = citasMedicas.Observaciones,
                PacienteDocumento = citasMedicas.PacienteDocumento,
            };

            db.Entry(citasMedicasN).State = EntityState.Modified;
            db.SaveChanges();
            return citasMedicasN;
        }
    }
}
