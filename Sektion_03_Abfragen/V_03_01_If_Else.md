# Abfragen

## Was sind Abfragen?

* Bei der Programmierung reicht es oft nicht aus, eine Reihe von Befehlen zu haben, die vom Computer ausgeführt werden
* Wir möchten verschiedene Möglichkeiten haben, was zu tun ist, basierend auf den Daten und Informationen, die wir haben
* Stell dir eine Kreuzung vor, bei der du dich entscheiden kannst, ob du nach rechts, links oder geradeaus fahren möchtest
* um so etwas zu machen haben wir if-Abfragen

## Einfache if-Abfrage

* besteht aus zwei Teilen
* header -> die Frage / die Bedingung
* body -> der Code, der ausgeführt werden soll, wenn die if-Bedingung erfüllt ist

```csharp
int number = 5;

// simple if statement
if(number > 4) 
{
    Console.WriteLine("Number is greater then 4");
}
```

## Sonstiger Zweig / Else

* Oft benötigen wir einen alternativen Zweig von Ereignissen, wenn die Bedingung nicht erfüllt ist
* wenn beispielsweise an einer Kreuzung die Straße nach rechts geschlossen ist, nehmen wir die linke
* Der Else-Zweig wird immer verwendet, wenn die Bedingung des Ifs nicht erfüllt ist / falsch ist
* Es gibt keinen Else Zweig ohne mindestens ein If

```csharp
int number = 5;

// in this example the else branch is triggered
if(number > 10) 
{
    Console.WriteLine("big number");
}
else
{
    Console.WriteLine("Small number");
}
```
