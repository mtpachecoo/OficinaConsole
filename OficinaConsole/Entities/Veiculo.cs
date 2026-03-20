using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.Entities
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Placa { get; private set; }

        public Veiculo() { }

        public Veiculo(string modelo, string marca, int placa)
        {
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
        }
    }
}

/*
Veiculo (classe base abstrata)
├── Carro
└── Moto

Mecanico (classe concreta)

Servico (classe concreta)

OrdemDeServico (classe concreta)
└── usa: Veiculo, Mecanico, List<Servico>, IPagamento

IPagamento (interface)
├── PagamentoPix
├── PagamentoCartao
└── PagamentoDinheiro
*/