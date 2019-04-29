# Variablen

## Was sind Variablen?

* man kann sich eine Variable als eine Art Box vorstellen in der man Daten bzw. Informationen speichert
* Beispiel: 5 + 10 = 15

```
    // simple variable example
    a = 5
    b = 10
    c = a + b
    c -> 15
```

## Wie ist ein Variable in C# aufgebaut

* Datentype (Definition)
* Name (Deklaration)
* Wert (Initialisierung)

```csharp
    // example from before in code
    int a = 5;
    int b = 10;
    int c = a + b;
    Console.WriteLine(c);
```

## Datentypen

* Stell dir Boxen mit unterschiedlichen Formen vor, zb eine Schuhbox oder eine Hutbox, Boxen in verschiedenen größen
* nicht alle Informationen passen in alle Boxen

```csharp
// numerical types
int wholeNumber = 5;                // only numbers without floating point
double commaNumber = 10.5;          // floating point numbers
float anotherCommaNumber = 9.6F;     // floating point numbers

// alphanumberical types
string text = "this is a test";     // words, sentences, alphanumerical
char singleCharacter = 'a';         // single characters 

// condition / logic type
bool isProgrammer = true;           // only true or false
```
