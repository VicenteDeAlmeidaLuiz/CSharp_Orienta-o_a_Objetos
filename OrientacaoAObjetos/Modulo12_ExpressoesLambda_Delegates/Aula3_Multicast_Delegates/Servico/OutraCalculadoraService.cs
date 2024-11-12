namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula3_Multicast_Delegates.Servico;

internal class OutraCalculadoraService
{
    public static void ShowMax(double x, double y)
    {
        double max = (x > y) ? x : y;
        Console.WriteLine(max);



    }

    public static void ShowSum(double x, double y)
    {
        double soma = x + y;
        Console.WriteLine(soma);


    }





}

