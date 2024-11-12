using System.Text;

namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula3_Exercicio.Entidades;

internal class Post
{
    public DateTime Momento { get; set; }
    public string Titulo { get; set; }
    public string Conteudo { get; set; }
    public int Curtidas { get; set; }

    public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public Post()
    {

    }

    public Post(DateTime momento, string titulo, string conteudo, int curtidas)
    {
        Momento = momento;
        Titulo = titulo;
        Conteudo = conteudo;
        Curtidas = curtidas;
    }

    public void AdicionarComentario(Comentario comentario)
    {

        Comentarios.Add(comentario);



    }

    public void RemoverComentario(Comentario comentario)
    {

        Comentarios.Remove(comentario);

    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(Titulo);
        stringBuilder.Append(Curtidas);
        stringBuilder.Append(" Likes - ");
        stringBuilder.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
        stringBuilder.AppendLine(Conteudo);
        stringBuilder.AppendLine("Comentários: ");
        foreach (Comentario comentario in Comentarios)
        {
            stringBuilder.AppendLine(comentario.Texto);
        }
        return stringBuilder.ToString();
    }
}
