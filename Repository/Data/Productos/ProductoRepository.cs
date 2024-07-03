using Dapper;
using Repository.Data.ConfiguracionesDB;
using Repository.Data.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Productos
{
    public class ProductoRepository : IProductos
    {
        IDbConnection connection;

        public ProductoRepository(string connectionString)
        {

            connection = new ConnectionDB(connectionString).OpenConnection();
        }
        public bool add(ProductoModel productomodel)
        {
            try
            {
                connection.Execute("INSERT INTO productos (descripcion, cantidad_minima, cantidad_stock, precio_compra, precio_venta, categoria, marca, ,estado)" +
                    $"Values(@descripcion, @cantidad_minima, @cantidad_stock, @precio_compra, @precio_venta, @categoria, @marca, @estado)", productomodel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<ProductoModel> GetAll()
        {
            return connection.Query<ProductoModel>("SELECT * FROM productos");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM productos WHERE id= {id}");

        }

        public bool update(ProductoModel productomodel)
        {
            try
            {
                connection.Execute("UPDATE productos SET " +
                "@descripcion," +
                    " @cantidad_minima, " +
                    " @cantidad_stock," +
                    " @precio_compra, " +
                    "@precio_venta, " +
                    "@categoria, " +
                    "@marca, " +
                    "@estado)" +
                    $"WHERE id = @id", productomodel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
