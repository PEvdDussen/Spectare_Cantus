using Avalonia.Controls;
using SpectareCantus.Core;
using SpectareCantus.Parser; // Link to your Parser project
using System;

namespace App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try 
            {
                // CHANGE THIS: Use the full path to your JSON file
                string path = "";
                
                // Use the Parser to load real data
                Lyrics realData = LyricsLoader.LoadPsalm(path);

                // Update the UI with real data from the file
                WelcomeText.Text = $"Loaded: {realData.Header.Type} {realData.Header.Number}-{realData.Header.Rhyme} verse {realData.Header.VerseNumber} (Melody: {realData.Header.PreferedMelody})";
            }
            catch (Exception ex)
            {
                WelcomeText.Text = $"Error: {ex.Message}";
            }
        }
    }
}