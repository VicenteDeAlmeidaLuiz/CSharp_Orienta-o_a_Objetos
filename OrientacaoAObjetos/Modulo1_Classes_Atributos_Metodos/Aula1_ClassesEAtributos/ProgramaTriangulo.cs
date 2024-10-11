
//using System.Globalization;


//namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula1_ResolvendoSemOrientacaoAObj;

//internal class ProgramaTriangulo
//{
//    static void Main(string[] args)
//    {
//        TrianguloClasse TrianguloX, TrianguloY;

//        TrianguloX = new TrianguloClasse();
//        TrianguloY = new TrianguloClasse();

//        Console.WriteLine("Entre com as medidas do triângulo x!");
//        TrianguloX.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloX.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloX.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//        Console.WriteLine("Entre com as medidas do triângulo y!");
//        TrianguloY.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloY.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloY.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//        double p = (TrianguloX.ladoA + TrianguloX.ladoB + TrianguloX.ladoC) / 2.0;
//        double areax = Math.Sqrt(p * (p - TrianguloX.ladoA) * (p - TrianguloX.ladoB) * (p - TrianguloX.ladoC));

//        p = (TrianguloY.ladoA + TrianguloY.ladoB + TrianguloY.ladoC) / 2.0;
//        double areay = Math.Sqrt(p * (p - TrianguloY.ladoA) * (p - TrianguloY.ladoB) * (p - TrianguloY.ladoC));

//        Console.WriteLine("Área de x = " + areax.ToString("F4", CultureInfo.InvariantCulture));
//        Console.WriteLine("Área de y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

//        if (areax > areay)
//        {
//            Console.WriteLine("Maior área: X");

//        }
//        else
//        {
//            Console.WriteLine("Maior área: Y");

//        }
//    }
//}
