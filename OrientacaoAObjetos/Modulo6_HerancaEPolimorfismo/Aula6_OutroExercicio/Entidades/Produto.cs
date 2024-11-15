﻿using System.Globalization;

namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula6_OutroExercicio.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaDePreco()
        {
            return Nome
                + " R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
