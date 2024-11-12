namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula1.Entidades;

internal class CarroAluguel
{
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }

    public Veiculo Veiculo { get; set; }
    public NotaFiscal NotaFiscal { get; set; }

    public CarroAluguel(DateTime inicio, DateTime fim, Veiculo veiculo)
    {
        Inicio = inicio;
        Fim = fim;
        Veiculo = veiculo;
    }
}
