using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamenParcial_OptativoIII.Modelos
{
    public abstract class Factura
    {
        public int Id { get; set; }
        public string Nro_Factura { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string Total { get; set; }
        public string Total_iva5 { get; set; }
        public string Total_iva10 { get; set; }
        public string Total_iva { get; set; }
        public string Total_letras { get; set; }
        public string Sucursal { get; set; }

        public string getNro_Factura()
        {
            return Nro_Factura;
        }
        public void setNro_Factura(string _nro_factura)
        {
            Nro_Factura = _nro_factura;
        }
        public string getTotal()
        {
            try
            {
                if (string.IsNullOrEmpty(Total))
                    throw new Exception("El total no puede dejar vacìo");
                else
                    return Total;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void setTotal(string _total)
        {
            this.Total = _total;
        }

        public abstract void imprimirResponsabilidad();
    }
}
