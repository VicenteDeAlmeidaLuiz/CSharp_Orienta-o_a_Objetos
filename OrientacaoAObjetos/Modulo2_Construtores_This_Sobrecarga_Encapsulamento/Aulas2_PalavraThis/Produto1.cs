using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aula2_PalavraThis;

internal class Produto1
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto1()
    {
        Quantidade = 10;
    }

    public Produto1(string nome, double preco): this() /*Nesse caso com o this eu reaproveito o construtor de cima,sem precisar passar a
                                                        quantidade*/
    {
        Nome = nome;
        Preco = preco;
    }

    public Produto1(string nome, double preco, int quantidade) : this(nome, preco)/*Nesse caso com o this eu reaproveito o construtor de 
                                                                                   * cima,sem precisar passar nome e preco*/

    {
        Quantidade = quantidade;
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;

    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;

    }
    public void RemoverProdutos(int quantidadeRemovida)
    {
        Quantidade -= quantidadeRemovida;

    }

    public override string ToString() {
        return Nome
                + ",R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
    
    
    }
}
