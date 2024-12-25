using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionBDpymeTransporte.Models
{
    internal class Editar_valores
    {

        public int IdTransporte { get; set; }
        public string Nombre { get; set; }
        private string connectionString
            = "server=MSI\\SQLEXPRESS; initial catalog=BDPYME;" +
            "User=sa;Password=it2990";


        public void Edit(Transporte Transporte)
        {
            string query
            = " update transportes set nombre = @nombre where idTransporte = @idtransporte";


            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Idtransporte", Transporte.IdTransporte);
                command.Parameters.AddWithValue("@Nombre", Transporte.Nombre);

                connection.Open(); //Abro la conexcion
                command.ExecuteNonQuery(); //es para ejecutar el insert

                connection.Close(); //Cierro la conexcion
            }



        }



    }
}
