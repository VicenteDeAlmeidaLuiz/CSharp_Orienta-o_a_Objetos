
namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula6_TimeSpan;

internal class TimeSpanPrograma
{
    static void Main(string[] args)
    {
        TimeSpan t1 = new TimeSpan(0, 1, 30); /*Imprime hora,minuto e segundo*/
        Console.WriteLine(t1);
        TimeSpan t2 = TimeSpan.FromDays(1.5); /*Imprime o timespan referente a um dia e doze horas*/
        Console.WriteLine(t2);
        TimeSpan t3 = TimeSpan.FromHours(1.5); /*Imprime uma hora e 30 minutos*/
        Console.WriteLine(t3);
        TimeSpan t4 = TimeSpan.FromMinutes(60); /*Imprime o valor de 60 minutos.Nesse caso uma hora*/
        Console.WriteLine(t4);
        TimeSpan t5 = TimeSpan.FromSeconds(60);/*Imprime o valor de 60 segundos.Nesse caso um minuto*/
        Console.WriteLine(t5);
        TimeSpan t6 = TimeSpan.FromMilliseconds(1000); /*Imprime o valor de 1000 milisegundos*/
        Console.WriteLine(t6);





    }
}
