using System.Globalization;


namespace OrientacaoAObjetos.Modulo11_TopicosEspeciaisParte2.Extensoes;

internal static class DateTimeExtensao
{
    public static string TempoPercorrido(this DateTime thisObj)
    {
        TimeSpan duracao = DateTime.Now.Subtract(thisObj);

        if (duracao.TotalHours < 24.0)
        {
            return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas.";

        }
        else {
            return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " dias.";
        
        
        }
       


    }
}
