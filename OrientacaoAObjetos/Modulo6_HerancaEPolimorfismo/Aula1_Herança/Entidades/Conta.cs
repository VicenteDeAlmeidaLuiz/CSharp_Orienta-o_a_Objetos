namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula1_Herança.Entidades;

internal class Conta1
{
    public int Numero { get; protected set; }
    public string Titular { get; protected set; }
    public double Saldo { get; protected set; }

    /*Protected eu posso modificar os atributos somente na superclasse e na subclasse,mas não em outras classes*/

    public Conta1()
    {
    }

    public Conta1(int numero, string titular, double saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public void Saque(double valorSaque)
    {
         Saldo -= valorSaque;

    }

    public void Deposito(double valorDeposito)
    {
         Saldo += valorDeposito;

    }
}
