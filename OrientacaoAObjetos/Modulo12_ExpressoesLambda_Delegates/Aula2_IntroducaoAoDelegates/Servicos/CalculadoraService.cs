namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula2_IntroducaoAoDelegates.Servicos;

internal class CalculadoraService
{
    public static double Maximo(double x, double y)
    {
        return (x > y) ? x : y;

    }

    public static double Soma(double x, double y)
    {
        return x + y;

    }

    public static double Multiplicacao(double x, double y)
    {
        return x * y;

    }
}
