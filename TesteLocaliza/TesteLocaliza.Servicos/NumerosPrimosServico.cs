using System;
using System.Collections.Generic;
using System.Text;
using TesteLocaliza.Interfaces;

namespace TesteLocaliza.Servicos
{
    public class NumerosPrimosServico : INumerosPrimosServico
    {

        /// <summary>
        ///Obtém uma lista com todos os divisores primos válidos da lista informada.
        /// </summary>
        /// <param name="divisores">Lista de valores a serem consultados</param>
        /// <returns>Lista de divisores primos</returns>
        public IEnumerable<int> ObterDivisoresPrimos(IEnumerable<int> divisores)
        {
            var divisoresPrimos = new List<int>();

            foreach (var divisor in divisores)
            {
                if (ValidarDivisorPrimo(divisor))
                    divisoresPrimos.Add(divisor);
            }

            return divisoresPrimos;
        }

        /// <summary>
        ///Valida de o número corrente é um número primo.
        /// </summary>
        /// <param name="divisor">Valor a ser consultado</param>
        /// <returns>booleano de validação </returns>
        private bool ValidarDivisorPrimo(int divisor)
        {
            if (divisor < 2)
                return false;

            var resultado = true;

            for (int i = 2; i < divisor; i++)
            {
                if (divisor % i == 0)
                    resultado = false;
            }

            return resultado;
        }
    }
}
