namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula7_ClassesAbstratas.Aula1_ClassesAbstratas.Entidades;

internal abstract class Conta1Abs /*Colocando o abstract na classe siginfica que a classe não pode mais ser instanciada*/
{
    public int Numero { get; protected set; }
    public string Titular { get; protected set; }
    public double Saldo { get; protected set; }


    public Conta1Abs()
    {
    }

    public Conta1Abs(int numero, string titular, double saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public virtual void Saque(double valorSaque)
    {
        Saldo -= valorSaque + 5.0;

    }

    public void Deposito(double valorDeposito)
    {
        Saldo += valorDeposito;

    }
}
