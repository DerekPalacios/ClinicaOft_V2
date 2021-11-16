using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
using Capa_Logica_Negocio.Models;

namespace ClinicaOft_V2_UI.Controllers
{
    public class ClienteMainViewController : Controller
    {

        private ClienteModelController clienteModel;

        public ClienteMainViewController(ClinicaDBContext context) => clienteModel = new ClienteModelController(context);


        public IActionResult MainIndex()
        {
            return View(clienteModel.GetClienteList());
        }

        public IActionResult Create()
        {
            return View();
        }


        //Http post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClienteModel cliente)
        {

            if (ModelState.IsValid)
            {
                var clienteIsAdded = clienteModel.AddCliente(cliente);
                if (clienteIsAdded)
                {
                    TempData["mensaje"] = "El Cliente se ha creado correctamente";
                    return RedirectToAction("MainIndex");

                }
                else
                {
                    TempData["mensaje"] = "El Cliente no se ha creado!";
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
            return View(clienteModel.GetClienteById((int)id));

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteIdEdited = clienteModel.EditCliente(cliente);
                TempData["mensaje"] = "El Registro de Cliente se ha actualizado correctamente";
                return RedirectToAction("MainIndex");
            }
            else
            {
                TempData["mensaje"] = "El Registro de Cliente no pudo ser actualizado";
                return RedirectToAction("MainIndex");
            }


        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            return View(clienteModel.GetClienteById((int)id));
        }

        //Http post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(ClienteModel cliente)
        {
            //obtener  el libro por id
            var clienteIsDeleted = clienteModel.DeleteCliente(cliente);
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
