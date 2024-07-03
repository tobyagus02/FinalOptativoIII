using Repository.Data.Pedido_compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class Pedido_compraService 
    {
        private Pedido_compraRepository pedido_CompraRepository;
        public Pedido_compraService(string connectionString)
        {
            pedido_CompraRepository = new Pedido_compraRepository(connectionString);
        }

        public bool add(Pedido_compraModel pedido_Compra)
        {
            return Validardatos(pedido_Compra) ? pedido_CompraRepository.add(pedido_Compra) : throw new Exception("Error de datos Corroborar");


        }
        public IEnumerable<Pedido_compraModel> GetAll()
        {
            return pedido_CompraRepository.GetAll();
        }
        public bool delete(int id)
        {
            return id > 0 ? pedido_CompraRepository.delete(id) : false;
        }

        public bool update(Pedido_compraModel pedido_Compra)
        {
            return Validardatos(pedido_Compra) ? pedido_CompraRepository.update(pedido_Compra) : throw new Exception("Error de Validacion de datos corroborar");
        }


        private bool Validardatos(Pedido_compraModel pedido_Compra)
        {

            if (pedido_Compra == null)
                return false;
            if (string.IsNullOrEmpty(pedido_Compra.id)) return false;
            if (string.IsNullOrEmpty(pedido_Compra.id_proveedor)) return false;
            if (string.IsNullOrEmpty(pedido_Compra.id_sucursal)) return false;
            if (string.IsNullOrEmpty(pedido_Compra.fecha_hora)) return false;
            if (string.IsNullOrEmpty(pedido_Compra.total)) return false;


            return true;
        }
    }
}

