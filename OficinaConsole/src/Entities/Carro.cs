using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Entities
{
    public class Carro : Veiculo
    {
        public Carro() { }
        public Carro(int anoFabricacao, string modelo, string marca, int placa) : base(anoFabricacao, modelo, marca, placa)
        {
        }

        public override string ObterDescricao()
        {
            return $"Veiculo: {AnoFabricacao} - {Marca} {Modelo}";
        }

    }
}
