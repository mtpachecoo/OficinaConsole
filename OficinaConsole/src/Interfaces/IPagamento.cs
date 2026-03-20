using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Interfaces
{
    public interface IPagamento
    {
        public void ProcessarPagamento(double valor);
    }
}
