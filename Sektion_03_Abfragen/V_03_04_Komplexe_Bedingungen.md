## Komplexere Bedingungen

* Oft reicht Es nicht aus, nur zu überprüfen, ob eine Zahl größer ist als eine andere
* Wir brauchen komplexere Bedingungen
* Ohne dass der Code sehr schnell unlesbar wird
* daher gibt es AND und OR

### AND

* Um wahr zu sein, erfordert der Operator und/and, dass alle Teile der Bedingungen erfüllt sind

```csharp
// in this example the number has to be bigger then 5 AND has to be divided by 2 without any rest
if(number > 5 && number % 2 == 0)
{
    number = number + 5;
    Console.WriteLine("Result: " + number);
}
```

### OR

* Um wahr zu sein, erfordert der Operator oder/or, dass einer der Teile der Bedingung erfüllt sind

```csharp
// in this example the game should end if the max score is reached or if the player as no health left
if(playerScore >= 20 || playerHealth <= 0) {
    Console.WriteLine("Stop the game");
}
```
