* [Lettre devant la porte] MSG;A;4.0;Vous m'avez laissé votre numéro devant ma porte, c'est pour de la publicité ? 
-> Reponse_1
* [Harcèlement] MSG;A;4.0;J'ai vu votre message sous ma porte, arrêter de me harceler sinon j'appelle la police !
-> Reponse_2 
* [Ne pas envoyer de message] 
-> END

=== Reponse_1 ===
- MSG;B;3.0;Non ce n'est pas ça, je suis votre voisin, je vous ai croisé tout à l'heure, vous n'aviez pas l'air bien
* [Tout va bien merci] MSG;A;2.5;Tous va bien, vous n'aviez pas besoin de vous inquiéter, bonne journée.
->vraiment
* [Ça ne va pas bien] MSG;A;4.5;J'ai reçu des messages assez dur ce matin et ce n'est pas la première fois. Je ne sais pas quoi faire
-> confession_1

=== Reponse_2 ===
- MSG;B;3.5;Vous faites erreur, je voulais pas du tout vous faire peur, désolé, je suis votre voisin du dessus. Vous n'aviez pas l'air bien quand je vous ai croisé tout à l'heure je voulais m'assurer que vous alliez bien.
* [Tout va bien merci] MSG;A;2.5;Tous va bien, vous n'aviez pas besoin de vous inquiéter, bonne journée.
-> vraiment
* [Ça ne va pas bien] MSG;A;4.5;J'ai reçu des messages assez dur ce matin et ce n'est pas la premi-re fois. Je ne sais pas quoi faire.
-> confession_1

=== confession_1 ===
- MSG;B;2.5;On vous harcèle ?
* [Pas vraiment] MSG;A;4.5;Pas vraiment ça ressemble plutôt à une blague, je ne sais pas trop ça semble être écrit par un enfant.
->confession_6
* [Oui] MSG;A;4.5;C'est un sms que j'ai reçu qui me traite de sorcière...
->confession_2

=== confession_2 ===
- MSG;B;1.5;Ah et vous en êtes une du coup :D ?
* [Plaisanter] MSG;A;3.0;Ne me posez pas la question ça me ferait disparaître :D
->confession_3
* [Non] MSG;A;5.5;Ce n'est pas très drôle, les enfants de l'immeuble disent tous ça de moi
->confession_3

=== confession_3 ===
- MSG;B;3.0;Ecoutez, je pense que c'est le petit Sacha, votre jeune voisin qui à fait le coup, j'en parlerais à ces parents si vous voulez
* [Merci] MSG;A;3.5;Merci, je ne me sens pas très bien à cause de ça, les gens de cette immeuble ne sont pas très gentils avec moi en générale, je ne sort pas beaucoup et je suis trop différente à leurs goûts...
->confession_4
* [Ne pas répondre] MSG;A;4.0;
->dernier_sms

=== confession_6 ===
- MSG;B;3.0;Ça doit être le petit Sacha, votre jeune voisin qui à fait le coup, j'en parlerais à ces parents si vous voulez
* [Merci] MSG;A;3.5;Merci, je ne me sens pas très bien à cause de ça, les gens de cette immeuble ne sont pas très gentils avec moi en générale, je ne sort pas beaucoup et je suis trop différente à leurs goûts...
->confession_4
* [Ne pas répondre]
->dernier_sms

=== confession_4 ===
- MSG;B;3.0;Vous avez plutôt l'air d'une mami fabulous si vous voulez mon avis :)
* [Vous êtes adorable] MSG;A;4.5;Vous êtes adorable, peu de gens ici le savent mais...
MSG;A;3;Je suis asperger. Les gens ne sont pas très tolérant en générale avec ceux qui sont différent.
->confession_5
* [Ne pas répondre]
->dernier_sms

=== confession_5 ===
- MSG;B;3.5;A qui le dites-vous. 
MSG;A;3.5;Merci d'avoir pris le temps de parler avec moi. Tout ça m'a grandement fatiguée, je vais me reposer, n'hésitez pas à passer prendre un thé chez moi, vous aurez surement envie de voir Nestor, Carotte et Patachon
 ->bonne_fin
 
 === vraiment ===
- MSG;B;1.5;Vous êtes sur ?
* [Ça ne va pas bien] MSG;A;3.5;J'ai reçu des messages assez dur ce matin et ce n'est pas la première fois. Je ne sais pas quoi faire.
->confession_1
* [Ce n'est pas important] MSG;A;3.0;Ne vous en faite pas jeune homme, n'écoutez pas les vieilles dames
->vraiment_sur

 === vraiment_sur ===
- MSG;B;2.5;Vous savez, on m'a éduqué en me disant qu'il fallait écouter les personnes plus anciennes.
* [Ça ne va pas bien] MSG;A;3.5;J'ai reçu des messages assez dur ce matin. Je ne sais pas quoi faire
->confession_1

=== dernier_sms ===
- MSG;B;2.0;Gardez courage, je sais à quel point, il est compliqué de trouver sa place.
->END

=== bonne_fin ===
- MSG;B;1.5;Avec plaisir, à bientôt
->END