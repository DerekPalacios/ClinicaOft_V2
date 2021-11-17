using System;
using System.Collections.Generic;
using Capa_Logica_Negocio.Models;
using Capa_Logica_Negocio.Context;

namespace Capa_Logica_Negocio
{
    public class OftalmologoModelController
    {
        private ClinicaDBContext _context;

        public OftalmologoModelController(ClinicaDBContext context) => _context = context;

        public IEnumerable<OftalmologoModel> GetOftalmologoList() => _context.tbl_Oftalmologo;
        public bool AddOftalmologo(OftalmologoModel Oftalmologo)
        {
            try
            {
                _context.tbl_Oftalmologo.Add(Oftalmologo);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public OftalmologoModel GetOftalmologoById(int IdOftalmologo)
        {
            try
            {
                var Oftalmologo = _context.tbl_Oftalmologo.Find(IdOftalmologo);
                if (Oftalmologo == null)
                {
                    return null;
                }
                else
                {
                    return Oftalmologo;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool EditOftalmologo(OftalmologoModel Oftalmologo)
        {
            try
            {
                _context.tbl_Oftalmologo.Update(Oftalmologo);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DeleteOftalmologo(OftalmologoModel Oftalmologo)
        {
            try
            {
                _context.tbl_Oftalmologo.Remove(Oftalmologo);
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