
namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula1_Tipos_Referencia_E_Valor;

struct RefVal /*Ao invés da classe criamos o struct que são dados de tipo valor,não podem ser null*/
{

    public double X; /*Atributos do struct*/
    public double Y;

    public override string ToString()
    {
        return "(" + X + ", " + Y + ")";
    }

}
