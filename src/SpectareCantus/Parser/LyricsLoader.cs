using System.IO;
using System.Text.Json;
using SpectareCantus.Core;

namespace SpectareCantus.Parser
{
    public static class LyricsLoader
    {
        public static Lyrics LoadPsalm(string filePath)
        {
            // 1. Read the raw string from the file
            string jsonString = File.ReadAllText(filePath);

            // 2. Turn that string into our PsalmData object
            var data = JsonSerializer.Deserialize<Lyrics>(jsonString);

            // 3. Return the hydrated object (or throw if it failed)
            return data ?? throw new InvalidDataException("Failed to parse JSON.");
        }
    }
}