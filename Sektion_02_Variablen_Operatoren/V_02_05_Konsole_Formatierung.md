# Konsole

## Was ist die Konsole?

* eine einfache Benutzeroberfläche
* perfekt zum Starten der Programmierung

## Daten auf der Konsole ausgeben

* Die Ausgabe von Daten an die Konsole kann auf verschiedene Arten erfolgen
* Es gibt mehrere Möglichkeiten, die Ausgabe zu formatieren

```csharp
// use placeholder
Console.WriteLine("Number: {0}", number);

// right-aligned
Console.WriteLine("Number: {0, 10}", number);
// left-aligned
Console.WriteLine("Number: {0, -10}", number);

// number of decimals, f stands for floating point number
Console.WriteLine("Number: {0, 10:f2}", number);

// print number as currency
Console.WriteLine("Currrency: {0:c}", number);

// print number with 5 right padding and 3 diggits min.
Console.WriteLine("Number: {0,5:d3}", 20);

// print number as exponential number
Console.WriteLine("Number: {0:e}", 100000000);
```

* Es gibt einen kleinen Unterschied zwischen WriteLine und Write
* WriteLine fügt eine neue Zeile hinzu und Write nicht
* Das Zeichen \n erstellt auch eine neue Zeile / Zeilenumbruch

## Daten von der Konsole einlesen

* strings von der Konsole einlesen
* wenn man mit nummerischen Datentypen arbeiten will müssen diese zuerst konvertiert werden

```csharp
// input string from console
string input = Console.ReadLine();

int number = Convert.ToInt32(input);

number = number * 2;

Console.WriteLine("New number: " + number);
```
