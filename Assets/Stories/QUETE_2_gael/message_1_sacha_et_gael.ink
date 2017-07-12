VAR mechant = 0
* [L'engueuler] MSG;A;10.0;On m'a dit que tu envoyais des messages à Mme Spitz, t'es vraiment qu'un petit con. Ce n'est pas un moyen de se conduire avec les personnes âgés, si je te chope à refaire ce genre de blague, ça va barder.
-> be_bastard
* [La jouer cool] MSG;A;4.0;Bonjour, Sacha, j'ai parlé avec Mme Spizt et je pense que ton comportement envers elle était déplacé
-> be_cool

=== be_bastard ===
- MSG;B;3.0;Bonjour Gaël, je vous ai donner le numéro de mon fils pour que vous lui expliquez le problème, pas pour l'insulter.
~ mechant = 1

* [S'excusez] MSG;A;2.0;Pardon, je me suis laissé emporter par l'émotion.
MSG;A;3.0;Bonjour, Sacha, j'ai parlé avec Mme Spizt et je pense que ton comportement envers elle était déplacé
->be_cool


=== be_cool ===
- MSG;B;2.5;Mais c une sorcière, elle a plein 2 chat, et 2 plantes pour ampoisonner les enfants. Mon copin Jason ma di qu'une fois, il l'avez vu manger de la viande cru !
* [Expliquez] MSG;A;10.0;Tu sais ce sont juste des plaisanteries d'enfants, tu ne devrais pas faire ce genre de chose, ça peut faire du mal aux gens...
->fin

* [Sermonner] MSG;A;7.0;Il est temps de grandir Sacha, tu devrais arrêter de croire ce que les autres enfants te racontes, et prendre le temps de réfléchir, tu sais bien que les sorcières n'existent pas et tu as fait de la peine à Mme Spitz.
->fin

=== mauvaise_fin ===
- MSG;B;4.0;Vous dites sa parceque les adultes disent des choses bizard sur vous aussi ?
[Répondre]Ce ne sont pas tes affaires, arrête de faire perdre leurs temps aux grandes personnes.
->END
[Ne pas répondre]
->END

=== bonne_fin ===
- MSG;B;5.5;Désolé monsieur, je vais arrêté de faire sa.

->END

=== fin ===
{ mechant == 1:
    -> mauvaise_fin
    - else:
    -> bonne_fin
}

->END