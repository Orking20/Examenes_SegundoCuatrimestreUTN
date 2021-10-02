using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmLogin : Form
    {
        private static string path;
        private static List<Empleado> empleados;
        private static List<Administrador> administradores;
        private static List<Producto> productos;
        private static List<Factura> facturas;
        private static Dictionary<Cliente, int> stocks;
        private static Dictionary<string, string> usuarios;
        private static bool esAdmin;

        #region Carga de datos
        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Hardcodeo();
            path = Directory.GetCurrentDirectory();
        }
        #endregion

        #region Botones
        /// <summary>
        /// Si el usuario y la contraseña son correctas accede al menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuarios.ContainsKey(txtUsuario.Text) && txtPass.Text == usuarios[txtUsuario.Text])
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (i < empleados.Count)
                    {
                        if (empleados[i].Usuario == txtUsuario.Text && empleados[i].Password == txtPass.Text)
                        {
                            esAdmin = false;
                            break;
                        }
                    }
                    if (i < administradores.Count)
                    {
                        if (administradores[i].Usuario == txtUsuario.Text && administradores[i].Password == txtPass.Text)
                        {
                            esAdmin = true;
                            break;
                        }
                    }
                }

                ReproducirSonidoBoton();
                new FrmMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre y/o contraseña incorrecta", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
        /// Borra lo que estuviera escrito en donde va el usuario y la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = String.Empty;
            txtPass.Text = String.Empty;
            ReproducirSonidoBoton();
        }

        /// <summary>
        /// Autocompleta el usuario y contraseña para que los profesores puedan entrar sin saber la contraseña o el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int valorAleatorio;
            string valorAux;
            int contador = 0;
            bool seguirBuscando = true;

            while (seguirBuscando)
            {
                if (contador >= Usuarios.Count)
                {
                    contador = 0;
                }
                valorAleatorio = random.Next(10);
                if (valorAleatorio < Usuarios.Count)
                {
                    if (Usuarios.Keys.ElementAt(valorAleatorio) == Usuarios.Keys.ElementAt(contador))
                    {
                        txtUsuario.Text = Usuarios.Keys.ElementAt(contador);

                        if (Usuarios.TryGetValue(txtUsuario.Text, out valorAux))
                        {
                            txtPass.Text = valorAux;
                            seguirBuscando = false;
                            ReproducirSonidoBoton();
                        }
                    }
                }

                contador++;
            }
        }
        #endregion

        #region Hardcodeo
        /// <summary>
        /// Carga algunos empleados
        /// </summary>
        private void Hardcodeo()
        {
            empleados = new List<Empleado>();
            administradores = new List<Administrador>();
            productos = new List<Producto>();
            facturas = new List<Factura>();
            stocks = new Dictionary<Cliente, int>();
            usuarios = new Dictionary<string, string>();

            Empleado empleado1 = Administrador.AltaEmpleado("Gonzalo", "Kublai", 25000, EPuesto.cajero, new string[] { "L", "Ma", "Mi", "J", "V", null, null }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Gonzalo", "Marquinez", Convert.ToDateTime("14/07/1992"), 41542195, "Masculino", "Argentina", "Cabrera 3015");
            Empleado empleado2 = Administrador.AltaEmpleado("Juli", "EmpanadaFrita", 19000, EPuesto.delivery, new string[] { "L", "Ma", "Mi", "J", "V", null, null }, Convert.ToDateTime("13:00"), Convert.ToDateTime("19:00"), "Julia", "Dominguez", Convert.ToDateTime("23/03/2000"), 40462485, "Femenino", "Argentina", "Bompland 5002");
            Empleado empleado3 = Administrador.AltaEmpleado("Juancita", "Merales123", 25000, EPuesto.limpieza, new string[] { "L", null, "Mi", null, null, "S", null }, Convert.ToDateTime("13:00"), Convert.ToDateTime("15:00"), "Juana", "Merales", Convert.ToDateTime("19/12/1990"), 38452158, "No binario", "Paraguay", "Av. Santa Fe 5124");
            Empleado empleado4 = Administrador.AltaEmpleado("Marce", "lito246", 20000, EPuesto.cajero, new string[] { null, null, null, null, null, "S", "D" }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Marcelo", "Ricaño", Convert.ToDateTime("01/01/1993"), 40830644, "Masculino", "Argentina", "Bersalles 203");
            Administrador admin1 = Administrador.AltaAdministrador("Tatiana", "jinjer123", 73000, EPuesto.administrador, new string[] { "L", "Ma", "Mi", "J", "V", "S", "D" }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Tatiana", "Shmaylyuk", Convert.ToDateTime("15/03/1987"), 38245987, "Femenino", "Ucrania", "Pavón 3120");
            Administrador admin2 = Administrador.AltaAdministrador("Will", "Lorna_400", 68000, EPuesto.administrador, new string[] { "L", "Ma", "Mi", "J", "V", "S", "D" }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "William", "Ramos", Convert.ToDateTime("02/05/1982"), 36846528, "Masculino", "Argentina", "Salcedo 2857");
            Producto producto1 = Empleado.AltaProducto("Hueso", "Dog Chow", ETipo.alimento, 480, 1, 30);
            Producto producto2 = Empleado.AltaProducto("Lata gastrointestinal", "Royal canin", ETipo.alimento, 311, 0.200, 60);
            Producto producto3 = Empleado.AltaProducto("Cepillo rastrillo", "Essentials", ETipo.cuidado, 980, 0.35, 15);
            Producto producto4 = Empleado.AltaProducto("Cama acolchada", "Essentials", ETipo.cama, 3200, 3, 6);
            Producto producto5 = Empleado.AltaProducto("Shampoo garrapatas", "Essentials", ETipo.cuidado, 1100, 1, 10);
            Producto producto6 = Empleado.AltaProducto("Comida para gatos", "Royal canin", ETipo.alimento, 850, 1, 56);
            Producto producto7 = Empleado.AltaProducto("Comida para gatos 4Kg", "Royal canin", ETipo.alimento, 3000, 4, 32);
            Producto producto8 = Empleado.AltaProducto("Trepador para gatos", "Royal canin", ETipo.juguete, 2600, 2.5, 3);
            Producto producto9 = Empleado.AltaProducto("Varita con pluma para gatos", "Can cat", ETipo.juguete, 671, 0.35, 43);
            Producto producto10 = Empleado.AltaProducto("Collar", "Catycan", ETipo.cuidado, 1560, 0.15, 8);
            Producto producto11 = Empleado.AltaProducto("Golosina bocaditos", "Dog Chow", ETipo.alimento, 566, 0.500, 33);
            Producto producto12 = Empleado.AltaProducto("Pelota para perros", "Catycan", ETipo.juguete, 242.40, 0.25, 15);
            Producto producto13 = Empleado.AltaProducto("Camita para gatos", "Catycan", ETipo.cama, 2300, 3.2, 2);
            Producto producto14 = Empleado.AltaProducto("Peine/cardina", "Essentials", ETipo.juguete, 992.20, 0.35, 5);
            Producto producto15 = Empleado.AltaProducto("Alicate corta uñas", "Can cat", ETipo.cuidado, 891, 0.50, 7);
            Producto producto16 = Empleado.AltaProducto("Cama para perro/gato", "Catycat", ETipo.cama, 1253, 2.30, 4);
            Producto producto17 = Empleado.AltaProducto("Lata pollo", "Dog Chow", ETipo.alimento, 247, 0.340, 47);
            Producto producto18 = Empleado.AltaProducto("Golosina huesito", "Royal canin", ETipo.alimento, 220, 0.250, 38);
            Producto producto19 = Empleado.AltaProducto("Pelota dental", "Dog Chow", ETipo.juguete, 1481, 1, 22);
            Producto producto20 = Empleado.AltaProducto("Golosina gatuna", "Royal canin", ETipo.alimento, 340, 0.700, 31);

            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);
            empleados.Add(empleado4);

            administradores.Add(admin1);
            administradores.Add(admin2);

            usuarios.Add(empleado1.Usuario, empleado1.Password);
            usuarios.Add(empleado2.Usuario, empleado2.Password);
            usuarios.Add(empleado3.Usuario, empleado3.Password);
            usuarios.Add(empleado4.Usuario, empleado4.Password);
            usuarios.Add(admin1.Usuario, admin1.Password);
            usuarios.Add(admin2.Usuario, admin2.Password);

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
            productos.Add(producto4);
            productos.Add(producto5);
            productos.Add(producto6);
            productos.Add(producto7);
            productos.Add(producto8);
            productos.Add(producto9);
            productos.Add(producto10);
            productos.Add(producto11);
            productos.Add(producto12);
            productos.Add(producto13);
            productos.Add(producto14);
            productos.Add(producto15);
            productos.Add(producto16);
            productos.Add(producto17);
            productos.Add(producto18);
            productos.Add(producto19);
            productos.Add(producto20);
        }
        #endregion

        #region Getters
        /// <summary>
        /// Devuelve la lista de empleados
        /// </summary>
        public static List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }
        }

        /// <summary>
        /// Devuelve la lista de administradores
        /// </summary>
        public static List<Administrador> Administradores
        {
            get
            {
                return administradores;
            }
        }

        /// <summary>
        /// Devuelve la lista de productos
        /// </summary>
        public static List<Producto> Productos
        {
            get
            {
                return productos;
            }
        }

        /// <summary>
        /// Devuelve la lista de facturas
        /// </summary>
        public static List<Factura> Facturas
        {
            get
            {
                return facturas;
            }
        }

        /// <summary>
        /// Devuelve la lista de productos comprados en la misma compra
        /// </summary>
        public static Dictionary<Cliente, int> Stocks
        {
            get
            {
                return stocks;
            }
        }

        /// <summary>
        /// Devuelve el diccionario de usuarios
        /// </summary>
        public static Dictionary<string, string> Usuarios
        {
            get
            {
                return usuarios;
            }
        }

        /// <summary>
        /// Devuelve el valor de esAdmin
        /// </summary>
        public static bool EsAdmin
        {
            get
            {
                return esAdmin;
            }
        }

        /// <summary>
        /// Devuelve el valor de path
        /// </summary>
        public static string Path
        {
            get
            {
                return path;
            }
        }
        #endregion

        #region Sonido
        /// <summary>
        /// Reproduce un sonido indicando que se presionó un botón
        /// </summary>
        private void ReproducirSonidoBoton()
        {
            SoundPlayer sonido = new SoundPlayer($"{Path}\\Sonidos\\Boton.wav");
            sonido.Play();
        }
        #endregion
    }
}
