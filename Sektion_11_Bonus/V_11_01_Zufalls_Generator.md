# Zufalls-Generator

* Es gibt eine Möglichkeit, Zufallszahlen in c# zu generieren.
* Wir verwenden gelegentlich den Zufallsgenerator in unseren Projekten

```csharp
// generate a random number betweeen 1 and 10
Random random = new Random();

int newRandomNumber = random.Next(1, 11);
```
