
public abstract class Veiculo
{
    protected int velocidade;

    public void mostrarVelocidade(int valor)
    {
        velocidade = valor;
    }
    public abstract void Acelerar();
    public abstract void Frear();

    public void ExibeVelocidade()
    {
        Console.WriteLine("Velocidade: " + velocidade);
    }

}