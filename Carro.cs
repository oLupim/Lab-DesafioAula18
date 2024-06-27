public class Carro : Veiculo
{
    public override void Acelerar()
    {
        velocidade += 10;
        Console.WriteLine("Carro acelerando(...)");
    }
    
    public override void Frear()
    {
        velocidade -= 5;
        Console.WriteLine("Carro freando(...)");
    }
}