using OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula1_Generics;

namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary;

internal class GenericsExecutora
{
    static void Main(string[] args)
    {
        PrintService<string> printservice = new PrintService<string>(); /*Com generics eu consigo instanciar classes com quqlquer tipo
                                                                          Os atributos também aceitam qualquer tipo de valor*/
        PrintService<int> printserviceint = new PrintService<int>();
        Console.WriteLine("Quantos valores vc vai digitar?");
        int valores = int.Parse(Console.ReadLine());

        for (int i = 0; i < valores; i++)
        {
            string x = Console.ReadLine();
            printservice.adicionarValor(x);


        }
        printservice.Print();
        Console.WriteLine("Primeiro: " + printservice.Primeiro());



    }
}
