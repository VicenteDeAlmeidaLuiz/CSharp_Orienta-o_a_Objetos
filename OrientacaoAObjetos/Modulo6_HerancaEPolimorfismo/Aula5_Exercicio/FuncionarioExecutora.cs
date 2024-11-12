//using System.Globalization;
//using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula5_Exercicio.Entidades;

//namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula5_Exercicio
//{
//    internal class FuncionarioExecutora
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Digite o número de funcionários: ");
//            List<Funcionario> listaFuncionarios = new List<Funcionario>();
//            int funcionario = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= funcionario; i++)
//            {
//                Console.WriteLine($"Dados do funcionario {i}:");
//                Console.Write("Funcionário é terceirizado (y/n)? ");
//                string funcTerceirizado = Console.ReadLine();
//                if (funcTerceirizado == "n")
//                {
//                    Console.Write("Nome: ");
//                    string nome = Console.ReadLine();
//                    Console.Write("Horas: ");
//                    int horas = int.Parse(Console.ReadLine());
//                    Console.Write("Valor por hora: ");
//                    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    listaFuncionarios.Add(new Funcionario(nome, horas, valorHora));

//                }
//                else if (funcTerceirizado == "y")
//                {
//                    Console.Write("Nome: ");
//                    string nomeFuncTerceirizado = Console.ReadLine();
//                    Console.Write("Horas: ");
//                    int horasFuncTerceirizado = int.Parse(Console.ReadLine());
//                    Console.Write("Valor por hora: ");
//                    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    Console.Write("Custo Adicional: ");
//                    double custoAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    listaFuncionarios.Add(new FuncionarioTerceirizado(nomeFuncTerceirizado, horasFuncTerceirizado, valorHora, custoAdicional));

//                }
//                else
//                {
//                    Console.WriteLine("Você digitou um valor incorreto!");

//                }
//            }
//            Console.WriteLine();

//            Console.WriteLine("Pagamentos: ");
//            foreach (Funcionario func in listaFuncionarios)
//            {
//                Console.WriteLine(func.Nome + "- R$ " + func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));


//            }



//        }
//    }
//}
