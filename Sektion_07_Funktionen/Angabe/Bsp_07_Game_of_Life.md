## Bsp_07_Game_of_Life

Game of Life ist eine kleine Simulation die das verhalten von Zellen in einem 2 dimensionalen Array wiederspiegelt. In unserem Beispiel soll das Array 60 * 20 Felder groß sein.

Jede Zelle hat zwei Zustände, entweder ist sie lebend oder tot. Wenn sie lebend ist wird sie als ein X auf der Konsle angezeigt.

Jeder Zelle unterliegt bestimmten Regeln und auf Basis dieser Regeln läuft die Simulation ab. Diese Regeln werden pro Durchlauf einmal auf jede einzelne Zelle angewendet.

Regeln:

* eine Zelle überlebt wenn sie zwei oder drei lebende Nachbarzellen hat, sonst überlebt sie nicht
* ein leeres Feld kann eine neue lebende Zelle entstehen lassen wenn sie genau 3 lebende Nachbarzellen hat

Zu Beginn der Simulation wird der Benutzer gefragt wie viele Zellen zufällig im Array verteilt werden sollen.
Sobald für alle Zellen der neue Status ermittelt wurde und das neu Zellen-Array ausgegeben wurde wartet das Program so lange, bis der Benutzer eine Taste drückt, danach wird das ganze wiederholt. (zu jeder Zeit soll zu sehen sein wie viele Zellen leben)

Durch diese Regeln kommt es zu ganz speziellen Mustern. Sollte der Benutzer ein 'X' oder 'x' eingeben wird das Program beendet.

Tipp: wenn die Regeln auf das aktuelle Array angewendet werden macht es Sinn das Resultat in einem neuen Array mit gleicher größe zu speichern und am Ende das neue Array als das aktuelle zu verwenden.
[Hier](https://de.wikipedia.org/wiki/Conways_Spiel_des_Lebens) kannst du dich weiter informieren.

![https://i.imgur.com/xHkVOzA.png](https://i.imgur.com/xHkVOzA.png)

![https://i.imgur.com/iMKbjHH.png](https://i.imgur.com/iMKbjHH.png)

![https://i.imgur.com/HYrKabl.png](https://i.imgur.com/HYrKabl.png)
