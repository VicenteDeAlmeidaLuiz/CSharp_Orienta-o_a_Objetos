//using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades;
//using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos.Entidades.Enums;
//using System.Drawing;
//using System.Globalization;

//namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula8_MetodosAbstratos
//{
//    internal class ExecutoraFormas
//    {
//        static void Main(string[] args)
//        {
//            List<Figura> figuras = new List<Figura>();
//            Console.Write("Digite a quantidade de figuras: ");
//            int quantidadeFiguras = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= quantidadeFiguras; i++)
//            {
//                Console.WriteLine($"Dados da figura {i}:");
//                Console.Write("Retângulo ou Círculo (r/c)?");
//                char rOuC = char.Parse(Console.ReadLine());
//                Console.Write("Cor? (Preto,Azul ou Vermelho)");
//                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

//                if (rOuC == 'r')
//                {
//                    Console.Write("Largura: ");
//                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    Console.Write("Altura: ");
//                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    figuras.Add(new Retangulo(largura, altura, cor));

//                }
//                else
//                {
//                    Console.Write("Raio: ");
//                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                    figuras.Add(new Circulo(raio, cor));

//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("Área das figuras: ");

//            foreach (Figura figura in figuras)
//            {
//                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));

//            }
//        }
//    }
//}
