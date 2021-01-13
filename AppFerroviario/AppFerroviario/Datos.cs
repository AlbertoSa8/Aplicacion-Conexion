using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AppFerroviario
{
    public class Datos
    {
        private static string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database = Ferroviario; Trusted_Connection = True;";
        private static SqlConnection conexion = new SqlConnection(cadenaConexion);

        public static int EjecutarConsulta(string consulta)
        {
            int registroAfectados = 0;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            registroAfectados = comando.ExecuteNonQuery();
            conexion.Close();
            return registroAfectados;
            
        }

        public static void AgregarDataTable(DataSet ds, string consulta, string nombreTabla)
        {
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, cadenaConexion);

                da.Fill(ds, nombreTabla);
            }
            catch
            {
                MessageBox.Show("No se puede esta tabla hace referencia con una tabla foranea");
            }
               

            
           

            



        }
    }
}
    

