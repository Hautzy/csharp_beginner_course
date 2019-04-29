## In eine Datei schreiben

* Wir können auch in eine Datei schreiben, indem wir entweder ein String-Array hinausschreiben
* oder direkt unsre neuen Daten an den aktuellen Text in der Datei anhängen

```csharp
string path = "data.csv";

// simply write a string array to the file
string[] newLines = { "This is a simply test.", "I like cats!" };
File.WriteAllLines(path, newLines);

// or append a string to the text in the file
string newText = "this is a new text";
File.AppendAllText(path, newText);
```
