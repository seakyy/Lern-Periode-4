# Lern-Periode-4

David Koteski

20.2.2024

## Grob Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
   
   Ich stehe gut mit meinen Noten. Ich möchte aber Fokus auf das Modul 164 legen.

2. Was hatten Sie sich am Ende von LP3 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?

   In dieser LP will ich ein Projekt mit einem Discord Bot machen. Als VBV möchte ich mir zuerst mehr Informationen aussuchen und anschauen bevor ich mit dem Projekt anfange.

3. Was wäre ein geeignetes Projekt würd diese LP3?

   Ein Programm zu schreiben, sodass ich selbst einen Discord Bot konfigurieren kann.



## 20.2.2024

Heute habe ich recherchiert und geschaut, wo und wie ich einen Discord Bot machen kann. Ich möchte einen eigenen Bot in den Discord Server von meinen Kollegen einfügen, um Memes abspielen zu können.


## 27.2.2024

- [ ] Mir aufschreiben welche Funktionen der Bot haben sollte
- [ ] Mit welchem Text was aufrufbar ist
- [ ] Wie bekommt der Bot die Memes?
- [ ] Wie soll er sie abspielen?

|Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| -------------- | -------------------- | -------------- | -------------- | -------- |
| 1              |    Informationen     |  (noch nichts) |   (noch nichts)       |          |
| 2              |     Tastatur         |   Text         |   Memes        |          |
| 3              |     Internet         |   Text         |                |          |
| 4              | Bot und Discord      |  Command       |(noch nicht entschieden)|          |


✍️ Heute am 27.2 habe ich... (50-100 Wörter)

Ich habe mich umentschieden, es sollte zuerst ein Bot werden der den gesamten Discord Server benachrichtigt, wenn ein bestimtter Youtuber ein neues Video veröffentlicht hat. Somit sind alle Mitglieder des Servers auf dem neuesten Stand und verpassen keine tollen Videos mehr. Ich programmiere den Bot in C#. Ich habe angefangen das Discord Add-on in C# herunterzuladen und die Basis funktionen zu programmieren.


## 05.03.2024

- [ ] Bot vollständig funktionstüchtig machen
- [ ] Mich informieren wie ich es dazu schaffe den Bot online zu bekommen
- [ ] Wie greift der Bot auf dem YT-Kanal zu?
- [ ] Erster Testversuch um zu überprüfen ob es klappt

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 5               |   Visual Studio   | Startknopf auf VS | Bot funktioniert / Stürzt nicht ab|   ja  |
| 6               |   Internet  | (nichts)  | (nichts) |    ja    |
| 7               |   Youtube und VS |  URL vom Kanal     | Kann Zugreifen|     nein  |
| 8               |     Discord         |  Command  |  Zeigt Informationen über den YT-Kanal  |    nein   |


✍️ Heute am 5.3 habe ich... (50-100 Wörter)

Heute habe ich den Bot gründsätzlich fertig programmiert, dass heisst der Bot schafft es ohne Fehler zu starten und Online zu kommen. Jedoch kann man noch keine /-Befehle durchführen respektiv führt noch nichts aus. Ich musste den Token vom Bot öfters resetten und auch erneuern. Die ersten zwei Arbeitspakete wurden erledigt. Für die nächsten zwei muss ich aber zuerst noch die /-Befehle programmieren und müssen somit weit zurück verschoben werden.


## 12.03.2024

- [ ] Überlegen / Informieren was für Commands es braucht
- [ ] Diese Commands zu programmieren
- [ ] Testen ob sie funktionieren / Keine Fehler
- [ ] Testen ob sie etwas ausgeben können 


| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 9              |   Internet  | (nichts)  | (nichts) |        |
| 10                |   Visual Studio   | Startknopf auf VS | Funktioniert ohne Fehler|     |
| 11               |     Discord & VS        |  Command / Start  |  Bot reagiert |       |
| 12               |     Discord         |  Command  |  Zeigt etwas |       |

