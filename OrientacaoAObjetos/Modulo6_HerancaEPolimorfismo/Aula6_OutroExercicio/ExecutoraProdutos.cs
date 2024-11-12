//using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula6_OutroExercicio.Entidades;
//using System.Globalization;

//namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula6_OutroExercicio;

//internal class ExecutoraProdutos
//{
//    static void Main(string[] args)
//    {
//        List<Produto> Produtos = new List<Produto>();
//        Console.Write("Digite a quantidade de produtos: ");
//        int quantidadeProdutos = int.Parse(Console.ReadLine());



//        for (int i = 1; i <= quantidadeProdutos; i++)
//        {
//            Console.WriteLine($"Entre com os dados do produto {i}:");
//            Console.Write("Produto comum,usado ou importado (c/u/i)? ");
//            char categoriaProduto = char.Parse(Console.ReadLine());
//            if (categoriaProduto == 'i')
//            {
//                Console.Write("Nome: ");
//                string nomeProdutoImp = Console.ReadLine();
//                Console.Write("Preço: ");
//                double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                Console.Write("Custos de alfândega: ");
//                double custoAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                Produtos.Add(new ProdutoImportado(nomeProdutoImp, Preco, custoAlfandega));


//            }
//            else if (categoriaProduto == 'c')
//            {
//                Console.Write("Nome: ");
//                string nomeProdComum = Console.ReadLine();
//                Console.Write("Preço: ");
//                double precoProdComum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                Produtos.Add(new Produto(nomeProdComum, precoProdComum));


//            }
//            else if (categoriaProduto == 'u')
//            {
//                Console.Write("Nome: ");
//                string nomeProdUsado = Console.ReadLine();
//                Console.Write("Preço: ");
//                double precoProdUsado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                Console.Write("Data da manufatura (DD/MM/YYYY): ");
//                DateTime dataManufatura = DateTime.Parse(Console.ReadLine());
//                Produtos.Add(new ProdutoUsado(nomeProdUsado, precoProdUsado, dataManufatura));


//            }
//            else
//            {
//                Console.WriteLine("Você digitou um valor inválido:");

//            }


//        }
//        Console.WriteLine();

//        Console.WriteLine("Etiquetas de preço:");
//        foreach (Produto produtos in Produtos)
//        {
//            Console.WriteLine(produtos.EtiquetaDePreco());


//        }




//    }
//}
