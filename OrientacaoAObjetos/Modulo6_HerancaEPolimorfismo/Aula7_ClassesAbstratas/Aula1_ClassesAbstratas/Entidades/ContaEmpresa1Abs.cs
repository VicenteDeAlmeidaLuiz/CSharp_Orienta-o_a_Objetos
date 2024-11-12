namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula7_ClassesAbstratas.Aula1_ClassesAbstratas.Entidades;

internal class ContaEmpresa1Abs : Conta1Abs /*Aqui é a herança,onde eu digo que a classe conta empresa herda atributos e métodos da da classe conta*/
{
    public double LimiteEmprestimo { get; set; }

    public ContaEmpresa1Abs()
    {
    }

    public ContaEmpresa1Abs(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
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
