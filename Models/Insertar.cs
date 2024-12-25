using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionBDpymeTransporte.Models
{
    internal class Insertar
    {

        public int IdTransporte { get; set; }
        public string Nombre { get; set; }
        private string connectionString
            = "server=MSI\\SQLEXPRESS; initial catalog=BDPYME;" +
            "User=sa;Password=it2990";

        public void Add(Insertar InsertarTransporte)
        {
            string query
            = "insert into transportes(idtransporte, nombre) " +
            " values(@Idtransporte,@Nombre) ";


            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Idtransporte", InsertarTransporte.IdTransporte);
                command.Parameters.AddWithValue("@Nombre", InsertarTransporte.Nombre);

                connection.Open(); //Abro la conexcion
                command.ExecuteNonQuery(); //es para ejecutar el insert

                connection.Close(); //Cierro la conexcion
            }



        }


    }
}
