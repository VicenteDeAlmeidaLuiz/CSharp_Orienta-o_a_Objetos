namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula1_Herança.Entidades;

internal class ContaEmpresa1 : Conta1 /*Aqui é a herança,onde eu digo que a classe conta empresa herda atributos e métodos da da classe conta*/
{
    public double LimiteEmprestimo { get; set; }

    public ContaEmpresa1()
    {
    }

    public ContaEmpresa1(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
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
