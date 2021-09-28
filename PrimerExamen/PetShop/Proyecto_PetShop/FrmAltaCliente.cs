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
        public FrmAltaCliente()
        {
            InitializeComponent();
            this.cmbSexo.Text = "Masculino";
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

            if (long.TryParse(txtDni.Text, out dni) && Persona.ValidarDni(dni) &&
                Persona.ValidarNombre(txtNombre.Text) &&
                Persona.ValidarApellido(txtApellido.Text)
                && Persona.ValidarSexo(cmbSexo.SelectedItem.ToString())
                && Persona.ValidarNacionalidad(txtNacionalidad.Text)
                && Persona.ValidarDomicilio(txtDomicilio.Text))
            {
                nombre = txtNombre.Text;
                sueldo = sueldoRandom.Next(50000);
                apellido = txtApellido.Text;
                fechaNacimiento = ca1FechaNacimiento.SelectionStart.Date;
                sexo = cmbSexo.SelectedItem.ToString();
                nacionalidad = txtNacionalidad.Text;
                domicilio = txtDomicilio.Text;
            
                clienteNuevo = Empleado.AltaCliente(sueldo, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);
                FrmMenu.Clientes.Add(clienteNuevo);
            }
            else
            {
                MessageBox.Show("Uno o varios de los datos ingresados no son válidos\nRevise y corrija los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
