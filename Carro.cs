class Carro : Veiculo 
{
    public int NumeroDePortas;

    public Carro (string marca, string modelo, int numeroDePortas) : base(marca, modelo)
    {
        NumeroDePortas = numeroDePortas;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Carro: {Marca}{Modelo} Número de Portas: {NumeroDePortas}");
    }

    public override void TipoDeVeiculo()
    {
        Console.WriteLine("Este é um Carro!");
    }
}