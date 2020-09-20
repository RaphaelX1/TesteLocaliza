using NUnit.Framework;
using System.Linq;
using TesteLocaliza.Servicos;

namespace TesteLocaliza.Testes
{
    public class DivisoresServicoTeste
    {
        public DivisoresServico divisoresServico;

        [SetUp]
        public void Setup()
        {
            divisoresServico = new DivisoresServico();
        }

        [Test]
        public void ObterDivisores_40()
        {
            var resposta = new int[]{ 1, 2, 4, 5, 8, 10, 20, 40 };
            var resultado = divisoresServico.ObterDivisores(40);

            var validacao = resultado.SequenceEqual(resposta);
            Assert.IsTrue(validacao);
        }

        [Test]
        public void ObterDivisores_0()
        {
            var resposta = new int[] { };
            var resultado = divisoresServico.ObterDivisores(0);

            var validacao = resultado.SequenceEqual(resposta);
            Assert.IsTrue(validacao);
        }
    }
}