VAR mechant = 0
* [Salut] MSG;A;3.0;Slt, est ce ke je pe te parler d'un truc ?
-> welcome
* [Ne pas envoyer de message]
-> END

=== welcome ===
- MSG;B;2.0;Ouai bien sûr.
* [Rumeur] MSG;A;6.0;Mes parents on dit que tu sortais avec des garçons, c vrai ? Pk ? C dégueu
-> gay
* [Parler de Blanche]MSG;A;2.5;Je voulais parler ac toi de ce ki c passé avec Mme Spitz.
-> blanche

=== gay ===
- MSG;B;4.0;C'est pas plus dégueue que sortir avec des filles, tu penses pas ?
* [Pas pareil] MSG;A;3.5;C pas pareil
->cpaspareil
* [Pas faux] MSG;A;2.5;Je croit ke je voi ce que tu veux dire...
->findeconversation

=== blanche ===
- MSG;B;2.0; Je t'écoute
* [Remords] Je suis vraiment dsl de ce ke jai fait l'autre jour, je navai pas l'impression de faire du mal à Mme Spitz, pour moi s'été juste des blagues koi, du trolling
-> fin1
* [Ne pas répondre] MSG;A;4.0;
-> fin1

=== findeconversation ===
- MSG;B;2.0;C'est bien prend le temps d'y réfléchir, bon week end ;)
* [Merci] MSG;A;0.0;Merci, à plus tard
->END
* [Parler de Blanche] MSG;A;3.0;Et je voulais parler ac toi de ce ki c passé avec Mme Spitz.
-> blanche

=== findeconversation2 ===
- MSG;B;3.0;Je pense que tu devrais en parler avec elle un jour histoire de remettre les choses à plat, elle est beaucoup plus gentille que tu ne le pense.
* [Merci] à plus tard
-> END
* [Ne pas répondre] MSG;A;4.0;
->findeconversation3

=== cpaspareil ===
- MSG;B;3.0;Écoutes, j'ai vraiment pas envie d'avoir cette conversation avec toi, si tu as des questions demande à tes parents.
~ mechant = 1

* [Parler de Blanche] MSG;A;3.0;Et je voulais parler ac toi de ce ki c passé avec Mme Spitz.
-> blanche

=== findeconversation3 ===
- MSG;B;3.0;Vraiment ne t'en fait pas, tu peux réparer ton erreur, j'en suis certain.
* [Merci] à plus tard
-> END

=== findeconversationbad ===
- MSG;B;3.0;Je pense que tu devrais en parler avec elle un jour histoire de remettre les choses à plat. En générale tu devrais réfléchir à la manière dont tu juges les gens, parfois on ne comprend pas les choses et on se comporte mal avec les autres à cause de ça, essaye de ne pas recommencer ce que tu as fait avec Blanche avec d'autres personnes...
* [Merci] à plus tard
-> END
* [Ne pas répondre] MSG;A;4.0;
->END

=== fin1 ===
{ mechant == 1:
    -> findeconversationbad
    - else:
    -> findeconversation2
}

->END
