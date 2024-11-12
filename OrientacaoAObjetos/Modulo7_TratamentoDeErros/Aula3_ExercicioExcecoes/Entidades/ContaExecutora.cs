using OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula3_ExercicioExcecoes.Entidades.Excecoes;
using System.Globalization;

namespace OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula3_ExercicioExcecoes.Entidades;

internal class ContaExecutora
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os dados da conta: ");
        Console.Write("Número: ");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.Write("Nome do cliente: ");
        string nomeCliente = Console.ReadLine();
        Console.Write("Saldo inicial: ");
        double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Limite de saque: ");
        double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Conta conta = new Conta(numeroConta, nomeCliente, saldoInicial, limiteDeSaque);
        Console.Write("Digite um valor para saque: ");
        double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        try
        {
            conta.Saque(valorSaque);
            Console.Write("Novo saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (ExcecaoDominio e)
        {
            Console.WriteLine("Erro de saque: " + e.Message);

        }





    }
}
