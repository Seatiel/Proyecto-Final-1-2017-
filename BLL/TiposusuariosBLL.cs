using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class TiposusuariosBLL
    {
        public static Entidades.TiposUsuarios Guardar(Entidades.TiposUsuarios nuevo)
        {
            Entidades.TiposUsuarios creado = null;
            using (var repositorio = new Repositorio<Entidades.TiposUsuarios>())
            {
                creado = repositorio.Guardar(nuevo);
            }
            return creado;
        }

        public static bool Mofidicar(Entidades.TiposUsuarios existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposUsuarios>())
            {
                eliminado = repositorio.Modificar(existente);
            }
            return eliminado;
        }

        public static bool Eliminar(Entidades.TiposUsuarios existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposUsuarios>())
            {
                eliminado = repositorio.Eliminar(existente);
            }
            return eliminado;
        }

        public static Entidades.TiposUsuarios Buscar(Expression<Func<Entidades.TiposUsuarios, bool>> criterioBusqueda)
        {
            Entidades.TiposUsuarios Result = null;
            using (var repoitorio = new Repositorio<Entidades.TiposUsuarios>())
            {
                Result = repoitorio.Buscar(criterioBusqueda);
            }
            return Result;
        }

        public static List<Entidades.TiposUsuarios> Lista(Expression<Func<Entidades.TiposUsuarios, bool>> busqueda)
        {
            List<Entidades.TiposUsuarios> Result = null;
            using (var repoitorio = new Repositorio<Entidades.TiposUsuarios>())
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

        public static List<Entidades.TiposUsuarios> ListarTodo()
        {
            List<Entidades.TiposUsuarios> Result = null;
            using (var repoitorio = new Repositorio<Entidades.TiposUsuarios>())
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
