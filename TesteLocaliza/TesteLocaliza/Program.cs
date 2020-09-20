using System;
using TesteLocaliza.Servicos;

namespace TesteLocaliza
{
    class Program
    {
        static void Main(string[] args)
        {
            var decompositorServico = new DecompositorServico();

            Console.WriteLine("--Decompositor--");

            var sair = "0";
            while (!sair.Equals("-1"))
            {
       
                Console.WriteLine("Digite o valor a decompor:");
                var resposta = decompositorServico.DecomporValores(Console.ReadLine());
                Console.WriteLine(resposta);
                Console.ReadKey();

                Console.WriteLine("Digite qualquer valor para continuar (-1 para sair)");
                sair = Console.ReadLine();
            }

        }
    }
}
