## Else-If

* Wenn wir mehrere mögliche Ergebnisse haben, wollen wir verschiedene Dinge tun
* dafür verwenden wir die else-if-Zweige
* Wir können sehr komplexe Kreuzungen in unserem Code erstellen
* das else if kann nur verwendet werden, wenn es eine andere if-Verzweigung gibt
* der else-Zweig ist immer der letzte mögliche Zweig

```csharp
// we simulate a traffic light
// when its green we drive, when its yellow we deceleration and when its red we stop
if(trafficLight == "green")
{
    Console.WriteLine("go ahead!")
}
else if (trafficLight == "yellow")
{
    Console.WriteLine("slow down!");
}
else    // there is no other options so it has to be red
{
    Console.WriteLine("STOP!");
}
```

## Wann was verwenden?

* es gibt kein perfektes Rezept
* learning by doing
