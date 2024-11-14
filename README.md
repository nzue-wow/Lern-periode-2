# Lern-Periode 2

25.10 bis 20.12

## Grob-Planung

In dieser 2.Lernperiode möchte ich ein  Spiel programmieren. Ich möchte das Schlangenspiel von Google nachprogrammieren. Die Schlange muss Früchteaufsammeln, dabei wird sie länger. Sie darf nicht in die Wand fahren dann dann ist das spiel vorbei.

## 25.10.2024

- [x] Random Number guesser
- [x] Ein Projekt für die 2. Lernperiode finden

✍️ Heute habe ich... (50-100 Wörter)
Ich habe zuerst einen Random Number guesser programmiert um zu checken ob ich das gut kann. Es ging surprisingly(weiss das deutsch wort nicht) gut. Ich musste nur nochmal kurz nachschauen wie die Random funktion ging: `Random rnd = new Random();
                      int nummer = rnd.Next(1, 101);`
Später habe ich nach Ideen gesucht für die 2. Lernperiode.ICh bin darauf gekommen ein Snake spiel zu machen.
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 1.11.2024

- [x] Recherche wie man das Spielfeld kann machen
- [x] Rausfinden wie man die Schlange darstellen möchte
- [ ] Die Schlange bewegen lassen

✍️ Heute habe ich... (50-100 Wörter)
Habe ich recherchiert wie ich ein Spielfeld könnte machen. Dann hat herr Colic mir zwei Möglichkeiten geschickt die ich dann ausprobiert habe. Leider hat es irgendwie nicht funktioniert, ich denke es liegt daran das ich etwas falsch gemacht habe. Denn das Speilfeld war so komisch verschoben. Ich habe dann im Internet noch ein bisschen rum geschaut wie es auch gemacht werden könnte. Es hat ähnliche sochen drinn ist aber einfacher aufgeabut habe ich das gefühl. aber ich binn mir nicht ganz sicher obe es zum Spiel funktionieren würde. Ich habe eigendlich den ganzen morgen versucht rauszufinden wie ich das Spielfeld mache, so das ich nur kurz am Schluss mir überlegen konnte wie ich  meine Schlange machen möchte. Ich habe mir èberlegt das ich es mit so grösser kleiner Zeichen kann machen: `<, >, ^, v`
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 8.11.2024
- [x] Herausfinden wie ich die Schlange(<, >...) in die Konsole bringen kann
- [ ] Die Schlange bewegenlassen mit Tastaturkontrolle
- [x] überlegen wie die Schlange nicht aus dem Spielfeld geht.

Heute habe ich...
Heute habe nicht viel neues am code gearbeitet, denn wie ich das Spielfeld letztes Mal gemacht habe hat für mich nicht viel Sinn gemacht. Also ich habe es nicht ganz verstanden. Jetzt habe ich das Spielfeld mit x und y und for Schleifen gemacht. Ich habe nun noch die start position der schlange initialiesiert. Die Schlange ist jetzt schon in der Mitte aufgezeichnet aber sie kann sich noch nicht bewegen. Heute habe ich auch noch gelernt wei man Variabeln initialisiert dass sie für alle Funktionen gelten nämlich mit z.Bsp. `static int breite = 25`. ICh habe schon angefangen zu überlegen wie ich dei Schlange im Spielfeld behalten kann `if (neuX <= 0 || neuX >= breite - 1 || neuY <= 0 || neuY >= höhe - 1)`.Aber est muss ich sie noch zum bewegen bringen.

## 15.11.2024
- [x] Die Schlange zum bewegen bringen mit koordinaten x und y.
- [x] Die Schlange darf oben, unten, rechts und links nicht aus dem spielfeld kommen. Versuchen mit: `if (neuX <= 0 || neuX >= breite - 1 || neuY <= 0 || neuY >= höhe - 1)`
- [x] Die Schlange soll nach oben, unten, recht und links gehen mit kommando der Pfeiltasten
- [x] Pfeiltasten mit dem Programm verbinden


Heute habe ich...
Ich habe sehr viel Ausprobiert und gegoogelt und Tutorials angeschaut, zum rausfinden wie man die schlange mit x und y bewegt. Dabei habe ich noch den code denn ich letzes Mal schon gefunden habe: `if (neuX <= 0 || neuX >= breite - 1 || neuY <= 0 || neuY >= höhe - 1)` gebraucht damit das Spiel Aufhört wenn die Schlange den Spielrand berührt. Ich hatte auch ein Problem: Die Schlange hat sich zwar bewegt aber sie wurde dabei immer länger, also es hat irgendwie die Pfeile nicht gelöscht so das sie gleich lang bleibt. Das konnte ich dann jedoch gut beheben. Ich habe dann mit einem switch case geschafft die Tastatur zu benutzen und die schlange in alle Richtungen zu leiten. Leider hat es hier ein Problem weil wenn ich die Taste nach oben oder unten gedrückt habe, sind die anderen dann blockiert.

## 22.11.2024
- [ ] Fehler beheben: Blockierung der Tasten wenn der `UpArrow` oder der `DownArrow` gedrückt wird
- [ ] Geschwindikeit der Schlange programmieren: langsamer machen
- [ ] Äpfel auf dem Spielfeld erscheinen lassen
- [ ] Schlange länger werden lassen wenn ein Apfel gegessen wird
- [ ] (Bei Game Over entscheiden können ob man nochmals spielen möchte oder ob das Programm sich schliessen soll)
