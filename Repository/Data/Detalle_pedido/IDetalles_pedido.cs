using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Detalle_pedido
{
    public interface IDetalles_pedido
    {
        bool add(Detalle_pedidoModel detalle_PedidoModel);
        bool update(Detalle_pedidoModel detalle_PedidoModel);
        bool delete(int id);
        IEnumerable<Detalle_pedidoModel> GetAll();
    }
}
