using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            using (var repositorio = new Repositorio<Usuarios>())
            {
                try
                {
                    if (Buscar(u => u.UsuarioId == usuario.UsuarioId) == null)
                    {
                        return repositorio.Guardar(usuario);
                    }
                    else
                    {
                        return repositorio.Modificar(usuario);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Mofidicar(Entidades.Usuarios existente)
        {
            bool modificado = false;
            using (var repositorio = new Repositorio<Entidades.Usuarios>())
            {
                modificado = repositorio.Modificar(existente);
            }
            return modificado;
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

        public static List<Entidades.Usuarios> Listar(Expression<Func<Entidades.Usuarios, bool>> busqueda)
        {
            List<Entidades.Usuarios> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Usuarios>())
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
