namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula5_Exercicio.Entidades;

internal class Funcionario
{
    public string Nome { get; set; }
    public int Horas { get; set; }
    public double ValorPorHora { get; set; }

    public Funcionario()
    {
    }

    public Funcionario(string nome, int horas, double valorPorHora)
    {
        Nome = nome;
        Horas = horas;
        this.ValorPorHora = valorPorHora;
    }

    public virtual double Pagamento()
    {
        return Horas * ValorPorHora;

    }
}
