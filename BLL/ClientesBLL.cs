﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class ClientesBLL
    {
        public static Entidades.Clientes Guardar(Entidades.Clientes nuevo)
        {
            Entidades.Clientes creado = null;
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                creado = repositorio.Guardar(nuevo);
            }
            return creado;
        }

        public static bool Mofidicar(Entidades.Clientes existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                eliminado = repositorio.Modificar(existente);
            }
            return eliminado;
        }

        public static bool Eliminar(Entidades.Clientes existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Clientes>())
            {
                eliminado = repositorio.Eliminar(existente);
            }
            return eliminado;
        }

        public static Entidades.Clientes Buscar(Expression<Func<Entidades.Clientes, bool>> criterioBusqueda)
        {
            Entidades.Clientes Result = null;
            using (var repoitorio = new Repositorio<Entidades.Clientes>())
            {
                Result = repoitorio.Buscar(criterioBusqueda);
            }
            return Result;
        }

        public static List<Entidades.Clientes> Lista(Expression<Func<Entidades.Clientes, bool>> busqueda)
        {
            List<Entidades.Clientes> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Clientes>())
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

        public static List<Entidades.Clientes> ListarTodo()
        {
            List<Entidades.Clientes> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Clientes>())
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