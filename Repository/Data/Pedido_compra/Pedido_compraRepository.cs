using Dapper;
using Repository.Data.ConfiguracionesDB;
using Repository.Data.Pedido_compra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Pedido_compra
{
    public class Pedido_compraRepository : IPedido_compra
    {
        IDbConnection connection;

        public Pedido_compraRepository(string connectionString)
        {

            connection = new ConnectionDB(connectionString).OpenConnection();
        }
        public bool add(Pedido_compraModel pedido_Compramodel)
        {
            try
            {
                connection.Execute("INSERT INTO pedido_compra (id_proveedor, id_sucursal, fecha_hora, total)" +
                $"Values(@id_proveedor, @id_sucursal, @fecha_hora, @total)", pedido_Compramodel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Pedido_compraModel> GetAll()
        {
            return connection.Query<Pedido_compraModel>("SELECT * FROM pedido_compra");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM pedido_compra WHERE id= {id}");

        }

        public bool update(Pedido_compraModel pedido_Compramodel)
        {
            try
            {
                connection.Execute("UPDATE pedido_compra SET " +
            "@id_proveedor," +
            " @id_sucursal, " +
            "@fecha_hora, " +
            "@total)" +
                    $"WHERE id = @id", pedido_Compramodel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
