

namespace OficinaConsole.src.Entities
{
    public class Peca
    {
        public int IdPeca { get; private set; }
        public string NomePeca {get; private set;}
        public double PrecoCusto { get; private set; }
        public double PrecoVenda {get; private set;}

        public Peca(){}

        public Peca( int idPeca, string nomePeca, double precoCusto, double precoVenda)
        {
            IdPeca = idPeca;
            NomePeca = nomePeca;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
        }



    }
}