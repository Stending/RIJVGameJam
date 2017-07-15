- MSG;B;3.0;Salut Sacha,
Merci pour hier, grâce à toi et ta maman, j'ai eu un entretien pour aller travailler à Amnesty et je tenais à te remercier. J'ai appris pour ta grand-mère tout à l'heure, toutes mes condoléances si tu as besoin de quelque chose, n'importe quoi, dis-le moi :)

* [Merci]MSG;A;4.5;Jpense pa ke tu puisses fer un truc mais cimer pour ton message
-> merci

=== merci ===
- MSG;B;3.0;Moi non, mais je connnais une vieille femme dans l'immeuble...
* [Pas la sorcière !] MSG;A;3.5;NOOON PAS LA SORCIÈRE ! 
-> calmedown
* [Pas certain] MSG;A;3.0;Jsais pas, je pense kel me déteste m1tenant
-> blanche

=== calmedown ===
- MSG;B;3.0;Hey du calme, c'est juste une vieille dame et si tu crois encore aux sorcières à ton âge c'est chaud
* [Problème] MSG;A;3.0;Jai pas été gentil ac elle l'autre jour et jpense kel me déteste m1tenant
->blanche

=== blanche ===
- MSG;B;2.5;Qu'est ce que tu as fait ?
* [Parler des insultes] MSG;A;7.5;Jlui ai envoyé plusieurs sms d'insultes, j'aimerais bien m'excuzé mé c dificile
-> blanche2
* [Eluder la question] MSG;A;2.5;C'est pas important
-> findeconversation2

=== blanche2 ===
- MSG;B;4.0;L'important c'est de comprendre ses erreurs, je pense qu'elle te pardonnera si c'est sincère et pour le coup ça a l'air de l'être, je t'envoie pas son numéro, je pense que tu l'as déjà ;)
MSG;B;2.0;Courage, tu peux le faire
* [Merci] Merci, a +
->END

=== findeconversation2 ===
- MSG;B;2.5;Ok, en tout cas, si tu penses avoir fait une bêtise, c'est important d'aller s'excuser, si tu commences à ton âge, tu seras peut-être un adulte intéressant une fois grand :P
* [Merci] à plus tard
-> END
* [Ne pas répondre]
->findeconversation3

=== findeconversation3 ===
- MSG;B;2.0;Vraiment ne t'en fais pas, tu peux réparer ton erreur, j'en suis certaine.
* [Merci] Cimer a+
-> END