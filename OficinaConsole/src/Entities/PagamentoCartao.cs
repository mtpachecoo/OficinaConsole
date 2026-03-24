using OficinaConsole.src.Interfaces;

namespace OficinaConsole.src.Entities
{
    public class PagamentoCartao : IPagamento
    {
        public void ProcessarPagamento(double valor)
        {
            System.Console.WriteLine("Pagamento concluído!");
        }
    }
}