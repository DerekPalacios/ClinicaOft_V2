using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Capa_Logica_Negocio.Models;
using Capa_Logica_Negocio.Context;
namespace Capa_Logica_Negocio
{
    public class PagoModelController
    {
        ClinicaDBContext _context;
        public PagoModelController(ClinicaDBContext context) => _context = context;
        public IEnumerable<PagoModel> GetPagoList() => _context.tbl_Pago;


        public IEnumerable<PagoModel> GetPagoDetailList(int? idCuenta)
        {
            if (idCuenta.HasValue)
            {
                return GetPagoList().Where(items => items.IdCuenta_Pago == idCuenta).TakeLast(10);

            }
            else
            {
                return null;
            }
        }
    }
}
