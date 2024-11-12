namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula5_Exercicio.Entidades;

internal class FuncionarioTerceirizado : Funcionario
{
    public double CustoAdicional { get; set; }

    public FuncionarioTerceirizado()
    {
    }

    public FuncionarioTerceirizado(string nome, int horas, double valorPorHora,double custoAdicional) : base(nome, horas, valorPorHora)
    {
        CustoAdicional = custoAdicional;
    }

    public override double Pagamento()
    {
        return base.Pagamento() + 1.1 * CustoAdicional;
    }
}
