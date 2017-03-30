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
    public class FacturasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Assert.IsTrue(BLL.FacturasBLL.Guardar(new Entidades.Facturas(1, DateTime.Now, 1, 1234)));
        }

        [TestMethod()]
        public void MofidicarTest()
        {
            Assert.IsTrue(BLL.FacturasBLL.Guardar(new Entidades.Facturas(1, DateTime.Now, 1, 1234)));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(BLL.FacturasBLL.Guardar(new Entidades.Facturas(1, DateTime.Now, 1, 1234)));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Assert.IsNotNull(BLL.FacturasBLL.Buscar(f => f.FacturaId == id));
        }

        [TestMethod()]
        public void ListarTest()
        {
            int id = 1;
            Assert.IsNotNull(BLL.FacturasBLL.Listar(f => f.FacturaId == id));
        }

        [TestMethod()]
        public void ListarTodoTest()
        {
            Assert.IsNotNull(BLL.FacturasBLL.ListarTodo());
        }
    }
}