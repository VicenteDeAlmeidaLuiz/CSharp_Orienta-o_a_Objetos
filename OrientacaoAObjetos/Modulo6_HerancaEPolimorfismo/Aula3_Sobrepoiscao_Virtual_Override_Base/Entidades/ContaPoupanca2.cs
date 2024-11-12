namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula3_Sobrepoiscao_Virtual_Override_Base.Entidades;

internal class ContaPoupanca2 : Conta2
{

    public double TaxaJuros { get; set; }

    public ContaPoupanca2()
    {
    }

    public ContaPoupanca2(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
    {
        TaxaJuros = taxaJuros;
    }

    public void AtualizarSaldo()
    {
        Saldo += Saldo * TaxaJuros;

    }

    //public override void Saque(double valorSaque) /*Aqui eu reimplementei o método de saque lá da superclasse,porém sem a taxa.Isso é que é a
    //                                               sobreposição ou sobrescrita de método,qunado reimplementamos o método para dar 
    //                                                um comportamento diferente*/
    //{
    //    Saldo -= valorSaque;
    //}

    public override void Saque(double valorSaque) /*Aqui eu reimplementei o método de saque lá da superclasse,porém com a taxa da superclasse 
                                                   * mais uma taxa de 2.0
                                                   A palavra bse define que eu estou utilizando o método da superclasse*/
    {
        base.Saque(valorSaque);
        Saldo -= 2.0;
    }
}

