using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Pedido_compra
{
    internal interface IPedido_compra
    {
        bool add(Pedido_compraModel pedido_Compramodel);
        bool update(Pedido_compraModel pedido_Compramodel);
        bool delete(int id);
        IEnumerable<Pedido_compraModel> GetALL();



    }
}
