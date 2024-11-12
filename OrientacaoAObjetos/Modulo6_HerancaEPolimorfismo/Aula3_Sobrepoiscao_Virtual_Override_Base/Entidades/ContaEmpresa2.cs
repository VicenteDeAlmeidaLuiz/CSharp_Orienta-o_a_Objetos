namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula3_Sobrepoiscao_Virtual_Override_Base.Entidades;

internal class ContaEmpresa2 : Conta2
{

    public double LimiteEmprestimo { get; set; }

    public ContaEmpresa2()
    {
    }

    public ContaEmpresa2(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
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
