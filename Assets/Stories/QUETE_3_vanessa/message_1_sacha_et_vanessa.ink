- MSG;A;5.0;Bonjour Mme,
J'ai eu votre numéro par votre voisin Gaël. Je suis étudiante en L3 de droit et je suis à la recherche d'un stage. J'ai un peu de difficulté pour en trouver un et il m'a dit que vous auriez peut être des contacts qui pourrait m'aider.
Bien à vous,
Vanessa

- MSG;B;4.0;Salut, je pense qu'il s'est trompé parceke je suis son fils Sacha.

* [Excuse]MSG;A;2.0;Ah pardon
-> apardon
* [Ne pas répondre] 
-> pasrep

=== apardon ===
- MSG;B;3.0;Pas 2 soucis, je lui dis quoi du coup ?
* [Expliquer] MSG;A;4.0;Je cherche un stage en droit, de préférence dans une association
-> amnesty

=== pasrep ===
- MSG;B;2.0;Mais je peu lui donner ton msg, tu a besoin de koi ?
* [Ok] MSG;A;4.0;Je cherche un stage en droit, de préférence dans une association
->amnesty

=== amnesty ===
- MSG;B;2.5;Jcrois kel à une copine qui travail à amnety jsais pu koi, je lui demande ;)
* [Merci] MERCI :D
-> fin

=== fin ===
- MSG;B;4.0; ;)
->END