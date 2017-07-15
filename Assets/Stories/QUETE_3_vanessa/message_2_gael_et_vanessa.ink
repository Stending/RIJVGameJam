* [Salut] MSG;A;3.0;Salut
-> welcome

=== welcome ===
- MSG;B;3.0;Hey, tout va bien ?
* [Oui] MSG;A;3.0;Oui, merci de m'avoir invitée à ton spectacle hier soir, c'était cool :D
-> acool
* [Pas vraiment] MSG;A;5.0;Pas vraiment, je dois trouver un stage. Ca fait déjà deux mois que je cherche mais j'ai rarement des réponses... et quand je vais en entretien ça se passe pas trop mal, mais on me rapelle jamais.
-> amerde

=== acool ===
- MSG;B;3.0;De rien, tu es bien rentrée, je suis désolé de pas avoir pu te raccompagner mais on a l'habitude d'aller boire un verre ensemble à la fin du spectacle
* [Retour pas évident] MSG;A;5.0;Je suis tombée sur un groupe de relous qui pense qu'il y a des tigresses en Afrique, mais t'inquiète pas pour moi (même si ça me soule ce genre de situation haha)
->harcelement
* [Pas de soucis] MSG;A;3.0;Je suis rentrée sans problème ne t'inquiète pas
->acool2

=== acool2 ===
- MSG;B;3.0;Tant mieux, c'était très sympa que tu sois venue ! Sinon les études ça avance ?
* [Difficulté] MSG;A;5.0;Les études en elles-mêmes ça va mais je n'arrive pas à trouver de stage, mon CV plaît et les entretiens se passent bien mais on ne me rapelle jamais.
->amerde
* [Ça va] MSG;A;3.0;Ça se passe très bien dans l'ensemble, ça change de la L3 de droit, là j'ai l'impression d'avoir vraiment trouvé ma voie.
->acouche

=== harcelement ===
- MSG;B;3.0;Je suis désolé, ça a dû être chiant, j'aurais dû te raccompagner
* [Pas sérieux] MSG;A;5.0;Avec tes pouvoirs de magical girl c'est sûr que ça n'aurait rien eu à voir :)
->acool23
* [Sérieux] MSG;A;3.0;Je ne sais pas, je ne pense pas qu'une Drag Queen soit plus à l'abri que moi pour ce genre de chose...
->harcelement2

=== harcelement2 ===
- MSG;B;3.0; C'est sûr...
* [Désolée] MSG;A;5.0;Désolée, je ne voulais pas parler de choses aussi graves, c'est évident qu'avec tes pouvoirs de magical girl personne ne t'approche <3
->acool23

=== acool23 ===
- MSG;B;3.0;Lol, en tout cas, c'était très sympa que tu sois venue, sinon les études ça avance ?
* [Difficulté] MSG;A;5.0;Les études en elle-même ça va mais je n'arrive pas à trouver de stage, mon CV plaît et les entretiens se passent bien mais on ne me rapelle jamais.
->amerde
* [Ça va] MSG;A;3.0;Ça se passe très bien dans l'ensemble, ça change de la L3 de droit, là j'ai l'impression d'avoir vraiment trouvé ma voie.
->acouche

=== acouche ===
- MSG;B;3.0;Ça c'est vraiment cool, j'aurais bien voulu avoir un travail qui me plaise, heureusement pour compenser j'ai mon travail d'artiste ;)
* [Difficulté] MSG;A;5.0;Après c'est pas tous rose, ma recherche de stage ne se passe pas comme je l'espérais, dans l'ensemble mon CV plait mais on me rapelle jamais après les entretiens.
-> amerde
* [Ne pas répondre]MSG;A;6.0;
-> autrefinal2

=== amerde===
- MSG;B;3.0;C'est chiant ça, tu penses que c'est dû à quoi ?
* [Cheveux] MSG;A;5.0;La coupe afro n'est pas très bien vue en général, et puis mon look dans le droit ça a toujours été plutôt vu comme quelque chose de transgressif.
->jepenseoui
* [Aisance à l'oral] MSG;A;3.0;Je ne suis peut-être pas très convainquante à l'oral.
->jepensepas

=== jepensepas ===
- MSG;B;3.0;Je suis pas sûr que ce soit ça
* [Aider] MSG;A;5.0;Tu penses que tu peux m'aider ? Tu connais peut-être des gens qui bossent dans le droit
->final
* [Ne pas répondre]MSG;A;5.0;
->autrefinal

=== jepenseoui ===
- MSG;B;2.0;Ah merde, je comprends, j'ai un peu le même problème avec ma deuxième vie de Drag Queen si les gens savaient au boulot, je tiendrais pas très longtemps là-bas...
* [Demander de l'aide] MSG;A;5.0;Tu penses que tu peux m'aider ? Tu connais peut être des gens qui bossent dans le droit.
->final
* [Ne pas répondre]MSG;A;5.0;
->autrefinal

=== final ===
- MSG;B;2.0;J'en connais pas personnellement, mais je crois que la femme qui vit dans l'appartement au dessous du tiens bosse dans ce domaine, je t'envoie son numéro.
* [Merci] Merci, t'es un amour <3
->END

=== autrefinal ===
- MSG;B;3.0;Je dois filer au travail n'hésites pas à me contacter si tu as besoin.
* [Demander de l'aide] MSG;A;5.0;Tu penses que tu peux m'aider ? Tu connais peut être des gens qui bossent dans le droit ?
->final
* [Ne pas répondre]
->END

=== autrefinal2 ===
- MSG;B;2.5;Je dois filer au travail n'hésites pas à me contacter si tu as besoin.
* [Stage] MSG;A;5.0;Je n'arrive pas à trouver un stage, est-ce que tu penses que tu peux m'aider ? Tu connais peut être des gens qui bossent dans le droit ?
->final
* [Ne pas répondre]
->END