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
    public class SedesOperations
    {
        MedicalAppEntitiesDev db = new MedicalAppEntitiesDev();
        public Sedes CrearSede(SedesModel sedesModel)
        {
            Sedes sedes = new Sedes();

            var sedesN = new Sedes
            {
                NombreSede= sedesModel.NombreSede,
                Direccion= sedesModel.Direccion,
                Telefono= sedesModel.Telefono,
                EstadoSede = sedesModel.EstadoSede,
                FechaCreacion = sedesModel.FechaCreacion,
                Email = sedesModel.Email,
                CodigoSede = sedesModel.CodigoSede
            };

            db.Entry(sedesN).State = EntityState.Added;
            db.SaveChanges();
            sedes = sedesN;
            return sedes;
        }
        public Sedes GetSede(SedesModel sedesModels)
        {
            Sedes sedes = new Sedes();
            sedes = db.Sedes?.Where(c => c.CodigoSede.Equals(sedesModels.CodigoSede)).SingleOrDefault();
            return sedes;
        }
        public List<Sedes> GetSedes()
        {
            return db.Sedes?.Where(c => c.EstadoSede==true).ToList(); 
        }

        public Sedes ActualizarSede(SedesModel sedesModel)
        {
            Sedes sedes = new Sedes();
            sedes = db.Sedes?.Where(c => c.CodigoSede.Equals(sedesModel.CodigoSede)).SingleOrDefault();
            sedes = new Sedes
            {
                IdSede= sedesModel.IdSede,
                NombreSede = sedesModel.NombreSede,
                Direccion = sedesModel.Direccion,
                Telefono = sedesModel.Telefono,
                EstadoSede = sedesModel.EstadoSede,
                FechaCreacion = sedesModel.FechaCreacion,
                Email = sedesModel.Email,
                CodigoSede = sedesModel.CodigoSede
            };

            db.Entry(sedes).State = EntityState.Modified;
            db.SaveChanges();
            return sedes;
        }
    }
}
