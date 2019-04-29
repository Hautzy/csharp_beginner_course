# Schleifen

## Was sind Schleifen
* eine Möglichkeit, Befehle häufiger auszuführen
* einen bestimmten Befehlssatz ausführen, bis eine Bedingung erfüllt ist
* verschiedene Arten von Schleifen
* Teile einer Schleife
   * Header mit einer Bedingung
   * Körper mit den Befehlen

### While-Schleife

* Eine while-Schleife wird verwendet, um einen bestimmten Befehlssatz zu wiederholen, solange eine bestimmte Bedingung erfüllt ist
* wie funktioniert es:
     1. Bedingung im Header wird geprüft
     2. dann wird der Körper ausgeführt
     3. zurück zum Header

```csharp
// double a number until its bigger then 50
int number = 2;
while(number <= 50)
{
    number = number * 2;
}
Console.WriteLine("Result: " + number);
```
