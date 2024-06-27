public class Moto : Veiculo{

        public override void Acelerar()
    {
        velocidade += 15;
        Console.WriteLine("Moto acelerando(...)");
    }

    public override void Frear()
    {
        velocidade -= 10;
        Console.WriteLine("Moto freando(...)");
    }
}
