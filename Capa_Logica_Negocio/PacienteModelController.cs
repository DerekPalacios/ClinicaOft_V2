using System;
using System.Collections.Generic;
using Capa_Logica_Negocio.Models;
using Capa_Logica_Negocio.Context;

namespace Capa_Logica_Negocio
{
    public class PacienteModelController
    {
        private ClinicaDBContext _context;

        public PacienteModelController(ClinicaDBContext context) => _context = context;

        public IEnumerable<PacienteModel> GetPacienteList() => _context.tbl_Paciente;
        public bool AddPaciente(PacienteModel Paciente)
        {
            try
            {
                _context.tbl_Paciente.Add(Paciente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PacienteModel GetPacienteById(int IdPaciente)
        {
            try
            {
                var paciente = _context.tbl_Paciente.Find(IdPaciente);
                if (paciente == null)
                {
                    return null;
                }
                else
                {
                    return paciente;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool EdiPaciente(PacienteModel paciente)
        {
            try
            {
                _context.tbl_Paciente.Update(paciente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DeletePaciente(PacienteModel paciente)
        {
            try
            {
                _context.tbl_Paciente.Remove(paciente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
