* [Prendre de ces nouvelles] MSG;A;8.0;Bonjour Blanche, on m'a dit que nous avions une nouvelle voisine, vous voulez venir la rencontrer avec moi ?
-> deprime

=== deprime ===
- MSG;B;3.0;Bonjour, Gaël, je préfère ne pas faire ça aujourd'hui

* [Ne pas insister] MSG;A;5.0;Très bien Blanche, dites-moi si vous avez besoin de quelques choses.
* [Insister] MSG;A;8.0;Allez Blanche ça vous fera du bien de sortir de chez vous.
->relou

=== relou ===
- MSG;B;3.0;Non Gaël, vous êtes gentil de vous inquiéter pour moi, mais je n'ai pas envie de sortir.
* [Ne pas insister] MSG;A;3.0;Très bien Blanche, dites-moi si vous avez besoin de quelques choses.
->smsfinal
* [Insister plus] MSG;A;4.0;Allez Blanche !
->gros_relou

=== gros_relou ===
- MSG;B;3.0;Ecoutez je n'ai pas envie, vous me fatiguez 😡
->END

=== smsfinal ===
- MSG;B;3.0;Bonne soirée, j'espère que vous viendrez à la maison si vous avez le temps avec votre travail 😉
->END