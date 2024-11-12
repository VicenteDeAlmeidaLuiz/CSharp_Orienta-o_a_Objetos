using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula5_MembrosEstaticos;

internal class MembrosEstaticosV1
{
    static double Pi = 3.14;/*Membro estático pois só uso na classe dentro de um métod estático,no caso o Main*/
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do raio!");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double circ = Circunferencia(raio);
        double volume = Volume(raio);

        Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volune: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI " + Pi.ToString("F2", CultureInfo.InvariantCulture));
    }

    static double Circunferencia(double raio)
    { /*Mesmo caso do Pi*/
        return 2.0 * Pi * raio;


    }
    static double Volume(double raio)
    { /*Mesmo caso do Pi*/
        return 4.0 / 3.0 * Pi * raio * raio * raio;

    }
}
