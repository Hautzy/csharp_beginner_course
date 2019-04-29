# Strings und characters

## Strings

* strings sind einer der wichtigsten Datentypen
* wir können durch strings mit einem Indexers iterieren []

```csharp
// loop through a string
string text = "I'm a programmer";
for(int i = 0; i < text.Length; i++)
{
    Console.WriteLine(text[i]);
}
```

* man kann die einzelnen Character in einem string nicht ändern
* man kann jedoch strings aneinanderhängen

```csharp
// simple example, replacing character i with X
string text = "This is a test";
string newText = "";

for(int i = 0; i < text.Length; i++)
{
    if(text[i] != 'i')
    {
        newText += text[i];
    }
    else
    {
        newText += 'X';
    }
}
```

### Wichtige String-Methoden

* kurze Einführung in Methoden, sie können direkt auf der Variable aufgerufen werden und Strings bearbeiten oder analysieren

Am nützlichsten:

* ToUpper() - setzt die gesamte Zeichenfolge in Großbuchstaben
* ToLower() - bewirkt, dass die gesamte Zeichenfolge in Kleinbuchsten ist
* IndexOf() - gibt den Index des ersten Vorkommens der Teilzeichenfolge zurück, -1, falls nicht in der Zeichenfolge gefunden
* Replace() - Ersetzt die Zeichenfolge durch eine andere Zeichenfolge
* Split() - teilt den String in ein String-Array auf, basierend auf einem Delemiter
* Substring() - findet den Teilstring in einer Zeichenfolge
* Trim() - schneidet bestimmte Zeichen aus einer Zeichenfolge ab
* Insert() - Fügt einen String in einen String ein
* Contains() - prüft, ob eine Zeichenfolge eine andere Zeichenfolge enthält
