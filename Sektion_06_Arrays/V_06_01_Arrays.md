# 1D Arrays

## Was sind Arrays?

* Oft möchtest du mehr als einen Wert eines Typs speichern
* beispielsweise alle Namen deiner Familienmitglieder speichern
* Arrays sind wie Bücherregale, jeder Eintrag im Bücherregal kann mit einem Index aufgerufen werden
* Ein Array hat einen Typ, einen Namen und einen Wert -> wie eine Variable
* Die verschiedenen Elemente eines Arrays können geändert werden

## Wie erstelle ich ein Array?

* Ein Array hat immer einen zugrunde liegenden Datentyp, wie String, Int oder jeden anderen Typ
* Wenn du ein Array erstellst, musst du eine feste Länge angeben
* [] zeigt an, dass die Variable ein Array ist
* Das neue Schlüsselwort wird zum Erstellen eines Arrays verwendet

```csharp
string[] family = new string[3];   // create an array of strings

family[0] = "Julian";
family[1] = "Felix";
family[2] = "Markus";
```

## Was tut man mit Arrays?

* Wir können die Anzahl der Elemente in einem Array mit ```array.Length``` ermitteln
* du kannst ein Array wie mit Strings durchlaufen

```csharp
// loop through an array
for(int i = 0; i < family.Length; i++)
{
    Console.WriteLine(family[i]);
}
```
