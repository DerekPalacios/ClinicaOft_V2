using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
namespace ClinicaOft_V2_UI.Views.ViewComponents.Creditos_Components
{
    public class creditoConsultaDetailsViewComponent : ViewComponent
    {
        private CreditoConsultaModelController creditoConsulta;

        public creditoConsultaDetailsViewComponent(ClinicaDBContext context) => creditoConsulta = new CreditoConsultaModelController(context);

        public IViewComponentResult Invoke(int? idCuenta)
        {
            return View(creditoConsulta.GetCreditoConsultaDetailList(idCuenta));
        }


    }
}
