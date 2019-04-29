# Funktions-Überladung

* In c# kannst du mehrere Funktionen mit demselben Namen haben
* jedoch muss sich der Rückgabetyp oder die übergebenen Parameter unterscheiden

```csharp
// simple example of function overloading
public static void Main()
{
    DisplaySomething();
    DisplaySomething(1);
    DisplaySomething("Cat");
}

public static void DisplaySomething()
{
    Console.WriteLine("Something!!!");
}

public static void DisplaySomething(int number)
{
    Console.WriteLine("Number: " + number);
}

public static void DisplaySomething(string text)
{
    Console.WriteLine("Text: " + text);
}

```