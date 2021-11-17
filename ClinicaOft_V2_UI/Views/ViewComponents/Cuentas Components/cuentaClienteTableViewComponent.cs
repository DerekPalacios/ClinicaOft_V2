using Microsoft.AspNetCore.Mvc;
using Capa_Logica_Negocio;
using Capa_Logica_Negocio.Context;
namespace ClinicaOft_V2_UI.Views.ViewComponents.Cuentas_Components
{
    public class cuentaClienteTableViewComponent:ViewComponent
    {
        private CuentaClienteModelController cuentaClienteModel;
        public cuentaClienteTableViewComponent(ClinicaDBContext context) => cuentaClienteModel=new CuentaClienteModelController(context);

        public IViewComponentResult Invoke()
        {
            return View(cuentaClienteModel.GetCuentaList());
        }

    }
}
