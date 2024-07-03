using Dapper;
using Npgsql;
using Repository.Data.ConfiguracionesDB;
using Repository.Data.Sucursal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sucursal
{
    public class SucursalRepository : ISucursal
    {
        IDbConnection connection;
        public SucursalRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(SucursalModel sucursalModel)
        {
            try
            {
                connection.Execute("INSERT INTO Sucursal(Descripcion, Direccion, Telefono, Whatsapp, Mail, estado) " +
                    $"Values(@Descripcion,@Direccion,@Telefono,@Whatsapp,@Mail,@estado)", sucursalModel);
                    
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<SucursalModel> GetAll()
        {
            return connection.Query<SucursalModel>("SELECT * FROM sucursal");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM sucursal WHERE id= {id}");

        }

        public bool update(SucursalModel sucursalmodel)
        { 
            try
            {
                connection.Execute("UPDATE sucursal SET " +
                    "@Descripcion," +
                    " @Direccion," +
                    " @Telefono," +
                    " @Whatsapp," +
                    " @Mail,}" +
                    " @estado" +
                    $"WHERE id = @id", sucursalmodel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
