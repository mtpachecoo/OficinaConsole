using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Entities
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public Mecanico Mecanico { get; set; }
        public List<Servico> Servicos { get; set; } = new List<Servico>();
        public List<Peca> pecas {get; set;} = new List<Peca>();
        public double ValorServicoTotal { get; private set;}
        public double ValorTotal { get; set; }


        public OrdemServico() { }

        public OrdemServico(int id, Veiculo veiculo, Mecanico mecanico, List<Servico> servico)
        {
            Id = id;
            Veiculo = veiculo;
            Mecanico = mecanico;
            Servicos = servico;
        }




    }
}
