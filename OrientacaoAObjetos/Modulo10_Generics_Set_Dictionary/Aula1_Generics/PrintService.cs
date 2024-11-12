namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula1_Generics;

internal class PrintService<T>
{
    private T[] _valores = new T[10];
    private int contador = 0;

    public void adicionarValor(T valor)
    {
        if (contador == 10)
        {
            throw new InvalidOperationException("PrintService está cheio");


        }
        _valores[contador] = valor;
        contador++;

    }
    public T Primeiro()
    {
        if (contador == 0)
        {
            throw new InvalidOperationException("Printservice está vazio");


        }
        return _valores[0];

    }

    public void Print()
    {
        Console.WriteLine("[");
        for (int i = 0; i < contador - 1; i++)
        {
            Console.WriteLine(_valores[i] + ", ");


        }
        if (contador > 0) {

            Console.WriteLine(_valores[contador -1]);
        }
        Console.WriteLine("]");

    }

}

