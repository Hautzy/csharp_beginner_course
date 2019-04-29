#### Loops und Strings

* Schleifen können verwendet werden, um eine Zeichenfolge zu durchlaufen
* Du kannst mit dem Indexer [] auf ein einzelnes Zeichen einer Zeichenfolge zugreifen.
* Mit myString.Length kannst du die Anzahl der Zeichen in einer Zeichenfolge ermitteln

```csharp
// loop through a string
string text = "Julian";
int index = 0;

while(index < text.Length)
{
    Console.WriteLine(text[index]);
    index = index + 1;
}
```

```csharp
// let the user input a number, sum them up until he enters an empty string
string input = "";
int sum = 0;
int number = 0;

Console.Write("Enter number: ");
input = Console.ReadLine();
while(input != "")
    number = Convert.ToInt32(input);
    sum += number;      // same as sum = sum + number;
    
    Console.Write("Enter number: ");
    input = Console.ReadLine()
}
Console.WriteLine("end...");
```
