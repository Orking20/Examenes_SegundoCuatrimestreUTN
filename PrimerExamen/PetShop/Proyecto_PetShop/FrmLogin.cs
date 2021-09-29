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
    public partial class FrmLogin : Form
    {
        private static List<Empleado> empleados;
        private static List<Administrador> administradores;
        private static List<Producto> productos;
        private static Dictionary<string, string> usuarios;
        private static bool esAdmin;

        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Hardcodeo();
        }

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
                        }
                    }
                }

                contador++;
            }
        }

        #region Hardcodeo
        /// <summary>
        /// Carga algunos empleados
        /// </summary>
        private void Hardcodeo()
        {
            empleados = new List<Empleado>();
            administradores = new List<Administrador>();
            productos = new List<Producto>();
            usuarios = new Dictionary<string, string>();

            Empleado empleado1 = Administrador.AltaEmpleado("Gonzalo", "Kublai", 25000, EPuesto.cajero, new string[] { "L", "Ma", "Mi", "J", "V", null, null }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Gonzalo", "Marquinez", Convert.ToDateTime("14/07/1992"), 41542195, "Masculino", "Argentina", "Cabrera 3015");
            Empleado empleado2 = Administrador.AltaEmpleado("Juli", "EmpanadaFrita", 19000, EPuesto.delivery, new string[] { "L", "Ma", "Mi", "J", "V", null, null }, Convert.ToDateTime("13:00"), Convert.ToDateTime("19:00"), "Julia", "Dominguez", Convert.ToDateTime("23/03/2000"), 40462485, "Femenino", "Argentina", "Bompland 5002");
            Empleado empleado3 = Administrador.AltaEmpleado("Juancita", "Merales123", 25000, EPuesto.limpieza, new string[] { "L", null, "Mi", null, null, "S", null }, Convert.ToDateTime("13:00"), Convert.ToDateTime("15:00"), "Juana", "Merales", Convert.ToDateTime("19/12/1990"), 38452158, "No binario", "Paraguay", "Av. Santa Fe 5124");
            Empleado empleado4 = Administrador.AltaEmpleado("Marce", "lito246", 20000, EPuesto.cajero, new string[] { null, null, null, null, null, "S", "D" }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Marcelo", "Ricaño", Convert.ToDateTime("01/01/1993"), 40830644, "Masculino", "Argentina", "Bersalles 203");
            Administrador admin1 = Administrador.AltaAdministrador("Tatiana", "jinjer123", 73000, EPuesto.administrador, new string[] { "L", "Ma", "Mi", "J", "V", "S", "D" }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Tatiana", "Shmaylyuk", Convert.ToDateTime("15/03/1987"), 38245987, "Femenino", "Ucrania", "Pavón 3120");
            Administrador admin2 = Administrador.AltaAdministrador("Will", "Lorna_400", 68000, EPuesto.administrador, new string[] { "L", "Ma", "Mi", "J", "V", "S", "D" }, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "William", "Ramos", Convert.ToDateTime("02/05/1982"), 36846528, "Masculino", "Argentina", "Salcedo 2857");

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
        #endregion
    }
}
