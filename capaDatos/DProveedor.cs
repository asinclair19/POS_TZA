using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class DProveedor
    {
        //declaracion variables privadas
        private int _Idproveedor;
        private string _NombreEmpresa;
        private string _NombreContacto;
        private int _Activo;
        private string _Textobuscar;

        //encapsulamiento
        public int Idproveedor
        {
            get { return _Idproveedor; }
            set { _Idproveedor = value; }
        }

        public string NombreEmpresa
        {
            get { return _NombreEmpresa; }
            set { _NombreEmpresa = value; }
        }

        public string NombreContacto
        {
            get { return _NombreContacto; }
            set { _NombreContacto = value; }
        }

        public int Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }

        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; }
        }

        //constructor vacio
        public DProveedor()
        { 
        
        }

        //constructor con parametros
        public DProveedor(int idproveedor, string nombre, string contacto, int activo, string textobuscar)
        {
            this.Idproveedor = idproveedor;
            this.NombreEmpresa = nombre;
            this.NombreContacto = contacto;
            this.Activo = activo;
        }

        //METODOS DE CLASE:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //metodo insertar
        public string Insertar(DProveedor Proveedor)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo funcion
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_proveedor";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 255;
                ParNombre.Value = Proveedor.NombreEmpresa;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParContacto = new SqlParameter();
                ParContacto.ParameterName = "@contacto_proveedor";
                ParContacto.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 100;
                ParContacto.Value = Proveedor.NombreContacto;
                SqlCmd.Parameters.Add(ParContacto);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo_proveedor";
                ParActivo.SqlDbType = SqlDbType.Int;
                ParActivo.Value = Proveedor.Activo;
                SqlCmd.Parameters.Add(ParActivo);

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
        public string Editar(DProveedor Proveedor)
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
                SqlCmd.CommandText = "speditar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_proveedor";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 255;
                ParNombre.Value = Proveedor.NombreEmpresa;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParContacto = new SqlParameter();
                ParContacto.ParameterName = "@contacto_proveedor";
                ParContacto.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 100;
                ParContacto.Value = Proveedor.NombreContacto;
                SqlCmd.Parameters.Add(ParContacto);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo_proveedor";
                ParActivo.SqlDbType = SqlDbType.Int;
                ParActivo.Value = Proveedor.Activo;
                SqlCmd.Parameters.Add(ParActivo);

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
        public string Eliminar(DProveedor Proveedor)
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
                SqlCmd.CommandText = "speliminar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

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
            DataTable DtResultado = new DataTable("proveedores");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //buscar
        public DataTable BuscarNombre(DProveedor Proveedor) 
        {
            DataTable DtResultado = new DataTable("proveedores");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //metodo activar
        public string Activar(DProveedor Proveedor)
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
                SqlCmd.CommandText = "spactivar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Activó.";
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

        //metodo desactivar
        public string Desactivar(DProveedor Proveedor)
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
                SqlCmd.CommandText = "spdesactivar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Activó.";
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


    }
}
