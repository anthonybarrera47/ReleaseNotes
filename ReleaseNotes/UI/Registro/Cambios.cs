using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseNotes.UI.Registro
{
    public partial class Cambios : Form
    {
        public Cambios()
        {
            InitializeComponent();
        }
        public Entidades.Usuario GetUsuario()
        {
            Entidades.Usuario usuario = new Entidades.Usuario();
            usuario = BLL.UsuarioBLL.Buscar(1);
            return usuario;
        }
        public void Insertar(int IdUsuario,int IdCambios)
        {

        }
        public void GetCambios(int IdUsuario)
        {
            Entidades.Usuario usuario = GetUsuario();
            SqlCommand command;
            SqlDataAdapter dataAdapter;
            String sql = "SELECT ";
        }
        public string GetVersion()
        {
            string version = Application.ProductVersion;
            return version;
        }
    }
}
