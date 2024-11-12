namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula4_ClassesEMetodosSelados.Entidades;

internal sealed class ContaPoupanca3 : Conta3 /*Colocando sealed quer dizer que essa classe não pode ser herdada,se eu tentar herdar ela,aparece erro*/
{

    public double TaxaJuros { get; set; }

    public ContaPoupanca3()
    {
    }

    public ContaPoupanca3(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
    {
        TaxaJuros = taxaJuros;
    }

    public void AtualizarSaldo() /*Métodos comuns que ainda não foram sobrepostos não podem ser selados,o copilador não aceita*/
    {
        Saldo += Saldo * TaxaJuros;

    }

    public sealed override void Saque(double valorSaque) /*Acrescentando o sealed no método que já foi sobrescrito uma vez,eo informo ao copilador
                                                          esse método não pode ser sobrescrito novamente*/
    {
        base.Saque(valorSaque);
        Saldo -= 2.0;
    }
}
