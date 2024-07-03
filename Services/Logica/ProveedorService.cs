using Repository.Data.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ProveedorService
    {

        private ProveedorService ProveedorRepository;
        public ProveedorService(String connectionString)
        {
            ProveedorService proveedorService = new(connectionString);
            ProveedorRepository = proveedorService;
            
        }

        public bool add(ProveedorModel proveedormodel) 
        {
            return validardatos(proveedormodel) ? ProveedorRepository.add(proveedormodel) : throw new Exception("Error de Datos, comprovar en proveedor");

        }
        public IEnumerable<ProveedorModel> GetAll()
        {

            return ProveedorRepository.GetAll();
        }
        public bool delete(int id)
        {
            return id > 0 ? ProveedorRepository.delete(id) : false;
        }
        public bool update(ProveedorModel Proveedor)
        {
            return validardatos(Proveedor) ? ProveedorRepository.update(Proveedor) : throw new Exception("Error de Datos, comprovar en proveedor");
        }
        private bool Esnumero(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;

        }
        private bool validardatos(ProveedorModel Proveedor)
        {
            if (Proveedor == null)
                return false;
            if (string.IsNullOrEmpty(Proveedor.razon_social) && Proveedor.razon_social.Length < 3)
                return false;
            if (string.IsNullOrEmpty(Proveedor.tipo_documento) && Proveedor.tipo_documento.Length < 3)
                return false;
            if (string.IsNullOrEmpty(Proveedor.numero_documento) && Proveedor.numero_documento.Length < 3)
                return false;
            if (string.IsNullOrEmpty(Proveedor.direccion)) return false;
            if (string.IsNullOrEmpty(Proveedor.mail)) return false;
            if (string.IsNullOrEmpty(Proveedor.celular) || Proveedor.celular.Length != 10 || !!Esnumero(Proveedor.celular))
                return false;
            if (string.IsNullOrEmpty(Proveedor.estado)) return false;



            return false;
            return true;
        }
    }
}
