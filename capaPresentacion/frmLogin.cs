using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using capaNegocio;
using capaPresentacion;

namespace capaPresentacion
{
    public partial class frmLogin : Form
    {
        private static DataTable dtConfig;
        private static DataRow rowConfig;

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, rowConfig["titulo_sistema"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, rowConfig["titulo_sistema"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public frmLogin()
        {
            InitializeComponent();
            this.lblHora.Text = "Tiempo: " + DateTime.Now.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                dtConfig = NConfig.Obtener();
                if (dtConfig.Rows.Count != 0)
                {
                    rowConfig = dtConfig.Rows[0];
                    this.lblTituloLogin.Text = rowConfig["titulo_sistema"].ToString();
                    this.groupBoxLogin.Enabled = true;
                    this.txtUser.Focus();
                }
                else
                {
                    MessageBox.Show("No hay configuración default configurada en la base de datos.!");
                    this.groupBoxLogin.Enabled = false;
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Problemas con la base de datos!");
                //string error = ex.ToString();
                this.groupBoxLogin.Enabled = false;
                this.Close();
            }
            
            
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = "Tiempo: " + DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkVisible.Checked == false)
            {
                this.txtPass.UseSystemPasswordChar = true;
            }else{
                this.txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string idempleado = "0";
            string user = "";
            string pass = "";
            string privilegios = "config-inventario-compras-empleados-planilla-ventas-reportes";

            user = rowConfig["usuario_root"].ToString();
            pass = rowConfig["pass_root"].ToString();

            if (this.txtUser.Text.Trim() == user && this.txtPass.Text.Trim() == pass)
            {
                frmPrincipal form = frmPrincipal.GetInstancia();
                form.Idempleado = idempleado;
                form.Nombre = user;
                form.Apellido = user;
                form.Privilegios = privilegios;
                form.Restricciones();
                this.Hide();
            }
            else
            {
                DataTable Datos = capaNegocio.NEmpleado.Login(this.txtUser.Text.Trim(), this.txtPass.Text.Trim());

                if (Datos.Rows.Count == 0)
                {
                    MensajeError("No tiene acceso al sistema.");
                }
                else
                {
                    frmPrincipal form = frmPrincipal.GetInstancia();
                    form.Idempleado = Datos.Rows[0][0].ToString();
                    form.Nombre = Datos.Rows[0][1].ToString();
                    form.Apellido = Datos.Rows[0][2].ToString();
                    form.Privilegios = Datos.Rows[0][3].ToString();
                    form.Restricciones();
                    this.Hide();
                    //MessageBox.Show("Bienvenid@ al sistema, " + Datos.Rows[0][1].ToString() + " " + Datos.Rows[0][2].ToString() + ".");
                }

            }
        }

        private void lblTituloLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
