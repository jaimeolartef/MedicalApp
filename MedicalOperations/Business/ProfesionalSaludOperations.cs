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
    public class ProfesionalSaludOperations
    {
        MedicalAppEntitiesDev db = new MedicalAppEntitiesDev();

        public ProfesionalSalud CrearPaciente(ProfesionalSaludModel profesionalSaludModel)
        {

            ProfesionalSalud profesionalSalud = new ProfesionalSalud();
            var profesionalNewS = new ProfesionalSalud
            {
                Nombres = profesionalSaludModel.Nombres,
                Apellidos = profesionalSaludModel.Apellidos,
                NumeroDocumento = profesionalSaludModel.NumeroDocumento,
                TipoDocumento = profesionalSaludModel.TipoDocumento,
                Direccion = profesionalSaludModel.Direccion,
                Email = profesionalSaludModel.Email,
                Telefono = profesionalSaludModel.Telefono,
                Estado = profesionalSaludModel.Estado,
                FecharCreacion = profesionalSaludModel.FecharCreacion,
                Especialidad =profesionalSaludModel.Especialidad,
                NumeroLicencia=profesionalSalud.NumeroLicencia
            };

            db.Entry(profesionalNewS).State = EntityState.Added;
            db.SaveChanges();
            profesionalSalud = profesionalNewS;
            return profesionalSalud;
        }
        public ProfesionalSalud GetProfesional(ProfesionalSaludModel profesionalSaludM)
        {
            ProfesionalSalud profesional = new ProfesionalSalud();
            profesional = db.ProfesionalSalud?.Where(c => c.NumeroDocumento.Equals(profesionalSaludM.NumeroDocumento) && c.TipoDocumento.Equals(profesionalSaludM.TipoDocumento)
              && c.Estado.Equals(true)).SingleOrDefault();
            return profesional;
        }
        public ProfesionalSalud GetProfesionalLicencia(ProfesionalSaludModel profesionalSaludM)
        {
            ProfesionalSalud profesional = new ProfesionalSalud();
            profesional = db.ProfesionalSalud?.Where(c => c.NumeroLicencia.Equals(profesionalSaludM.NumeroLicencia) && c.Estado.Equals(true)).SingleOrDefault();
            return profesional;
        }
        public List<ProfesionalSalud> GetProfesionalEspe(string CodEspe)
        {
            List<ProfesionalSalud> profesionals = new List<ProfesionalSalud>();
           return profesionals=db.ProfesionalSalud?.Where(z=>z.Especialidad==CodEspe && z.Estado==true).ToList();
        }
        public ProfesionalSalud ActualizarProfesional(ProfesionalSaludModel profesionalSaludModel)
        {
            ProfesionalSalud profesionalSalud = new ProfesionalSalud();
            profesionalSalud = db.ProfesionalSalud?.Where(c => c.NumeroDocumento.Equals(profesionalSaludModel.NumeroDocumento) && c.TipoDocumento.Equals(profesionalSaludModel.TipoDocumento)
             && c.Estado.Equals(true)).SingleOrDefault();
            profesionalSalud = new ProfesionalSalud
            {
                Id = profesionalSaludModel.Id,
                Nombres = profesionalSaludModel.Nombres,
                Apellidos = profesionalSaludModel.Apellidos,
                NumeroDocumento = profesionalSaludModel.NumeroDocumento,
                TipoDocumento = profesionalSaludModel.TipoDocumento,
                Direccion = profesionalSaludModel.Direccion,
                Email = profesionalSaludModel.Email,
                Telefono = profesionalSaludModel.Telefono,
                Estado = profesionalSaludModel.Estado,
                FecharCreacion = profesionalSaludModel.FecharCreacion,
                Especialidad = profesionalSaludModel.Especialidad,
                NumeroLicencia = profesionalSalud.NumeroLicencia
            };

            db.Entry(profesionalSalud).State = EntityState.Modified;
            db.SaveChanges();
            return profesionalSalud;
        }
    }
}
