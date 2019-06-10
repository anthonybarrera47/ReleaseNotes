using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseNotes.DAL
{
    public class DBConexion
    {
        
        public static SqlConnection GetConnection()
        {
            string connetionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Test;
            Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Conexion Exitosa!!");
            return cnn;
        }
    }
}
