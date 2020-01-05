# ShootAsteroids
A Unity project for school. 

UnityGame par Mathieu Guilbert


Description du jeu:

	Le jeu est une version évoluée de celui réalisé en cours.
	Le but est de faire le plus gros score possible en tirant sur les asteroids. Si le vaisseau est touché 5 fois, la partie s’arrête.  
	
	Le jeu est constitué de 3 scènes : un menu, une scène de jeu et un écran de Game Over.
	Le jeu comporte une musique, en boucle. Elle se lance au démarrage du Menu pour ne plus s'arreter.



Difficultés rencontrées:
	La première grosse difficulté rencontrée a été de garder le même score entre les scènes de jeu et du Game Over. J'ai tout d'abord essayer d'utiliser la méthode DontDestroy, mais cela créait un problème lorsqu'on rejouait (chaque nouvelle partie ajouter un nouvel audio listener, et le dontDestroy avait pour effet de ne pas les supprimés). J'ai donc au final choisit de passer l'attribut scorePlayer du gameState en publique afin de pouvoir le récupérer pour l'afficher dans une autre scene.
	Le deuxième long problème a été de trouver une manière de déplacer le vaisseau sur mobile. J'ai d'abord voulu créer deux flèches Haut et Bas, mais je n'ai pas réussi à faire ce que je souhaitait de cette manière. J'ai alors choisit de déplacer le vaisseau  lorsque l'utilisateur touche n'importe ou sur l'écran (en dehors des boutons Pause et Tir).
	Enfin, le seul gros défaut qui persiste jusqu'à maintenant viens du background; Je n'arrive pas a faire une transition fluide entre mes sprites de backgrounds.

Appareils testés:
-Samsung Galaxy S8


Sources:

Sprite du bouton: https://www.pngrepo.com/svg/149631/pause-button
Squelette du script pour faire les menus de pause et de regles : https://www.youtube.com/watch?v=pbeB9NsaoPs
Squelette du script pour bouger le vaisseau avec le doigt: https://www.youtube.com/watch?v=ST7BAqV-1ow
Police d'écriture Xirod: https://www.1001fonts.com/xirod-font.html
Police d'écriture Terminator Real NFI : https://www.1001fonts.com/terminator-real-nfi-font.html

Musique: Rootwork de PrototypeRaptor
