### Do-while-Schleife

* do-while-Schleifen sind zwar sehr ähnlich zu While-Schleifen, jedoch befindet sich die Bedingung unten
* Das bedeutet, dass der Körper einmal ausgeführt wird, bevor die Bedingung geprüft wird
* wie funktioniert es:
     1. Der Körper wird ausgeführt
     2. dann wird die Fuß-Bedingung geprüft
     3. zurück zum Top des Körpers

```csharp
// simple do-while
int number = 2;
do
{
    number *= 2;
}while(number <= 50)
Console.WriteLine("Result: " + number);
```

```csharp
// user input example from before
string input = "";
int sum = 0;
int number = 0;

do
{
    Console.Write("Enter number: ");
    input = Console.ReadLine();
    if(input != "") 
    {
        number = Convert.ToInt32(input);
        sum += number;
    }
}while(input != "");
```

* in manchen Fällen ist es kürzer wenn man eine do-while statt einer while Schleife verwendet und vize versa
