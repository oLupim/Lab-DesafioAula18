

Carro c1 = new Carro();
c1.mostrarVelocidade(100);

Moto m1 = new Moto();
m1.mostrarVelocidade(150);

//criando Arrays
//int[] notas = new int[5];

// notas[0] = 90;
// notas[1] = 85;
// notas[2] = 88;
// notas[3] = 92;
// notas[4] = 95;

//acessando e imprimindo as notas dos alunos
// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Notas do Aluno: {i+1} = {notas[i]}");
// }

List<Veiculo> veiculos= new List<Veiculo>();

veiculos.Add(c1);
veiculos.Add(m1);

//veiculos.Remove(c1);

foreach(var veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibeVelocidade();
    veiculo.Frear();
    veiculo.ExibeVelocidade();
}