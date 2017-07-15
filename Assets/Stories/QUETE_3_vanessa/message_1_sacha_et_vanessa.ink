VAR conseil = 0
VAR maman = 0

- MSG;A;5.0;Bonjour Mme,
J'ai eu votre numéro par votre voisin Gaël. Je suis étudiante en L3 de droit et je suis à la recherche d'un stage. J'ai un peu de difficulté pour en trouver un et il m'a dit que vous auriez peut être des contacts qui pourrait m'aider.
Bien à vous,
Vanessa

- MSG;B;4.0;slt je pense qu'il s'est trompé parceke je suis son fils sacha.

* [Excuse]MSG;A;2.0;Ah pardon
-> apardon
* [Ne pas répondre]
-> pasrep

=== apardon ===
- MSG;B;3.0;Pas 2 soucis, tu é la nouvel voisine ?
~ conseil = 1
* [Oui]MSG;A;4.0;Oui
-> apardon2

=== apardon2 ===
- MSG;B;3.0;Jé entendu l'aut jour de la musik de ché toi, tu joue d1 instrument ?
* [Oui] MSG;A;4.0;Oui, je joue de la basse
-> apardon3

=== apardon32 ===
- MSG;B;3.0;Tpeux m'aprendre ?
* [Oui] MSG;A;4.0;Avec plaisir
-> pasrep3
* [Échange] MSG;A;4.0;Avec plaisir, mais en échange tu peux donner un message de ma part à ta mère ?
-> pasrep2

=== pasrep3 ===
- MSG;A;2.5;Tu peux me rendre un service ?
- MSG;B;2.0;oué biensur, ta besoin de koi ?
* [Demande]MSG;A;4.0;Je cherche un stage en droit, de préférence dans une association
->amnesty3

=== apardonbis ===
- MSG;B;3.0;Tpeux m'aprendre ?
* [Oui] MSG;A;4.0;Avec plaisir
MSG;B;3.0;Super, à plus alors :)
-> END

=== pasrep2 ===
- MSG;B;2.0;oué biensur, ta besoin de koi ?
- MSG;A;4.0;Je cherche un stage en droit, de préférence dans une association
->amnesty3

=== pasrep ===
- MSG;B;2.0;Mais je peu lui donner ton msg, tu a besoin de koi ?
* [Ok]MSG;A;4.0;Je cherche un stage en droit, de préférence dans une association
->amnesty3

=== amnesty3 ===
- MSG;B;2.5;Jcrois kel à une copine qui travail à amnesty jsais pu koi, je lui demande ;)
~ maman = 1
* [Merci]MSG;A;5.5;MERCI :D
->fin

=== fin2 ===
- MSG;B;5.5;;)))))
->END

=== fin ===
{ conseil == 1:
    -> fin2
    - else:
    -> apardon
}

->END

=== apardon3 ===
{ maman == 1:
    -> apardonbis
    - else:
    -> apardon32
}

->END