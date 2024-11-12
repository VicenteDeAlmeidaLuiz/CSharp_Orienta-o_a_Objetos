namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio.Entidades;

internal class Produto
{
    public string  Nome { get; set; }
    public double Preco { get; set; }

    public Produto()
    {
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}
