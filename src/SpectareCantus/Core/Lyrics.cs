using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpectareCantus.Core
{
    public class Lyrics
    {
        [JsonPropertyName("header")]
        public Header Header { get; set; } = null!;

        [JsonPropertyName("syllables")]
        public Dictionary<string, string> Syllables { get; set; } = null!;
    }

    public class Header
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("rhyme")]
        public int Rhyme { get; set; }

        [JsonPropertyName("verse")]
        public int VerseNumber { get; set; }

        [JsonPropertyName("prefered_melody")]
        public string PreferedMelody { get; set; } = null!;

        [JsonPropertyName("all_melodies")]
        public Dictionary<string, string> Melodies { get; set; } = null!;

        [JsonPropertyName("transcriber")]
        public Transcriber Transcriber { get; set; } = null!;
    }

    public class Transcriber
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("date")]
        public string Date { get; set; } = null!;

        [JsonPropertyName("place")]
        public string Place { get; set; } = null!;
    }
}