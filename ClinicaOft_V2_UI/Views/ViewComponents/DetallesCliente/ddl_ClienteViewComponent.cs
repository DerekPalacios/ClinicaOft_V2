using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
using Capa_Logica_Negocio.Models;
namespace ClinicaOft_V2_UI.Views.ViewComponents.DetallesCliente
{
    public class ddl_ClienteViewComponent:ViewComponent 
    {
        private ClienteModelController clienteModel;

        public ddl_ClienteViewComponent(ClinicaDBContext context) => clienteModel = new ClienteModelController(context);

        public IViewComponentResult Invoke()
        {
            return View(clienteModel.getClienteDetailsForDDL());
        }




    }
}
