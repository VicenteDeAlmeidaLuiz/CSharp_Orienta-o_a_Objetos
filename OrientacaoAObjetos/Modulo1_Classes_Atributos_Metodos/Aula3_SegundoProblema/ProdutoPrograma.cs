//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula3_SegundoProblema
//{
//    internal class ProdutoPrograma
//    {
//        static void Main(string[] args)
//        {

//            Produto produto = new Produto();

//            Console.WriteLine("Entre com os dados do produto: ");
//            Console.Write("Nome: ");
//            produto.Nome = Console.ReadLine();
//            Console.Write("Preço: ");
//            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//            Console.Write("Quantidade no estoque:");
//            produto.Quantidade = int.Parse(Console.ReadLine());

//            Console.WriteLine("Dados do produto " + produto);
//            Console.WriteLine();
//            Console.Write("Digite a quantidade de produtos a serem adicionados ao estoque: ");
//            int quantidade = int.Parse(Console.ReadLine());
//            produto.AdicionarPordutos(quantidade);
//            Console.WriteLine("Dados atualizados: " + produto);
//            Console.WriteLine();
//            Console.Write("Digite a quantidade de produtos a serem removidos do estoque: ");
//            quantidade = int.Parse(Console.ReadLine());
//            produto.RemoverProdutos(quantidade);
//            Console.WriteLine("Dados atualizados: " + produto);









//        }
//    }
//}
