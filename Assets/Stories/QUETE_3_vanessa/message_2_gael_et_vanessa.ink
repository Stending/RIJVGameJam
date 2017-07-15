VAR harcel = 0
VAR boulot = 0



* [Salut] MSG;A;3.0;Salut
-> welcome

=== welcome ===
- MSG;B;3.0;Hey, tout va bien ?
* [Oui] MSG;A;4.0;Oui, merci de m'avoir invitée à ton spectacle hier soir, c'était cool :D
-> acool
* [Pas vraiment] MSG;A;5.0;Pas vraiment, je dois trouver un stage, ça fait déjà deux mois que je cherche mais j'ai rarement des réponses, et quand je vais en entretien ça se passe pas trop mal, mais on me rapelle jamais.
~ boulot = 1
-> amerde

=== acool ===
- MSG;B;3.5;De rien, tu es bien rentrée ? Je suis désolé de pas avoir pu te raccompagner mais on a l'habitude d'aller boire un verre ensemble à la fin du spectacle
* [Retour pas évident] MSG;A;5.0;Je suis tombée sur un groupe de relous qui pensent qu'il y a des tigresses en Afrique et qui visiblement pensait que j'en suis une, mais t'inquiète pas pour moi (même si ça bon me soule trop ce genre de situation)
~ harcel = 1
->harcelement
* [Pas de soucis] MSG;A;3.0;Je suis rentrée sans problème ne t'inquiète pas
->acool2

=== acool2 ===
- MSG;B;3.0;Tant mieux, c'était très sympa que tu soit venue, sinon les études ça avance ?
* [Difficulté] MSG;A;5.0;Les études en elle-même ça va mais je n'arrive pas à trouver de stage, mon CV plait et les entretiens se passe bien mais on ne me rappelle jamais.
->amerde
* [Ça va] MSG;A;3.0;Ça se passe très bien dans l'ensemble, ça change de la L3 de droit, là j'ai l'impression d'avoir vraiment trouver ma voie.
->acouche

=== harcelement ===
- MSG;B;3.0;Je suis désolé, ça a du être chiant, j'aurais du te racompagner
* [Pas sérieux] MSG;A;5.0;Avec tes pouvoirs de magical girl c'est sur que ça n'aurait rien eu a voir :)
->magic

* [Sérieux] MSG;A;5.0;Je ne sais pas, je ne pense pas qu'une drag queen soit plus à l'abri que moi pour ce genre de chose...
->pasdesoucis

=== acool234 ===
- MSG;B;3.0;Lol, en tout cas, c'était très sympa que tu soit venue.
MSG;A;3.5;Btw, oublie pas que je fais ma crémaillière demain, il faut absolument que tu viennes :3
MSG;B;3.5;Je serais là compte sur moi
MSG;A;3.5;<3
->END

=== harcelement2 ===
- MSG;B;3.0; C'est sûr...
* [Désolée] MSG;A;5.0;Désolée, je ne voulais pas parler de chose aussi grave, c'est évident qu'avec tes pouvoirs de magical girl personne ne t'approche <3
->acool23

=== harcelement23 ===
- MSG;B;3.0; C'est sûr...
* [Désolée] MSG;A;5.0;Désolée, je ne voulais pas parler de chose aussi grave, c'est évident qu'avec tes pouvoirs de magical girl personne ne t'approche <3
MSG;A;3.5;Haha, c'est sûr, on reparlera ça une autre fois si tu veux, là je dois filer, à plus tard ;)
->END

=== harcelementbis ===
- MSG;B;3.0; C'est sûr...
* [Désolée] MSG;A;5.0;Désolée, je ne voulais pas parler de chose aussi grave, c'est évident qu'avec tes pouvoirs de magical girl personne ne t'approche <3
MSG;B;2.5;Pas de soucis, on reparlera de ça une autre fois si tu veux, là je dois filer, à plus tard ;)
->END

=== acool23 ===
- MSG;B;3.0;Lol, en tout cas, s'était très sympa que tu sois venue, sinon les études ça avance ?
* [Difficulté] MSG;A;5.0;Les études en elles-mêmes ça va mais je n'arrive pas à trouver de stage, mon CV plait et les entretiens se passe bien mais on ne me rappelle jamais.
->amerde
* [Ça va] MSG;A;3.0;Ça se passe très bien dans l'ensemble, ça change de la L3 de droit, là j'ai l'impression d'avoir vraiment trouver ma voie.
->acouche

=== acouche ===
- MSG;B;3.0;Ça c'est vraiment cool, j'aurais bien voulu avoir un travail qui me plaise, heureusement pour compenser j'ai mon travail d'artiste ;)
* [Difficulté] MSG;A;5.0;Après c'est pas tout rose, ma recherche de stage ne se passe pas comme je l'espérais, dans l'ensemble mon CV plait mais on me rappelle jamais après les entretiens.
-> amerde
* [Ne pas répondre]
-> autrefinal2

=== amerde===
- MSG;B;3.0;C'est chiant ça, tu penses que c'est dû à quoi ?
~ boulot = 1
* [Cheveux] MSG;A;5.0;La coupe afro n'est pas très bien vue en général, et puis mon look dans le droit ça à toujours été plutôt vu comme quelque chose de transgressif.
->jepenseoui
* [Aisance à l'oral] MSG;A;3.0;Je ne suis peut-être pas très convainquante à l'oral.
->jepensepas

=== jepensepas ===
- MSG;B;3.0;Je suis pas sur que ce soit ça, y a qu'à te connaitre un peu pour s'en rendre compte :)
~ boulot = 1
* [Aider] MSG;A;5.0;Du coup j'ai besoin d'aide pour ma recherche, tu penses que tu peux m'aider ?
->fifin
* [Ne pas répondre]
->autrefinal

=== jepenseoui ===
- MSG;B;2.0;Ah merde, je comprends, j'ai un peu le même problème avec ma deuxième vie de drag si les gens savaient au boulot, je tiendrais pas très longtemps...
* [Demander de l'aide]MSG;A;5.0;Tu penses que tu peux m'aider ? Tu connais peut-être des gens qui bossent dans le droit ?
->fifin
* [Ne pas répondre]
->autrefinal

=== final23 ===
- MSG;B;2.0;J'en connais pas personnellement, mais je crois que la femme qui vit dans l'appartement au dessous du tien bosse dans ce domaine, je t'envoie son numéro.
* [Merci] Merci, t'es un amour <3
-MSG;B;2.0;Merci à toi pour hier :)
-MSG;A;2.0;<3
->acool25

=== final ===
- MSG;B;2.0;J'en connais pas personnellement, mais je crois que la femme qui vit dans l'appartement au dessous du tien bosse dans ce domaine, je t'envoie son numéro.
* [Merci] MSG;A;3.5;Merci, t'es un amour <3
MSG;B;3.5;De rien darling ;)
MSG;A;3.5;Oublie pas que je fais ma crémaillière demain, il faut absolument que tu viennes :3
MSG;B;3.5;Je serais là compte sur moi
->END

=== acool25 ===
- MSG;B;3.0;Tu es bien rentrée, je suis désolé de pas avoir pu te racompagner mais on a l'habitude d'aller boire un verre ensemble à la fin du spectacle
* [Retour pas évident] MSG;A;5.0;Je suis tombée sur un groupe de relous qui pensent qu'il y a des tigresses en Afrique, mais t'inquiète pas pour moi (même si ça me soule ce genre de situation haha)
->harcelement
* [Pas de soucis] MSG;A;3.0;Je suis rentrée sans problème ne t'inquiète pas
->ok
=== ok ===
- MSG;B;3.0;Ok j'y vais alors, à plus tard ;)
->END

=== autrefinal ===
- MSG;B;3.0;Je dois filer au travail n'hésite pas à me contacter si tu as besoin.
* [Demander de l'aide] MSG;A;5.0;Tu penses que tu peux m'aider ? Tu connais peut être des gens qui bossent dans le droit ?
->fifin
* [Ne pas répondre]
->autrefinal3

=== autrefinal2 ===
- MSG;B;2.5;Je dois filer au travail n'hésites pas à me contacter si tu as besoin.
* [Stage] MSG;A;5.0;Je n'arrive pas à trouver un stage, est-ce que tu penses que tu peux m'aider ? Tu connais peut être des gens qui bossent dans le droit ?
->fifin
* [Ne pas répondre]
->END

=== autrefinal3 ===
- MSG;B;2.5;xoxoxo ;)
* [Stage] MSG;A;5.0;Je n'arrive pas à trouver un stage, est-ce que tu penses que tu peux m'aider ? Tu connais peut être des gens qui bossent dans le droit ?
->fifin



=== fifin ===
{ harcel == 1:
    -> final
    - else:
    -> final23
}

->END

=== pasdesoucis ===
{ boulot == 1:
    -> harcelement23
    - else:
    -> acool23
}

->END


=== magic ===
{ boulot == 1:
    -> acool234
    - else:
    -> acool23
}

->END