# Contributing to Spectare Cantus

Welcome! We are currently in the early prototype phase. This document explains the technical structure of the melody engine.

## Notes
This project will initially be developed for the Afrikaans language. As I am a member of `Gereformeerde Kerk Centurion`, or `GK Centurion`, I will be developing the project to support the Psalmody approved by the `Gereformeerde Kerke in Suid-Afrika`, or `GKSA`,. The project will be developed to try and accomodate other languages and denominations, as such any contributions from any other denomination or language is most welcome. Please open an issue on GitHub so we can start integrating your requirements.

I am not yet a highly experienced developer. I have a little over a year's experience and that is mostly in python 3.13 and 3.14.
As such, I am highly open to any suggestions, critiques or guidance in regards to both C# and the overall project structure.

Lastly, I am only one person. I apologise for any delay in replying to anything, be that pull requests or new issues. Thank you for your understanding and patience.

## Project Structure
- `/src`: The C# source code.
- `/assets/version:1/melodies`: Melody "Skeletons" with syllable tokens (syl_1, syl_2...).
- `/assets/version:1/lyrics/afr`: JSON mapping files for different languages (e.g., Afr = Afrikaans, Eng = English, Fre = French).
- `/assets/version:1/lyrics/afr/psalm/100`: The files for psalm 100 in the Afrikaans language.

## Melody Structure
A melody is defined by a MusicXML v4.0 definition.

### Syllable Notation
A syllable is defined in a `<lyric>` tag.
The syllables are defined sequentially (e.g., syl_1, syl_2, syl_3). 
A word can span more than one note; this is handled by standard `<syllable>...</syllable>` notation within the MusicXML.
The real syllables are found in the lyrics files as denoted above.

### MusicXML and JSON interaction.
Below is a portion on the MusicXML for the second melody of Psalm 100-1 for Afrikaans (The Totius beryming)
```xml
<?xml version="1.0" encoding="UTF-8" standalone="no"?>
<!DOCTYPE score-partwise PUBLIC "-//Recordare//DTD MusicXML 4.0 Partwise//EN" "http://www.musicxml.org/dtds/partwise.dtd">
<score-partwise version="4.0">
  <work>
    <work-title>Psalm 100 (1926 Melody)</work-title>
  </work>
  <identification>
    <creator type="composer">P.K. de Villiers</creator>
    <encoding>
      <software>SpectareCantus Parser v1</software>
      <encoder>Pieter Ernst van der Dussen III</encoder>
      <encoding-date>2026-02-12</encoding-date>
    </encoding>
  </identification>
  <part-list>
    <score-part id="P1">
      <part-name>Voice</part-name>
    </score-part>
  </part-list>
  <part id="P1">
    <measure number="1">
      <attributes>
        <divisions>1</divisions>
        <key><fifths>3</fifths></key> <time><beats>2</beats><beat-type>2</beat-type></time>
        <clef><sign>G</sign><line>2</line></clef>
      </attributes>
      <note>
        <pitch><step>A</step><octave>4</octave></pitch>
        <duration>1</duration>
        <type>half</type>
        <lyric number="1">syl_1</lyric>
      </note>
    </measure>
    <measure number="2">
      <attributes>
        <divisions>1</divisions>
        <key><fifths>3</fifths></key> <time><beats>2</beats><beat-type>2</beat-type></time>
        <clef><sign>G</sign><line>2</line></clef>
      </attributes>
      <note>
        <pitch><step>E</step><octave>4</octave></pitch>
        <duration>1</duration>
        <type>half</type>
        <lyric number="1">syl_2</lyric>
      </note>
      <note>
        <pitch><step>C</step><octave>4</octave><alter>1</alter></pitch>
        <duration>1</duration>
        <type>half</type>
        <lyric number="1">syl_3</lyric>
      </note>
    </measure>
    ...
```

Notice the syl_`n` notation specificcally. These represent individual syllables to be replaced by the matching syllables in any compatible JSON lyrics. All other aspects follow MusicXML v4.0.

Below is a portion of the JSON lyrics for the second melody of Psalm 100-1 for Afrikaans (The Totius beryming)
```json
{
    "header": {
        "type": "Psalm",
        "number": 100,
        "rhyme": 1,
        "verse": 1,
        "prefered_melody": "Tweede Melodie",
        "all_melodies": {
            "Eerste Melodie": "place:geneve_year:1551_writer:loys-bourgeois_origin:seigneur,-je-n'ay-point-le-coeur-fier_syllables:32_measure:8-8-8-8",
            "Tweede Melodie": "year:1926_writer:pk-de-villiers_name:juich,-aard,-juicht-alom-den-heer'_syllables:32_measure:8-8-8-8"
        },
        "transcriber": {
            "name": "Pieter Ernst van der Dussen",
            "date": "2026/02/10T12:55:00Z0200",
            "place": "Gauteng, South Africa"
        }
    },
    "syllables": {
        "syl_1": "<syllabic>single</syllabic><text>Juig</text>",
        "syl_2": "<syllabic>single</syllabic><text>al</text>",
        "syl_3": "<syllabic>single</syllabic><text>wat</text>",
        "...": "..."
    }
}
```
The syl_`n` of the above MusicXML will be replaced by the matching syl_`n` in the JSON. The `<syllabic>` tag works exactly like MusicXML v4.0 specifies.

## Development Setup
- **SDK:** .NET 8.0+
- **UI Framework:** Avalonia UI
- **IDE:** VS Code or Visual Studio recommended.