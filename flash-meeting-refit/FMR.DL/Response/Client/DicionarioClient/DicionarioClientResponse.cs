using Newtonsoft.Json;
using System.Collections.Generic;

namespace FMR.DL.Response.Client.DicionarioClient
{
    public class SentidosAlternativos
    {
        [JsonProperty("definitions")] public List<string> DefinicoesAlternativas { get; set; }
        [JsonProperty("id")] public string IdDefinicaoAlternativa { get; set; }
        [JsonProperty("examples")] public List<Exemplos> Exemplos { get; set; }
        [JsonProperty("synonyms")] public List<Sinonimos> Sinonimos { get; set; }
    }

    public class Exemplos
    {
        [JsonProperty("text")] public string Exemplo { get; set; }
    }

    public class Sinonimos
    {
        [JsonProperty("text")] public string Sinonimo { get; set; }
    }

    public class Sentidos
    {
        [JsonProperty("definitions")] public List<string> Definicoes { get; set; }
        [JsonProperty("id")] public string IdDefinicao { get; set; }
        [JsonProperty("subsenses")] public List<SentidosAlternativos> SentidosAlternativos { get; set; }
    }

    public class Entradas
    {
        [JsonProperty("senses")] public List<Sentidos> Sentidos { get; set; }
    }
    public class EntradaLexical
    {
        [JsonProperty("entries")] public List<Entradas> Entradas { get; set; }
        [JsonProperty("text")] public string Texto { get; set; }
    }
    public class Result
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("language")] public string Ligua { get; set; }
        [JsonProperty("lexicalEntries")] public List<EntradaLexical> EntradaLexical { get; set; }
        [JsonProperty("word")] public string Palavra { get; set; }
    }

    public class DicionarioClientResponse
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("results")] public List<Result> Resultado { get; set; }
        [JsonProperty("word")] public string Palavra { get; set; }

    }
}
