public class Moto : Veiculo
{
    public bool TemSidecar;

    public Moto(string marca, string modelo, bool temSidecar) : base(marca, modelo)
    {
         TemSidecar = temSidecar;   
    }

    public override void ExibirDetalhes()
    {
        string sidecar = TemSidecar ? "com sidecar" : "sem sidecar";
        Console.WriteLine($"Moto: {Marca}{Modelo}, {sidecar}");
    }

    public override void TipoDeVeiculo()
    {
        Console.WriteLine("Esta é uma Moto!");
    }
}