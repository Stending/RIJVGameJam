VAR mechant = 0
* [L'engueuler] MSG;A;10.0;On m'a dit que tu envoyais des messages à Mme Spitz, t'es vraiment qu'un petit con. C'est pas une façon de se conduire avec les personnes âgées, si je te chope à refaire ce genre de chose, ça va barder
-> be_bastard
* [La jouer cool] MSG;A;4.0;Bonjour Sacha, j'ai parlé avec Mme Spitz et je pense que ton comportement envers elle était vraiment déplacé
-> be_cool

=== be_bastard ===
- MSG;B;3.0;Bonjour Gaël, je vous ai donné le numéro de mon fils pour que vous parliez avec lui et que vous lui expliquiez le problème quant au comportement qu'il a eu avec Blanche, pas pour l'insulter.
~ mechant = 1

* [S'excuser] MSG;A;2.0;Vous avez raison, navré de m'être emporté
MSG;B;2.5;Très bien, je vous le repasse, mais essayez de ne pas oublier que vous parlez à un enfant.
MSG;A;3.0;Du coup Sacha, j'ai parlé avec Mme Spitz et je pense que ton comportement envers elle était déplacé
->be_cool


=== be_cool ===
- MSG;B;5.5;Mais c une sorcière, elle a plein 2 chats, et 2 plantes pour ampoisonner lé enfants. Mon copin Jason ma di qu'1 fois, il l'avez vu manger de la viande cru !!!!
* [Expliquer] MSG;A;11.0;Tu sais ce sont juste des plaisanteries d'enfant, tu ne devrais pas faire ce genre de choses, ça peut faire de la peine aux gens. Tu devrais te mettre à la place de Mme Spitz, elle est seule chez elle et reçoit plein de messages d'insultes, pour elle ce n'est pas une blague, c'est juste de la haine et du harcèlement...
->fin

* [Sermonner] MSG;A;7.0;Tu devrais arrêter de croire ce que les autres enfants te racontent et prendre le temps de réfléchir. Tu sais très bien que les sorcières n'existent pas et tu fais du mal à Mme Spitz avec ce genre de comportement...
->fin

=== mauvaise_fin ===
- MSG;B;4.0;Vs dites sa parceque les adultes dise des choses bizard sur vous ?
* [Répondre] Ce ne sont pas vraiment tes affaires, Sacha
->END
* [Ne pas répondre]
->END

=== bonne_fin ===
- MSG;B;3.0;Désolé monsieur je vais arrêté de faire sa...

->END

=== fin ===
{ mechant == 1:
    -> mauvaise_fin
    - else:
    -> bonne_fin
}

->END