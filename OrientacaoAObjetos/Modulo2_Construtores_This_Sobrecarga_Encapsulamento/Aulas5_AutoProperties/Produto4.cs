using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aulas5_AutoProperties;

internal class Produto4
{
    private string _nome; /*Aqui como nome tem uma lógica,não implementamos o propertie*/
    public double Preco { get; private set; } /*Aqui a implementação de auto properties,mudo para public dou get para usar e posso usar o private
                                               * no set se acaso o atributo não puder ser alterado,não sendo necessário implementar a propertie
                                               como se fosse um método*/
    public int Quantidade { get; private set; }

    public Produto4()
    {

    }

    public Produto4(string nome, double preco, int quantidade)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public string Nome /*Aqui é a propertie,no C# utilizamos assim ao invés de get e set*/
    {
        get { return _nome; }
        set
        {
            if (value != null & value.Length > 1)
            {
                _nome = value;


            }
            else
            {
                Console.WriteLine("Nome não pode ser nulo e precisa ter mais de um caractere.");

            }
        }


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

    public override string ToString()
    {
        return _nome
                + ",R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


    }
}
