using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Assert.IsTrue(BLL.UsuariosBLL.Guardar(new Entidades.Usuarios(1, "Sea01", "Seatiel", "bhj12345", 1)));
        }

        [TestMethod()]
        public void MofidicarTest()
        {
            //Assert.IsTrue();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListarTodoTest()
        {
            Assert.Fail();
        }
    }
}