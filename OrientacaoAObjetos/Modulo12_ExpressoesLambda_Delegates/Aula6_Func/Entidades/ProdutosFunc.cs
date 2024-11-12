using System.Globalization;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula6_Func.Entidades;

internal class ProdutosFunc
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public ProdutosFunc(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString()
    {
        return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture);
    }
}
