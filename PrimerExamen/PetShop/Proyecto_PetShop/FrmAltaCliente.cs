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
            FrmMenu.Clientes.Add(clienteNuevo);

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
