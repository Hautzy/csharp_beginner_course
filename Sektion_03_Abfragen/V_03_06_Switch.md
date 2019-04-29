## Switch

* ähnlich einer if-Abfrage
* Es ist wie eine if-Abfrage mit vielen vergleichen mit dem == Operator
* hat einen Standardfall
* Nachdem wir einen case-Block definiert haben, verlassen wir ihn mit dem Befehl break

```csharp
// simple if statement, imagine we have multiple error codes in ours system
switch (code)
{
    case 1:
        Console.WriteLine("Code A");
        break;
    case 2:
    case 3:
        Console.WriteLine("Code B");
        break;
    case 4:
        Console.WriteLine("Code C");
        break;
    default:
        Console.WriteLine("No code found");
        break;
}

// switch example as if
if(code == 1) 
{
    Console.WriteLine("Code A");
}
else if (code == 2 or code == 3)
{
    Console.WriteLine("Code B");
}
else if (code == 4)
{
    Console.WriteLine("Code C");
}
else
{
    Console.WriteLine("Not code found");
}
```
