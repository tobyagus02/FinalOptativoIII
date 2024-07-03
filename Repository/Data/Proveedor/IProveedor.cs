using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Proveedor
{
    public interface IProveedor
    {
        bool add(ProveedorModel proveedormodel);
        bool update(ProveedorModel proveedormodel);
        bool delete(int id);
        IEnumerable<ProveedorModel> GetAll();
    }
}
