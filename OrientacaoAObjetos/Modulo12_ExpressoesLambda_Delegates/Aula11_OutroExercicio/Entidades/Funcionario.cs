namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula11_OutroExercicio.Entidades;

internal class Funcionario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public double Salario { get; set; }

    public Funcionario(string nome, string email, double salario)
    {
        Nome = nome;
        Email = email;
        Salario = salario;
    }
}
