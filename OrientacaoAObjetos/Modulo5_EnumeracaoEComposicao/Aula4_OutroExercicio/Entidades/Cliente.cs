namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula4_OutroExercicio.Entidades
{
    internal class Cliente
    {
        public string  Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeAniversario { get; set; }

        public Cliente() {
        
        
        }

        public Cliente(string nome, string email, DateTime dataDeAniversario)
        {
            Nome = nome;
            Email = email;
            DataDeAniversario = dataDeAniversario;
        }

        public override string ToString()
        {
            return Nome
                + ", ("
                + DataDeAniversario.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
