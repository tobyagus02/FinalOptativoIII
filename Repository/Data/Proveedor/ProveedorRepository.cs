using Npgsql;
using Dapper;
using Repository.Data.Proveedor;
using Repository.Data.ConfiguracionesDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Repository.Data.Proveedor
{
    
    public class ProveedorRepository : IProveedor
    {
        IDbConnection connection;
        public ProveedorRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(ProveedorModel proveedormodel)
        {
            try
            {
                
                connection.Execute("INSER INTO proveedor(razon_social,tipo_doc,numero_doc,direccion,mail,celular,estado)" +
                          $"Values( @razon_social, @tipo_doc, @numero_doc, @direccion, @mail, @celular, @estado)", proveedormodel);
                    
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ProveedorModel> GetAll()
        {
            return connection.Query<ProveedorModel>("SELECT * FROM proveedor");
        }
        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM proveedor WHERE id ={id}");
            return true;
        }

        public bool update(ProveedorModel proveedormodel)
        {
            try
            {
                connection.Execute("UPDATE INTO proveedor Set " +
                        "razon_social=@nombre" +
                        "tipo_doc=@apellido," +
                        "numero_doc=@cedula," +
                        "direccion@direccion," +
                        "mail@mail," +
                        "celular@celular," +
                        "estado@estado" +
                        $"WERE id=@id", proveedormodel);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}


