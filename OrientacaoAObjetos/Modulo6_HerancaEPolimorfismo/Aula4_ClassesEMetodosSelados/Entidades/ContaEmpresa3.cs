namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula4_ClassesEMetodosSelados.Entidades;

internal class ContaEmpresa3 : Conta3
{
    public double LimiteEmprestimo { get; set; }

    public ContaEmpresa3()
    {
    }

    public ContaEmpresa3(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
    {
        LimiteEmprestimo = limiteEmprestimo; /*Aqui o construtor da subclasse.Só preciso acrescentar o atributo dessa subclasse*/
    }

    public void Emprestimo(double valorEmprestimo)
    {
        if (valorEmprestimo <= LimiteEmprestimo)
        {
            Saldo += valorEmprestimo;


        }
    }
}
