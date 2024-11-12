using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula3_ExpressaoCondicionalTernaria
{
    internal class TernariaPrograma
    {
        static void Main(string[] args)
        {
            /*Estrutura opcional ao if else quando se deseja decidir um valor com base em uma condição
             Sintaxe: (condição) ? valor_se_verdadeiros : valor_se_falso*/

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; /*Leitura da expressão: Se o preço for menor que 20 preço * 0.1(10%),
                                                                            * se não preço*0.05 (5%)*/

            Console.WriteLine(desconto);





        }
    }
}
