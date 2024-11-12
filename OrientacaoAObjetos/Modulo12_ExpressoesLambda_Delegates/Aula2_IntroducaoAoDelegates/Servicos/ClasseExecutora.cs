namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula2_IntroducaoAoDelegates.Servicos;


delegate double OperacaoNumericaBinaria(double n1, double n2); /*Aqui é o delegate*/


internal class ClasseExecutora
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        OperacaoNumericaBinaria opSoma = CalculadoraService.Soma; /*Assim usamos o delegate*/
        OperacaoNumericaBinaria opMax = CalculadoraService.Maximo; /*Assim usamos o delegate*/
        OperacaoNumericaBinaria opMult = CalculadoraService.Multiplicacao; /*Assim usamos o delegate*/

        double resultado = opSoma(a, b);
        double resultado1 = opMax(a, b);
        double resultado2 = opMult(a, b);
        Console.WriteLine(resultado);
        Console.WriteLine(resultado1);
        Console.WriteLine(resultado2);



    }
}
