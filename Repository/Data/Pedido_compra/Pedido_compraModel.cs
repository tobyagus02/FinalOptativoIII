using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Pedido_compra
{
    public class Pedido_compraModel
    {
        public int id { get; set; }
        public string id_proveedor { get; set; }
        public string id_sucursal { get; set; }
        public string fecha_hora { get; set; }
        public string total { get; set; }

    }
}
