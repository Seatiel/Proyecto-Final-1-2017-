using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class FacturasBLL
    {
        public static bool Guardar(Facturas factura)
        {
            using (var repositorio = new Repositorio<Facturas>())
            {
                try
                {
                    if (Buscar(f => f.FacturaId == factura.FacturaId) == null)
                    {
                        return repositorio.Guardar(factura);
                    }
                    else
                    {
                        return repositorio.Modificar(factura);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Mofidicar(Entidades.Facturas existente)
        {
            bool modificado = false;
            using (var repositorio = new Repositorio<Entidades.Facturas>())
            {
                modificado = repositorio.Modificar(existente);
            }
            return modificado;
        }

        public static bool Eliminar(Entidades.Facturas existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Facturas>())
            {
                eliminado = repositorio.Eliminar(existente);
            }
            return eliminado;
        }

        public static Entidades.Facturas Buscar(Expression<Func<Entidades.Facturas, bool>> criterioBusqueda)
        {
            Facturas factura = null;
            using (var repositorio = new Repositorio<Facturas>())
            {
                try
                {
                    factura = repositorio.Buscar(criterioBusqueda);
                    if (factura != null)
                        factura.Detalle.Count();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return factura;
        }

        public static List<Entidades.Facturas> Listar(Expression<Func<Entidades.Facturas, bool>> busqueda)
        {
            List<Entidades.Facturas> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Facturas>())
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

        public static List<Entidades.Facturas> ListarTodo()
        {
            List<Entidades.Facturas> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Facturas>())
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
