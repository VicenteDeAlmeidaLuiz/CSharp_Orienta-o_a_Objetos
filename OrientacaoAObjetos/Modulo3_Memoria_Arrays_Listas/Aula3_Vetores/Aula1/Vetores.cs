//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula3_Vetores
//{
//    internal class Vetores
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite quantas alturas você deseja obter: ");
//            int alturas = int.Parse(Console.ReadLine());

//            double[] vetor = new double[alturas];

//            for (int i = 0; i < alturas; i++)
//            {
//                Console.WriteLine("Digite a altura " + i);
//                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//            }

//            double soma = 0.0;
//            for (int i = 0; i < alturas; i++)
//            {
//                soma += vetor[i];


//            }
//            double media = soma / alturas;
//            Console.WriteLine("Altura média:" + media.ToString("F2", CultureInfo.InvariantCulture));


//        }
//    }
//}
