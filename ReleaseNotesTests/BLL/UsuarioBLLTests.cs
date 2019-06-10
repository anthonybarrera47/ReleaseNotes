using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReleaseNotes.BLL;
using ReleaseNotes.DAL;
using ReleaseNotes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNotes.BLL.Tests
{
    [TestClass()]
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Usuario usuario = new Usuario(0,"Juan","Juan","root1234","a",DateTime.Now);
            paso = UsuarioBLL.Guardar(usuario);
            Assert.AreEqual(paso,true);
        }
    }
}