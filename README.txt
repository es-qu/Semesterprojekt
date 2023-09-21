# PROJECT NAME
This semester project (2. semester "Zentrum für berufliche Weiterbildung") includes the development of a contact manager software.

## CREDITS
This project includes code contributions from the following authors:
- [Maximilian Degen](https://github.com/Hamstergruesch)
- [Elias Götte](https://github.com/Eliasgoette)
- [Khabat Rammo](https://github.com/Niceplayer13)
- [Steven Näf](https://github.com/es-qu)

Special thanks to the contributors for their valuable input and effort in making this project possible.

## LICENSES
This program is open-source and uses SQLite.
- SQLite is in the public domain and is not subject to copyright. (https://www.sqlite.org/copyright.html)

## DESIGN
The modern design of the Application will be achieved using the H.MaterialSkin NuGet package.

##################################
########## INSTRUCTIONS ##########

# SQLite (mandatory)
Follow the steps to ensure the program's SQLite components reliability.
  1.  Copy the folders "x86" and "x64" with the "SQLite.Interop.dll" within from the repository path:
        .\Semesterprojekt\packages\Stub.System.Data.SQLite.Core.NetFramework.1.0.118.0\build\net46
  2.  Paste the folders to the repository path:
        .\Semesterprojekt\ContactManager\bin\Debug
  3.  Ready to run the program. If it's already running -> make sure to restart it.
######

# LOGIN
username: root
password: Password123
#######

# New import feature
If you want to try the new feature "IMPORT FROM FILE" try the import with some demo contacts:
  1.  Run the program to open the menu
  2.  Click "IMPORT FROM FILE"
  3.  Click "OPEN FILE" to open the file explorer
  4.  Choose the following csv file from the repository:
        .\Semesterprojekt\contacts.csv
  5.  Click "CONFIRM"

##################################
##################################

# Other

## Which features from the project guideline are functioning? 
(project guidelines are in german)

Funktionale Anforderungen:
[x] Erfassung von Mitarbeitern und Kunden
[x] Mutieren von Mitarbeitern und Kunden
[x] Aktivieren und deaktivieren von Mitarbeitern und Kunden
[x] Löschen von Mitarbeitern und Kunden
[x] Automatische Vergabe von Mitarbeiternummern
[x] Protokollieren von Notizen in Kundenkontakten inkl. Historie
[x] Suchmöglichkeiten über alle gespeicherten Informationen
[x] Automatisches Speichern des Datenstamms auf Festplatte

Optionale funktionale Anforderungen:
[x] Mutationshistorie von Kontaktdaten
[x] Login
[ ] Dashboard-View
[x] Import von Kontakten im CSV-Format oder VCard-Format (look at instructions # New import feature)

##################################
