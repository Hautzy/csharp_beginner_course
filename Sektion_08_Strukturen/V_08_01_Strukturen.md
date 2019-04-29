# Struktur

* mit Structs kann man Variablen intelligent gruppieren
* Zum Beispiel, anstatt eine Variable firstName, lastName und age zu haben, um eine Person darzustellen
* kann man einfach eine Struktur Person erstellen
* Diese Struktur Person kann dann wie ein Datentyp verwendet werden (tatsächlich handelt es sich um einen Datentyp)
* und wir könnten zum Beispiel eine Liste von Personen speichern

## Eine Struktur erstellen

* Wir könnten eine neue CS-Datei erstellen
* oder definieren die Struktur in derselben Datei wie die Hauptmethode
* Wichtig zu wissen, Strukturen werden mittels call by value übergben

```csharp
// simple struct
public struct Person
{
    public string firstName;
    public string lastName;
    public int age;
}

public static void Main()
{
    Person person = new Person();

    person.firstName = "Max";
    person.lastName = "Mustermann";
    person.age = 8;

    Console.WriteLine("{0} {1} is {2}", person.firstName, person.lastName, person.age);
}
```