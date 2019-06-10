using ReleaseNotes.DAL;
using ReleaseNotes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNotes.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(Usuario Usuario)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                if (db.Usuarios.Add(Usuario) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {throw;}
            finally
            {db.Dispose();}
            return paso;
        }
        public static bool Modificar(Usuario Usuario)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                db.Entry(Usuario).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() > 0)
                    paso = true;
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Usuario Usuario = db.Usuarios.Find(id);
                db.Usuarios.Remove(Usuario);
                if (db.SaveChanges() > 0)
                    paso = true;
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }
        public static Usuario Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuario Usuario = new Usuario();
            try
            {
                Usuario = db.Usuarios.Find(id);
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return Usuario;
        }
        public static List<Usuario> GetList(Expression<Func<Usuario, bool>> expression)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            Contexto db = new Contexto();
            try
            {
                Usuarios = db.Usuarios.Where(expression).ToList();
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return Usuarios;
        }
    }
}
