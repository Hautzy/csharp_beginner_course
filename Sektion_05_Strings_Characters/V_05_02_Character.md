## Characters

* Ein char ist ein einzelnes Zeichen
* Jedes Zeichen hat einen Wert in der ASCII-Tabelle

### ASCII-Tabelle

* eine standardisierte Tabelle, die jedem Zeichen eine Zahl zuweist
* [http://www.asciitable.com/] (http: //www.asciitable.com/)

* Wir können die ASCII-Nummer eines Charakters erhalten, indem du ihn in einen int konvertierst
* wir können den ASCII-Wert ändern und ihn wieder in ein Zeichen verwandeln

```csharp
char letter = 'a';

letter = (char)(letter + 5);
Console.WriteLine(letter);      // now the letter will be f
```

```csharp
// check if a letter is a lower case letter in the abc
char letter = 'a';

if(letter >= 97 && letter <= 122)
{
    Console.WriteLine("in abc!");
}
```