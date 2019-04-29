### AND & OR zusammen

* Du kannst beliebig viele Bedingungen mit und & oder beliebig kombinieren
* und ist dann stärker als oder
* Du kannst die Reihenfolge und die Kombination der Bedingungen mit () ändern

```csharp
// this if statement checks if a year is a leap year
// year is divided by 4 without rest
// not divided by 100
// or divided by 400
if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine(year + " is a leap year!");
}

```

### Verneinungsoperator

* Verneinung von Aussage
* Verneinung von Variablen
* einfaches Rufzeichen als Operator

* mit diesem Operator wahr -> falsch und falsch -> wahr

```csharp
// we want to check if a year is not a leap year, without changing the code above
if(!(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)))
{
    Console.WriteLine(year + " is NOT a leap year!");
}

// another simple example
if(!isPet)  // this would be true if the value of isPet is false
{
    Console.WriteLine('Is not a pet')
}
```
