using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class ServiciosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Assert.IsTrue(BLL.ServiciosBLL.Guardar(new Entidades.Servicios(1,"Pantalon Planchado",55)));
        }

        [TestMethod()]
        public void MofidicarTest()
        {
            Assert.IsTrue(BLL.ServiciosBLL.Guardar(new Entidades.Servicios(1, "Pantalon Planchado", 55)));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(BLL.ServiciosBLL.Guardar(new Entidades.Servicios(1, "Pantalon Planchado", 55)));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Assert.IsNotNull(ServiciosBLL.Buscar(s => s.ServicioId == id));
        }

        [TestMethod()]
        public void ListarTest()
        {
            int id = 1;
            Assert.IsNotNull(ServiciosBLL.Listar(s=> s.ServicioId == id));
        }

        [TestMethod()]
        public void ListarTodoTest()
        {
            Assert.IsNotNull(ServiciosBLL.ListarTodo());
        }
    }
}