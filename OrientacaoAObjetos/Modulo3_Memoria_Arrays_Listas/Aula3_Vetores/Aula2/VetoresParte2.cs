//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula3_Vetores.Aula2
//{
//    internal class VetoresParte2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite a quantidade de produtos: ");
//            int quantidade = int.Parse(Console.ReadLine());

//            Produto[] vetorProdutos = new Produto[quantidade];

//            for (int i = 0; i < quantidade; i++)
//            {
//                string nome = Console.ReadLine();
//                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                vetorProdutos[i] = new Produto { Nome = nome, Preco = preco };


//            }

//            double soma = 0.0;
//            for (int i = 0; i < quantidade; i++) {
//                soma += vetorProdutos[i].Preco;
            
//            }
//            double media = soma / quantidade;

//            Console.WriteLine($"Média de preço dos produtos: {media.ToString("F2",CultureInfo.InvariantCulture)}.");



//        }
//    }
//}
