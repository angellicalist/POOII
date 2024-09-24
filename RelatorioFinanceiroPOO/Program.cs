List<Transacao> transacoes = new List<Transacao>
        {
            new Transacao("Venda de produto A", 150.00m),
            new Transacao("Despesa com aluguel", -500.00m),
            new Transacao("Venda de produto B", 200.00m),
            new Transacao("Despesa com conta de luz", -100.00m)
        };

       
        RelatorioFinanceiro relatorio = new RelatorioFinanceiro();
        decimal saldoFinal = relatorio.CalcularSaldoFinal(transacoes);

        
        Console.WriteLine($"Saldo Final: {saldoFinal:C}");