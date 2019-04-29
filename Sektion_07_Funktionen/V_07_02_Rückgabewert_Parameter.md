## Rückgabetyp / Rückgabewert

* Eine Funktion kann nur einen Rückgabetyp haben
* Jeder Typ kann ein Rückgabetyp sein
* Das Return-Schlüsselwort gibt den Wert zurück
* Ein Array kann auch ein Rückgabewert sein
* Manchmal gibt es Funktionen ohne Rückgabewert. In diesem Fall wird der Rückgabetyp durch das Schlüsselwort void ersetzt

* Wenn du eine Funktion aufrufst, musst du den Rückgabewert nicht in einer Variablen speichern
* Wenn die Funktion keinen Rückgabewert hat, kannst du auch keinen Wert speichern

```csharp
public static void Main() {
    CrazyFunction();
}

// function without any return value
public static void CrazyFunction(int number) 
{
    Console.WriteLine("Number: " + number);
}
```

## Parameter

* Parameter sind eine Möglichkeit, zwischen dem aufrufenden Programm und der Funktion zu kommunizieren
* Eine Funktion kann beliebig viele Parameter haben
* Eine Funktion kann auch überhaupt keine Parameter haben
* Jeder Datentyp kann ein Parameter sein
* Du kannst den Wert einer Variablen nicht ändern, wenn sie als Parameter übergeben wird. Die Elemente eines Arrays können jedoch geändert werden

```csharp
// function without any parameters
public static void PrintATest()
{
    Console.WriteLine("A test!");
}
```

```csharp
public static void PrintAnArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
}
```
