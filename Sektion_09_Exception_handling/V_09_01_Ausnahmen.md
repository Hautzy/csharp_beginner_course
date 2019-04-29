# Ausnahmen / Exceptions

## Eine Ausnahme auffangen

* Ausnahme sind Fehler, die während der Laufzeit des Programms auftreten
* Wenn eine Ausnahme auftritt, wird das Programm beendet
* Es gibt eine Möglichkeit, dies zu verhindern
* indem eine Ausnahme abgefangen wird
* dies wird mit try and catch erledigt

```csharp
// creating an exception on my own
int[] arr = new int[10];

try
{
    arr[11] = 11;
}
catch(Exception ex)
{
    Console.WriteLine("ERROR!!!");
}
```

* im try-Block ist der Code, der möglicherweise eine Ausnahme auslösen kann
* im catch-Block steht der Code der ausgeführt werden soll, wenn eine Ausnahme ausgelöst wird
* du kannst mehrere catch-Blöcke deklarieren und verschiedene Ausnahmetypen abfangen
* Nicht jede Ausnahme ist vom Typ Exception

Verschiedene / bekannteste Ausnahmetypen:

* InvalidOperationException
* StackOverflowException - oft, wenn mit Rekursion gearbeitet wird
* IndexOutOfRangeException - häufig beim Arbeiten mit Arrays
* NullPointerException - häufig beim Arbeiten mit Referenzen

## Eine Ausnahme auslösen

* Manchmal musst du eine Ausnahme erneut auslösen
* oder selbst eine Ausnahme auslösen
* Dies erfolgt mit dem Schlüsselwort throw

```csharp
throw new Exception();
```
