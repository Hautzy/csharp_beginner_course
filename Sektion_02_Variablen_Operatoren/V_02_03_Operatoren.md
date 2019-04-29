### Variablen manipulieren

#### Numerische Typen

* ints, floats und doubles haben die selben Operatoren (+, -, *, / und %)

```csharp
// integers
Console.WriteLine(5 + 10);          // 15
Console.WriteLine(5 - 10);          // -5
Console.WriteLine(5 * 10);          // 50
Console.WriteLine(10 / 5);          // 2
Console.WriteLine(5 / 10);          // 0
Console.WriteLine(10 % 8);          // 2 

// doubles
Console.WriteLine(5.5 + 10.1);      // 15.6
Console.WriteLine(5.0 - 10.1);      // -5.1
Console.WriteLine(5.0 * 10.5);      // 50.5
Console.WriteLine(10.0 / 5.0);      // 2.0
Console.WriteLine(5.0 + 10.0);      // 15.0
Console.WriteLine(10 % 8);          // 2.0

// combine
Console.WriteLine(5 / 2.0);         // 2.5
Console.WriteLine(2.5 + 10);        // 12.5
Console.WriteLine(10 * 1.2);        // 12
```

Der Modulo Operator (%) gibt den Rest der Division zurück.

#### Alphanumerische Typen

* Zeichenfolge und Zeichen haben nur den Plus-Operator
* mithilfe dessen kann man sie aneinander hängen (konkatenieren)

```csharp
// strings
Console.WriteLine("Hello" + " " + "World");

string myName = "Julian";
string greetingText = "Hello, your name is ";

string result = myName + greetingText = myName + greetingText;
Console.WriteLine(result);

// chars
Console.WriteLine('a' + 'b' + 'c');         // abc -> result is a string

// combine
Console.WriteLine("Julian" + 'A');          // JulianA
```

### Variablen vergleichen

* Die meisten Datentypen unterstützen den Operator gleich und ungleich
**HINWEIS:** Ein einzelnes Gleichheitszeichen bedeutet, dass du einer Variablen einen Wert zuweisen. Nur zwei Gleichheitszeichen vergleichen zwei Variablen
* Priorität der Operationen * und / vor + und -
* Das Ergebnis eines Vergleichs ist immer wahr oder falsch (true oder false)

```csharp
// ints, doubles, floats
Console.WriteLine(5 == 10);             // false
Console.WriteLine(5 == 5);              // true
Console.WriteLine(5.0 != 10.5);         // true

// strings, chars
Console.WriteLine("test" == "test1");   // false
Console.WriteLine('a' == 'a');          // true
Console.WriteLine("test" != "abc");     // true

// bools
bool isHungry = true;
Console.WriteLine(isHungry == true);    // true
Console.WriteLine(isHungry != true);    // false
```

* Numerische Datentypen unterstützen auch >, <, >= und <=

```csharp
int myNumber = 5;
Console.WriteLine(myNumber > 4);            // true
Console.WriteLine(myNumber < 5);            // false
Console.WriteLine(myNumber >= 4);            // true
Console.WriteLine(myNumber <= 5);            // true
```
