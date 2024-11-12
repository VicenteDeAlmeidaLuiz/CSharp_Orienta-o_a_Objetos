using System.Globalization;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula9_LinqComLambda.Entidades;

internal class Artigo
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Categoria Categoria { get; set; }

    public override string ToString()
    {
        return Id
            + ","
            + Nome
            + ", "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Categoria.Classificação;
    }
}
