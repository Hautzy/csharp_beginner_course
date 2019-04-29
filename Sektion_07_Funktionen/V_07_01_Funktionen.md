# Funktionen

* Funktionen sind eine einfache Möglichkeit, Teile deines Codes zu extrahieren, um ihn
     * lesbarer
     * besser wiederverwendbar zu machen
* Man kann sich eine Funktion wie ein Modul vorstellen, das du ein- und ausstecken kannst

## Eine Funktion erstellen

* Funktionen haben drei entscheidende Teile
     * einen Namen, um die Funktion zu identifizieren und aufzurufen
     * eine Liste von Parametern, um Variablen vom aufrufenden Programm an die Funktion zu übergeben
     * und ein Rückgabewert, ein einzelner Wert, der dem aufrufenden Programm Informationen über das Ergebnis der Funktion gibt
* Mit dem Schlüsselwort return wird die Funktion verlassen und ein Wert an das aufrufende Programm zurückgegeben

```csharp
public static void Main() {
    int newNumber = MyFunction(6);  // here the function is called from the main method
    Console.WriteLine(newNumber);   // the new number is now 60
}

// this function takes a parameter from type int called number and returns an int
public static int MyFunction(int number)      // function header with return type, name and parameters
{
    Console.WriteLine("this is a function");
    int result = number * 10;

    return result;
}
```

## Funktionsbenennung

* Der Name der Funktion sollte mit einem Großbuchstaben beginnen
* gefolgt von einem Namen in camelcase
* Der Funktionsname sollte ausdrücken, was die Funktion tut
