## Arrays als Parameter

* Der Wert von Parametern kann nicht geändert werden
* Die Elemente eines Arrays können jedoch geändert werden
* Warum ist das so?
* Grund ist die Art wie Arrays an die Methode übergeben werden
* für ein Array gibt es tatsächlich einen Bereich im Speicher, in dem die Daten gespeichert werden
* Unsere Array-Variable ist eigentlich nur der Zeiger, der auf die Startadresse im Speicher zeigt
* Also übergeben wir nicht die Wert sondern wir übergeben die Referenz / die Adresse im Speicher und können die Elemente des Arrays dadurch ändern
* dies bezeichnet man als call by reference
