using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class TiposusuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Assert.IsTrue(BLL.TiposusuariosBLL.Guardar(new Entidades.TiposUsuarios(2,"Invitado")));
        }

        [TestMethod()]
        public void MofidicarTest()
        {
            Assert.IsTrue(BLL.TiposusuariosBLL.Mofidicar(new Entidades.TiposUsuarios(2, "Invitado")));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(BLL.TiposusuariosBLL.Eliminar(new Entidades.TiposUsuarios(2, "Persona")));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 2;
            Assert.IsNotNull(BLL.TiposusuariosBLL.Buscar(tu => tu.TipoUsuarioId == id));
        }

        [TestMethod()]
        public void ListarTest()
        {
            int id = 2;
            Assert.IsNotNull(BLL.TiposusuariosBLL.Listar(tu => tu.TipoUsuarioId == id));
        }

        [TestMethod()]
        public void ListarTodoTest()
        {
            Assert.IsNotNull(BLL.TiposusuariosBLL.ListarTodo());
        }
    }
}