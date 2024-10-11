using System;


namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula2_Metodo;

internal class Triangulo
{
    public double ladoA;
    public double ladoB;
    public double ladoC;

    public double Area()
    {
        double p = (ladoA + ladoB + ladoC) / 2.0;
        double raiz = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        return raiz;


    }
    /*Aqui eu criei o método*/


}
