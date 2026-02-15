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
                // CHANGE THIS: Use the full path to your JSON file on your Linux Mint machine
                string path = "/home/pvddussen/Documents/Projects/Spectare_Cantus/assets/version-1.0.0/psalms/afr/100/psalm-100-1_verse-1.json";
                
                // Use the Parser to load real data
                Lyrics realData = JsonLoader.LoadPsalm(path);

                // Update the UI with real data from the file
                WelcomeText.Text = $"Loaded: {realData.Header.Type} {realData.Header.Number}-{realData.Header.Rhyme} (Melody: {realData.Header.PreferedMelody})";
            }
            catch (Exception ex)
            {
                WelcomeText.Text = $"Error: {ex.Message}";
            }
        }
    }
}