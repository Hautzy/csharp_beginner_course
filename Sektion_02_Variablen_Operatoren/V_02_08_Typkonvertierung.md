# Typen Konvertierung

* Konvertierung ist der Prozess der Umwandlung eines Werts eines bestimmten Datentyps in einen anderen Datentyp
* Es gibt verschiedene Arten der Konvertierung
   * implizit (fehleranfällig)
   * explizit
     * casting
     * Konvertierungsmethoden

```csharp
// implicit
double number = 10.5;
int newNumber = number;

Console.WriteLine(newNumber);   // 10
```

```csharp
// explicit
double number = 10.5;
int newNumber = (int)number;

Console.WriteLine(newNumber);   // 10

// or
Console.WriteLine(5/2);         // 2
Console.WriteLine(5/(double)2)  // 2.5
```

```csharp
// convertion method
string text = "12";
int number = Convert.ToInt32(text);
Console.WriteLine(number * 2);

Convert.ToDouble(<value>)
Convert.ToString(<value)
Convert.ToFloat(<value>)
Convert.ToBool(<value>)
```
