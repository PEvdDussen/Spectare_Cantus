# Spectare Cantus

A modern, cross-platform engine for liturgical music, built with .NET. 
*Spectare Cantus* ("Beholding the Song" or "See and Sing") aims to bridge the gap between traditional musical notation and modern digital accessibility.

### The Vision
The goal is to provide a high-fidelity experience for displaying Psalms. By decoupling music notation from language through a unique **Syllable-Token** mapping system, we enable professional recordings and localized lyrics to work in perfect harmony.

### Current Focus: Psalm 100
We are currently building the "Vertical Slice" prototype using Psalm 100 (40-syllable structure).
- **Core Engine:** C# implementation of MusicXML parsing.
- **Data Layer:** SQLite for offline-first localized content.
- **Audio Sync:** High-fidelity professional recording integration with real-time lyric highlighting.

### Architecture
- **Language:** C# 12 / .NET 8+
- **Database:** SQLite (Selective Sync)
- **Frontend:** Avalonia UI (Cross-platform)
- **Notation:** MusicXML with Token Mapping

### Project Structure
- `/src`: The C# source code.
- `/assets/melodies`: Melody "Skeletons" with syllable tokens (Syl_1, Syl_2...).
- `/assets/melodies/audio`: Recordings of the melody if available.
- `/assets/psalms/afr`: JSON mapping files for different languages (e.g., Afr = Afrikaans, Eng = English, Fre = French).

### Legal Note
This project is an independent modern reimagining inspired by the liturgical software by the same name create for "Gereformeerde Kerk Centurion, Guateng, South Africa". It is built from the ground up with entirely new algorithms and architecture.

## Melody Structure
A melody is defined by a MusicXML v4 definition.

### Sylable Notation
A sylable is defined in a `<lyric><text>Syl_1<text/><lyric/>` tag.
The sylables are defined sequentially i.e. Syl_1, Syl_2, Syl_3, etc.
A sylable can span more than one note. This is handled by appending an alphabetic letter to the end of the sylable i.e. Syl_1_A, Syl_1_B. In the final Psalm sylables only a definition for Syl_1 and the rest will be handled automatically.