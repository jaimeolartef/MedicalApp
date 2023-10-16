using MedicalBusiness.Database;
using MedicalOperations.Business;
using MedicalOperations.Models;
using MedicalOperations.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ApiMedicalAPP.Controllers
{
    [System.Web.Http.RoutePrefix("api/medical")]
    public class AppMedicalController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("v2/obtenerCitas")]
        public HttpResponseMessage GetCitas()
        {
            CitasMedicasOperations citasMedicasOperations = new CitasMedicasOperations();
            List<CitasMedicas> citasMedicas = null;
            try
            {
                citasMedicas = citasMedicasOperations.GetMedicasAll().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, citasMedicas, Configuration.Formatters.JsonFormatter);
            }
            catch (Exception)
            {
               
            }
            return Request.CreateResponse(HttpStatusCode.OK, citasMedicas, Configuration.Formatters.JsonFormatter);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("v2/registarCitas")]
        public HttpResponseMessage SendCitaMedica(RequestCita request)
        {
            bool result = false;
            MedicalProcess medicalProcess = new MedicalProcess();
            try
            {
               
                DateTime fechaCitas = DateTime.Parse(request.DateD);
                CitasMedicasModel citasNewS = new CitasMedicasModel();
                PacienteModel pacienteModel = new PacienteModel();
                pacienteModel.TipDocumento = Convert.ToInt32(request.TipDocument);
                pacienteModel.NumeroDocumento = request.NumeroDocumento;
                pacienteModel.Apellidos = request.Apellidos;
                pacienteModel.Nombre = request.Nombres;
                pacienteModel.Direccion = request.Direccion;
                pacienteModel.Email = request.Email;
                pacienteModel.Telefono = Convert.ToString(request.Telefono);
                pacienteModel.Estado = true;
                pacienteModel.FechaCreacion = DateTime.Now;
                UtilsGeneral utilsGeneral = new UtilsGeneral();
                citasNewS.profesionalSalud = request.Medical;
                citasNewS.Especialidad = request.TipEspe;
                citasNewS.Sede = request.SedesN;
                citasNewS.Direccion = request.Direccion;
                citasNewS.Fecha = fechaCitas;
                citasNewS.Hora = request.Hora;
                citasNewS.CodigoCita = utilsGeneral.GenerarCodigoCita();
                citasNewS.Asistencia = true;
                citasNewS.Observaciones = "Confirma Cita";
                citasNewS.PacienteDocumento = request.NumeroDocumento;
                return Request.CreateResponse(HttpStatusCode.OK, result, Configuration.Formatters.JsonFormatter);
                //return result = medicalProcess.CrearCitaMedicalApp(citasNewS, pacienteModel);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result, Configuration.Formatters.JsonFormatter);
            }
            return Request.CreateResponse(HttpStatusCode.OK, result, Configuration.Formatters.JsonFormatter);
        }
    
}
}