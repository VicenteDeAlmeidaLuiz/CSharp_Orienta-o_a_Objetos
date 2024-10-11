using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula4_Exercicios.Exercicio3;

internal class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;



    public void alunoAprovadoReprovado()
    {
        double notaFinal = Nota1 + Nota2 + Nota3;
        double notaFaltante = 60 - Nota1 - Nota2 - Nota3;

        if (notaFinal >= 60)
        {
            Console.WriteLine("NOTA FINAL = " + notaFinal);
            Console.WriteLine("APROVADO");

        }
        else
        {
            Console.WriteLine("NOTA FINAL = " + notaFinal);
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM " + notaFaltante + " PONTOS");

        }






    }

}
