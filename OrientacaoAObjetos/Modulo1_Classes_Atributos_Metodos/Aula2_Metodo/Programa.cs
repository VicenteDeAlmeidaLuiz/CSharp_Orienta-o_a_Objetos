//using OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula1_ResolvendoSemOrientacaoAObj;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula2_Metodo;

//internal class Programa
//{
//    static void Main(string[] args)
//    {
//        Triangulo TrianguloX, TrianguloY;

//        TrianguloX = new Triangulo();
//        TrianguloY = new Triangulo();

//        Console.WriteLine("Entre com as medidas do triângulo x!");
//        TrianguloX.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloX.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloX.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//        Console.WriteLine("Entre com as medidas do triângulo y!");
//        TrianguloY.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloY.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        TrianguloY.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//        double areax = TrianguloX.Area(); /*Aqui chamo o método criado*/
//        double areay = TrianguloY.Area();

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
