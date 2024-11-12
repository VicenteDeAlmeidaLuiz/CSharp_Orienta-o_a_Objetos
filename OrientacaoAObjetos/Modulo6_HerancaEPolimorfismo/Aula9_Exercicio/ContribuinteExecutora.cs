//using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula9_Exercicio.Entidades;
//using System.Globalization;

//namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula9_Exercicio
//{
//    internal class ContribuinteExecutora
//    {
//        static void Main(string[] args)
//        {
//            List<Contribuinte> contribuintes = new List<Contribuinte>();
//            Console.Write("Digite o núemro de contribuintes: ");
//            int numeroContribuintes = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= numeroContribuintes; i++)
//            {
//                Console.WriteLine($"Dados do contribuinte {i}:");
//                Console.Write("Pessoa Fisica ou Jurídica (f/j)?");
//                char tipoContribuinte = char.Parse(Console.ReadLine());
//                if (tipoContribuinte == 'f')
//                {
//                    Console.Write("Nome: ");
//                    string nome = Console.ReadLine();
//                    Console.Write("Renda Anual: ");
//                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    Console.Write("Gastos com saúde: ");
//                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    contribuintes.Add(new PessoaFisica(gastosComSaude, nome, rendaAnual));

//                }
//                else
//                {
//                    Console.Write("Nome: ");
//                    string nomePj = Console.ReadLine();
//                    Console.Write("Renda Anual: ");
//                    double rendaAnualPj = double.Parse(Console.ReadLine());
//                    Console.Write("Número de colaboradores: ");
//                    int numeroDeColaboradores = int.Parse(Console.ReadLine());
//                    contribuintes.Add(new PessoaJuridica(numeroDeColaboradores, nomePj, rendaAnualPj));



//                }


//            }
//            Console.WriteLine();
//            Console.WriteLine("Valor de taxas: ");

//            foreach (Contribuinte contribuinte in contribuintes)
//            {
//                Console.WriteLine(contribuinte.Nome + ":" + "R$" + contribuinte.CalculoImposto().ToString("F2"), CultureInfo.InvariantCulture);
//            }



//        }
//    }
//}
