* [Lettre devant la porte] MSG;A;4.0;Vous m'avez laissé votre numéro devant ma porte, c'est pour de la publicité ? 
-> Reponse_1
* [Harcèlement] MSG;A;4.0;J'ai vu votre message sous ma porte, arrêtez de me harceler, sinon j'appelle la police !
-> Reponse_2

=== Reponse_1 ===
- MSG;B;3.0;Non ce n'est pas ça, je suis votre voisin ! Je vous ai croisée tout à l'heure vous n'aviez pas l'air bien
* [Tout va bien merci] MSG;A;2.5;Tout va bien, vous n'aviez pas besoin de vous inquiéter, bonne journée.
->vraiment
* [Ça ne va pas bien] MSG;A;4.5;J'ai reçu des messages assez durs ce matin, et ce n'est pas la première fois. Je ne sais pas quoi faire...
-> confession_1

=== Reponse_2 ===
- MSG;B;3.5;Vous faites erreur, je voulais pas du tout vous faire peur, désolé, je suis votre voisin du dessus. Vous n'aviez pas l'air bien quand je vous ai croisée tout à l'heure et je voulais m'assurer que vous alliez bien
* [Tout va bien merci] MSG;A;2.5;Tout va bien, vous n'aviez pas besoin de vous inquiéter, bonne journée.
-> vraiment
* [Ça ne va pas bien] MSG;A;4.5;J'ai reçu des messages assez durs ce matin, et ce n'est pas la première fois. Je ne sais pas quoi faire...
-> confession_1


 === vraiment ===
- MSG;B;1.5;Vous êtes sûre ?
* [Ce n'est pas important] MSG;A;3.0;Oui, vous êtes gentil de vous inquiéter mais il n'y a rien.
->vraiment_sur
* [Ça ne va pas bien] MSG;A;4.5;J'ai reçu des messages assez durs ce matin, et ce n'est pas la première fois. Je ne sais pas quoi faire...
-> confession_1


 === vraiment_sur ===
- MSG;B;1.5;Vraiment ?
* [Oui] MSG;A;3.0;Ne vous en faites pas jeune homme, n'écoutez pas les vieilles dames.
->vraimentvrai_sur
* [Ça ne va pas bien] MSG;A;4.5;J'ai reçu des messages assez durs ce matin, et ce n'est pas la première fois. Je ne sais pas quoi faire...
-> confession_1


 === vraimentvrai_sur ===
- MSG;B;2.5;Vous savez on m'a éduqué en me disant qu'il fallait écouter les anciens. Si vous avez besoin de quelqu'un, je suis là
* [Ça ne va pas bien] MSG;A;4.5;J'ai reçu des messages assez durs ce matin, et ce n'est pas la première fois. Je ne sais pas quoi faire...
-> confession_1


=== confession_1 ===
- MSG;B;2.5;On vous harcèle ?
* [Oui] MSG;A;4.5;C'est un SMS que j'ai reçu, on me traite de sorcière...
->confession_2
* [Pas vraiment] MSG;A;4.5;Pas vraiment. Ca ressemble plutôt à une blague, je ne sais pas trop... ça semble être écrit par un enfant.
->confession_2bis

=== confession_2 ===
- MSG;B;1.5;Ah et vous en êtes une du coup :P ?
* [Plaisanter] MSG;A;3.0;Ne me posez pas la question, je ne voudrais pas finir au bûcher si quelqu'un l'apprend :D
->confession_3
* [Non] MSG;A;5.5;Ce n'est pas très drôle, les enfants de l'immeuble disent tous ça de moi.
->confession_3

=== confession_3 ===
- MSG;B;3.0;Écoutez, je pense que c'est le petit Sacha qui a fait le coup. J'en parlerai à ses parents si vous voulez
* [Merci] MSG;A;3.5;Merci, je ne me sens pas très bien à cause de ça. Les gens de cet immeuble sont généralement peu aimables avec moi. Je ne sors pas beaucoup et je suis trop différente à leur goût...
->confession_4
* [Ne pas répondre] MSG;A;4.0;
->dernier_sms

=== confession_2bis ===
- MSG;B;3.0;Ça doit être le petit Sacha qui a fait le coup. J'en parlerai à ses parents si vous voulez
* [Merci] MSG;A;3.5;Merci, je ne me sens pas très bien à cause de ça. Les gens de cet immeuble sont généralement peu aimables avec moi. Je ne sors pas beaucoup et je reste bizarre à leurs yeux...
->confession_4
* [Ne pas répondre]
->dernier_sms

=== confession_4 ===
- MSG;B;3.0;Vous avez plutôt l'air d'une mamie fabulous si vous voulez mon avis :)
* [Vous êtes adorable] MSG;A;4.0;Vous êtes adorable :)
->confession_5
* [Ne pas répondre]
->dernier_sms

=== confession_5 ===
- MSG;B;3.0;Je dois vous avouer que j'ai lu certains de vos livres... dont votre biographie
* [Se confier] MSG;A;4.0;Je vois, pourriez-vous garder cela pour vous ?
MSG;A;3.0;Je ne veux pas que les gens sachent pour mon asperger. Au moment où je militais cela avait du sens, mais maintenant je ne suis plus qu'une vieille veuve qui ne sort pas trop de chez elle.
->confession_6
* [Ne pas répondre]
->dernier_sms

=== confession_6 ===
- MSG;B;3.5;Très bien, je garderai ça pour moi. Mais sachez que je suis là si vous avez besoin, je sais à quel point c'est compliqué d'être différent
MSG;A;3.5;Merci d'avoir pris le temps de parler avec moi. Tout ça m'a grandement fatiguée, je vais me reposer. N'hésitez pas à passer prendre un thé chez moi, vous aurez sûrement envie de voir Nestor, Ricky, Carotte et Patachon
 ->bonne_fin

=== dernier_sms ===
- MSG;B;2.0;Courage ! Je sais à quel point c'est compliqué de trouver sa place
->END

=== bonne_fin ===
- MSG;B;1.5;Avec plaisir, à bientôt
->END