//using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula7_ClassesAbstratas.Aula1_ClassesAbstratas.Entidades;
//using System.Globalization;

//namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula7_ClassesAbstratas.Aula1_ClassesAbstratas
//{
//    internal class ExecutoraContas
//    {
//        static void Main(string[] args)
//        {

//            List<Conta1Abs> listaContas = new List<Conta1Abs>(); /*Mesmo a classe sendo abstrata eu consigo inserir ela como uma lista*/

//            listaContas.Add(new ContaPoupanca1Abs(1001, "Alex", 500.0, 0.01));
//            listaContas.Add(new ContaEmpresa1Abs(1002, "Maria", 500.0, 400.0));
//            listaContas.Add(new ContaPoupanca1Abs(1003, "Bob", 500.0, 0.01));
//            listaContas.Add(new ContaEmpresa1Abs(1004, "Ana", 500.0, 500.0));

//            /*Como eu tenho a superclasse genérica,abstrata eu posso fazer um for e dados das diferentes contas*/

//            double soma = 0;

//            foreach (Conta1Abs contas in listaContas)
//            {
//                soma += contas.Saldo;


//            }

//            Console.WriteLine($"O saldo de todas as contas dos tipos empresa e poupança é de R${soma.ToString("F2", CultureInfo.InvariantCulture)}.");

//            /*Posso também usar a lista do tipo da classe genérica e usar os métodos*/

//            foreach (Conta1Abs contas in listaContas)
//            {
//                contas.Saque(10.0);

//            }

//            foreach (Conta1Abs contasSaldo in listaContas)
//            {
//                Console.WriteLine("Saldo atualizado para a conta " + contasSaldo.Numero
//                    + ":"
//                    + contasSaldo.Saldo.ToString("F2", CultureInfo.InvariantCulture)

//                    );

//            }



//        }
//    }
//}
