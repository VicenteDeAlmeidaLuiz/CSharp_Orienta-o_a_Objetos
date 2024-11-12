

using System.Globalization;

namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula5_DateTime;

internal class DateTimePrograma
{
    static void Main(string[] args)
    {

        DateTime d1 = DateTime.Now; /*Devolve o instante atual do sistema (data,hora,minuto e segundo)*/
        Console.WriteLine(d1);
        Console.WriteLine(d1.Ticks); /*Devolve a quantidade de ticks desde 01/01 até o horário atual*/

        Console.WriteLine("____________________________________________");

        DateTime d2 = new DateTime(2018, 11, 25); /*Instanciei e vai imprimir nesse dia as 0 horas*/
        Console.WriteLine(d2);

        Console.WriteLine("____________________________________________");
        DateTime d3 = new DateTime(2019, 11, 25, 20, 45, 03); /*Especificando data,hora,minuto e segundo*/
        Console.WriteLine(d3);
        Console.WriteLine("____________________________________________");
        DateTime d4 = new DateTime(2019, 11, 25, 20, 45, 03, 500); /*Especificando data,hora,minuto e segundo e milisegundo,porém aqui não imprime
                                                                   o milisegundo.Para imprimir o milisegundo vamos aprender mais a frente no curso*/
        Console.WriteLine(d4);
        Console.WriteLine("____________________________________________");
        DateTime d5 = DateTime.Today;
        Console.WriteLine(d5); /*Data de hj porém as 0 horas*/
        Console.WriteLine("____________________________________________");
        DateTime d6 = DateTime.UtcNow;
        Console.WriteLine(d6); /*Data universal em Grenwich*/
        Console.WriteLine("____________________________________________");
        DateTime d7 = DateTime.Parse("2000-08-15"); /*Aqui eu estou convertendo a string para data,imprime com 0 horas*/
        Console.WriteLine(d7);
        DateTime d8 = DateTime.Parse("2000-08-15 13:05:58"); /*Aqui eu estou convertendo a string para data e hora*/
        Console.WriteLine(d8);
        DateTime d9 = DateTime.Parse("15/05/2020 14:59:58");/*Padrã brasileiro também funciona*/
        Console.WriteLine(d9);
        Console.WriteLine("_______________________________________________________________________");
        DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); /*Eu mesmo formatando a minha data*/
        Console.WriteLine(d10);
        Console.WriteLine("_______________________________________________________________________");
        DateTime d11 = DateTime.ParseExact("18/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);/*Eu mesmo formatando a minha data
                                                                                                                        completa*/
        Console.WriteLine(d11);




    }
}
