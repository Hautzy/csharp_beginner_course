# File IO

* Dateien sind eine gute Möglichkeit, Daten zu speichern
* weil die Daten, die wir in unseren Variablen verwenden, nur zur Laufzeit existieren
* Wenn du Daten länger speichern möchtest, benötigst du zum Beispiel eine score list Datei

## Infos zu Files

* Dateien sind kodiert
* Die typische Kodierung für Dateien sollte UTF-8 für Sonderzeichen sein
* Bei der Arbeit mit Dateien kann es viele Ausnahmen geben
    * file not found exception
    * file already in use exception
    * ...
* Mit c# können wir Dateien schreiben und lesen
* Ein Dateityp, auf den wir uns konzentrieren werden, sind CSV-Dateien
* Diese Dateien speichern Informationen / Daten durch Aufteilen der Daten mit dem ; Symbole (manchmal auch andere Symbole)
