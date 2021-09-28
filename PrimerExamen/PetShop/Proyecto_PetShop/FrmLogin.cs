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
        static List<Empleado> empleados;
        static List<Administrador> administradores;
        static Dictionary<string, string> usuarios;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            HardcodeoEmpleados();
            HardcodeoAdministradores();
            HardcodeoUsuarios();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuarios.ContainsKey(txtUsuario.Text) && txtPass.Text == usuarios[txtUsuario.Text])
            {
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
        private void HardcodeoEmpleados()
        {
            empleados = new List<Empleado>();

            string[] diasLaborales = new string[5] { "L", "Ma", "Mi", "J", "V" };
            string[] diasLaborales2 = new string[3] { "L", "Mi", "S" };
            string[] diasLaborales3 = new string[2] { "S", "D" };

            empleados.Add(Administrador.AltaEmpleado("Gonzalo", "Kublai", 25000, EPuesto.cajero, diasLaborales, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Gonzalo", "Marquinez", Convert.ToDateTime("14/07/1992"), 41542195, "Masculino", "Argentina", "Cabrera 3015"));
            empleados.Add(Administrador.AltaEmpleado("Juli", "EmpanadaFrita", 19000, EPuesto.delivery, diasLaborales, Convert.ToDateTime("13:00"), Convert.ToDateTime("19:00"), "Julia", "Dominguez", Convert.ToDateTime("23/03/2000"), 40462485, "Femenino", "Argentina", "Bompland 5002"));
            empleados.Add(Administrador.AltaEmpleado("Juancita", "Merales123", 25000, EPuesto.limpieza, diasLaborales2, Convert.ToDateTime("13:00"), Convert.ToDateTime("15:00"), "Juana", "Merales", Convert.ToDateTime("19/12/1990"), 38452158, "No binario", "Paraguay", "Av. Santa Fe 5124"));
            empleados.Add(Administrador.AltaEmpleado("Marce", "lito246", 20000, EPuesto.cajero, diasLaborales3, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Marcelo", "Ricaño", Convert.ToDateTime("01/01/1993"), 40830644, "Masculino", "Argentina", "Bersalles 203"));
        }

        private void HardcodeoAdministradores()
        {
            administradores = new List<Administrador>();

            string[] diasLaborales4 = new string[7] { "L", "Ma", "Mi", "J", "V", "S", "D" };
            
            administradores.Add(Administrador.AltaAdministrador("Tatiana", "jinjer123", 73000, EPuesto.cajero, diasLaborales4, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "Tatiana", "Shmaylyuk", Convert.ToDateTime("15/03/1987"), 38245987, "Femenino", "Ucrania", "Pavón 3120"));
            administradores.Add(Administrador.AltaAdministrador("Will", "Lorna_400", 68000, EPuesto.cajero, diasLaborales4, Convert.ToDateTime("12:00"), Convert.ToDateTime("19:00"), "William", "Ramos", Convert.ToDateTime("02/05/1982"), 36846528, "Masculino", "Argentina", "Salcedo 2857"));
        }

        private void HardcodeoUsuarios()
        {
            usuarios = new Dictionary<string, string>();

            usuarios.Add("Gonzalo", "Kublai");
            usuarios.Add("Juli", "EmpanadaFrita");
            usuarios.Add("Juancita", "Merales123");
            usuarios.Add("Marce", "lito246");
            usuarios.Add("Tatiana", "jinjer123");
            usuarios.Add("Will", "Lorna_400");
        }
        #endregion

        #region Getters
        public static List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }
        }

        public static List<Administrador> Administradores
        {
            get
            {
                return administradores;
            }
        }

        public static Dictionary<string, string> Usuarios
        {
            get
            {
                return usuarios;
            }
        }
        #endregion

    }
}
