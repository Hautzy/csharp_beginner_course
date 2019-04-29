### Schlüsselwörter für Schleifen

#### Break

* Manchmal möchten Sie aus einer Schleife springen
* Das break-Schlüsselwort springt aus der aktuellen Schleife

```csharp
// simple example of how to use break
string input = "";

do
{
    Console.Write("Enter <E> to end loop: ")
    input = Console.ReadLine();

    if(input == "cheat") 
    {
        break;
    }
}while(input != "E");
Console.WriteLine("loop ended");
```

#### Continue

* continue springt weiter bis zum Ende der Schleife
* Überspringen aller folgenden Befehle in der aktuellen Schleife

```csharp
// this example counts the characters in a string that are not 'T'
string text = "TESTTESTTEST";
int notTCount = 0;

for(int i = 0; i < text.Length; i++)
{
    if(text[i] == 'T')
    {
        continue;
    }
    Console.WriteLine(text[i]);
    notTCount++;
}
```
