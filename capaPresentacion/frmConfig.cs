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
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public frmConfig()
        {
            InitializeComponent();
        }

        //private void LLenarGrid()
        //{
        //    this.dgvConfiguracion.DataSource = NConfig.Obtener();
        //}

        private void MostrarDatos()
        {
            DataTable dt = new DataTable();
            dt = NConfig.Obtener(); //llenamos el data-table

            DataRow row = dt.Rows[0];
            if (row != null)
            {
                //MensajeOK("Si hay filas en el data-table!");
                this.txtIdConfig.Text = row["idconfig"].ToString();
                this.txtTitulo.Text = row["titulo_sistema"].ToString();
                this.txtNombre.Text = row["nombre_razon_social"].ToString();
                this.txtComercialNombre.Text = row["nombre_comercial"].ToString();
                this.txtSucursal.Text = row["nombre_sucursal"].ToString();
                this.txtDirección.Text = row["direccion"].ToString();
                this.txtTelefono.Text = row["telefono"].ToString();
                this.txtCorreo.Text = row["correo"].ToString();
                this.txtSlogan.Text = row["slogan"].ToString();
                this.txtPropietario.Text = row["propietario"].ToString();
                this.txtUserRoot.Text = row["usuario_root"].ToString();
                this.txtPassRoot.Text = row["pass_root"].ToString();
                this.txtGanancia.Value = Convert.ToDecimal(row["default_ganancia_venta"]);
                this.txtSeguro.Value = Convert.ToDecimal(row["default_seguro_deducido"]);
                this.txtISR.Value = Convert.ToDecimal(row["default_isr"]);
                this.txtISV.Value = Convert.ToDecimal(row["default_isv"]);
                this.txtDescuento.Value = Convert.ToDecimal(row["default_porc_descuento"]);
                this.txtRTN.Text = row["rtn"].ToString();
                this.txtCAI.Text = row["cai"].ToString();
                this.txtPuntoEmision.Text = row["punto_emision"].ToString();
                this.txtEstablecimiento.Text = row["establecimiento"].ToString();
                this.txtTipoDocumento.Text = row["tipo_documento"].ToString();
                this.txtRangoInicial.Text = row["rango_inicial"].ToString();
                this.txtRangoFinal.Text = row["rango_final"].ToString();
            }
            else {
                this.txtIdConfig.Text = "";
                MensajeOK("No hay configuración creada!");
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            //this.LLenarGrid();
            this.MostrarDatos();
            this.txtTitulo.Focus();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //Guardar Datos
            try
            {
                string rpta = "";
                if (
                    this.txtTitulo.Text == string.Empty ||
                    this.txtNombre.Text == string.Empty ||
                    this.txtComercialNombre.Text == string.Empty ||
                    this.txtSucursal.Text == string.Empty ||
                    this.txtUserRoot.Text == string.Empty ||
                    this.txtPassRoot.Text == string.Empty ||
                    this.txtRTN.Text == string.Empty ||
                    this.txtCAI.Text == string.Empty
                    )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtTitulo, "Ingrese titulo del sistema");
                    errorIcono.SetError(this.txtNombre, "Ingrese razon social de la empresa");
                    errorIcono.SetError(this.txtUserRoot, "Ingrese nombre de usuario root del sistema");
                    errorIcono.SetError(this.txtPassRoot, "Ingrese contraseña root del sistema");
                    errorIcono.SetError(this.txtNombre, "Ingrese RTN de la empresa (autogenerado).");
                    errorIcono.SetError(this.txtNombre, "Ingrese CAI de la empresa (autogenerado).");
                    errorIcono.SetError(this.txtComercialNombre, "Ingrese nombre comercial de la empresa");
                    errorIcono.SetError(this.txtSucursal, "Ingrese nombre de sucursal que usará el sistema");
                }
                else
                {
                    if (this.txtIdConfig.Text == "")
                    {
                        //nombre,descripcion,imagen,activa
                        rpta = NConfig.Insertar(
                                this.txtTitulo.Text,
                                this.txtNombre.Text.ToUpper(),
                                this.txtComercialNombre.Text.ToUpper(),
                                this.txtSucursal.Text.ToUpper(),
                                this.txtDirección.Text,
                                this.txtTelefono.Text,
                                this.txtCorreo.Text,
                                this.txtSlogan.Text,
                                this.txtPropietario.Text,
                                this.txtUserRoot.Text,
                                this.txtPassRoot.Text,
                                Convert.ToDecimal(txtGanancia.Value),
                                Convert.ToDecimal(txtSeguro.Value),
                                Convert.ToDecimal(txtISR.Value),
                                Convert.ToDecimal(txtISV.Value),
                                Convert.ToDecimal(txtDescuento.Value),
                                this.txtRTN.Text,
                                this.txtCAI.Text,
                                this.txtPuntoEmision.Text,
                                this.txtEstablecimiento.Text,
                                this.txtTipoDocumento.Text,
                                this.txtRangoInicial.Text,
                                this.txtRangoFinal.Text
                            );
                    }
                    else
                    {
                        //actualizar
                        rpta = NConfig.Actualizar(
                                Convert.ToInt32(this.txtIdConfig.Text),
                                this.txtTitulo.Text,
                                this.txtNombre.Text.ToUpper(),
                                this.txtComercialNombre.Text.ToUpper(),
                                this.txtSucursal.Text.ToUpper(),
                                this.txtDirección.Text,
                                this.txtTelefono.Text,
                                this.txtCorreo.Text,
                                this.txtSlogan.Text,
                                this.txtPropietario.Text,
                                this.txtUserRoot.Text,
                                this.txtPassRoot.Text,
                                Convert.ToDecimal(txtGanancia.Value),
                                Convert.ToDecimal(txtSeguro.Value),
                                Convert.ToDecimal(txtISR.Value),
                                Convert.ToDecimal(txtISV.Value),
                                Convert.ToDecimal(txtDescuento.Value),
                                this.txtRTN.Text,
                                this.txtCAI.Text,
                                this.txtPuntoEmision.Text,
                                this.txtEstablecimiento.Text,
                                this.txtTipoDocumento.Text,
                                this.txtRangoInicial.Text,
                                this.txtRangoFinal.Text
                            );
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.txtIdConfig.Text == "")
                        {
                            this.MensajeOK("Configuración nueva guardada.");
                        }
                        else
                        {
                            this.MensajeOK("Configuración actualizada.");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    //preparamos para nuevos datos
                    this.MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
