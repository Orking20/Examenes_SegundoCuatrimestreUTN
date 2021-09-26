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
    public partial class FrmMostrarClientes : Form
    {
        public FrmMostrarClientes()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            StringBuilder ids = new StringBuilder();
            StringBuilder nombres = new StringBuilder();
            StringBuilder apellidos = new StringBuilder();
            StringBuilder fechasNacimientos = new StringBuilder();
            StringBuilder dnis = new StringBuilder();
            StringBuilder sexos = new StringBuilder();
            StringBuilder nacionalidades = new StringBuilder();
            StringBuilder domicilios = new StringBuilder();

            if (!FrmMenu.FlagPrimeraVezClientes)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    ids.AppendLine(cliente.IdCliente.ToString());
                    nombres.AppendLine(cliente.Nombre);
                    apellidos.AppendLine(cliente.Apellido);
                    fechasNacimientos.AppendLine($"{cliente.FechaNacimiento.Day}/{cliente.FechaNacimiento.Month}/{cliente.FechaNacimiento.Year}");
                    dnis.AppendLine(cliente.Dni.ToString());
                    if (cliente.Sexo == "Masculino")
                    {
                        sexos.AppendLine("M");
                    }
                    else if(cliente.Sexo == "Femenino")
                    {
                        sexos.AppendLine("F");
                    }
                    else
                    {
                        sexos.AppendLine("NB");
                    }
                    nacionalidades.AppendLine(cliente.Nacionalidad);
                    domicilios.AppendLine(cliente.Domicilio);
                }

                lblId.Visible = true;
                lblNombres.Visible = true;
                lblApellidos.Visible = true;
                lblFechaNacimiento.Visible = true;
                lblDni.Visible = true;
                lblSexo.Visible = true;
                lblNacionalidad.Visible = true;
                lblDomicilio.Visible = true;

                lblId.Text = ids.ToString();
                lblNombres.Text = nombres.ToString();
                lblApellidos.Text = apellidos.ToString();
                lblFechaNacimiento.Text = fechasNacimientos.ToString();
                lblDni.Text = dnis.ToString();
                lblSexo.Text = sexos.ToString();
                lblNacionalidad.Text = nacionalidades.ToString();
                lblDomicilio.Text = domicilios.ToString();
            }
            else
            {
                MessageBox.Show("No hay ningun cliente registrado", "Nada que mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
