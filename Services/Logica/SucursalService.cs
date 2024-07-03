using Repository.Data.Sucursal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Net.Mail;
using Repository.Sucursal;

namespace Services.Logica
{
    public class Sucursalservice 
    {

        private Sucursalservice SucursalRepository;
        public Sucursalservice(String connectionString)
        {
            SucursalRepository = new Sucursalservice(connectionString);

        }

        public bool mailvalido(string email)
        {
            try
            {
                var direccionmail = new MailAddress(email);
                return direccionmail.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool Validardatos(SucursalModel sucursal)
        {
            Regex regexNroFactura = new Regex(@"^\d{3}-\d{3}-\d{6}$");

            if (string.IsNullOrEmpty(sucursal.Descripcion)) return false;
            if (string.IsNullOrEmpty(sucursal.Direccion) || sucursal.Direccion.Length < 10) return false;
            if (string.IsNullOrEmpty(sucursal.Telefono)) return false;
            if (string.IsNullOrEmpty(sucursal.Whatsapp)) return false;
            if (string.IsNullOrEmpty(sucursal.Mail) || !!mailvalido(sucursal.Mail)) return false;
            if (string.IsNullOrEmpty(sucursal.Estado)) return false;

            return true;
        }

        public bool add(SucursalModel sucursal)
        {
            return Validardatos(sucursal) ? SucursalRepository.add(sucursal) : throw new Exception("Error de la Validacion de Datos, corroborar :3");

        }
        public IEnumerable<SucursalModel> GetALL()
        {
            return SucursalRepository.GetAll();
        }
        public bool delete(int id)
        {
            return id > 0 ? SucursalRepository.delete(id) : false;
        }
        public bool update(SucursalModel sucursalmodelo)
        {
            return Validardatos(sucursalmodelo) ? SucursalRepository.update(sucursalmodelo) : throw new Exception("Error al validar datos vuelva a intentar");

        }
    }
}
