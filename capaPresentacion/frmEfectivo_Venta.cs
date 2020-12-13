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
    public partial class frmEfectivo_Venta : Form
    {
        private decimal _TotalAPagar = 44;

        public decimal TotalAPagar
        {
            get { return _TotalAPagar; }
            set { _TotalAPagar = value; }
        }

        private void retornaCambio()
        {
            if (this.txtEfectivo.Text != string.Empty)
            {
                if (this.txtEfectivo.Text != string.Empty & (Convert.ToDecimal(this.txtEfectivo.Text) - this.txtAPagar.Value) > 0)
                {
                    this.txtCambio.Text = (Convert.ToDecimal(this.txtEfectivo.Text) - this.txtAPagar.Value).ToString("#0.00#");
                }
                else
                {
                    this.txtCambio.Text = "0.00";
                }
            }
            else {
                this.txtCambio.BackColor = Color.Orange;
                this.txtCambio.Text = "0.00";
            }
        }

        private void retornaSaldo()
        {
            if (this.txtEfectivo.Text != string.Empty)
            {
                if (this.txtEfectivo.Text != string.Empty & (Convert.ToDecimal(this.txtEfectivo.Text) - this.txtAPagar.Value) < 0)
                {
                    this.txtSaldo.BackColor = Color.Red;
                    this.txtSaldo.Text = Convert.ToDecimal((Convert.ToDecimal(this.txtEfectivo.Text) - this.txtAPagar.Value) * -1).ToString("#0.00#");
                    this.btnAceptar.Enabled = false;
                }
                else
                {
                    this.txtSaldo.BackColor = Color.GreenYellow;
                    this.txtSaldo.Text = "0.00";
                    this.btnAceptar.Enabled = true;
                }
            }
            else {
                this.txtSaldo.BackColor = Color.Orange;
                this.txtSaldo.Text = "0.00";
            }        
        }

        private void soloNumeros(KeyPressEventArgs valor)
        {
            if (Char.IsNumber(valor.KeyChar))
            {
                valor.Handled = false;
            }
            else if (Char.IsControl(valor.KeyChar))
            {
                valor.Handled = false;
            }
            else if (Char.IsSeparator(valor.KeyChar))
            {
                valor.Handled = true;
            }
            else
            {
                valor.Handled = true;
            }
        }

        public frmEfectivo_Venta()
        {
            InitializeComponent();
            this.txtEfectivo.Focus();
        }

        private void frmEfectivo_Venta_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Enabled = false;
            this.txtAPagar.Value = TotalAPagar;
            this.txtEfectivo.Text = string.Empty;
            this.txtEfectivo.Focus();
        }

        private void txtEfectivo_ValueChanged(object sender, EventArgs e)
        {
            this.retornaCambio();
            this.retornaSaldo();
        }

        private void txtEfectivo_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtEfectivo_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NVenta.Listosave = true;
            this.Hide();
        }

        private void frmEfectivo_Venta_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NVenta.Listosave = false;
            this.Hide();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            this.retornaCambio();
            this.retornaSaldo();
        }

        private void txtEfectivo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        
    }
}
