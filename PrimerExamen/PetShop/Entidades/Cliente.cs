using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private double saldo;
        private int idCliente;

        #region Constructor
        /// <summary>
        /// Inicializa los datos de un cliente
        /// </summary>
        /// <param name="saldo">Saldo del cliente</param>
        /// <param name="idCliente">ID del cliente</param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="apellido">Apellido del cliente</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del cliente</param>
        /// <param name="dni">DNI del cliente</param>
        /// <param name="sexo">Sexo del cliente</param>
        /// <param name="nacionalidad">Nacionalidad del cliente</param>
        /// <param name="domicilio">Domicilio del cliente</param>
        public Cliente(double saldo, int idCliente, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
            : base(nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio)
        {
            this.idCliente = idCliente;
            this.Saldo = saldo;
        }
        #endregion

        #region Getters/Setters
        /// <summary>
        /// Establece el valor de saldo
        /// </summary>
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if (ValidarSaldo(value))
                {
                    this.saldo = value;
                }
            }
        }

        /// <summary>
        /// Devuelve el valor de idCliente
        /// </summary>
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
        }
        #endregion

        #region Implicit
        /// <summary>
        /// Junta en un mismo string el nombre y apellido de un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public static implicit operator string(Cliente cliente)
        {
            string nombreConApellido;

            nombreConApellido = $"{cliente.Nombre} {cliente.Apellido}";

            return nombreConApellido;
        }
        #endregion

        #region Validaciones
        /// <summary>
        /// Valida que el saldo sea mayor o igual a 0 
        /// </summary>
        /// <param name="saldo">El saldo a validar</param>
        /// <returns>Retorna true si el saldo en mayor o igual a 0 o si no false</returns>
        private bool ValidarSaldo(double saldo)
        {
            bool retorno = false;

            if (saldo >= 0)
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
