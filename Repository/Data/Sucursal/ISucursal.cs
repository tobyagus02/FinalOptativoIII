using Repository.Sucursal;
using Dapper;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Sucursal
{
    internal interface ISucursal
    {
        bool add(SucursalModel sucursalmodel);
        bool update(SucursalModel sucursalmodel);
        bool delete(int id);
        IEnumerable<SucursalModel> GetALL();



    }
}
