using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class DUnidad
    {
        //VARIABLES GLOBALES
        private int _Idunidad;
        private string _Nombre;
        private string _Descripcion;
        private string _Textobuscar;

        //ENCAPSULAMIENTO
        public int Idunidad
        {
            get { return _Idunidad; }
            set { _Idunidad = value; }
        }
        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; }
        }

        //CONSTRUCTOR VACIO
        public DUnidad()
        {

        }

        //constructor GLOBAL
        public DUnidad(int idunidad, string nombre, string descripcion, string textobuscar) {
            this.Idunidad = idunidad;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Textobuscar = textobuscar;
        }

        //metodo insertar
        public string Insertar(DUnidad Unidad)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_unidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdUnidad = new SqlParameter();
                ParIdUnidad.ParameterName = "@idunidad";
                ParIdUnidad.SqlDbType = SqlDbType.Int;
                ParIdUnidad.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdUnidad);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_unidad";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Unidad.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion_unidad";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParDescripcion.Value = Unidad.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingresó el Registro.";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        //metodo editar
        public string Editar(DUnidad Unidad)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_unidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdUnidad = new SqlParameter();
                ParIdUnidad.ParameterName = "@idunidad";
                ParIdUnidad.SqlDbType = SqlDbType.Int;
                ParIdUnidad.Value = Unidad.Idunidad;
                SqlCmd.Parameters.Add(ParIdUnidad);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_unidad";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Unidad.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion_unidad";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParDescripcion.Value = Unidad.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Modificó el Registro.";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        //metodo eliminar
        public string Eliminar(DUnidad Unidad)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_unidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdUnidad = new SqlParameter();
                ParIdUnidad.ParameterName = "@idunidad";
                ParIdUnidad.SqlDbType = SqlDbType.Int;
                ParIdUnidad.Value = Unidad.Idunidad;
                SqlCmd.Parameters.Add(ParIdUnidad);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Eliminó el Registro.";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        //mostrar valores
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("unidades");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_unidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string valor = ex.ToString();
            }

            return DtResultado;
        }

        //buscar
        public DataTable BuscarNombre(DUnidad Unidad)
        {
            DataTable DtResultado = new DataTable("unidades");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_unidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Unidad.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string valor = ex.ToString();
            }

            return DtResultado;
        }
    }
}
