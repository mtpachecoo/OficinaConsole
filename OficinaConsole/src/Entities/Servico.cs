using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Entities
{
    public class Servico
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public Servico() { }
        public Servico(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
