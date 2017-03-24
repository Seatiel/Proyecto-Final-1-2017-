using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class TiposusuariosBLL
    {
        public static bool Guardar(TiposUsuarios tipoUsuario)
        {
            using (var repositorio = new Repositorio<TiposUsuarios>())
            {
                try
                {
                    if (Buscar(tu => tu.TipoUsuarioId == tipoUsuario.TipoUsuarioId) == null)
                    {
                        return repositorio.Guardar(tipoUsuario);
                    }
                    else
                    {
                        return repositorio.Modificar(tipoUsuario);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
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
                    Result = repoitorio.Listar(busqueda).ToList();
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
