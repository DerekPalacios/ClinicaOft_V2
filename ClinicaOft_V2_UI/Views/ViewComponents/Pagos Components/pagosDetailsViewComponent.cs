using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
namespace ClinicaOft_V2_UI.Views.ViewComponents.Pagos_Components
{
    public class pagosDetailsViewComponent : ViewComponent
    {

        private PagoModelController pagoModel;

        public pagosDetailsViewComponent(ClinicaDBContext context) => pagoModel = new PagoModelController(context);

        public IViewComponentResult Invoke(int? idCuenta)
        {
            return View(pagoModel.GetPagoDetailList(idCuenta));
        }

    }
}
