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
        private static List<Cliente> clientes;
        private static bool flagPrimeraVezModificable = true;
        private static bool flagPrimeraVez = true;

        public FrmMenu()
        {
            InitializeComponent();

            if (flagPrimeraVezModificable)
            {
                clientes = new List<Cliente>();
                flagPrimeraVezModificable = false;
            }

            if (flagPrimeraVez)
            {
                Clientes.Add(Empleado.AltaCliente(41270, "Roberto", "Morales", Convert.ToDateTime("14/05/1992"), 37452102, "Masculino", "Argentina", "Charlone 1302"));
                Clientes.Add(Empleado.AltaCliente(4200, "Mariana", "Rodriguez", Convert.ToDateTime("03/12/1962"), 30640222, "Femenino", "Argentina", "Moldes 1429"));
                Clientes.Add(Empleado.AltaCliente(202, "Javier", "Rey", Convert.ToDateTime("21/04/1998"), 40588922, "No binario", "Argentina", "Del Signo 4037"));
                Clientes.Add(Empleado.AltaCliente(23000, "Marcelo", "Oviedo", Convert.ToDateTime("12/06/1993"), 40842351, "Masculino", "Perú", "Alsina 110"));
                Clientes.Add(Empleado.AltaCliente(44, "Sofía", "Velez", Convert.ToDateTime("29/03/1997"), 40256483, "Femenino", "Argentina", "José Bonifacio 1406"));
                Clientes.Add(Empleado.AltaCliente(209, "Camila", "Gutierrez", Convert.ToDateTime("22/11/1984"), 38266548, "No binario", "Argentina", "Giribone 1700"));
                Clientes.Add(Empleado.AltaCliente(1990, "Farrokh", "Bulsara", Convert.ToDateTime("05/09/1946"), 29542356, "Masculino", "Tanzania", "Zanzíbar 2004"));
                Clientes.Add(Empleado.AltaCliente(57500, "Carlos", "Díaz", Convert.ToDateTime("22/01/1992"), 35524124, "Masculino", "Argentina", "Av. Forest 1427"));
                Clientes.Add(Empleado.AltaCliente(800, "Sigvar", "Gangraz", Convert.ToDateTime("20/04/1999"), 42412358, "Masculino", "España", "Metano 10"));

                flagPrimeraVez = false;
            }
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

        public static bool FlagPrimeraVezClientes
        {
            get
            {
                return flagPrimeraVezModificable;
            }
            set
            {
                flagPrimeraVezModificable = value;
            }
        }

        public static List<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
        }
    }
}
