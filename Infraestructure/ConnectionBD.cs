using Domain.IConnection;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Infraestructure.Connection
{
    public class ConnectionBD : IConnection
    {
        private string connection = string.Empty;

        public ConnectionBD()
        {
            try
            {
                var constructor = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.Development.json").Build();

                

                connection = constructor.GetSection("ConnectionStrings:conexion").Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR" + " " + ex.Message);
            }
        }

        public string var_conexion()
        {
            return connection;
        }
    }
}
