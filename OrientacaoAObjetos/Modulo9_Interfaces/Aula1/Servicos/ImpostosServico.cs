namespace orientacaoaobjetos.modulo9_interfaces.aula1.servicos;

internal class impostosservico : iimpostosservicos
{
    public double imposto(double quantia)
    {
        if (quantia <= 100)
        {
            return quantia * 0.2;

        }
        else
        {
            return quantia * 0.15;


        }


    }
}
