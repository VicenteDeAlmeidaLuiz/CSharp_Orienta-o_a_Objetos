

namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula7_PropriedadesEOperacoesComDateTime;

internal class DateTimePropEOp
{
    static void Main(string[] args)
    {
        DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
        Console.WriteLine(d);
        Console.WriteLine("1 - Data como um todo,sem o horário: " + d.Date);
        Console.WriteLine("2 - Imrimindo somente o dia: " + d.Day);
        Console.WriteLine("3 - Imrimindo somente o dia da semana: " + d.DayOfWeek);
        Console.WriteLine("4 - Imrimindo somente o dia do ano: " + d.DayOfYear);
        Console.WriteLine("5 - Imrimindo a hora: " + d.Hour);
        Console.WriteLine("6 - Imrimindo somente o tipo (Local ou universal): " + d.Kind);
        Console.WriteLine("7 - Imrimindo o milisegundo: " + d.Millisecond);
        Console.WriteLine("8 - Imrimindo o minuto: " + d.Minute);
        Console.WriteLine("9 - Imrimindo o mês: " + d.Month);
        Console.WriteLine("10 - Imrimindo o segundo: " + d.Second);
        Console.WriteLine("11 - Imrimindo o ticks: " + d.Ticks);
        Console.WriteLine("12 - Imrimindo o horário do dia: " + d.TimeOfDay);
        Console.WriteLine("13 - Imrimindo o ano: " + d.Year);
        Console.WriteLine("_____________IMPRIMINDO DE MANEIRAS DIFERENTES___________________");
        Console.WriteLine(d.ToLongDateString()); /*Imprime a data completa por extenso*/
        Console.WriteLine(d.ToLongTimeString()); /*Imprime só o horário*/
        Console.WriteLine(d.ToShortDateString()); /*Imprime só a data*/
        Console.WriteLine(d.ToShortTimeString()); /*Imprime só a hora e minuto*/
        Console.WriteLine(d.ToString()); /*Imprime data e hora no formato padrão*/
        Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss")); /*Imprime data e hora formatada*/
        Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff")); /*Imprime data e hora formatada e mais os milisegundos*/
        Console.WriteLine("_____________OPERAÇÕES COM DATETIME___________________");
        Console.WriteLine(d.AddHours(2)); /*Add horas*/
        Console.WriteLine(d.AddMinutes(3)); /*Add minutos*/
        DateTime d1 = new DateTime(2000, 10, 15);
        DateTime d2 = new DateTime(2000, 10, 25);
        TimeSpan t = d2.Subtract(d1); /*Para calcular a diferença entre datas*/
        Console.WriteLine(t);




    }
}
