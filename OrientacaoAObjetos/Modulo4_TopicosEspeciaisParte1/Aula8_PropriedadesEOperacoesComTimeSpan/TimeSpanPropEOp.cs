using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula8_PropriedadesEOperacoesComTimeSpan;

internal class TimeSpanPropEOp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Propriedades do timespan");
        TimeSpan t1 = TimeSpan.MaxValue; /*Valor Máximo suportado pelo timespan*/
        TimeSpan t2 = TimeSpan.MinValue; /*Valor mínimo suportado pelo timespan*/
        TimeSpan t3 = TimeSpan.Zero;
        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine("_______________________________");
        TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
        Console.WriteLine(t4);
        Console.WriteLine("Dias desse timespan " + t4.Days);
        Console.WriteLine("Horas desse timespan " + t4.Hours);
        Console.WriteLine("Minutos desse timespan " + t4.Minutes);
        Console.WriteLine("Milisegundos desse timespan " + t4.Milliseconds);
        Console.WriteLine("Segundos desse timespan " + t4.Seconds);
        Console.WriteLine("Ticks desse timespan " + t4.Ticks);
        Console.WriteLine("Total de dias desse timespan " + t4.TotalDays);
        Console.WriteLine("Total de horas desse timespan " + t4.TotalHours);
        Console.WriteLine("Total de minutos desse timespan " + t4.TotalMinutes);
        Console.WriteLine("Total de segundos desse timespan " + t4.TotalSeconds);
        Console.WriteLine("Total de milisegundos desse timespan " + t4.TotalMilliseconds);
        Console.WriteLine("_______________________________________________");
        Console.WriteLine("Operações do timespan");
        TimeSpan t5 = new TimeSpan(1, 30, 10);
        TimeSpan t6 = new TimeSpan(0, 10, 5);
        TimeSpan soma = t5.Add(t6); /*Operação para somar os dois timespan*/
        Console.WriteLine(soma);
        TimeSpan diferenca = t5.Subtract(t6);
        Console.WriteLine(diferenca);
        TimeSpan multiplicacao = t5.Multiply(2.0);
        Console.WriteLine(multiplicacao);
        TimeSpan divisao = t6.Divide(2.0);
        Console.WriteLine(divisao);


    }
}
