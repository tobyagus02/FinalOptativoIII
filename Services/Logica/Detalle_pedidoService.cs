using Repository.Data.Detalle_pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class Detalle_pedidoService : IDetalles_pedido
    {
        private Detalle_pedidoRepository detalle_PedidoRepository;
        public Detalle_pedidoService(string connectionString)
        {
            detalle_PedidoRepository = new Detalle_pedidoRepository(connectionString);
        }

        public bool add(Detalle_pedidoModel detalle_Pedido)
        {
            return validarDatos(detalle_Pedido) ? Detalle_pedidoRepository.add(detalle_Pedido) : throw new Exception("Error de Datos, comprobar en detalle_Pedido");

        }
        public IEnumerable<Detalle_pedidoModel> GetAll()
        {

            return Detalle_pedidoRepository.GetAll();
        }
        public bool delete(int id)
        {
            return id > 0 ? Detalle_pedidoRepository.delete(id) : false;
        }
        public bool update(Detalle_pedidoModel detalle_PedidoModel)
        {
            return validarDatos(detalle_PedidoModel) ? Detalle_pedidoRepository.update(detalle_PedidoModel) : throw new Exception("Error de Validacion de datos en detalles_Pedido, favor corroNorar");
        }
        private bool Esnumero(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        private bool validarDatos(Detalle_pedidoModel detalle_Pedido)
        {
            if (detalle_Pedido == null)
                return false;
            if (string.IsNullOrEmpty(detalle_Pedido.id_producto) && detalle_Pedido.id_producto.Length < 1)
                return false;
            if (string.IsNullOrEmpty(detalle_Pedido.id_pedido) && detalle_Pedido.id_pedido.Length < 1)
                return false;
            if (string.IsNullOrEmpty(detalle_Pedido.cantidad_producto) && detalle_Pedido.cantidad_producto.Length < 1)
                return false;
            if (string.IsNullOrEmpty(detalle_Pedido.subtotal)) return false;

            return true;
        }
    }
}

