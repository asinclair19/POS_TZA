using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using capaPresentacion;

namespace capaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.lblHora.Text = "Tiempo: " + DateTime.Now.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

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
            DataTable Datos = capaNegocio.NEmpleado.Login(this.txtUser.Text.Trim(), this.txtPass.Text.Trim());

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene acceso al sistema.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string par1, par2;
                frmPrincipal form = frmPrincipal.GetInstancia();
                form.Idempleado = Datos.Rows[0][0].ToString();
                form.Nombre = Datos.Rows[0][1].ToString();
                par1 = Datos.Rows[0][1].ToString();
                form.Apellido = Datos.Rows[0][2].ToString();
                par2 = Datos.Rows[0][2].ToString();
                form.Privilegios = Datos.Rows[0][3].ToString();
                form.Restricciones();
                this.Hide();
                MessageBox.Show("Bienvenid@ al sistema, " + par1 + " " + par2 + ".");
            }
        }
    }
}
