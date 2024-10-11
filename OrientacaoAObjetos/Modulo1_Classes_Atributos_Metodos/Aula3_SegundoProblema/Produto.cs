using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula3_SegundoProblema;

internal class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;


    }

    public void AdicionarPordutos(int quantidade)
    {
        Quantidade += quantidade;

    }

    public void RemoverProdutos(int quantidadeR)
    {
        Quantidade -= quantidadeR;

    }

    public override string ToString() /*Aqui criamos o tostring para que na impressão os dados do produto já venham prontos.Assim eu reaproveito sempre que eu precisar
                                       independente de quantos ´rodutos eu instanciar*/
    {
        return Nome
            + ",R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades,Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }


}