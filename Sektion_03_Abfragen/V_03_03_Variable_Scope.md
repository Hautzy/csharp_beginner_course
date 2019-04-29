## Variabler scope

* Variablen leben in Blöcken
* Eine Variable, die in einer if-Anweisung definiert ist, existiert nur in diesem Bereich / in diesem if-Block

```csharp
string text = "Julian";

if (text == "Mia") {
    int age = 25;

    Console.WriteLine("Hi Mia your age is " + age);

    age = age * 2;  // we can access the age in the if block

    text = "New name";  // we can access a variable in every underlying block
}

age = 20;   // accessing the variable age outside its scope will lead to an error
```
