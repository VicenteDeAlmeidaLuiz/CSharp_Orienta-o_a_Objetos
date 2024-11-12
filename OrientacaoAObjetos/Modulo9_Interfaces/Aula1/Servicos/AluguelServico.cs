using OrientacaoAObjetos.Modulo9_Interfaces.Aula1.Entidades;
using OrientacaoAObjetos.Modulo9_Interfaces.Entidades;

namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula1.Servicos;

internal class AluguelServico
{
    public double PrecoPorHora { get; private set; }
    public double PrecoPorDia { get; private set; }

    private IImpostosServicos _impostosServico;

    public AluguelServico(double precoPorHora, double precoPorDia, IImpostosServicos impostosServicos)
    {
        PrecoPorHora = precoPorHora;
        PrecoPorDia = precoPorDia;
        _impostosServico = impostosServicos;
    }

    public void ProcessarNotaFiscal(CarroAluguel carroAluguel)
    {
        TimeSpan duracao = carroAluguel.Fim.Subtract(carroAluguel.Inicio);
        double pagamentoBasico = 0.0;

        if (duracao.TotalHours <= 12.0)
        {
            pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);


        }
        else
        {
            pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);


        }

        double taxa = _impostosServico.Imposto(pagamentoBasico);
        carroAluguel.NotaFiscal = new NotaFiscal(pagamentoBasico, taxa);


    }
}
