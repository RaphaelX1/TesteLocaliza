using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteLocaliza.Comum;
using TesteLocaliza.Interfaces;

namespace TesteLocaliza.Servicos
{
    public class DecompositorServico : IDecompositorServico
    {
        private readonly DivisoresServico _divisoresServico;
        private readonly NumerosPrimosServico _numerosPrimosServico;

        public DecompositorServico()
        {
            _divisoresServico = new DivisoresServico();
            _numerosPrimosServico = new NumerosPrimosServico();
        }


        /// <summary>
        /// Obtém lista de divisores possíveis e os respectivos divisores primos.
        /// </summary>
        /// <param name="entrada">valor de texto a ser processado</param>
        /// <returns>Lista de divisores possíveis e seus divisores primos ou mensagens de validação. </returns>
        public string DecomporValores(string entrada)
        {

            if (!ValidarEntrada(entrada))
                return Mensagens.ValorInvalido;

            var entradaTratada = TratarEntrada(entrada);
            var divisores = _divisoresServico.ObterDivisores(entradaTratada);
            var divisoresPrimos = _numerosPrimosServico.ObterDivisoresPrimos(divisores);

            var builder = new StringBuilder();
            builder.AppendLine("Divisores: " + string.Join(", ", divisores.ToArray()));
            builder.AppendLine("Divisores Primos: " + string.Join(", ", divisoresPrimos.ToArray()));

            return builder.ToString();
        }

        /// <summary>
        ///Converte o valor de entrada para o padrão Inteiro.
        /// </summary>
        /// <param name="entrada">valor de texto a ser processado</param>
        /// <returns>Valor inteiro</returns>
        private int TratarEntrada(string entrada)
        {
            return Convert.ToInt32(entrada);
        }


        /// <summary>
        ///Valida se a entrada fornecida está em um padrão válido.
        /// </summary>
        /// <param name="entrada">valor de texto a ser processado</param>
        /// <returns>booleano de validação</returns>
        private bool ValidarEntrada(string entrada)
        {
            int conversao = 0;


            if (!int.TryParse(entrada, out conversao)) 
            {
                return false;
            }

            if (conversao < 0)
                return false;

            return true;
        }
    }
}
