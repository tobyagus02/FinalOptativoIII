using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamenParcial_OptativoIII.Modelos
{
    public abstract class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Celular { get; set; }
        public string Estado { get; set; }

        public string getApellido()
        {
            return Apellido;
        }
        public void setApellido(string _apellido)
        {
            Apellido = _apellido;
        }
        public string getNombre()
        {
            try
            {
                if (string.IsNullOrEmpty(Nombre))
                    throw new Exception("El nombre no puede dejar vacìo");
                else
                    return Nombre;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setNombre(string _nombre)
        {
            this.Nombre = _nombre;
        }

        public abstract void imprimirResponsabilidad();
    }
}
