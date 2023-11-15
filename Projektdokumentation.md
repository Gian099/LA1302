# Projekt-Dokumentation 
 
Yanik Müller, Gian-Marco Mileti, Noah Maximillian Meier, Benas Sivickas

## 1 Informieren


### 1.1 User Stories

| US-№ |   Beschreibung                       |
| ---- |   ---------------------------------- |
| 1 | Als Spieler möchte ich verschiedene Bosse bekämpfen können.|
| 2| Als Spieler möchte ich verschiedene Charaktere auswählen können und sie spielen.|
| 3| Als Spieler möchte ich in einer Map gegen Gegner kämpfen können.|
| 4| Als Spieler möchte ich Aktionen auswählen, welche dann ausgeführt werden.|
| 5| Als Spieler möchte ich, dass die Aktionen auf Zufallszahlen beruhen.|
| 6| Als Spieler möchte ich in einem weiteren Szenario spielen können, wenn ich alle Gegner besiegt habe|
| 7| Als Spieler möchte ich gegen einen zweiphasigen Boss kämpfen können|
| 8| Als Spieler möchte ich wissen, dass ich das Spiel gewonnen habe, wenn ich den Boss besiegt habe|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|1.1|Spiel gestartet|start|Charakter auswahl Menu|
|2.1|1.1|Charakter auswählen|Spiel startet|
|3.1|2.1|map starten|Gegner tauchen auf|
|4.1|3.1|aktion auswählen|aktion wird ausgeführt|
|5.1|4.1|Zufallszahl wird gewürfelt|die aktion basiert auf der gewürfelten Zahl|
|6.1|Alle Gegner besiegt| weiter| neues Scenario|
|7.1|letztes level|los|Boss erscheint|
|7.2|7.1|Boss besiegt|Boss hat eine 2. Phase|
|8.1|7.2|2.Bossphase besiegt|Spiel gewonnen|


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ |---------------|
| 1.A | 22.11.23 | Alle | Ideen für verschiedene Bosse sammeln | 45' |
| 2.A | 22.11.23 | Yanik | Character select Screen implementieren | 90' |
| 3.A | 22.11.23 | Benas | Darstellung der Map implementieren | 45' |
| 3.B | 29.11.23 | Gian-Marco | Spawnen von Gegnern implementieren | 45' |
| 3.C | 29.11.23 | Noah | Kampf-UI implementieren | 90' |
| 4.A | 29.11.23 | Benas | Aktionen implementieren | 90' |
| 5.A | 29.11.23 | Gian-Marco | Einprogrammieren von RNG in Aktionen | 45' |
| 6.A | 6.11.23 | Alle | Weiteres Szenario Überlegen | 45' |
| 6.B | 6.11.23 | Benas | Logik zum wechseln von Szenarien implementieren | 90' |
| 7.A | 13.11.23 | Noah | Implementieren der Schadens-logik des Bosses | 45' |
| 7.B | 13.11.23 | Yanik | Phasenwechsel des Bosses implementieren | 45' |
| 8.A | 13.11.23 | Yanik | Anzeigen eines "gewonnen"-screens implementieren | 45' |




## 3 Entscheiden


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |


## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |      | |       |
| 2.1  |    | |       |
| 3.1  |     | |      |
| 4.1  || |       |
| 5.1  || |        |
| 6.1  || |       |



## 6 Code


