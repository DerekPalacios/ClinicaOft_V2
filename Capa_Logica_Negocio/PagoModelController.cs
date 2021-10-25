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


        public IEnumerable<object> GetPagoDetailList(int idCuenta)
        {
            var pagos = from pago in GetPagoList()
                        where pago.IdCuenta_Pago == idCuenta
                        select new
                        {
                            pagador = pago.Pagador_Pago,
                            Concepto = pago.Concepto_Pago,
                            FechaPago = pago.Fecha_Pago,
                            Monto = pago.Monto_Pago
                        };
                        
            return pagos;
        }
    }
}
