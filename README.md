[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-718a45dd9cf7e7f842a935f5ebbe5719a5e09af4491e668f4dbf3b35d5cca122.svg)](https://classroom.github.com/online_ide?assignment_repo_id=12000376&assignment_repo_type=AssignmentRepo)
# Bank

TODO:
- Die Funktion der Klasse Konto soll mit UnitTests überprüft werden.
- Diese Anleitung ist nicht mehr aktuell und muss überarbeitet werden. Screenshots wären sicherlich auch angebracht.
- Bitte überprüfen:
- Finden Sie Fehler in der Implementierung?
- Finden Sie "Verbesserungen" in den UserStories?

# Anleitung zur Erstellung von Unit UnitTests
1. Zu testende Klasse als öffentlich deklarieren
2. Neues Komponententestprojekt zur Projektmappe hinzufügen
3. Verweis auf zu testendes Projekt hinzufügen
4. Using-Direktive für den Namensraum der zu testenden Klasse hinzufügen
5. Testmethode implementieren
- Attribut `[TestMethod]` in eine eigene Zeile vor der Methodendeklaration schreiben
- Testmethoden haben keine Übergabeparameter und keinen Rückgabewert
- Name: zu testende Methode_Informationen_zum_erwarteten_Verhalten, z.B. Skalieren_AendertBreiteUndHoehe oder Skalieren_Faktor_Null_Schlaegt_Fehl
- Muster Arrange – Act – Assert (AAA) verwenden

6. Tests ausführen
