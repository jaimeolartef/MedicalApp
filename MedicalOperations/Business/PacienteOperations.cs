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
    public class PacienteOperations
    {
        MedicalAppEntitiesDev db = new MedicalAppEntitiesDev();
        public Paciente CrearPaciente(PacienteModel pacienteModel)
        {

            Paciente paciente = new Paciente();
            var pacientNew = new Paciente
            {
                Nombre = pacienteModel.Nombre,
                Apellidos = pacienteModel.Apellidos,
                NumeroDocumento = pacienteModel.NumeroDocumento,
                TipDocumento = pacienteModel.TipDocumento,
                Direccion = pacienteModel.Direccion,
                Email = pacienteModel.Email,
                Telefono = pacienteModel.Telefono,
                Estado = pacienteModel.Estado,
                FechaCreacion = pacienteModel.FechaCreacion,
            };

            db.Entry(pacientNew).State = EntityState.Added;
            db.SaveChanges();
            paciente = pacientNew;
            return paciente;
        }
        public Paciente GetPaciente(PacienteModel pacienteModel)
        {
            Paciente paciente = new Paciente();
            paciente = db.Paciente?.Where(c => c.NumeroDocumento.Equals(pacienteModel.NumeroDocumento) && c.TipDocumento.Equals(pacienteModel.TipDocumento)
              && c.Estado.Equals(true)).SingleOrDefault();
            return paciente;
        }

        public Paciente ActualizarPaciente(PacienteModel pacienteM)
        {
            Paciente paciente = new Paciente();
            paciente = db.Paciente?.Where(c => c.NumeroDocumento.Equals(pacienteM.NumeroDocumento) && c.TipDocumento.Equals(pacienteM.TipDocumento)
             && c.Estado.Equals(true)).SingleOrDefault();
            paciente = new Paciente
            {
                IdClient = pacienteM.IdClient,
                Nombre = pacienteM.Nombre,
                Apellidos = pacienteM.Apellidos,
                NumeroDocumento = pacienteM.NumeroDocumento,
                TipDocumento = pacienteM.TipDocumento,
                Direccion = pacienteM.Direccion,
                Email = pacienteM.Email,
                Telefono = pacienteM.Telefono,
                Estado = pacienteM.Estado,
                FechaCreacion = pacienteM.FechaCreacion,
            };

            db.Entry(paciente).State = EntityState.Modified;
            db.SaveChanges();
            return paciente;
        }
    }
}
