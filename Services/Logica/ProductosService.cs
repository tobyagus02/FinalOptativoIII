using Repository.Data.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ProductosService 
    {
        private ProductoRepository productoRepository;
        public ProductosService(string connectionString)
        {

            productoRepository = new ProductoRepository(connectionString);
        }


        private bool ValidarDatos(ProductoModel producto)
        {
            
            if (string.IsNullOrEmpty(producto.descripccion) ||
                string.IsNullOrEmpty(producto.cantidad_minima) ||
                string.IsNullOrEmpty(producto.cantidad_stock) ||
                string.IsNullOrEmpty(producto.precio_compra) ||
                string.IsNullOrEmpty(producto.precio_venta) ||
                string.IsNullOrEmpty(producto.categoria) ||
                string.IsNullOrEmpty(producto.marca) ||
                string.IsNullOrEmpty(producto.estado))
            {
                return false;
            }

            
            if (!int.TryParse(producto.cantidad_minima, out int cantidadMinima) || cantidadMinima <= 1)
            {
                return false;
            }

            
            if (!int.TryParse(producto.precio_compra, out int precioCompra) || precioCompra < 0 ||
                !int.TryParse(producto.precio_venta, out int precioVenta) || precioVenta < 0)
            {
                return false;
            }

            return true;
        }

        public bool add(ProductoModel producto)
        {
            return ValidarDatos(producto) ? productoRepository.add(producto) : throw new Exception("Error de la Validacion de Datos, corroborar :3");

        }
        public IEnumerable<ProductoModel> GetALL()
        {
            return productoRepository.GetAll();
        }
        public bool delete(int id)
        {
            return id > 0 ? productoRepository.delete(id) : false;
        }
        public bool update(ProductoModel productomodelo)
        {
            return ValidarDatos(productomodelo) ? productoRepository.update(productomodelo) : throw new Exception("Error al validar datos vuelva a intentar");


        }

    }
}
