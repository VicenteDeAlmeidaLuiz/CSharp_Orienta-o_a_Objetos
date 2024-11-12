namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula6_Exercicio.Entidades;

internal class RegistroDeLog
{
    public string NomeUsuario { get; set; }
    public DateTime Instante { get; set; }

    public override bool Equals(object? obj)
    {
        if (!(obj is RegistroDeLog))
        {
            return false;

        }
        RegistroDeLog outro = obj as RegistroDeLog;
        return NomeUsuario.Equals(outro.NomeUsuario);
    }

    public override int GetHashCode()
    {
        return NomeUsuario.GetHashCode();
    }
}
