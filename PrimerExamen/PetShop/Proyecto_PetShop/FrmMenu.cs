using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmMenu : Form
    {
        private Form formularioActivo = null;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false;
            pnlPrincipal.Controls.Add(formularioHijo);
            pnlPrincipal.Tag = formularioHijo;
            formularioHijo.Show();
        }

        /// <summary>
        /// Cierra la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Minimiza la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Agranda o achica la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Abre el sub menú de clientes y oculta el resto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuClientes.Visible)
            {
                pnlSubMenuClientes.Visible = false;
            }
            else
            {
                pnlSubMenuEmpleados.Visible = false;
                pnlSubMenuProductos.Visible = false;
                pnlSubMenuClientes.Visible = true;
            }
        }

        /// <summary>
        /// Abre el sub menú de productos y oculta el resto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuProductos.Visible)
            {
                pnlSubMenuProductos.Visible = false;
            }
            else
            {
                pnlSubMenuClientes.Visible = false;
                pnlSubMenuEmpleados.Visible = false;
                pnlSubMenuProductos.Visible = true;
            }
        }

        /// <summary>
        /// Abre el sub menú de empleados y oculta el resto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuEmpleados.Visible)
            {
                pnlSubMenuEmpleados.Visible = false;
            }
            else
            {
                pnlSubMenuClientes.Visible = false;
                pnlSubMenuProductos.Visible = false;
                pnlSubMenuEmpleados.Visible = true;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Abre un formulario para dar de alta un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAltaCliente());
        }

        /// <summary>
        /// Muestra los datos de un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarClientes());
        }

        private void btnBajaModificacionCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmBajaModificacionCliente());
        }
    }
}
