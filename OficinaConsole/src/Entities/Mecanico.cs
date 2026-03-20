using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaConsole.src.Entities
{
    public class Mecanico
    {
        public string Nome { get; set; }    

        public double Salario { get; set; }

        public Mecanico (){ }

        public Mecanico(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
