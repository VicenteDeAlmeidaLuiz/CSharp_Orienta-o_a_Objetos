using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo4_TopicosEspeciaisParte1.Aula2_SwitchCase;

internal class SwitchCasePrograma

{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o dia!!");
        int numeroInteiro = int.Parse(Console.ReadLine());
        string dia;

        switch (numeroInteiro)
        {

            case 1:
                dia = "Domingo";
                break;
            case 2:
                dia = "Segunda";
                break;
            case 3:
                dia = "Terça";
                break;
            case 4:
                dia = "Quarta";
                break;
            case 5:
                dia = "Quinta";
                break;
            case 6:
                dia = "Sexta";
                break;
            case 7:
                dia = "Sábado";
                break;
            default:
                dia = "Valor Inválido";
                break;



        }

        Console.WriteLine($"Dia: {dia}.");



    }


}
