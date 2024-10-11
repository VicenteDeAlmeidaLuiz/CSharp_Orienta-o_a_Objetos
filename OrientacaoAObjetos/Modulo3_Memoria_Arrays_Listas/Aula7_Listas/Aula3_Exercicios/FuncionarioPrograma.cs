

//using System.Globalization;

//namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula7_Listas.Aula3_Exercicios
//{
//    internal class FuncionarioPrograma
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Quantos funcionários serão registrados? ");
//            int quantidade = int.Parse(Console.ReadLine());
//            List<Funcionario> funcionarios = new List<Funcionario>();
//            for (int i = 1; i <= quantidade; i++)
//            {
//                Console.WriteLine("Funcionário " + i);
//                Console.Write("Id:");
//                int id = int.Parse(Console.ReadLine());
//                Console.Write("Nome:");
//                string nome = Console.ReadLine();
//                Console.Write("Salário: ");
//                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                funcionarios.Add(new Funcionario(id, nome, salario));
//                Console.WriteLine();


//            }

//            Console.Write("Entre com o id do funcionário que terá seu salário aumentado: ");
//            int procId = int.Parse(Console.ReadLine());

//            Funcionario emp = funcionarios.Find(x => x.Id == procId);

//            if (emp != null)
//            {
//                Console.Write("Digite a porcentagem: ");
//                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                emp.incrementarSalario(porcentagem);


//            }
//            else
//            {
//                Console.WriteLine("Esse id não existe.");


//            }

//            Console.WriteLine();

//            Console.WriteLine("Atualizando lista de funcionários:");
//            foreach (Funcionario func in funcionarios)
//            {
//                Console.WriteLine(func);

//            }




//        }
//    }
//}
