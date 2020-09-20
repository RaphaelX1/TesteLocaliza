using System;
using System.Collections.Generic;
using System.Text;

namespace TesteLocaliza.Interfaces
{
    public interface IDivisoresServico
    {
        public IEnumerable<int> ObterDivisores(int entrada);
    }
}
