using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class DProducto
    {
        //variables globales
        private int _Idproducto;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;
        private string _Busqueda;
        private byte[] _Imagen;
        private int _Activo;
        private int _Idunidad;
        private int _Idcategoria;
        private string _Textobuscar;

        //encapsulamiento
        public int Idproducto
        {
            get { return _Idproducto; }
            set { _Idproducto = value; }
        }
        
        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
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

        public string Busqueda
        {
            get { return _Busqueda; }
            set { _Busqueda = value; }
        }

        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        public int Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }

        public int Idunidad
        {
            get { return _Idunidad; }
            set { _Idunidad = value; }
        }

        public int Idcategoria
        {
            get { return _Idcategoria; }
            set { _Idcategoria = value; }
        }

        public string Textobuscar
        {
          get { return _Textobuscar; }
          set { _Textobuscar = value; }
        }

        //constructor vacio
        public DProducto()
        {
        
        }

        //constructor con parametros
        public DProducto(int idproducto, string codigo, string nombre, string descripcion, 
            string busqueda, byte[] imagen, int activo, int idunidad, int idcategoria, string textobuscar)
        { 
            //codigo
            this.Idproducto = idproducto;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Busqueda = busqueda;
            this.Imagen = imagen;
            this.Activo = activo;
            this.Idunidad = idunidad;
            this.Idcategoria = idcategoria;
            this.Textobuscar = textobuscar;
        }

        //METODOS
        //metodo insertar
        public string Insertar(DProducto Producto)
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
                SqlCmd.CommandText = "spinsertar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo_producto";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 100;
                ParCodigo.Value = Producto.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_producto";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Producto.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion_producto";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 1024;
                ParDescripcion.Value = Producto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParBusqueda = new SqlParameter();
                ParBusqueda.ParameterName = "@busqueda_producto";
                ParBusqueda.SqlDbType = SqlDbType.NVarChar;
                ParBusqueda.Value = Producto.Busqueda;
                SqlCmd.Parameters.Add(ParBusqueda);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen_producto";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Producto.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo_producto";
                ParActivo.SqlDbType = SqlDbType.Int;
                ParActivo.Value = Producto.Activo;
                SqlCmd.Parameters.Add(ParActivo);

                SqlParameter ParIdUnidad = new SqlParameter();
                ParIdUnidad.ParameterName = "@idunidad";
                ParIdUnidad.SqlDbType = SqlDbType.Int;
                ParIdUnidad.Value = Producto.Idunidad;
                SqlCmd.Parameters.Add(ParIdUnidad);

                SqlParameter ParIdCategoria = new SqlParameter();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Value = Producto.Idcategoria;
                SqlCmd.Parameters.Add(ParIdCategoria);

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
        public string Editar(DProducto Producto)
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
                SqlCmd.CommandText = "speditar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Producto.Idproducto;
                SqlCmd.Parameters.Add(ParIdProducto);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo_producto";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 100;
                ParCodigo.Value = Producto.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_producto";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Producto.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion_producto";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 1024;
                ParDescripcion.Value = Producto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParBusqueda = new SqlParameter();
                ParBusqueda.ParameterName = "@busqueda_producto";
                ParBusqueda.SqlDbType = SqlDbType.NVarChar;
                ParBusqueda.Value = Producto.Busqueda;
                SqlCmd.Parameters.Add(ParBusqueda);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen_producto";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Producto.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo_producto";
                ParActivo.SqlDbType = SqlDbType.Int;
                ParActivo.Value = Producto.Activo;
                SqlCmd.Parameters.Add(ParActivo);

                SqlParameter ParIdUnidad = new SqlParameter();
                ParIdUnidad.ParameterName = "@idunidad";
                ParIdUnidad.SqlDbType = SqlDbType.Int;
                ParIdUnidad.Value = Producto.Idunidad;
                SqlCmd.Parameters.Add(ParIdUnidad);

                SqlParameter ParIdCategoria = new SqlParameter();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Value = Producto.Idcategoria;
                SqlCmd.Parameters.Add(ParIdCategoria);

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
        public string Eliminar(DProducto Producto)
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
                SqlCmd.CommandText = "speliminar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Producto.Idproducto;
                SqlCmd.Parameters.Add(ParIdProducto);

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
            DataTable DtResultado = new DataTable("productos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string result = ex.ToString();
            }

            return DtResultado;
        }

        //buscar
        public DataTable BuscarProducto(DProducto Producto)
        {
            DataTable DtResultado = new DataTable("productos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Producto.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string result = ex.ToString();
            }

            return DtResultado;
        }

        //metodo activar
        public string Activar(DProducto Producto)
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
                SqlCmd.CommandText = "spactivar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Producto.Idproducto;
                SqlCmd.Parameters.Add(ParIdProducto);

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
        public string Desactivar(DProducto Producto)
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
                SqlCmd.CommandText = "spdesactivar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Producto.Idproducto;
                SqlCmd.Parameters.Add(ParIdProducto);

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

        //mostrar stock productos
        public DataTable Stock_Productos()
        {
            DataTable DtResultado = new DataTable("stock");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spstock_productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string result = ex.ToString();
            }

            return DtResultado;
        }

    }
}
