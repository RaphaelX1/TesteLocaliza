using NUnit.Framework;
using System.Linq;
using TesteLocaliza.Comum;
using TesteLocaliza.Servicos;

namespace TesteLocaliza.Testes
{
    public class DecompositorServicoTeste
    {
        public DecompositorServico DecompositorServico;

        [SetUp]
        public void Setup()
        {
            DecompositorServico = new DecompositorServico();
        }

        [Test]
        public void DecomporValores_40()
        {
            var resposta = "Divisores: 1, 2, 4, 5, 8, 10, 20, 40\r\nDivisores Primos: 2, 5\r\n";
            var resultado = DecompositorServico.DecomporValores("40");
            Assert.AreEqual(resposta, resultado);
        }

        [Test]
        public void DecomporValores_letra()
        {
            var resultado = DecompositorServico.DecomporValores("ABC");
            Assert.AreEqual(Mensagens.ValorInvalido, resultado);
        }

        [Test]
        public void DecomporValores_numero_negativo()
        {
            var resultado = DecompositorServico.DecomporValores("-23");
            Assert.AreEqual(Mensagens.ValorInvalido, resultado);
        }


    }
}