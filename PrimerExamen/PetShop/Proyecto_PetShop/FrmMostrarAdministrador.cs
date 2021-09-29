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
    public partial class FrmMostrarAdministrador : Form
    {
        public FrmMostrarAdministrador()
        {
            InitializeComponent();
        }

        private void FrmMostrarAdministrador_Load(object sender, EventArgs e)
        {
            MostrarAdministradores();

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }

        private void MostrarAdministradores()
        {
            Administrador administrador;
            StringBuilder ids = new StringBuilder();
            StringBuilder nombres = new StringBuilder();
            StringBuilder apellidos = new StringBuilder();
            StringBuilder dnis = new StringBuilder();
            StringBuilder sueldos = new StringBuilder();
            StringBuilder diasLaborales = new StringBuilder();
            StringBuilder horaEntrada = new StringBuilder();
            StringBuilder horaSalida = new StringBuilder();

            for (int i = 0; i < FrmLogin.Administradores.Count; i++)
            {
                administrador = FrmLogin.Administradores[i];

                ids.AppendLine(administrador.IdAdministrador.ToString());
                nombres.AppendLine(administrador.Nombre);
                apellidos.AppendLine(administrador.Apellido);
                dnis.AppendLine(administrador.Dni.ToString());
                sueldos.AppendLine(administrador.Sueldo.ToString());

                for (int j = 0; j < administrador.DiasLaborales.Length; j++)
                {
                    diasLaborales.Append(administrador.DiasLaborales[j] + " ");
                }
                diasLaborales.AppendLine("");

                horaEntrada.AppendLine($"{administrador.HorarioEntrada.Hour}:{administrador.HorarioEntrada.Minute}");
                horaSalida.AppendLine($"{administrador.HorarioSalida.Hour}:{administrador.HorarioSalida.Minute}");

                lblId.Visible = true;
                lblNombres.Visible = true;
                lblApellidos.Visible = true;
                lblDni.Visible = true;
                lblSueldo.Visible = true;
                lblDiasLaborales.Visible = true;
                lblHoraEntrada.Visible = true;
                lblHoraSalida.Visible = true;

                lblId.Text = ids.ToString();
                lblNombres.Text = nombres.ToString();
                lblApellidos.Text = apellidos.ToString();
                lblDni.Text = dnis.ToString();
                lblSueldo.Text = sueldos.ToString();
                lblDiasLaborales.Text = diasLaborales.ToString();
                lblHoraEntrada.Text = horaEntrada.ToString();
                lblHoraSalida.Text = horaSalida.ToString();
            }
        }

    }
}
