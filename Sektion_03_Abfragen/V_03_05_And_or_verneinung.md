### AND & OR zusammen

* Du kannst beliebig viele Bedingungen mit und & oder beliebig kombinieren
* und ist dann stärker als oder
* Du kannst die Reihenfolge und die Kombination der Bedingungen mit () ändern

```csharp
int playerScore = 10;
string playerRace = "orc";

if(playerScore >= 5 && playerScore <= 20 || playerRace == "orc")
{
    Console.WriteLine("get achievement");
}

// when using () you can change the way a condition is interpreted
if(playerScore >= 5 && (playerScore <= 20 || playerRace == "orc"))
{
    Console.WriteLine("get achievement");
}
```

### Verneinungsoperator

* Verneinung von Aussage
* Verneinung von Variablen
* einfaches Rufzeichen als Operator

* mit diesem Operator wahr -> falsch und falsch -> wahr

```csharp
int playerScore = 10;
if(playerScore >= 5 && playerScore <= 20)
{
    Console.WriteLine("get achievement");
}

// verneinung
if(!(playerScore >= 5 && playerScore <= 20))
{
    Console.WriteLine("get achievement");
}
// statt
if(playerScore < 5 || playerScore > 20)
{
    Console.WriteLine("get achievement");
}
```
