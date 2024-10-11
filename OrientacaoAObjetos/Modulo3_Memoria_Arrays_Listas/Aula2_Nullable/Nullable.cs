//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula2_Nullable;

//internal class Nullable
//{
//    static void Main(string[] args) {

//        /*double x = null; Se eu fizer isso não copila.O copilador informa que o valoe double não pode ser nulo*/

//        Nullable<double> x = null; /*Usamos o nullable para resolver o problema acima*/

//        double? y = null; /*Maneira mais simples de escrever o nullable*/

//        /*Operações básicas para nullable*/

//        double? z = null;
//        double? a = 10.0;
//        Console.WriteLine(z.GetValueOrDefault()); /*Aqui vai imprimir zero pq vai pegar o valor padrão de double */
//        Console.WriteLine(a.GetValueOrDefault()); /*Aqui vai imprimir o valor da variável */
//        Console.WriteLine("_____");
//        Console.WriteLine(z.HasValue);  /*Aqui vai imprimir False pq não há valor na variável*/
//        Console.WriteLine(a.HasValue);  /*Aqui vai imprimir True pq há valor na variável*/
//        Console.WriteLine("_____");
//        //Console.WriteLine(z.Value); /*Aqui vai apresentar excessão informando que para utilizar a operação Value é necessário informar um valor*/
//        //Console.WriteLine(a.Value); /*Aqui vai apresentar o valor real da variável.*/
//        /*Tratamento para a excessão citada na variável z*/
//        if (z.HasValue)
//        {
//            Console.WriteLine(z.Value);

//        }
//        else {
//            Console.WriteLine("Variável z é nula!!");
        
//        }

//        if (a.HasValue)
//        {
//            Console.WriteLine(a.Value);

//        }
//        else {
//            Console.WriteLine("Variável a é nula!!");
        
//        }


//    }
//}
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula2_Nullable;

////internal class Nullable
////{
////    static void Main(string[] args) {

////        /*double x = null; Se eu fizer isso não copila.O copilador informa que o valoe double não pode ser nulo*/

////        Nullable<double> x = null; /*Usamos o nullable para resolver o problema acima*/

////        double? y = null; /*Maneira mais simples de escrever o nullable*/

////        /*Operações básicas para nullable*/

////        double? z = null;
////        double? a = 10.0;
////        Console.WriteLine(z.GetValueOrDefault()); /*Aqui vai imprimir zero pq vai pegar o valor padrão de double */
////        Console.WriteLine(a.GetValueOrDefault()); /*Aqui vai imprimir o valor da variável */
////        Console.WriteLine("_____");
////        Console.WriteLine(z.HasValue);  /*Aqui vai imprimir False pq não há valor na variável*/
////        Console.WriteLine(a.HasValue);  /*Aqui vai imprimir True pq há valor na variável*/
////        Console.WriteLine("_____");
////        //Console.WriteLine(z.Value); /*Aqui vai apresentar excessão informando que para utilizar a operação Value é necessário informar um valor*/
////        //Console.WriteLine(a.Value); /*Aqui vai apresentar o valor real da variável.*/
////        /*Tratamento para a excessão citada na variável z*/
////        if (z.HasValue)
////        {
////            Console.WriteLine(z.Value);

////        }
////        else {
////            Console.WriteLine("Variável z é nula!!");
        
////        }

////        if (a.HasValue)
////        {
////            Console.WriteLine(a.Value);

////        }
////        else {
////            Console.WriteLine("Variável a é nula!!");
        
////        }


////    }
////}
