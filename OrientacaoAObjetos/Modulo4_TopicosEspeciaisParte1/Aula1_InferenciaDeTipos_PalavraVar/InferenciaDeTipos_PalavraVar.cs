using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula1_InferenciaDeTipos_PalavraVar;

internal class InferenciaDeTipos_PalavraVar
{
    static void Main(string[] args)
    {
        /*Por exemplo eu psso iniciar uma variável com var e colocar 10 sem necessariamente colocar int que ela vai assumir o 10 como int
         E assim com pputros tipos de dados também*/

        var x = 10;
        var y = 20.0;
        var z = "Maria";

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);



    }
}
