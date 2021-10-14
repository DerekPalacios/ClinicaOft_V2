using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Logica_Negocio.Models;
namespace Capa_Logica_Negocio.Context
{
    public class ClinicaDBContext : DbContext
    {
        public ClinicaDBContext(DbContextOptions<ClinicaDBContext> options) : base(options)
        {

        }
        
        public DbSet<ClienteModel> tbl_Cliente { get; set; }
        public DbSet<OftalmologoModel> tbl_Oftalmologo { get; set; }
        public DbSet<PacienteModel> tbl_Paciente { get; set; }
        public DbSet<TipoConsultaModel> tbl_Tipo_Consulta { get; set; }
        public DbSet<CitaModel> tbl_Cita { get; set; }
        public DbSet<ConsultaModel> tbl_Consulta {  get; set; }
        public DbSet<FacturaConsultaModel> tbl_Factura_Consulta { get; set; }
        public DbSet<CuentaClienteModel> tbl_Cuenta_Cliente { get; set; }
        public DbSet<PagoModel> tbl_Pago { get; set; }
        public DbSet<CreditoConsultaModel> tbl_Credito_Consulta { get;set;  }

    }
}
