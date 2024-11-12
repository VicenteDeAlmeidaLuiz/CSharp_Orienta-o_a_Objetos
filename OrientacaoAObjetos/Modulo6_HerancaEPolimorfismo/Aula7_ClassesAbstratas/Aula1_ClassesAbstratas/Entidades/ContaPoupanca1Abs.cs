namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula7_ClassesAbstratas.Aula1_ClassesAbstratas.Entidades
{
    internal class ContaPoupanca1Abs : Conta1Abs
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca1Abs()
        {
        }

        public ContaPoupanca1Abs(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;

        }

        public override void Saque(double valorSaque)
        {
            base.Saque(valorSaque);
            Saldo -= 2.0;
        }
    }
}
