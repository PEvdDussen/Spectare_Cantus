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
                // CHANGE THIS: Use the full path to your JSON file on your machine
                string path = "../../assets/version:1/lyrics/afr/psalms/100/psalm:100_beryming:1_vers:1.json";
                
                Lyrics realData = LyricsLoader.LoadPsalm(path);

                WelcomeText.Text = $"Loaded: {realData.Header.Type} {realData.Header.Number}-{realData.Header.Rhyme} verse {realData.Header.VerseNumber} (Melody: {realData.Header.PreferedMelody})";
            }
            catch (Exception ex)
            {
                WelcomeText.Text = $"Error: {ex.Message}";
            }
        }
    }
}