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
Follow the following steps to ensure the program's reliability.
Make sure you got the right "SQLLite.Interop.dll" file:
  1.  Copy the folders "x86" and "x64" with the "SQLite.Interop.dll" within from the repository path:
        .\Semesterprojekt\packages\Stub.System.Data.SQLite.Core.NetFramework.1.0.118.0\build\net46
  2.  Paste the folders to the repository path:
        .\Semesterprojekt\ContactManager\bin\Debug

Make sure you got some correct demo contacts via CSV import:
  1.  Run the program to open the menu
  2.  Click "IMPORT FROM FILE"
  3.  Click "OPEN FILE" to open the file explorer
  4.  Choose the following csv file from the repository:
        .\Semesterprojekt\contacts.csv
  5.  Click "CONFIRM"
##################################
##################################
