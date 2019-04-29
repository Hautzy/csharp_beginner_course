## Aus einer Datei lesen

* Wir können einfach aus einer Datei mit der Methode `` File.ReadAllLines (path) `` `lesen
* Diese Methode verwendet den Pfad zur Datei als Parameter
* und gibt alle Zeilen in der Datei als String-Array zurück

```csharp
// read from file and print the data to the console
string path = "data.csv";

string[] lines = File.ReadAllLines(path);
for(int i = 0; i < lines.Length; i++)
{
    Console.WriteLine(lines[i]);
}
```
