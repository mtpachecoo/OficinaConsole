using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Entities
{
    public abstract class Veiculo
    {
        public int AnoFabricacao { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Placa { get; private set; }

        public Veiculo() { }

        public Veiculo(int anoFabricacao, string modelo, string marca, int placa)
        {
            AnoFabricacao = anoFabricacao;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
        }
        public abstract string ObterDescricao();
    }
}

