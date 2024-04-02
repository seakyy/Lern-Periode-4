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
| 9              |   Internet  | (nichts)  | (nichts) |    ja    |
| 10                |   Visual Studio   | Startknopf auf VS | Funktioniert ohne Fehler|  ja   |
| 11               |     Discord & VS        |  Command / Start  |  Bot reagiert |   ja    |
| 12               |     Discord         |  Command  |  Zeigt etwas |   ja    |

✍️ Heute am 12.3 habe ich... (50-100 Wörter)

Zum ersten Mal die Commands programmiert. Der Bot startet auf und kommt Online, führt die Commands sauber aus und gibt keine Fehler heraus. Der erste Command ist gleichzustellen mit dem "Hello World" in C#, der Bot sagt: Hallo(username)! Am Anfang hatte ich schwierigeiten das Programm und den Bot aufzustarten weil ich ausversehen mein Token vom Bot resetet habe. Das hat dazu geführt dass er auf einen ungültigen Code zurückgegriffen hat und das Programm abgestürzt ist. Als Lösung habe ich den Token noch mal resetet und ihn dann kopiert und im Programm neu eingefügt. Danach klappte alles super.


## 19.03.2024

- [ ] Mehr Commands schreiben, für Testzwecke
- [ ] Mich informieren wie "embed messages" funktionieren
- [ ] Die neuen Commands in "embed messages" zu transformieren
- [ ] Den Bot interaktionsfähig zu machen


| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 13           |   VS  | !Command  | Task |    ja    |
| 14                |   Internet  | (nichts)  | (nichts) |  ja  |
| 15               |      VS        |  Command   |  Programm lauft ohne Probleme |    ja   |
| 16               |     Discord & VS        |  Command  |  interagiert mit sich selbst oder dem User |   50/50    |

✍️ Heute am 19.3 habe ich... (50-100 Wörter)

Ich habe mein Ziel erfüllt, es sind von den basic Commands "add" & "subtract" noch viel mehr weitere hinzugekommen. Ich habe es geschafft mit den Command !rick einen Rick Astley Gif wiederzugeben. Ich zweifle sehr daran dass meine Idee überhaupt umsetzbar ist, da es mein Ziel wäre, immer das neuste Video von einem Youtuber auf Discord per Link hochzuladen. Ich habe mich informiert und eigentlich bräuchte man dafür keinen eigenen Bot, sondern nur einen Webhook. Deshalb muss ich mein Plan überarbeiten. 

## 26.03.2024

- [ ] Bot komplett überarbeiten
- [ ] Alte Commands lassen oder ersetzten und überarbeiten
- [ ] Einen Weg zu finden, wie man das ohne Webhok machen kann.
- [ ] Den Code so aufbereiten, dass er für das nächste Projekt startklar ist.


| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 17           |   VS  | nichts  | nichts |    ja    |
| 18               |   VS / code  | nichts  | nichts |  ja  |
| 19              |      Internet        |  nichts   |  nichts |    50/50   |
| 20              |     VS        |  Command  |  Befehl |   ja    |      


✍️ Heute am 26.3 habe ich... (50-100 Wörter)

Da ich in der letzten Sitzung festgestellt habe, dass mein Bot doch nicht so geht wie ich es mir vorgestellt habe, muss ich meine Hauptfunktion vom Bot auf ein anderes thema setzen. Damit der Bot immer die neusten Videos per Link schickt muss er die ganze Zeit Online sein. Mit einem Webhook muss man nur den Link eingeben und das Projekt wäre fertig. Aber so schnell lasse ich mich nicht vom Weg abkommen, desshalb habe ich den Bot überarbeitet und möchte ihn für einen Database- oder Support-Bot benutzen.


## 02.04.2024

- [ ] Den Code aussäubern
- [ ] Nur das wichtigste im Code haben
- [ ] Nochmals überprüfen ob er mit allen Funktionen auf dem Discord Server funktioniert

      
| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 21           |   VS / Code  | nichts  | Sauberer Code |    ja    |
| 22                |   VS / Code  | nichts  | nichts |  ja  |
| 23              |      VS / Discord       |  Command   |  Gibt den Befehl richtig aus |    ja   |

✍️ Heute am 2.4 habe ich... (50-100 Wörter)

Meinen ganzen Code nochmals überarbeitet und geschaut das nur das wichtigste reinkommt. Ich habe es probiert ihn so klar wie möglich zu schreiben, obwohl er meiner Meinung nach nicht viel Linien Code hat die verwirrend wirken. Nachdem ich alles aufgeräumt und gesäubert habe musste ich den Bot nochmals testen um zu schauen ob er auch wirklich funktioniert. Das war der Fall und deswegen habe ich meiner Meinung nach diese LP mein Projekt nur teilweise erfüllt.


#Reflexion

VBV: Ich habe mich am Anfang der LP nicht gut genug informiert über die Funktionsweise vom Discord Bot. Ich empfinde das aber als nicht schlimm, da man aus seinen Fehlern lernt. Dafür sollte ich aber zuerst ein Funktions-konzept machen, welches mir die Klarheit des Projekts schon am Anfang gibt. Jedoch denke ich, dass ich sehr gut und konzentriert durch die ganze LP gearbeitet habe.




