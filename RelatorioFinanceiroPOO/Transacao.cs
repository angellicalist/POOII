public class Transacao
{
    public string Descricao { get; set; }
    public decimal Valor { get; set; } 

    public Transacao(string descricao, decimal valor)
    {
        Descricao = descricao;
        Valor = valor;
    }
}
