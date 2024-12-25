using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionBDpymeTransporte.Models
{
    internal class Transporte
    {
            public int IdTransporte { get; set; }
            public string Nombre { get; set; }
            private string connectionString
                = "server=MSI\\SQLEXPRESS; initial catalog=BDPYME;" +
                "User=sa;Password=it2990";
        
                public List<Transporte> Get()
                {
                    List<Transporte> articulos = new List<Transporte>();

                    string query = "select IdTransporte,nombre from transportes";

                    using (SqlConnection coneccion = new SqlConnection(connectionString))
                    {
                        SqlCommand comando = new SqlCommand(query, coneccion);

                        coneccion.Open();
                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            string idtransporte = reader.GetString(0);
                            string Nombre = reader.GetString(1);

                            Transporte TransporteWhile = new Transporte();
                            TransporteWhile.IdTransporte = Convert.ToInt32(idtransporte);
                            TransporteWhile.Nombre = Nombre;
                            articulos.Add(TransporteWhile);
                        }

                        reader.Close();
                        coneccion.Close();
                    }

                    return articulos;
                }


        



    }
}
