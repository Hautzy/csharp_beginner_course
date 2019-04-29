# Rekursion

* Rekursion bedeutet, dass sich eine Funktion selbst aufruft
* und die Parameter weiter gibt
* bis eine bestimmte Bedingung erfüllt ist
* und das Ganze entrollt sich wieder
* Es gibt viele Probleme, die mit Rekursion viel einfacher gelöst werden können als mit Standard-Iterationsalgorithmen

```csharp
// simple recursion example, counting to 5 with recursion
public static void Main()
{
    int countingNumber = Count(0);
    Console.WriteLine("Final number: " + countingNumber);
}

public static int Count(int lastNumber) {
    if(lastNumber == 5)
    {
        return lastNumber;
    }
    return Count(lastNumber + 1);
}
```