using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Logica_Negocio.Models;
using Capa_Logica_Negocio.Context;
namespace Capa_Logica_Negocio
{

    public class ClienteModelController
    {

        ClinicaDBContext _context;

        public ClienteModelController(ClinicaDBContext context) => _context = context;

        public IEnumerable<ClienteModel> GetClienteList() => _context.tbl_Cliente;
        public bool AddCliente(ClienteModel cliente)
        {
            try
            {
                _context.tbl_Cliente.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ClienteModel GetClienteById(int Idcliente)
        {
            try
            {
                var cliente = _context.tbl_Cliente.Find(Idcliente);
                if (cliente == null)
                {
                    return null;
                }
                else
                {
                    return cliente;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool EditCliente(ClienteModel cliente)
        {
            try
            {
                _context.tbl_Cliente.Update(cliente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DeleteCliente(ClienteModel cliente)
        {
            try
            {
                _context.tbl_Cliente.Remove(cliente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<object> getClienteDetailsForDDL()
        {
            IEnumerable<object> clienteDetails = from ClienteModel in GetClienteList()
                                                 select new { IdCliente = ClienteModel.Id_Cliente, NombresCliente = ClienteModel.Nombres_Cliente + " " + ClienteModel.Apellidos_Cliente };
            return clienteDetails;
        }
    }
}
