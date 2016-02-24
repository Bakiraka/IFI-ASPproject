# IFI : Application MVC

Cette application a �t� cr�e � l'aide du tutoriel disponible � l'[adresse suivante](http://www.asp.net/mvc/overview/getting-started).

## Th�me de l'application

Cette application est un site permettant d'ajouter diff�rents �l�ments (des bateaux, avec leurs caract�ristiques).
Il y a plusieurs pages, pour s'enregistrer, se connecter, ajouter et modifier des �l�ments.

Mod�le cr�� : Bateaux.cs

Celui-ci poss�de diff�rents champs repr�sentant un bateau que l'on peut ajouter � la base.


## Sp�cificit� de l'application

+ Lorsqu'un utilisateur non connect� souhaite effectuer des modifications sur la base, il lui sera demand� de se connecter afin de r�aliser ces modifications (Modification effectu�e dans le contr�leur des bateaux).
+ Modification du css et customisation visuelle
+ V�rification des champs (une date devra �tre une date, validation du prix en tant que chiffre, etc)
