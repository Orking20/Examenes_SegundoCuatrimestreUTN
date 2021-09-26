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
    public partial class FrmAltaCliente : Form
    {
        private static List<Cliente> clientes;
        private static bool flagPrimeraVezModificable = true;
        private static bool flagPrimeraVez = true;

        public FrmAltaCliente()
        {
            InitializeComponent();

            if (flagPrimeraVezModificable)
            {
                clientes = new List<Cliente>();
                flagPrimeraVezModificable = false;
            }

            if (flagPrimeraVez)
            {
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(41270, "Roberto", "Morales", Convert.ToDateTime("14/05/1992"), 37452102, "Masculino", "Argentina", "Charlone 1302"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(4200, "Mariana", "Rodriguez", Convert.ToDateTime("03/12/1962"), 30640222, "Femenino", "Argentina", "Moldes 1429"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(202, "Javier", "Rey", Convert.ToDateTime("21/04/1998"), 40588922, "No binario", "Argentina", "Del Signo 4037"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(23000, "Marcelo", "Oviedo", Convert.ToDateTime("12/06/1993"), 40842351, "Masculino", "Perú", "Alsina 110"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(44, "Sofía", "Velez", Convert.ToDateTime("29/03/1997"), 40256483, "Femenino", "Argentina", "José Bonifacio 1406"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(209, "Camila", "Gutierrez", Convert.ToDateTime("22/11/1984"), 38266548, "No binario", "Argentina", "Giribone 1700"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(1990, "Farrokh", "Bulsara", Convert.ToDateTime("05/09/1946"), 29542356, "Masculino", "Tanzania", "Zanzíbar 2004"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(57500, "Carlos", "Díaz", Convert.ToDateTime("22/01/1992"), 35524124, "Masculino", "Argentina", "Av. Forest 1427"));
                FrmAltaCliente.Clientes.Add(Empleado.AltaCliente(800, "Sigvar", "Gangraz", Convert.ToDateTime("20/04/1999"), 42412358, "Masculino", "España", "Metano 10"));

                flagPrimeraVez = false;
            }

            this.cmbSexo.Text = "Masculino";
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

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            double sueldo;
            string nombre;
            string apellido;
            DateTime fechaNacimiento;
            long dni;
            string sexo;
            string nacionalidad;
            string domicilio;
            Cliente clienteNuevo;
            Random sueldoRandom = new Random();

            sueldo = sueldoRandom.Next(300000);

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            fechaNacimiento = ca1FechaNacimiento.SelectionStart.Date;
            if (!long.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("El DNI es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sexo = cmbSexo.SelectedItem.ToString();
            nacionalidad = txtNacionalidad.Text;
            domicilio = txtDomicilio.Text;
            
            clienteNuevo = Empleado.AltaCliente(sueldo, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);
            clientes.Add(clienteNuevo);

            MessageBox.Show($"El ID de el nuevo cliente es: {clienteNuevo.IdCliente}\nNo olvide dárselo a su cliente para futuras consultas", "ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
        }
    }
}
