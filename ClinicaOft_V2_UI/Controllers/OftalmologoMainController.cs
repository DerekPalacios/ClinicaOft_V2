using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
using Capa_Logica_Negocio.Models;

namespace ClinicaOft_V2_UI.Controllers
{
    public class OftalmologoMainViewController : Controller
    {
        private OftalmologoModelController OftalmologoModel;

        public OftalmologoMainViewController(ClinicaDBContext context) => OftalmologoModel = new OftalmologoModelController(context);


        public IActionResult MainIndex()
        {
            return View(OftalmologoModel.GetOftalmologoList());
        }

        public IActionResult Create()
        {
            return View();
        }


        //Http post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OftalmologoModel oftalmologo)
        {

            if (ModelState.IsValid)
            {
                var OftalmologoIsAdded = OftalmologoModel.AddOftalmologo(oftalmologo);
                if (OftalmologoIsAdded)
                {
                    TempData["mensaje"] = "El Registro se ha creado correctamente";
                    return RedirectToAction("MainIndex");

                }
                else
                {
                    TempData["mensaje"] = "El Registro no se ha creado!";
                    return View();
                }
            }

            return View();
        }




        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            return View(OftalmologoModel.GetOftalmologoById((int)id));

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OftalmologoModel oftalmologo)
        {
            if (ModelState.IsValid)
            {
                var OftalmologoIdEdited = OftalmologoModel.EditOftalmologo(oftalmologo);
                TempData["mensaje"] = "El Registro se ha actualizado correctamente";
                return RedirectToAction("MainIndex");
            }
            else
            {
                TempData["mensaje"] = "El Registro no pudo ser actualizado";
                return RedirectToAction("MainIndex");
            }


        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            return View(OftalmologoModel.GetOftalmologoById((int)id));
        }

        //Http post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(OftalmologoModel oftalmologo)
        {
            //obtener  el libro por id
            var clienteIsDeleted = OftalmologoModel.DeleteOftalmologo(oftalmologo);
            if (clienteIsDeleted)
            {
                TempData["mensaje"] = "El Registro se ha Eliminado  correctamente";
                return RedirectToAction("MainIndex");
            }


            TempData["mensaje"] = "El Registro no pudo ser Eliminado  correctamente";
            return RedirectToAction("MainIndex");
        }
    }
}