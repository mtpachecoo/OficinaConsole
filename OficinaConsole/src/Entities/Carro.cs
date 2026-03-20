using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Entities
{
    public class Carro : Veiculo
    {
        public Carro() { }
        public Carro(string modelo, string marca, int placa) : base(modelo, marca, placa)
        {
        }

    }
}
