

//namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula8_Matrizes.Aula2_Exercicio;

//internal class ExercicioMatriz
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Digite o número de linhas e colunas da matriz: ");

//        int numeroLinhas = int.Parse(Console.ReadLine());
//        int[,] matriz = new int[numeroLinhas, numeroLinhas];

//        for (int i = 0; i < numeroLinhas; i++)
//        {
//            string[] valores = Console.ReadLine().Split(' ');
//            for (int j = 0; j < numeroLinhas; j++)
//            {
//                matriz[i, j] = int.Parse(valores[j]);

//            }


//        }
//        Console.Write("Diagonal principal: ");
//        for (int i = 0; i < numeroLinhas; i++)
//        {

//            Console.Write(matriz[i, i] + " ");


//        }
//        Console.WriteLine();

//        int contagemNegativos = 0;
//        for (int i = 0; i < numeroLinhas; i++)
//        {
//            for (int j = 0; j < numeroLinhas; j++)
//            {
//                if (matriz[i, j] < 0)
//                {
//                    contagemNegativos++;


//                }



//            }



//        }
//        Console.WriteLine("Números Negativos: " + contagemNegativos);



//    }
//}
