using MedicalBusiness.Database;
using MedicalOperations.Business;
using MedicalOperations.Models;
using MedicalOperations.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SedesOperations sedesOperations = new SedesOperations();
            ViewBag.Sedes=sedesOperations.GetSedes().ToList();
            return View();
        }

        public ActionResult About()
        {
            
            CitasMedicasOperations citasMedicasOperations = new CitasMedicasOperations();
            ViewBag.Citas = citasMedicasOperations.GetMedicasAll().ToList();
            return View();
        }

        public ActionResult Contact()
        {
       

            return View();
        }

        [HttpGet]
        public ActionResult GetEspeALL(string IdEspe)
        {
            ProfesionalSaludOperations profesionalSalud = new ProfesionalSaludOperations();
            var Especialistas= profesionalSalud.GetProfesionalEspe(IdEspe).ToList();
            return Json(Especialistas, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetCitasAll()
        {
            CitasMedicasOperations citasMedicasOperations = new CitasMedicasOperations();
            var ListMedicas= citasMedicasOperations.GetMedicasAll();
            List<CitasMedicasModel> citasMedicas = new List<CitasMedicasModel>(ListMedicas.Cast<CitasMedicasModel>());
            return Json(citasMedicas, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public ActionResult SendCitaMedica(string Nombres, string Apellidos, string TipDocument, int NumeroDocumento, string Email, string Direccion, string DateD, int Telefono ,string TipEspe,string Medical,string Hora,string SedesN)
        {
            bool result = false;
            MedicalProcess medicalProcess = new MedicalProcess();
             DateTime fechaCitas = DateTime.Parse(DateD);
            CitasMedicasModel citasNewS = new CitasMedicasModel();
            PacienteModel pacienteModel = new PacienteModel();
            pacienteModel.TipDocumento = Convert.ToInt32(TipDocument);
            pacienteModel.NumeroDocumento = NumeroDocumento;
            pacienteModel.Apellidos= Apellidos;
            pacienteModel.Nombre= Nombres;
            pacienteModel.Direccion= Direccion;
            pacienteModel.Email= Email;
            pacienteModel.Telefono = Convert.ToString(Telefono);
            pacienteModel.Estado = true;
            pacienteModel.FechaCreacion = DateTime.Now;
            UtilsGeneral utilsGeneral = new UtilsGeneral();
            citasNewS.profesionalSalud = Medical;
            citasNewS.Especialidad = TipEspe;
            citasNewS.Sede = SedesN;
            citasNewS.Direccion = Direccion;
            citasNewS.Fecha = fechaCitas;
            citasNewS.Hora = Hora;
            citasNewS.CodigoCita = utilsGeneral.GenerarCodigoCita();
            citasNewS.Asistencia = true;
            citasNewS.Observaciones = "Confirma Cita";
            citasNewS.PacienteDocumento = NumeroDocumento;
            result= medicalProcess.CrearCitaMedicalApp(citasNewS, pacienteModel);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }

}