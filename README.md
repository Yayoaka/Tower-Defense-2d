# Introduction

Venez essayé mon petit jeu de Tower Defense 2D dont le but est de survivre 20 vagues de monstres qui augmente en nombres et en stats.

# Features

Liste des principales fonctionnalités de votre projet.

## MainMenu 
Permet de lancer et de quitter le jeu.

## Game
Espace de jeu où le but est d'empêcher les ennemis d'arriver à la fin de leur trajet en plaçant des tourelles sur le chemin.

## MenuPause
Permet de mettre le jeu en pause avec la touche Échap. Possibilité ensuite de relancer une nouvelle partie ou de retourner 
au menu principal.

## MenuShop
Permet de voir l'argent accumulé et de placer 2 types de tourelles en sélectionnant l'une des deux puis en faisant 
un clic gauche sur l'un des carrés en pierre prévus à cet effet :
 - Basic Turret : Coûte 100, a une portée de 4 et tire à 1,5 bps.
 - Sniper Turret : Coûte 200, a une portée de 7 et tire à 1 bps.

## InfoGame
En haut à droite, on voit différentes informations telles que votre nombre de vies, votre nombre de kills et la vague actuelle.

## Ecran de Victoire/Défaite
Termine la partie en cours, permet de voir le nombre d'ennemis tués et de relancer une nouvelle partie ou de retourner au menu principal.


# Installation
Provide step-by-step instructions on how to install your project.

# 1. Installer le projet projet
Installer le projet.
Assurez-vous que votre projet Unity est complet et fonctionne comme prévu dans l'éditeur Unity. Effectuez tous les tests nécessaires 
pour vous assurer qu'il n'y a pas de bugs majeurs.

# 2. Configurer les paramètres de build
Ouvrez Unity et chargez votre projet.
Allez dans File > Build Settings pour ouvrir la fenêtre des paramètres de build.
Dans la fenêtre Build Settings, sélectionnez la plateforme de votre choix (dans ce cas, PC, Mac & Linux Standalone).
Sélectionnez Windows comme plateforme cible.

# 3. Configurer les paramètres du joueur
Avant de créer le build, vous pouvez configurer des paramètres supplémentaires :
Allez dans Edit > Project Settings > Player pour ouvrir les paramètres du joueur.
Sous l’onglet Windows, vous pouvez configurer divers paramètres tels que :
Product Name : Le nom de votre jeu ou application.
Company Name : Le nom de votre entreprise ou développeur.
Icon : L'icône de l'application.
Resolution and Presentation : Les paramètres de résolution et de présentation de votre jeu.
Other Settings : Configurations additionnelles comme la version API, les paramètres de rendu, etc.

# 4. Ajouter les scènes au build
Dans la fenêtre Build Settings, sous Scenes In Build, ajoutez toutes les scènes que vous souhaitez inclure dans le build. 
Vous pouvez le faire en glissant les scènes depuis la fenêtre du projet ou en utilisant le bouton Add Open Scenes.

# 5. Créer le fichier .exe
Une fois que tout est configuré, cliquez sur le bouton Build dans la fenêtre Build Settings.
Choisissez un emplacement sur votre disque dur où vous souhaitez enregistrer le build.
Nommez le fichier et cliquez sur Save.
Puis tester le jeu.

# Grille d'éaluiation 
- Utilisation d'au  moins un trigger : la bullet qui rentre en collision avec les ennemmis
- Utilisation d'animation : rotation des tourelles/bouton menu shop
- Avoir des inputs géré avec le nouvel input system :
- Avoir un systeme de PV : Systeme de game over si on arrive a 0 PV
- Pouvoir voir ses PV : en haut à droite de l'écran (Lives)
- Avoir un menu Pause : possibilité de le voir dans la scene Game en faisant Echap
- Pouvoir reload sa partie : systeme de retry dans le menu pause et game over et win game
- Load une autre scene : 2 scene MainMenu et Game
- Avoir au moins un objet qui utilise la physique : la bullet
- Une fin de jeu (autre que la mort) : win game si on survit 20 vague
- Avoir une IA (vraiment simple) : les ennemis qui suivent un parcours prédéfini
- Scoring : compteur de kill
- objet instancié dynamiquement :

Polish :
- ajoutes des sons : boutons
- Utilisation d'asset pour le fond d'écran
- Systeme de monnaie
