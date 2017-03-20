using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class UsuariosBLL
    {
        public static Entidades.Usuarios Guardar(Entidades.Usuarios nuevo)
        {
            Entidades.Usuarios creado = null;
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                creado = repositorio.Guardar(nuevo);
            }
            return creado;
        }

        public static bool Mofidicar(Entidades.Usuarios existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                eliminado = repositorio.Modificar(existente);
            }
            return eliminado;
        }

        public static bool Eliminar(Entidades.Usuarios existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                eliminado = repositorio.Eliminar(existente);
            }
            return eliminado;
        }

        public static Entidades.Usuarios Buscar(Expression<Func<Entidades.Usuarios, bool>> criterioBusqueda)
        {
            Entidades.Usuarios Result = null;
            using (var repoitorio = new Repositorio<Entidades.Usuarios>())
            {
                Result = repoitorio.Buscar(criterioBusqueda);
            }
            return Result;
        }

        public static List<Entidades.Usuarios> Lista(Expression<Func<Entidades.Usuarios, bool>> busqueda)
        {
            List<Entidades.Usuarios> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Usuarios>())
            {
                try
                {
                    Result = repoitorio.Lista(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }

        public static List<Entidades.Usuarios> ListarTodo()
        {
            List<Entidades.Usuarios> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Usuarios>())
            {
                try
                {
                    Result = repoitorio.ListarTodo().ToList();
                }
                catch { }
                return Result;
            }
        }
    }
}
