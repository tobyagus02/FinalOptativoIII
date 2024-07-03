using Repository.Data.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Productos
{
    internal interface IProductos
    {
        bool add(ProductoModel productomodel);
        bool update(ProductoModel productomodel);
        bool delete(int id);
        IEnumerable<ProductoModel> GetALL();



    }
}
