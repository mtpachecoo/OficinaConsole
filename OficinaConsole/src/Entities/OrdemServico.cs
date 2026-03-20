using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Entities
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public Carro Carro { get; set; }
        public Mecanico Mecanico { get; set; }
        public List<Servico> Servicos { get; set; } = new List<Servico>();
        public double ValorServicoTotal { get; private set; }
        public double ValorTotal { get; set; }


        public OrdemServico() { }

        public OrdemServico(int id, Carro carro, Mecanico mecanico, List<Servico> servico)
        {
            Id = id;
            Carro = carro;
            Mecanico = mecanico;
            Servicos = servico;
        }




    }
}
