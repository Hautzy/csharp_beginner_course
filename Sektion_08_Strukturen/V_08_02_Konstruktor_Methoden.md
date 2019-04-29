## Konstruktor & Methoden

* Nachdem wir nun eine Struktur erstellt haben, benötigen wir eine Möglichkeit, alle Variablen zu initialisieren
* wir könnten das struct einfach instanziieren indem wir mit dem Punktoperator einzeln auf die Felder zugreifen und ihnen einen Wert zuweisen
* oder wir könnten einen so genannten Konstruktor verwenden
* Ein Konstruktor ist eine Art Funktion, die aufgerufen wird, wenn die Variable der Struktur erstellt wird
* du kannst Parameter an den Strukturkonstruktor übergeben
* du kannst auch Methoden für die Struktur erstellen

```csharp
// simple struct constructor
public struct Cat
{
    public string name;
    public int age;
    public string color;

    public Cat(string name, int age, string color)
    {
        this.name = name;
        this.age = age;
        this.color = color;
    }

    public void MakeSound()
    {
        Console.WriteLine("Miauuuu!!!");
    }

    public void ChangeColor(string newColor)
    {
        color = newColor;
    }
}

public static void Main()
{
    Cat newCat = new Cat("Mia", 6, "Brown");

    Console.WriteLine("Name: " + newCat.name);
    Console.WriteLine("Age: " + newCat.age);
    Console.WriteLine("Color: " + newCat.color);

    newCat.MakeSound();

    newCat.color = "White";
    Console.WriteLine(newCat.color);
    newCat.ChangeColor("Red");
    Console.WriteLine(newCat.color);
}
```
