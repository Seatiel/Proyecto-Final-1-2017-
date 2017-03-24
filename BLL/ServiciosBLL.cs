using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class ServiciosBLL
    {
        public static bool Guardar(Servicios servicio)
        {
            using (var repositorio = new Repositorio<Servicios>())
            {
                try
                {
                    if (Buscar(s => s.ServicioId == servicio.ServicioId) == null)
                    {
                        return repositorio.Guardar(servicio);
                    }
                    else
                    {
                        return repositorio.Modificar(servicio);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Mofidicar(Entidades.Servicios existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Servicios>())
            {
                eliminado = repositorio.Modificar(existente);
            }
            return eliminado;
        }

        public static bool Eliminar(Entidades.Servicios existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Servicios>())
            {
                eliminado = repositorio.Eliminar(existente);
            }
            return eliminado;
        }

        public static Entidades.Servicios Buscar(Expression<Func<Entidades.Servicios, bool>> criterioBusqueda)
        {
            Entidades.Servicios Result = null;
            using (var repoitorio = new Repositorio<Entidades.Servicios>())
            {
                Result = repoitorio.Buscar(criterioBusqueda);
            }
            return Result;
        }

        public static List<Entidades.Servicios> Listar(Expression<Func<Entidades.Servicios, bool>> busqueda)
        {
            List<Entidades.Servicios> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Servicios>())
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

        public static List<Entidades.Servicios> ListarTodo()
        {
            List<Entidades.Servicios> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Servicios>())
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
