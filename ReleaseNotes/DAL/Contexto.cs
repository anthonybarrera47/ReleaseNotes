using ReleaseNotes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNotes.DAL
{
    public class Contexto : DbContext
    {
        
            public DbSet<Usuario> Usuarios { get; set; }
            public Contexto() : base("ConStr")
            {

            }
    
    }
}
