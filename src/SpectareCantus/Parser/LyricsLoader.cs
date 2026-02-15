using System.IO;
using System.Text.Json;
using SpectareCantus.Core;

namespace SpectareCantus.Parser
{
    public static class LyricsLoader
    {
        public static Lyrics LoadPsalm(string filePath)
        {
            // Load file and parse
            string jsonString = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<Lyrics>(jsonString);
            return data ?? throw new InvalidDataException("Failed to parse JSON.");
        }
    }
}