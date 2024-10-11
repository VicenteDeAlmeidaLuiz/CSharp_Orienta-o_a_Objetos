//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula4_Exercicios.Exercicio2
//{
//    internal class FuncionarioPrograma
//    {
//        static void Main(string[] args)
//        {
//            Funcionario funcionario = new Funcionario();

//            Console.Write("Nome: ");
//            funcionario.Nome = Console.ReadLine();
//            Console.Write("Salário Bruto: ");
//            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//            Console.Write("Imposto: ");
//            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//            Console.WriteLine(funcionario);
//            Console.WriteLine();
//            Console.Write("Digite a porcentagem para aumento de salário");
//            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//            funcionario.AumentarSalario(porcentagem);
//            Console.WriteLine("Dados atualizados: " +funcionario);



//        }
//    }
//}
