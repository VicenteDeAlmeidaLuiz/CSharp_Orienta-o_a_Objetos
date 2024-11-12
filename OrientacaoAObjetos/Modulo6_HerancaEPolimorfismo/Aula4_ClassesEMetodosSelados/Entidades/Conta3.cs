namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula4_ClassesEMetodosSelados.Entidades;

internal class Conta3
{
    public int Numero { get; protected set; }
    public string Titular { get; protected set; }
    public double Saldo { get; protected set; }

    public Conta3()
    {
    }

    public Conta3(int numero, string titular, double saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public virtual void Saque(double valorSaque) /*Virtual significa que eu posso sobrescrever o método nas subclasses*/
    {
        Saldo -= valorSaque + 5.0;

    }

    public void Deposito(double valorDeposito) 
    {
        Saldo += valorDeposito;

    }


}
