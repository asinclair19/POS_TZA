using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using capaNegocio;

namespace capaPresentacion
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void MostrarDatos()
        {
            this.txtTitulo.Text = NConfig.Mostrar("title");
            this.txtNombre.Text = NConfig.Mostrar("name");
            this.txtComercialNombre.Text = NConfig.Mostrar("comercialname");
            this.txtSucursal.Text = NConfig.Mostrar("sucursal");
            this.txtDirección.Text = NConfig.Mostrar("direccion");
            this.txtTelefono.Text = NConfig.Mostrar("telefono");
            this.txtCorreo.Text = NConfig.Mostrar("correo");
            this.txtSlogan.Text = NConfig.Mostrar("slogan");
            this.txtPropietario.Text = NConfig.Mostrar("propietario");
            this.txtRTN.Text = NConfig.Mostrar("rtn");
            this.txtCAI.Text = NConfig.Mostrar("cai");
            this.txtUserRoot.Text = NConfig.Mostrar("rootuser");
            this.txtPassRoot.Text = NConfig.Mostrar("rootpass");
            this.txtGanancia.Text = NConfig.Mostrar("ganancia");
            this.txtSeguro.Text = NConfig.Mostrar("seguro");
            this.txtISR.Text = NConfig.Mostrar("isr");
            this.txtISV.Text = NConfig.Mostrar("isv");
            this.txtRangoInicial.Text = NConfig.Mostrar("rangoinicial");
            this.txtRangoFinal.Text = NConfig.Mostrar("rangofinal");
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string rpta = NConfig.Guardar(
                txtTitulo.Text,
                txtNombre.Text,
                txtComercialNombre.Text,
                txtSucursal.Text,
                txtDirección.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                txtSlogan.Text, 
                txtPropietario.Text, 
                txtRTN.Text, 
                txtCAI.Text, 
                txtUserRoot.Text, 
                txtPassRoot.Text,
                Convert.ToDecimal(txtGanancia.Text), 
                Convert.ToDecimal(txtSeguro.Text), 
                Convert.ToDecimal(txtISR.Text),
                Convert.ToDecimal(txtISV.Text), 
                txtRangoInicial.Text, txtRangoFinal.Text);
                MessageBox.Show(rpta);
                this.MostrarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vistaPreviaFacturacion()
        {
            this.lblVistaPrevia.Text = this.txtPuntoEmision.Text + "-" + this.txtEstablecimiento.Text + "-" + this.txtTipoDocumento.Text + "-" + this.txtRangoInicial.Text + " a " + txtRangoFinal.Text;
        }

        private void txtPuntoEmision_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPuntoEmision_TextChanged(object sender, EventArgs e)
        {
            this.vistaPreviaFacturacion();
        }

        private void txtEstablecimiento_TextChanged(object sender, EventArgs e)
        {
            this.vistaPreviaFacturacion();
        }

        private void txtTipoDocumento_TextChanged(object sender, EventArgs e)
        {
            this.vistaPreviaFacturacion();
        }

        private void txtRangoInicial_TextChanged(object sender, EventArgs e)
        {
            this.vistaPreviaFacturacion();
        }

        private void txtRangoFinal_TextChanged(object sender, EventArgs e)
        {
            this.vistaPreviaFacturacion();
        }


    }
}
