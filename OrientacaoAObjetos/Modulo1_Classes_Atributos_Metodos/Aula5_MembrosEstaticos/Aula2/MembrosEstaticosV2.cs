//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula5_MembrosEstaticos.Aula2;

//internal class MembrosEstaticosV2
//{

    
//    static void Main(string[] args)
//    {
        
//        Console.WriteLine("Digite o valor do raio!");
//        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        double circ = Calculadora.Circunferencia(raio);
//        double volume = Calculadora.Volume(raio);

//        Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
//        Console.WriteLine("Volune: " + volume.ToString("F2", CultureInfo.InvariantCulture));
//        Console.WriteLine("Valor de PI " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
//    }

//    /*Como lá na classe Calculadora as operações são static aqui eu não preciso instanciar nada,eu chamo essas operações direto 
//     com a classe,nesse caso Calculadora*/

    
//}
