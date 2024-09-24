public class Fornecedor
{
    private string nome?; 
    private decimal valorMinimoProduto; 

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do fornecedor não pode ser vazio.");
            }
            nome = value;
        }
    }

    public decimal ValorMinimoProduto
    {
        get { return valorMinimoProduto; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O valor mínimo de um produto não pode ser menor ou igual a zero.");
            }
            valorMinimoProduto = value;
        }
    }

    public Fornecedor(string nome, decimal valorMinimoProduto)
    {
        Nome = nome; 
        ValorMinimoProduto = valorMinimoProduto; 
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Fornecedor: {Nome}, Valor Mínimo do Produto: {ValorMinimoProduto:C}");
    }

    public bool PodeFornecer(decimal valorProduto)
    {
        return valorProduto >= valorMinimoProduto;
    }
}