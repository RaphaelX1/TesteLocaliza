using System;
using System.Collections.Generic;
using System.Text;

namespace TesteLocaliza.Interfaces
{
    public interface INumerosPrimosServico
    {
        public IEnumerable<int> ObterDivisoresPrimos(IEnumerable<int> divisores);
    }
}
