using System.Globalization;

namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula2_RestricoesParaGenerics.Entidades;

internal class Produto : IComparable
{
    public double Preco { get; set; }
    public string Nome { get; set; }

    public Produto()
    {
    }

    public Produto(string nome, double preco)
    {
        Preco = preco;
        Nome = nome;
    }

    public override string ToString()
    {
        return Nome
            + ","
            + Preco.ToString("F2", CultureInfo.InvariantCulture);
    }

    public int CompareTo(object? obj)
    {
        if (!(obj is Produto))
        {
            throw new ArgumentException("Erro de comparação: O argumento não é um produto.");

        }
        Produto outro = obj as Produto;
        return Preco.CompareTo(outro.Preco);
    }
}
