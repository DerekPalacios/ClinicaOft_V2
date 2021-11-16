using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
using Capa_Logica_Negocio.Models;

namespace ClinicaOft_V2_UI.Controllers
{
    public class PacienteMainViewController : Controller
    {

        private PacienteModelController pacienteModel;

        public PacienteMainViewController(ClinicaDBContext context) => pacienteModel = new PacienteModelController(context);

        //vista principal
        public IActionResult MainIndex()
        {
            return View(pacienteModel.GetPacienteList());
        }

        //pre vista de creacion
        public IActionResult CreatePaciente()
        {
            return View();
        }
        //vista de creacion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePaciente(PacienteModel paciente)
        {

            if (ModelState.IsValid)
            {
                var pacienteIsAdded = pacienteModel.AddPaciente(paciente);
                if (pacienteIsAdded)
                {
                    TempData["mensaje"] = "El Paciente se ha creado correctamente";
                    return RedirectToAction("MainIndex");

                }
                else
                {
                    TempData["mensaje"] = "El libro no se ha creado!";
                    return View();
                }
            }

            return View();
        }


        //PageRemoteAttribute vista de edicion 
        public IActionResult EditPaciente(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            return View(pacienteModel.GetPacienteById((int)id));

        }
        //vista de edicion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPaciente(PacienteModel paciente)
        {
            if (ModelState.IsValid)
            {
                var pacienteIdEdited = pacienteModel.EdiPaciente(paciente);
                TempData["mensaje"] = "El Registro de paciente se ha actualizado correctamente";
                return RedirectToAction("MainIndex");
            }
            else
            {
                TempData["mensaje"] = "El Registro de paciente no pudo ser actualizado";
                return RedirectToAction("MainIndex");
            }


        }


        //prevista de eliminacion
        public IActionResult DeletePaciente(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            return View(pacienteModel.GetPacienteById((int)id));
        }
        //vista de eliminacion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePaciente(PacienteModel paciente)
        {
            //obtener  el libro por id
            var pacienteIsDeleted = pacienteModel.DeletePaciente(paciente);
            if (pacienteIsDeleted)
            {
                TempData["mensaje"] = "El Registro se ha Eliminado  correctamente";
                return RedirectToAction("MainIndex");
            }


            TempData["mensaje"] = "El Registro no pudo ser Eliminado  correctamente";
            return RedirectToAction("MainIndex");
        }


    }
}
