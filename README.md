# Spectare Cantus

A modern, cross-platform engine for liturgical music, built with .NET. 
*Spectare Cantus* ("Beholding the Song" or "See and Sing") aims to bridge the gap between traditional musical notation and modern digital accessibility.

### The Vision
The goal is to provide a high-fidelity experience for displaying Psalms. By decoupling music notation from language through a unique **Syllable-Token** mapping system.

See `CONTRIBUTING.md` for mor information

### Current Focus: Psalm 100
We are currently building the "Vertical Slice" prototype using Psalm 100 (32-syllable structure).
- **Core Engine:** C# implementation of MusicXML parsing.
- **Data Layer:** SQLite for offline-first localized content.
- **Audio Sync:** High-fidelity professional recording integration with real-time lyric highlighting.

### Architecture
- **Language:** C# 12 / .NET 8+
- **Frontend:** Avalonia UI (Cross-platform)
- **Notation:** MusicXML with Token Mapping

### Legal Note
This project is an independent modern reimagining inspired by the liturgical software of the same name created for "Gereformeerde Kerk Centurion, Gauteng, South Africa". It is built from the ground up with entirely new algorithms and architecture.

See `LICENSE` for more information.