using Domain;
using Domain.IConnection;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Domain.ICamiones;

namespace Infraestructure
{
    public class servicioCamion : ICamiones
    {
        private readonly IConnection cn;

        public servicioCamion(IConnection conexion)
        {
            cn = conexion;
        }

        public async Task Agregar_Camiones(Camion c)
        {
           using (var sql = new SqlConnection(cn.var_conexion()))
           {
                using (var cmd = new SqlCommand("agregar_camion", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@marca", c.Marca);
                    cmd.Parameters.AddWithValue("@placa", c.Placa);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
           }
                
            
        }
    }
}
