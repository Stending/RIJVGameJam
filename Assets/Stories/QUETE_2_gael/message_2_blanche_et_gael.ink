* [Prendre de ses nouvelles] MSG;A;8.0;Bonjour Blanche, on m'a dit que nous avions une nouvelle voisine, vous voulez venir la rencontrer avec moi ?
-> deprime

=== deprime ===
- MSG;B;3.0;Bonjour, Gaël, je préfère ne pas faire ça aujourd'hui

* [Ne pas insister] MSG;A;5.0;Très bien Blanche, dites-moi si vous avez besoin de quelques choses.
* [Insister] MSG;A;8.0;Allez Blanche ça vous fera du bien de sortir de chez vous.
->deprime2

=== deprime2 ===
- MSG;B;3.0;Mais vous devriez aller la voir seul, vous êtes jeune, elle aussi, vous aurez plus de choses à partager ensemble sans que je sois là.

* [Ne pas insister] MSG;A;5.0;Très bien Blanche, dites-moi si vous avez besoin de quelques choses.
* [Insister] MSG;A;8.0;Mais ce ne sera pas aussi bien sans vous ;)
->relou

=== relou ===
- MSG;B;3.0;Non Gaël, vous êtes gentil de vous inquiéter pour moi, mais je n'ai pas envie de sortir.
* [Ne pas insister] MSG;A;3.0;Très bien Blanche, dites-moi si vous avez besoin de quelques choses.
->smsfinal
* [Insister plus] MSG;A;4.0;Allez Blanche !
->gros_relou

=== gros_relou ===
- MSG;B;3.0;Je n'ai pas envie, Gaël, arrêtez tous de suite s'il vous plaît, vous me fatiguez
* [S'excusez] MSG;A;2.5;Désolé Blanche, bonne soirée à vous
->END
* [Ne pas répondre]
->END

=== smsfinal ===
- MSG;B;3.0;Bonne soirée, j'espère que vous viendrez à la maison si vous avez le temps avec votre travail ;)
->END