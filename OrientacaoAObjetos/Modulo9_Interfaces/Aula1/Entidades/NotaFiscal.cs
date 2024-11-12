using System.Globalization;

namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula1.Entidades;

internal class NotaFiscal
{
    public double PagamentoBasico { get; set; }
    public double Impostos { get; set; }

    public NotaFiscal(double pagamentoBasico, double impostos)
    {
        PagamentoBasico = pagamentoBasico;
        Impostos = impostos;
    }

    public double PagamentoTotal
    {
        get { return PagamentoBasico + Impostos; } /*Isso aqui chamamos de propriedade calculada,como se fosse um método porém sem ()*/

    }

    public override string ToString()
    {
        return "Pagamento básico: "
            + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
            + "\nImpostos: "
            + Impostos.ToString("F2", CultureInfo.InvariantCulture)
            + "\nPagamento total: "
            + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
    }
}
