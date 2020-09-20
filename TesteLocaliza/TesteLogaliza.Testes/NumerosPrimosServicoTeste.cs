using NUnit.Framework;
using System.Linq;
using TesteLocaliza.Servicos;

namespace TesteLocaliza.Testes
{
    public class NumerosPrimosServicoTeste
    {
        public NumerosPrimosServico NumerosPrimosServico;

        [SetUp]
        public void Setup()
        {
            NumerosPrimosServico = new NumerosPrimosServico();
        }

        [Test]
        public void ObterDivisoresPrimos_40()
        {
            var resposta = new int[] { 2, 5 };
            var resultado = NumerosPrimosServico.ObterDivisoresPrimos(new int[] { 1, 2, 4, 5, 8, 10, 20, 40 });
            var validacao = resultado.SequenceEqual(resposta);
            Assert.IsTrue(validacao);
        }

        [Test]
        public void ObterDivisores_vazios()
        {
            var resposta = new int[] { };
            var resultado = NumerosPrimosServico.ObterDivisoresPrimos(new int[] { 0, 1 });

            var validacao = resultado.SequenceEqual(resposta);
            Assert.IsTrue(validacao);
        }

        [Test]
        public void ObterDivisores_negativos()
        {
            var resposta = new int[] { };
            var resultado = NumerosPrimosServico.ObterDivisoresPrimos(new int[] { -91, -52, -54 });

            var validacao = resultado.SequenceEqual(resposta);
            Assert.IsTrue(validacao);
        }
    }
}