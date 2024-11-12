using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aulas4_Properties;

internal class Produto4
{
    private string _nome;
    private double _preco;
    private int _quantidade; /*Por convenção da linguagem quando trabalhamos com atributos private,começamos com _ e primeira letra 
                              minúscula*/

    public Produto4()
    {

    }

    public Produto4(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
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

    public double Preco
    {
        get { return _preco; }



    }
    /*Porperties para Preço e Quantidade*/

    public int Quantidade
    {
        get { return _quantidade; }

    }


    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;

    }

    public void AdicionarProdutos(int quantidade)
    {
        _quantidade += quantidade;

    }
    public void RemoverProdutos(int quantidadeRemovida)
    {
        _quantidade -= quantidadeRemovida;

    }

    public override string ToString()
    {
        return _nome
                + ",R$"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


    }
}
