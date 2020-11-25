using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using capaDatos;

namespace capaNegocio
{
    public class NEmpleado
    {
        //metodo insertar
        public static string Insertar(string identidad, string nombre, string apellido, int nacimiento, string celular, double salario, string cargo, int activo, string username, string password, string privilegios)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Identidad = identidad;
            Obj.Primernombre = nombre;
            Obj.Primerapellido = apellido;
            Obj.Nacimiento = nacimiento;
            Obj.Celular = celular;
            Obj.Salariobase = salario;
            Obj.Cargoempleado = cargo;
            Obj.Activo = activo;
            Obj.Username = username;
            Obj.Passworduser = password;
            Obj.Privilegiosuser = privilegios;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int idempleado, string identidad, string nombre, string apellido, int nacimiento, string celular, double salario, string cargo, int activo, string username, string password, string privilegios)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Idempleado = idempleado;
            Obj.Identidad = identidad;
            Obj.Primernombre = nombre;
            Obj.Primerapellido = apellido;
            Obj.Nacimiento = nacimiento;
            Obj.Celular = celular;
            Obj.Salariobase = salario;
            Obj.Cargoempleado = cargo;
            Obj.Activo = activo;
            Obj.Username = username;
            Obj.Passworduser = password;
            Obj.Privilegiosuser = privilegios;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int idempleado)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Idempleado = idempleado;
            return Obj.Eliminar(Obj);
        }

        //mostrar
        public static DataTable Mostrar()
        {
            return new DEmpleado().Mostrar();
        }

        //buscar texto
        public static DataTable BuscarEmpleado(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarEmpleado(Obj);
        }

        //activar
        public static string Activar(int idempleado)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Idempleado = idempleado;
            return Obj.Activar(Obj);
        }

        //desactivar
        public static string Desactivar(int idempleado)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Idempleado = idempleado;
            return Obj.Desactivar(Obj);
        }

        //LOGIN
        public static DataTable Login(string user, string pass)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Username = user;
            Obj.Passworduser = pass;
            return Obj.Login(Obj);
        }
    }
}
