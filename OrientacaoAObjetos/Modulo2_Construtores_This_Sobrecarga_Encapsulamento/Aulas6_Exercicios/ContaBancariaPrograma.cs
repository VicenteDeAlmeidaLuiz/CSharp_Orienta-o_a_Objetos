//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aulas6_Exercicios
//{
//    internal class ContaBancariaPrograma
//    {
//        static void Main(string[] args)
//        {

//            ContaBancaria conta;

//            Console.Write("Entre com o número da conta: ");
//            int numeroConta = int.Parse(Console.ReadLine());
//            Console.Write("Entre com o tiutlar da conta: ");
//            string titular = Console.ReadLine();
//            Console.Write("Haverá depósito inicial? (s/n)");
//            char resposta = char.Parse(Console.ReadLine());

//            if (resposta == 's' || resposta == 'S')
//            {
//                Console.Write("Entre com o valor do depósito inicial: ");
//                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                conta = new ContaBancaria(numeroConta, titular, valorDepositoInicial);



//            }
//            else
//            {
//                conta = new ContaBancaria(numeroConta, titular);

//            }

//            Console.WriteLine();
//            Console.WriteLine(conta);

//            Console.WriteLine();
//            Console.Write("Entre com um valor para depósito: ");
//            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            conta.Deposito(quantia);
//            Console.WriteLine("Dados da conta atualizados: ");
//            Console.WriteLine(conta);

//            Console.WriteLine();
//            Console.Write("Entre com um valor para saque: ");
//            double quantiaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            conta.Saque(quantiaSaque);
//            Console.WriteLine("Dados da conta atualizados: ");
//            Console.WriteLine(conta);



//        }
//    }
//}
