using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private static bool flagPrimeraVez = true;

        #region Carga los datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (flagPrimeraVez)
            {
                clientes = new List<Cliente>();

                Clientes.Add(Empleado.AltaCliente(2000, "Roberto", "Morales", Convert.ToDateTime("14/05/1992"), 37452102, "Masculino", "Argentina", "Charlone 1302"));
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

            if (FrmLogin.EsAdmin)
            {
                pnlPrincipal.BackColor = Color.AntiqueWhite;
                picPrincipal.BackColor = Color.Brown;
                pnlBarra.BackColor = Color.Brown;
                pnlInfo.BackColor = Color.Tan;
                btnClientes.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnAltaCliente.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnBajaModificacionCliente.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnMostrarClientes.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnProductos.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnAgregarProductos.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnEliminarModificarProfuctos.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnMostrarProductos.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnVentas.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnEmpleados.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnAltaEmpleados.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnBajaModificacionEmpleados.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnMostrarEmpleados.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnAdmin.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnAltaAdmin.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnBajaModificacionAdmin.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnMostrarAdmin.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnFacturacion.FlatAppearance.MouseOverBackColor = Color.Brown;
                btnFacturacion.Visible = true;
                pnlSubMenuEmpleados.Visible = true;
                pnlSubMenuEmpleados.Visible = false;
                btnEmpleados.Visible = true;
                pnlSubMenuAdmin.Visible = true;
                pnlSubMenuAdmin.Visible = false;
                btnAdmin.Visible = true;
            }
        }
        #endregion

        #region PanelPrincipal
        /// <summary>
        /// Abre el formulario pasado por parámetro
        /// </summary>
        /// <param name="formularioHijo">Formulario a abrir</param>
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
            ReproducirSonidoBoton();
        }
        #endregion

        #region Botones
        /// <summary>
        /// Cierra la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Minimiza la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                pnlSubMenuAdmin.Visible = false;
            }
            ReproducirSonidoBoton();
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
                pnlSubMenuAdmin.Visible = false;
            }
            ReproducirSonidoBoton();
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
                pnlSubMenuAdmin.Visible = false;
            }
            ReproducirSonidoBoton();
        }

        /// <summary>
        /// Abre el sub menú de administradores y oculta el resto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuAdmin.Visible)
            {
                pnlSubMenuAdmin.Visible = false;
            }
            else
            {
                pnlSubMenuClientes.Visible = false;
                pnlSubMenuProductos.Visible = false;
                pnlSubMenuEmpleados.Visible = false;
                pnlSubMenuAdmin.Visible = true;
            }
            ReproducirSonidoBoton();
        }

        /// <summary>
        /// Abre el formulario de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVentas_Click(object sender, EventArgs e)
        {
            pnlSubMenuClientes.Visible = false;
            pnlSubMenuProductos.Visible = false;
            pnlSubMenuEmpleados.Visible = false;
            pnlSubMenuAdmin.Visible = false;
            AbrirFormularioHijo(new FrmVenta());
        }

        /// <summary>
        /// Abre el formulario de factuaraciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            pnlSubMenuClientes.Visible = false;
            pnlSubMenuProductos.Visible = false;
            pnlSubMenuEmpleados.Visible = false;
            pnlSubMenuAdmin.Visible = false;
            AbrirFormularioHijo(new FrmFacturacion());
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
        /// Abre un formulario para mostrar los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarClientes());
        }

        /// <summary>
        /// Abre un formulario para eliminar y/o modificar uno o varios clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaModificacionCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmBajaModificacionCliente());
        }

        /// <summary>
        /// Abre un formulario para dar de alta un empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAltaEmpleado());
        }

        /// <summary>
        /// Abre un formulario para mostrar los empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarEmpleados());
        }

        /// <summary>
        /// Abre un formulario para eliminar y/o modificar uno o varios empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaModificacionEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmBajaModificacionEmpleado());
        }

        /// <summary>
        /// Abre un formulario para dar de alta un administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAltaAdministrador());
        }

        /// <summary>
        /// Abre un formulario para mostrar los administradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarAdministrador());
        }

        /// <summary>
        /// Abre un formulario para eliminar y/o modificar uno o varios administradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaModificacionAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmBajaModificacionAdministrador());
        }

        /// <summary>
        /// Abre un formulario para agregar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAgregarProducto());
        }

        /// <summary>
        /// Abre un formulario para eliminar y/o modificar uno o varios productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarModificarProfuctos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmEliminarModificarProducto());
        }

        /// <summary>
        /// Abre un formulario para mostrar los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarProducto());
        }
        #endregion

        #region Fecha y hora
        /// <summary>
        /// Muestra la fecha y hora actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            StringBuilder hora = new StringBuilder();
            StringBuilder fecha = new StringBuilder();

            hora.Append($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            fecha.Append($"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}");

            lblFecha.Text = fecha.ToString();
            lblHora.Text = hora.ToString();
        }
        #endregion

        #region Getters
        /// <summary>
        /// Devuelve el valor de clientes
        /// </summary>
        public static List<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
        }
        #endregion

        #region Sonido
        /// <summary>
        /// Reproduce un sonido indicando que se presionó un botón
        /// </summary>
        private void ReproducirSonidoBoton()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Boton.wav");
            sonido.Play();
        }
        #endregion
    }
}
