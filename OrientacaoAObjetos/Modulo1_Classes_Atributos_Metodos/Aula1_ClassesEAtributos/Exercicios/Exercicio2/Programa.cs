namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula1_ClassesEAtributos.Exercicios.Exercicio2;

internal class Programa
{
    static void Main(string[] args)
    {
        FuncionarioClasse Funcionario1, Funcionario2;
        Funcionario1 = new FuncionarioClasse();
        Funcionario2 = new FuncionarioClasse();

        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        Funcionario1.nome = Console.ReadLine();
        Console.Write("Salário: ");
        Funcionario1.salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Dados do segundo funcionário:");
        Console.Write("Nome: ");
        Funcionario2.nome = Console.ReadLine();
        Console.Write("Salário: ");
        Funcionario2.salario = double.Parse(Console.ReadLine());

        double media = (Funcionario1.salario + Funcionario2.salario) / 2.0;

        Console.WriteLine($"Salário médio: {media.ToString("F2")}.");


    }
}
