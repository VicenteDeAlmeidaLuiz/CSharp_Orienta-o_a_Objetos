namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula2_RestricoesParaGenerics.Servicos;

internal class CalculoServico
{
    public T Max<T>(List<T> lista) where T : IComparable
    {
        if (lista.Count == 0)
        {
            throw new ArgumentException("A lista não pode ser vazia.");


        }

        T max = lista[0];
        for (int i = 1; i < lista.Count; i++)
        {
            if (lista[i].CompareTo(max)>0)
            {
                max = lista[i];


            }


        }
        return max;


    }
}
