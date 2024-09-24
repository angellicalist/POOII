public class RelatorioFinanceiro
{
    
    public decimal CalcularSaldoFinal(List<Transacao> transacoes)
    {
        decimal saldo = 0;

        foreach (var transacao in transacoes)
        {
            saldo += transacao.Valor; 
        }

        return saldo;
    }
}