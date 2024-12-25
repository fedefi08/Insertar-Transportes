using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionBDpymeTransporte.Models
{
    internal class Eliminar
    {

        public int IdTransporte { get; set; }
        public string Nombre { get; set; }
        private string connectionString
            = "server=MSI\\SQLEXPRESS; initial catalog=BDPYME;" +
            "User=sa;Password=it2990";



        //Eliminar
        public void Delete(int idTransporte)
        {
            string query
            = " delete from transportes where idTransporte = @idtransporte";


            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdTransporte", idTransporte);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }



        }


    }
}
