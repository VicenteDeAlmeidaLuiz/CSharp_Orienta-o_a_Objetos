﻿using System.Globalization;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula1_Comparison;

internal class Produto 
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString()
    {
        return Nome + ", " + Preco.ToString("F2",CultureInfo.InvariantCulture);
    }

}
