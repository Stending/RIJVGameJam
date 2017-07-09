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
- MSG;B;2.5;Mais c'est une sorcière, elle a plein de chat, et de plantes pour ampoisonner les enfants. Mon copin Jason m'a dit qu'une fois, il l'avait vu manger de la viande complètement cru !
* [Expliquez] MSG;A;10.0;Tu sais ce son juste des plaisanteries d'enfants, tu ne devrais pas faire ce genre de chose, ça peut faire du mal aux gens...
->fin

* [Sermonner] MSG;A;7.0;Il est temps de grandir Sacha, tu devrais arrêter de croire ce que les autres enfants te racontes, et prendre le temps de réfléchir, tu sais bien que les sorcières n'existent pas et tu as fait de la peine à Mme Spitz
->fin

=== mauvaise_fin ===
- MSG;B;4.0;Vous dites ça parce que les adultes disent aussi des choses bizarres sur vous aussi, monsieur ?

->END

=== bonne_fin ===
- MSG;B;5.5;Je suis désolé monsieur, je vais arrêter de faire ça.

->END

=== fin ===
{ mechant == 1:
    -> mauvaise_fin
    - else:
    -> bonne_fin
}

->END
