using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Administrador : Empleado
    {
        private static int idEmpleado = 0;
        private static int idAdministrador = 0;
        private int idAdmin = 0;

        #region Constructor
        /// <summary>
        /// Inicializa los datos de un administrador
        /// </summary>
        /// <param name="idAdministrador">ID del administrador</param>
        /// <param name="usuario">Usuario del administrador</param>
        /// <param name="password">Password del administrador</param>
        /// <param name="sueldo">Sueldo del administrador</param>
        /// <param name="puesto">Puesto del administrador</param>
        /// <param name="diasLaborales">Días laborales del administrador</param>
        /// <param name="horarioEntrada">Horario de entrada del administrador</param>
        /// <param name="horarioSalida">Horario de entrada del administrador</param>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del administrador</param>
        /// <param name="dni">DNI del administrador</param>
        /// <param name="sexo">Sexo del administrador</param>
        /// <param name="nacionalidad">Nacionalidad del administrador</param>
        /// <param name="domicilio">Domicilio del administrador</param>
        public Administrador(int idAdministrador, string usuario, string password, double sueldo, EPuesto puesto, string[] diasLaborales, DateTime horarioEntrada, DateTime horarioSalida, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
            : base(usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, idEmpleado, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio)
        {
            this.idAdmin = idAdministrador;
        }
        #endregion

        #region Administrar admin
        /// <summary>
        /// Crea un nuevo administrador
        /// </summary>
        /// <param name="usuario">Usuario del administrador</param>
        /// <param name="password">Password del administrador</param>
        /// <param name="sueldo">Sueldo del administrador</param>
        /// <param name="puesto">Puesto del administrador</param>
        /// <param name="diasLaborales">Dias laborales del administrador</param>
        /// <param name="horarioEntrada">Horario de entrada del administrador</param>
        /// <param name="horarioSalida">Horario de salida del administrador</param>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del administrador</param>
        /// <param name="dni">DNI del administrador</param>
        /// <param name="sexo">Sexo del administrador</param>
        /// <param name="nacionalidad">Nacionalidad del administrador</param>
        /// <param name="domicilio">Domicilio del administrador</param>
        /// <returns>Retorna el nuevo administrador</returns>
        public static Administrador AltaAdministrador(string usuario, string password, double sueldo, EPuesto puesto, string[] diasLaborales, DateTime horarioEntrada, DateTime horarioSalida, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
        {
            idAdministrador++;

            Administrador administradorNuevo = new Administrador(idAdministrador, usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);

            return administradorNuevo;
        }

        /// <summary>
        /// Elimina un administrador de la lista de administradores
        /// </summary>
        /// <param name="listaAdministradores">Lista de administradores</param>
        /// <param name="administrador">Administrador a eliminar</param>
        public static void BajaAdministrador(List<Administrador> listaAdministradores, Administrador administrador)
        {
            listaAdministradores.Remove(administrador);
        }
        #endregion

        #region Administrar empleado
        /// <summary>
        /// Crea un nuevo empleado
        /// </summary>
        /// <param name="usuario">Usuario del empleado</param>
        /// <param name="password">Password del empleado</param>
        /// <param name="sueldo">Sueldo del empleado</param>
        /// <param name="puesto">Puesto del empleado</param>
        /// <param name="diasLaborales">Días laborales del administrador</param>
        /// <param name="horarioEntrada">Hora de entrada del empleado</param>
        /// <param name="horarioSalida">Hora de salida del empleado</param>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del empleado</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del empleado</param>
        /// <param name="dni">DNI del empleado</param>
        /// <param name="sexo">Sexo del empleado</param>
        /// <param name="nacionalidad">Nacionalidad del empleado</param>
        /// <param name="domicilio">Domicilio del empleado</param>
        /// <returns>Retorna el nuevo empleado</returns>
        public static Empleado AltaEmpleado(string usuario, string password, double sueldo, EPuesto puesto, string[] diasLaborales, DateTime horarioEntrada, DateTime horarioSalida, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
        {
            idEmpleado++;

            Empleado empleadoNuevo = new Empleado(usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, idEmpleado, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);

            return empleadoNuevo;
        }

        /// <summary>
        /// Elimina un empleado de una lista de empleados
        /// </summary>
        /// <param name="listaEmpleados">Lista de empleados</param>
        /// <param name="empleado">Empleado a eliminar</param>
        public static void BajaEmpleado(List<Empleado> listaEmpleados, Empleado empleado)
        {
            listaEmpleados.Remove(empleado);
        }

        /// <summary>
        /// Muestra los datos de un empleado
        /// </summary>
        /// <param name="empleado">Empleado a mostrar</param>
        public static void MostrarEmpleado(Empleado empleado)
        {
            empleado.Mostrar();
        }
        #endregion

        #region Getter
        /// <summary>
        /// Devuelve el ID del administrador
        /// </summary>
        public int IdAdministrador
        {
            get
            {
                return idAdmin;
            }
        }
        #endregion
    }
}