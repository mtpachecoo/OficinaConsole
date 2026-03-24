using OficinaConsole.src.Entities;
using OficinaConsole.src.Interfaces;


public class OrdemServicoService
{
    
    private readonly IPagamento _pagamento;

    public OrdemServicoService(IPagamento pagamento)
    {
        _pagamento = pagamento;
    }

    public void AdicionarServico(OrdemServico ordemServico, Servico servico)
    {
        ordemServico.Servicos.Add(servico);
    }

    public void AdicionarPeca(OrdemServico ordemServico, Peca peca)
    {
        ordemServico.Pecas.Add(peca);
    }

    public void CalcularValorTotal(OrdemServico ordemServico)
    {
        double valorTotal = 0;

        foreach (var servico in ordemServico.Servicos)
        {
            valorTotal += servico.Valor;
        }

        foreach (var peca in ordemServico.Pecas)
        {
            valorTotal += peca.PrecoVenda;
        }

        ordemServico.ValorTotal = valorTotal;
    }

    public void ProcessarPagamento(OrdemServico ordemServico)
    {
        _pagamento.ProcessarPagamento(ordemServico.ValorTotal);
    }
    public void ProcessarPagamento(OrdemServico ordemServico, IPagamento pagamento)
    {
        pagamento.ProcessarPagamento(ordemServico.ValorTotal);
    }
}