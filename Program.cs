using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Cliente
{
    private string connectionString = "Host=localhost;port=5432;Database=postgres;username=postgres;password=12344321;";
    ClienteService clienteRepository = new ClienteService(ConnectionString);


}
