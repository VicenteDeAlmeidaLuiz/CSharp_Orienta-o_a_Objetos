namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula2_UpCastingEDownCasting.Entidades
{
    internal class ContaPoupanca1 : Conta1
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca1()
        {
        }

        public ContaPoupanca1(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;

        }
    }
}
