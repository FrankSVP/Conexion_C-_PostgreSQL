using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionConPostgreSQL.Clases
{
    class CConexion
    {
        NpgsqlConnection conex = new NpgsqlConnection();

        static String servidor="localhost";
        static String bd="dbjava";
        static String usuario="postgres";
        static String password="root";
        static String puerto = "5432";

        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public NpgsqlConnection establecerConexion() {

            try {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conectó correctamente a la Base de datos");

            }

            catch (NpgsqlException e) {
                MessageBox.Show("No se pudo conectar a la base de datos de PostgreSQL, error: "+ e.ToString());
            
            }

            return conex;
        }


    }
}
