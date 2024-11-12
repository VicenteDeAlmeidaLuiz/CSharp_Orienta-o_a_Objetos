//using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio.Entidades;
//using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio.Entidades.Enum;
//using System.Globalization;

//namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio;

//internal class Executora
//{
//    static void Main()
//    {
//        Console.WriteLine("Digite os dados do cliente: ");
//        Console.Write("Nome:");
//        string nome = Console.ReadLine();
//        Console.Write("Email: ");
//        string email = Console.ReadLine();
//        Console.Write("Data de aniversário: (DD/MM/YYYY): ");
//        DateTime aniversario = DateTime.Parse(Console.ReadLine());
//        Console.WriteLine("Digite os dados do pedido: ");
//        Console.Write("Status:");
//        SituacaoPedido situacao = Enum.Parse<SituacaoPedido>(Console.ReadLine());
//        Cliente cliente = new Cliente(nome, email, aniversario);
//        Pedido pedido = new Pedido(DateTime.Now, situacao, cliente);

//        Console.Write("Quantos itens você vai adicionar no pedido? ");
//        int quantidadeItens = int.Parse(Console.ReadLine());
//        for (int i = 1; i <= quantidadeItens; i++)
//        {
//            Console.WriteLine($"Preencha o pedido {i}:");
//            Console.Write("Nome do produto: ");
//            string nomeProduto = Console.ReadLine();
//            Console.Write("Preço do produto: ");
//            double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//            Produto produto = new Produto(nomeProduto, precoProduto);

//            Console.Write("Quantidade: ");
//            int quantidade = int.Parse(Console.ReadLine());

//            ItemPedido itemPedido = new ItemPedido(quantidade,precoProduto,produto);
//            pedido.AdicionarItem(itemPedido);
//        }
//        Console.WriteLine();
//        Console.WriteLine(pedido);





//    }
//}
