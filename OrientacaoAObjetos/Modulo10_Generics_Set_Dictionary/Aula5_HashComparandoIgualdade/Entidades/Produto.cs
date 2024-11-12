namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula5_HashComparandoIgualdade.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Preco.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Produto)) {
                return false;
            
            }
            Produto outro = obj as Produto;
            return Nome.Equals(outro.Nome) && Preco.Equals(outro.Preco);
        }
    }
}

