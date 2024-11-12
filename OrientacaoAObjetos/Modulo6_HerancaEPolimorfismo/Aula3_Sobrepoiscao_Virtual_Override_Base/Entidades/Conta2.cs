namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula3_Sobrepoiscao_Virtual_Override_Base.Entidades;

internal class Conta2
{
    public int Numero { get; protected set; }
    public string Titular { get; protected set; }
    public double Saldo { get; protected set; }

    /*Protected eu posso modificar os atributos somente na superclasse e na subclasse,mas não em outras classes*/

    public Conta2()
    {
    }

    public Conta2(int numero, string titular, double saldo)
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
