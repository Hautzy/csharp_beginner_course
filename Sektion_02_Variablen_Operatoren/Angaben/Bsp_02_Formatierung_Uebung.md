## Bsp_02_Formatierung_Uebung

Überleg dir wie die Ausgaben für das folgende Beispiel auf der Konsole aussehen.

```csharp
string firstName = "Hans";
string lastName = "Mayr";

int num1 = 10;

int num2 = 1222;

int num3 = 150;

double d1 = 6.1234;

double d2 = 100.2126;


Console.WriteLine("|{0,-10}|{1,-10}|{2,5}|", firstName, lastName, num1);

Console.WriteLine("{0} {0}", firstName, lastName);

Console.WriteLine("{0,10}", d1);

Console.WriteLine("{0,10:f2}", d1);

Console.WriteLine("{0,-7:d5}", num1);

Console.WriteLine("{0,-5:f2}{1,5:f1}{2,4:d3}{3}-{4}", d1, d2, num1, num2, firstName);

Console.WriteLine("{0,-5}", num1);

Console.WriteLine("{0:d5}", num1);
```
