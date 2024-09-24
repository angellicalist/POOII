public class Cliente 
{
    public string Nome;
    public string Email;
    public string Telefone;

    public Cliente (string nome, string email, string telefone) 
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}, Email: {Email}, Telefone: {Telefone}");
    }
}