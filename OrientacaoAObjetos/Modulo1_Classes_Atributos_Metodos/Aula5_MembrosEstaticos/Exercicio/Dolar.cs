using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula5_MembrosEstaticos.Exercicio
{
    internal class Dolar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?");
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = ConversorDeMoeda.valorASerPago(valorCompra, cotacao);
            Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
