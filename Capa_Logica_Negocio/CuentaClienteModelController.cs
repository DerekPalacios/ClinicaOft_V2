using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Logica_Negocio.Models;
using Capa_Logica_Negocio.Context;
namespace Capa_Logica_Negocio
{
    public class CuentaClienteModelController
    {
        ClinicaDBContext _context;
        public CuentaClienteModelController(ClinicaDBContext context) => _context = context;

        public IEnumerable<CuentaClienteModel> GetCuentaList() => _context.tbl_Cuenta_Cliente;









    }
}
