using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Assert.IsTrue(BLL.ClientesBLL.Guardar(new Entidades.Clientes(1,"Seatiel Ygnacio", "S.F.M.", "8092697360", DateTime.Now, "syr970220@gmail.com")));
        }

        [TestMethod()]
        public void MofidicarTest()
        {
            Assert.IsTrue(BLL.ClientesBLL.Mofidicar(new Entidades.Clientes(1, "Seatiel Ygnacio", "S.F.M.", "8092697360", DateTime.Now, "syr970220@gmail.com")));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(BLL.ClientesBLL.Eliminar(new Entidades.Clientes(1, "Seatiel Ygnacio", "S.F.M.", "8092697360", DateTime.Now, "syr970220@gmail.com")));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Assert.IsNotNull(BLL.ClientesBLL.Buscar(new Entidades.Clientes(), true));
        }

        [TestMethod()]
        public void ListarTest()
        {
            int id = 1;
            Assert.IsNotNull(BLL.ClientesBLL.Listar(c => c.ClienteId == id));
        }

        [TestMethod()]
        public void ListarTodoTest()
        {
            Assert.IsNotNull(BLL.ClientesBLL.ListarTodo());
        }
    }
}