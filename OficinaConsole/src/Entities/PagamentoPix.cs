using OficinaConsole.src.Interfaces;

namespace OficinaConsole.src.Entities
{   
    public class PagamentoPix : IPagamento
    {
        public void ProcessarPagamento(double valor)
        {
            System.Console.WriteLine("Pagamento concluído!");
        }
    }
}