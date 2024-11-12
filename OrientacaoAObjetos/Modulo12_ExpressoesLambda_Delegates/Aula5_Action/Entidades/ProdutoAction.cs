using System.Globalization;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula5_Action.Entidades;


internal class ProdutoAction
{
    public string  Nome { get; set; }
    public double  Preco { get; set; }

    public ProdutoAction(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString()
    {
        return Nome + ", " + Preco.ToString("F2",CultureInfo.InvariantCulture);
    }
}
