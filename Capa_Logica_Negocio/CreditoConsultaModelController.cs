using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Capa_Logica_Negocio.Models;
using Capa_Logica_Negocio.Context;
namespace Capa_Logica_Negocio
{
    public class CreditoConsultaModelController
    {
        ClinicaDBContext _context;
        public CreditoConsultaModelController(ClinicaDBContext context) => _context = context;
        public IEnumerable<CreditoConsultaModel> GetCreditoConsultaList() => _context.tbl_Credito_Consulta;


        public IEnumerable<CreditoConsultaModel> GetCreditoConsultaDetailList(int? idCuenta)
        {
            if (idCuenta.HasValue)
            {
                return GetCreditoConsultaList().Where(items => items.IdCuentaCliente_Credito_Consulta == idCuenta).TakeLast(10);

            }
            else
            {
                return null;
            }
        }
    }
}
