using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;
using Repository.Data.Detalle_pedido;
using Repository.Data.ConfiguracionesDB;

namespace Repository.Data.Detalle_pedido
{
    public class Detalle_pedidoRepository : IDetalles_pedido  
    {
        IDbConnection connection;
        public Detalle_pedidoRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }
        public bool add(Detalle_pedidoModel detalle_PedidoModel)
        {
            try
            {
                connection.Execute("INSERT INTO detalle_pedido(id_pedido,id_producto,cantidad_producto,subtotal)" +
                      $"Values(@id_pedido, @id_producto, @cantidad_producto, @subtotal)", detalle_PedidoModel);
                    
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Detalle_pedidoModel> GetAll()
        {
            return connection.Query<Detalle_pedidoModel>("Select * From detalle_pedido");
        }

        public bool delete(int id)
        {
            connection.Execute($"Delete From detalle_pedido Where id={id}");
        }
        public bool update(Detalle_pedidoModel detalle_PedidoModel)
        {
            try
            {

                connection.Execute("UPDATE INTO detalle_pedido Set (" +
                    "id_pedido=@id_pedido" +
                    "id_producto=@id_producto," +
                    "cantidad_producto=@cantidad_producto," +
                    "subtotal=@subtotal)" +

                    $"WERE id=@id", detalle_PedidoModel);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}
