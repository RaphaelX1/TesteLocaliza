using System;
using System.Collections.Generic;
using System.Text;
using TesteLocaliza.Interfaces;

namespace TesteLocaliza.Servicos
{
    public class DivisoresServico : IDivisoresServico
    {
        /// <summary>
        ///Obtém uma lista com todos os divisores válidos para aquela entrada.
        /// </summary>
        /// <param name="entrada">valor inteiro a ser processado</param>
        /// <returns>Lista de divisores</returns>
        public IEnumerable<int> ObterDivisores(int entrada)
        {
            var divisores = new List<int>();

            for (int i = 1; i <= entrada; i++)
            {
                if (entrada % i == 0)
                    divisores.Add(i);
            }

            return divisores;
        }
    }
}
