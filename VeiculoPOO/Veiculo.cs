public abstract class Veiculo 
{
    public string Marca;
    public string Modelo;

    public Veiculo (string marca, string modelo) 
    {
        Marca = marca;
        Modelo = modelo;
    }
    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Veículo: {Marca} {Modelo}");
    }

    public abstract void TipoDeVeiculo();
}