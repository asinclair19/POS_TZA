using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class DEmpleado
    {
        //VARIABLES GLOBALES
        private int _Idempleado;
        private string _Identidad;
        private string _Primernombre;
        private string _Primerapellido;
        private int _Nacimiento;
        private string _Celular;
        private double _Salariobase;
        private string _Cargoempleado;
        private int _Activo;
        private string _Username;
        private string _Passworduser;
        private string _Privilegiosuser;
        private string _Textobuscar;

        public int Idempleado
        {
            get { return _Idempleado; }
            set { _Idempleado = value; }
        }

        public string Identidad
        {
            get { return _Identidad; }
            set { _Identidad = value; }
        }

        public string Primernombre
        {
            get { return _Primernombre; }
            set { _Primernombre = value; }
        }

        public string Primerapellido
        {
            get { return _Primerapellido; }
            set { _Primerapellido = value; }
        }

        public int Nacimiento
        {
            get { return _Nacimiento; }
            set { _Nacimiento = value; }
        }

        public string Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }

        public double Salariobase
        {
            get { return _Salariobase; }
            set { _Salariobase = value; }
        }

        public string Cargoempleado
        {
            get { return _Cargoempleado; }
            set { _Cargoempleado = value; }
        }

        public int Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Passworduser
        {
            get { return _Passworduser; }
            set { _Passworduser = value; }
        }

        public string Privilegiosuser
        {
            get { return _Privilegiosuser; }
            set { _Privilegiosuser = value; }
        }

        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; }
        }
        //constructor VACIO
        public DEmpleado()
        { 
        
        }
        //constructor con PARAMETROS
        public DEmpleado(int idempleado, string identidad, string nombre, string apellido, int nacimiento, string celular, double salario, string cargo, int activo, string username, string password, string privilegios, string textobuscar)
        {
            this.Idempleado = idempleado;
            this.Identidad = identidad;
            this.Primernombre = nombre;
            this.Primerapellido = apellido;
            this.Nacimiento = nacimiento;
            this.Celular = celular;
            this.Salariobase = salario;
            this.Cargoempleado = cargo;
            this.Activo = activo;
            this.Username = username;
            this.Passworduser = password;
            this.Privilegiosuser = privilegios;
            this.Textobuscar = textobuscar;
        }

        //metodo insertar
        public string Insertar(DEmpleado Empleado)
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
                SqlCmd.CommandText = "spinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdempledo = new SqlParameter();
                ParIdempledo.ParameterName = "@idempleado";
                ParIdempledo.SqlDbType = SqlDbType.Int;
                ParIdempledo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdempledo);

                SqlParameter ParIdentidad = new SqlParameter();
                ParIdentidad.ParameterName = "@identidad";
                ParIdentidad.SqlDbType = SqlDbType.VarChar;
                ParIdentidad.Size = 50;
                ParIdentidad.Value = Empleado.Identidad;
                SqlCmd.Parameters.Add(ParIdentidad);

                SqlParameter ParPrimernombre = new SqlParameter();
                ParPrimernombre.ParameterName = "@primer_nombre";
                ParPrimernombre.SqlDbType = SqlDbType.NVarChar;
                ParPrimernombre.Size = 100;
                ParPrimernombre.Value = Empleado.Primernombre;
                SqlCmd.Parameters.Add(ParPrimernombre);

                SqlParameter ParPrimerapellido = new SqlParameter();
                ParPrimerapellido.ParameterName = "@primer_apellido";
                ParPrimerapellido.SqlDbType = SqlDbType.NVarChar;
                ParPrimerapellido.Size = 100;
                ParPrimerapellido.Value = Empleado.Primerapellido;
                SqlCmd.Parameters.Add(ParPrimerapellido);

                SqlParameter ParNacimiento = new SqlParameter();
                ParNacimiento.ParameterName = "@nacimiento";
                ParNacimiento.SqlDbType = SqlDbType.Int;
                ParNacimiento.Value = Empleado.Nacimiento;
                SqlCmd.Parameters.Add(ParNacimiento);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.NVarChar;
                ParCelular.Size = 30;
                ParCelular.Value = Empleado.Celular;
                SqlCmd.Parameters.Add(ParCelular);

                SqlParameter ParSalario = new SqlParameter();
                ParSalario.ParameterName = "@salario_base";
                ParSalario.SqlDbType = SqlDbType.Money;
                ParSalario.Value = Empleado.Salariobase;
                SqlCmd.Parameters.Add(ParSalario);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo_empleado";
                ParCargo.SqlDbType = SqlDbType.NVarChar;
                ParCargo.Size = 45;
                ParCargo.Value = Empleado.Cargoempleado;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo_empleado";
                ParActivo.SqlDbType = SqlDbType.Int;
                ParActivo.Value = Empleado.Activo;
                SqlCmd.Parameters.Add(ParActivo);

                SqlParameter ParUsername = new SqlParameter();
                ParUsername.ParameterName = "@username";
                ParUsername.SqlDbType = SqlDbType.NVarChar;
                ParUsername.Size = 50;
                ParUsername.Value = Empleado.Username;
                SqlCmd.Parameters.Add(ParUsername);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password_user";
                ParPassword.SqlDbType = SqlDbType.NVarChar;
                ParPassword.Value = Empleado.Passworduser;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParPrivilegios = new SqlParameter();
                ParPrivilegios.ParameterName = "@privilegios_user";
                ParPrivilegios.SqlDbType = SqlDbType.NVarChar;
                ParPrivilegios.Value = Empleado.Privilegiosuser;
                SqlCmd.Parameters.Add(ParPrivilegios);

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
        public string Editar(DEmpleado Empleado)
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
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdempledo = new SqlParameter();
                ParIdempledo.ParameterName = "@idempleado";
                ParIdempledo.SqlDbType = SqlDbType.Int;
                ParIdempledo.Value = Empleado.Idempleado;
                SqlCmd.Parameters.Add(ParIdempledo);

                SqlParameter ParIdentidad = new SqlParameter();
                ParIdentidad.ParameterName = "@identidad";
                ParIdentidad.SqlDbType = SqlDbType.VarChar;
                ParIdentidad.Size = 50;
                ParIdentidad.Value = Empleado.Identidad;
                SqlCmd.Parameters.Add(ParIdentidad);

                SqlParameter ParPrimernombre = new SqlParameter();
                ParPrimernombre.ParameterName = "@primer_nombre";
                ParPrimernombre.SqlDbType = SqlDbType.NVarChar;
                ParPrimernombre.Size = 100;
                ParPrimernombre.Value = Empleado.Primernombre;
                SqlCmd.Parameters.Add(ParPrimernombre);

                SqlParameter ParPrimerapellido = new SqlParameter();
                ParPrimerapellido.ParameterName = "@primer_apellido";
                ParPrimerapellido.SqlDbType = SqlDbType.NVarChar;
                ParPrimerapellido.Size = 100;
                ParPrimerapellido.Value = Empleado.Primerapellido;
                SqlCmd.Parameters.Add(ParPrimerapellido);

                SqlParameter ParNacimiento = new SqlParameter();
                ParNacimiento.ParameterName = "@nacimiento";
                ParNacimiento.SqlDbType = SqlDbType.Int;
                ParNacimiento.Value = Empleado.Nacimiento;
                SqlCmd.Parameters.Add(ParNacimiento);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.NVarChar;
                ParCelular.Size = 30;
                ParCelular.Value = Empleado.Celular;
                SqlCmd.Parameters.Add(ParCelular);

                SqlParameter ParSalario = new SqlParameter();
                ParSalario.ParameterName = "@salario_base";
                ParSalario.SqlDbType = SqlDbType.Money;
                ParSalario.Value = Empleado.Salariobase;
                SqlCmd.Parameters.Add(ParSalario);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo_empleado";
                ParCargo.SqlDbType = SqlDbType.NVarChar;
                ParCargo.Size = 45;
                ParCargo.Value = Empleado.Cargoempleado;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParActivo = new SqlParameter();
                ParActivo.ParameterName = "@activo_empleado";
                ParActivo.SqlDbType = SqlDbType.Int;
                ParActivo.Value = Empleado.Activo;
                SqlCmd.Parameters.Add(ParActivo);

                SqlParameter ParUsername = new SqlParameter();
                ParUsername.ParameterName = "@username";
                ParUsername.SqlDbType = SqlDbType.NVarChar;
                ParUsername.Size = 50;
                ParUsername.Value = Empleado.Username;
                SqlCmd.Parameters.Add(ParUsername);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password_user";
                ParPassword.SqlDbType = SqlDbType.NVarChar;
                ParPassword.Value = Empleado.Passworduser;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParPrivilegios = new SqlParameter();
                ParPrivilegios.ParameterName = "@privilegios_user";
                ParPrivilegios.SqlDbType = SqlDbType.NVarChar;
                ParPrivilegios.Value = Empleado.Privilegiosuser;
                SqlCmd.Parameters.Add(ParPrivilegios);

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
        public string Eliminar(DEmpleado Empleado)
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
                SqlCmd.CommandText = "speliminar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idempleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleado.Idempleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

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
            DataTable DtResultado = new DataTable("empleados");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string e = ex.ToString();
            }

            return DtResultado;
        }

        //buscar
        public DataTable BuscarEmpleado(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string e = ex.ToString();
            }

            return DtResultado;
        }

        //metodo activar
        public string Activar(DEmpleado Empleado)
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
                SqlCmd.CommandText = "spactivar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Empleado.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

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
        public string Desactivar(DEmpleado Empleado)
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
                SqlCmd.CommandText = "spdesactivar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Empleado.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

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

        //LOGIN
        public DataTable Login(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@username";
                ParUser.SqlDbType = SqlDbType.NVarChar;
                ParUser.Size = 50;
                ParUser.Value = Empleado.Username;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPass = new SqlParameter();
                ParPass.ParameterName = "@password_user";
                ParPass.SqlDbType = SqlDbType.NVarChar;
                ParPass.Value = Empleado.Passworduser;
                SqlCmd.Parameters.Add(ParPass);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string e = ex.ToString();
            }

            return DtResultado;
        }
    }
}
