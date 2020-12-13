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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;

        public string Idempleado = "0";
        public string Nombre = "Root";
        public string Apellido = "Root";
        public string Privilegios = "config-inventario-compras-empleados-planilla-ventas-reportes";

        private static frmPrincipal _Instancia;

        public static frmPrincipal GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmPrincipal();
            }

            return _Instancia;
        }

        public void setDatos(string id, string nombre, string apellido, string privilegios)
        {
            //this.Idempleado = id;
            //this.Nombre = nombre;
            //this.Apellido = apellido;
            //this.Privilegios = privilegios;
            
        }

        public frmPrincipal()
        {
            InitializeComponent();
            this.loginToolStripIniciarSesion.Enabled = true;
            this.toolStripCerrarSesion.Enabled = false;
            
        }

        private void HabilitarMnus(bool valor)
        {
            this.iconInventario.Enabled = valor; //inventario
            this.MnuInventario.Enabled = valor;
            this.iconCompras.Enabled = valor; //compras
            this.MnuCompras.Enabled = valor;
            this.iconVentas.Enabled = valor; //ventas
            this.MnuVentas.Enabled = valor;
            this.iconReportes.Enabled = valor; //reportes
            this.MnuReportes.Enabled = valor;
            this.iconEmpleados.Enabled = valor; //empleados
            this.empleadosToolStripMenuItem.Enabled = valor;
            this.iconPlanilla.Enabled = valor; //planilla
            this.planillaToolStripMenuItem1.Enabled = valor;
            this.iconConfig.Enabled = valor; //configuracion general
            this.configGeneralToolStripMenuItem.Enabled = valor;
        }

        public void Restricciones()
        {
            string permisos = this.Privilegios;
            if (permisos.Contains("inventario"))
            {
                this.iconInventario.Enabled = true;
                this.MnuInventario.Enabled = true;
            }
            else {
                this.iconInventario.Enabled = false;
                this.MnuInventario.Enabled = false;
            }

            //compras
            if (permisos.Contains("compras"))
            {
                this.iconCompras.Enabled = true;
                this.MnuCompras.Enabled = true;
            }
            else
            {
                this.iconCompras.Enabled = false;
                this.MnuCompras.Enabled = false;
            }

            //ventas
            if (permisos.Contains("ventas"))
            {
                this.iconVentas.Enabled = true;
                this.MnuVentas.Enabled = true;
            }
            else
            {
                this.iconVentas.Enabled = false;
                this.MnuVentas.Enabled = false;
            }

            //reportes
            if (permisos.Contains("reportes"))
            {
                this.iconReportes.Enabled = true;
                this.MnuReportes.Enabled = true;
            }
            else
            {
                this.iconReportes.Enabled = false;
                this.MnuReportes.Enabled = false;
            }

            //empleados
            if (permisos.Contains("empleados"))
            {
                this.iconEmpleados.Enabled = true;
                this.empleadosToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.iconEmpleados.Enabled = false;
                this.empleadosToolStripMenuItem.Enabled = false;
            }

            //planilla
            if (permisos.Contains("planilla"))
            {
                this.iconPlanilla.Enabled = true;
                this.planillaToolStripMenuItem1.Enabled = true;
            }
            else
            {
                this.iconPlanilla.Enabled = false;
                this.planillaToolStripMenuItem1.Enabled = false;
            }

            //config
            if (permisos.Contains("config"))
            {
                this.iconConfig.Enabled = true;
                this.configGeneralToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.iconConfig.Enabled = false;
                this.configGeneralToolStripMenuItem.Enabled = false;
            }
            this.loginToolStripIniciarSesion.Enabled = false;
            this.toolStripCerrarSesion.Enabled = true;
            statusLblUsuario.Text = Nombre + " " + Apellido;
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidades frm = new frmUnidades();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = frmProductos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconMenuProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = frmProductos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconMenuCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconMenuUnidades_Click(object sender, EventArgs e)
        {
            frmUnidades frm = new frmUnidades();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconMenuProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconMenuClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AbrirFrmLogin()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFrmLogin();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.HabilitarMnus(false);
            this.AbrirFrmLogin();
        }

        private void loguotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            statusLblTiempo.Text = DateTime.Now.ToString();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresos frm = frmIngresos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.idempleado = Convert.ToInt32(this.Idempleado);
        }

        private void iconMenuIngresos_Click(object sender, EventArgs e)
        {
            frmIngresos frm = frmIngresos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.idempleado = Convert.ToInt32(this.Idempleado);
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconPlanilla_Click(object sender, EventArgs e)
        {
            frmPlanillas frm = frmPlanillas.GetMiInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void planillaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPlanillas frm = frmPlanillas.GetMiInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripCerrarSesion_Click(object sender, EventArgs e)
        {
            this.HabilitarMnus(false);
            this.loginToolStripIniciarSesion.Enabled = true;
            this.toolStripCerrarSesion.Enabled = false;
            statusLblUsuario.Text = "root";
            this.AbrirFrmLogin();
        }

        private void iconConfig_Click(object sender, EventArgs e)
        {

            frmConfig frm = new frmConfig();
            frm.MdiParent = this;
            frm.Show();
        }

        private void configGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconVentas_ButtonClick(object sender, EventArgs e)
        {

        }

        private void iconMenuVentas_Click(object sender, EventArgs e)
        {
            frmVentas frm = frmVentas.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.idEmpleado = Convert.ToInt32(this.Idempleado);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVentas frm = frmVentas.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.idEmpleado = Convert.ToInt32(this.Idempleado);
        }

        private void stockDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta_Stock frm = new frmConsulta_Stock();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iconReportes_ButtonClick(object sender, EventArgs e)
        {
            //frmConsulta_Stock frm = new frmConsulta_Stock();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void iconMenuStockProducto_Click(object sender, EventArgs e)
        {
            frmConsulta_Stock frm = new frmConsulta_Stock();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresos frm = frmIngresos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.idempleado = Convert.ToInt32(this.Idempleado);
        }

        private void reporteDeVentasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frm = frmVentas.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.idEmpleado = Convert.ToInt32(this.Idempleado);
        }


    }
}
