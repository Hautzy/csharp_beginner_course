# 2D-Arrays

* 2d-Arrays funktionieren fast wie normale Arrays

## Unterschiede zu 1D-Arrays

* Sie haben Zeilen und Spalten
* 2 Indizes für den Zugriff auf ein einzelnes Element
* Stell dir ein Schachbrett / Spielfeld vor
* 2d-Arrays werden sehr ähnlich erstellt, jetzt benötigen wir jedoch 2 feste Längen, eine für Zeilen und eine für Spalten

```csharp
// in this example we want to save the firstname and lastname of your family members
string[,] family = new string[3, 2];    // [row count, column count]

family[0, 0] = "Julian";
family[0, 1] = "Huber";

family[1, 0] = "Felix";
family[1, 1] = "Tiger";

family[2, 0] = "Markus";
family[2, 1] = "Mayr";
```

* die Längen eines 2d-arrays bekommen
    * row length ```array.GetLength(0)```
    * column length ```array.GetLength(1)```

```csharp
// loop through string array and print firstname and lastname
for (int y = 0; y < family.GetLength(0); y++)
{
    for (int x = 0; x < family.GetLength(1); x++)
    {
        Console.Write(family[y, x] + " ");
    }
    Console.WriteLine();
}
```
