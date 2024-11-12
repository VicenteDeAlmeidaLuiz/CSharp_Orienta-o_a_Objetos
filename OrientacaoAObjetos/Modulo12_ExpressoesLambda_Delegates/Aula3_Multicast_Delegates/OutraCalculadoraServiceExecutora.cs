using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula3_Multicast_Delegates.Servico;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula3_Multicast_Delegates;



delegate void OperacaoNumerica(double n1, double n2);
internal class OutraCalculadoraServiceExecutora
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        OperacaoNumerica op = OutraCalculadoraService.ShowSum;
        op += OutraCalculadoraService.ShowMax;

        op.Invoke(a, b);



    }
}
