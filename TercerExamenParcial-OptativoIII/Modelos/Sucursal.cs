using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamenParcial_OptativoIII.Modelos
{
    public abstract class Sucursal
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Whatsapp { get; set; }
        public string Mail { get; set; }
        public string Estado { get; set; }

        public string getDireccion()
        {
            return Direccion;
        }
        public void setDireccion(string _direccion)
        {
            Direccion = _direccion;
        }
        public string getDescripcion()
        {
            try
            {
                if (string.IsNullOrEmpty(Descripcion))
                    throw new Exception("La descripcion no puede dejar vacìo");
                else
                    return Descripcion;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setDescripcion(string _descripcion)
        {
            this.Descripcion = _descripcion;
        }

        public abstract void imprimirResponsabilidad();
    }
}
