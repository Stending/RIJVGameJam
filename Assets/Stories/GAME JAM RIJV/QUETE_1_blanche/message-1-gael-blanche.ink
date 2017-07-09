- Contacter Gaël :

* [Publicité ?] Vous m'avez laissé votre numéro devant ma porte, c'est pour de la publicité ? 
-> Reponse_1
* [Qui êtes vous ?] J'ai vu votre message sous ma porte, arrêter de me harceler sinon j'appelle la police !
-> Reponse_2 
* [Ne pas envoyer de message] 
-> END

=== Reponse_1 ===
- Non ce n'est pas ça, je suis votre voisin, je vous ai croisé tout à l'heure, vous n'aviez pas l'air bien
* [Tout va bien merci] Tous va bien, vous n'aviez pas besoin de vous inquiéter, bonne journée.
->vraiment
* [Ça ne va pas bien] J'ai reçu des messages assez dur ce matin. Je ne sais pas quoi faire
-> confession_1

=== Reponse_2 ===
- Vous faites erreur, je voulais pas du tout vous faire peur, désolé, je suis votre voisin du dessus. Vous n'aviez pas l'air bien quand je vous ai croisé tout à l'heure je voulais m'assurer que vous alliez bien.
* [Tout va bien merci] Tous va bien, vous n'aviez pas besoin de vous inquiéter, bonne journée.
-> vraiment
* [Ça ne va pas bien] J'ai reçu des messages assez dur ce matin. Je ne sais pas quoi faire
-> confession_1

=== confession_1 ===
- On vous harcèle ?
* [Pas vraiment] Pas vraiment ça ressemble plutôt à une blague, je ne sais pas trop ça semble être écrit par un enfant.
->confession_6
* [Oui] C'est un sms que j'ai reçu qui me traite de sorcière...
->confession_2

=== confession_2 ===
- Ah et vous en êtes une du coup :D ?
* [Plaisanter] Ne me posez pas la question ça me ferait disparaître :D
->confession_3
* [Non] Ce n'est pas très drôle, les enfants de l'immeuble disent tous ça de moi
->confession_3

=== confession_3 ===
- Ecoutez, je pense que c'est le petit Sacha, votre jeune voisin qui à fait le coup, j'en parlerais à ces parents si vous voulez
* [Merci] Merci, je ne me sens pas très bien à cause de ça, les gens de cette immeuble ne sont pas très gentils avec moi en générale, je ne sort pas beaucoup et je suis trop différente à leurs goûts...
->confession_4
* [Ne pas répondre]
->dernier_sms

=== confession_6 ===
- Ça doit être le petit Sacha, votre jeune voisin qui à fait le coup, j'en parlerais à ces parents si vous voulez
* [Merci] Merci, je ne me sens pas très bien à cause de ça, les gens de cette immeuble ne sont pas très gentils avec moi en générale, je ne sort pas beaucoup et je suis trop différente à leurs goûts...
->confession_4
* [Ne pas répondre]
->dernier_sms

=== confession_4 ===
- Je vous trouve parfaite
* [Vous êtes adorable] Vous êtes adorable, peu de gens ici le savent mais...
Je suis asperger. Les gens ne sont pas très tolérant en générale avec ceux qui sont différent.
->confession_5
* [Ne pas répondre]
->dernier_sms

=== confession_5 ===
- A qui le dites-vous, 
 Merci d'avoir pris le temps de parler avec moi. Tout ça m'a grandement fatigué, je vais me reposer, n'hésitez pas à passer prendre un thé chez moi, vous aurez surement envie de voir Nestor, Carotte et Patachon
 ->bonne_fin
 
 === vraiment ===
- Vous êtes sur ?
* [Ça ne va pas bien] J'ai reçu des messages assez dur ce matin. Je ne sais pas quoi faire
->confession_1
* [Ce n'est pas important] Ne vous en faite pas jeune homme, n'écoutez pas les vieilles dames
->vraiment_sur

 === vraiment_sur ===
- Vous savez, on m'a éduqué en me disant qu'il fallait écouter les personnes plus anciennes.
* [Ça ne va pas bien] J'ai reçu des messages assez dur ce matin. Je ne sais pas quoi faire
->confession_1

=== dernier_sms ===
- Gardez courage, je sais à quel point, il est compliqué de trouver sa place.
->END

=== bonne_fin ===
- Avec plaisir, à bientôt
->END