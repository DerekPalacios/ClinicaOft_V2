using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
using Capa_Logica_Negocio.Models;
namespace ClinicaOft_V2_UI.Controllers
{
    public class CuentaClienteMainViewsController : Controller
    {
        private CuentaClienteModelController cuentaCliente;

        public CuentaClienteMainViewsController(ClinicaDBContext context) => cuentaCliente = new CuentaClienteModelController(context);

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult MainView()
        {
            return View(cuentaCliente.GetCuentaList());
        }



    }
}
