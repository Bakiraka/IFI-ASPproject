# IFI : Application MVC

Cette application a été crée à l'aide du tutoriel disponible à l'[adresse suivante](http://www.asp.net/mvc/overview/getting-started).

## Thème de l'application

Cette application est un site permettant d'ajouter différents éléments (des bateaux, avec leurs caractéristiques).
Il y a plusieurs pages, pour s'enregistrer, se connecter, ajouter et modifier des éléments.

Modèle créé : Bateaux.cs

Celui-ci possède différents champs représentant un bateau que l'on peut ajouter à la base.


## Spécificité de l'application

+ Lorsqu'un utilisateur non connecté souhaite effectuer des modifications sur la base, il lui sera demandé de se connecter afin de réaliser ces modifications (Modification effectuée dans le contrôleur des bateaux).
+ Modification du css et customisation visuelle
+ Vérification des champs (une date devra être une date, validation du prix en tant que chiffre, etc)
