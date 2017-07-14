* [Bonjour] MSG;A;10.0;Bonjour
-> bonjour

=== bonjour ===
- MSG;A;4.0;Je suis désolé pour les msg madame. Je faisais sa juste pour plaisanter 
* [Continuer] MSG;A;7.0;
-> continuer

=== continuer ===
- MSG;A;4.0;Je pensai pas ke sa vous blesseré.
* [Continuer] MSG;A.4.0; si je pouvai revenir en arrière je le ferai pa
->reponse

=== reponse ===
- MSG;A;7.0;Je suis vrément désolé...
- MSG;B;4.0;Le problème c'est qu'on ne peux pas revenir en arrière, mais il est possible de se racheter
* [Comment ?] Comment ?
-> comment

=== comment ===
- MSG;B;2.0;Je ne sais pas encore, déjà tes excuses étaient un bon début, on m'a dit que tu aimais l'espace, c'est vrai ?
- MSG;B;2.0;C'est une bien belle passion.
* [Comment vous savez ?] MSG;A;3.0;Comment vous savez ?
-> comment2
* [Oui c'est vrai] MSG;A;3.0;Oui c vrai...
-> espace

=== espace ===
- MSG;B;3.0;On se sent tout petit face à l'immensité de l'espace
* [Petit] MSG;A;3.0;Je me sens déjà petit, personne ne me fais jamais confiance...
-> espace2

=== espace2 ===
- MSG;B;3.0;Je suis sur que ta grand-mère, avait confiance en toi
* [Comment vous savez ?] MSG;A;3.0;Comment vous savez ?
-> comment2bis

=== comment2 ===
- MSG;B;3.0;Et bien comme tu le sais j'ai des sortes de super-pouvoirs, je devine beaucoup de choses...
* [Comment ?] MSG;A;3.0;Comment vous faites ça ?
-> continuer3
* [Grand-mère] MSG;A;3.0;Alors vous savez pr ma mami ?
-> comment3

=== comment2bis ===
- MSG;B;3.0;Et bien comme tu le sais j'ai des sortes de super-pouvoirs, je devine beaucoup de choses...
* [Comment ?] MSG;A;3.0;Comment vous faites ça ?
-> continuer3

=== comment3 ===
- MSG;B;3.0;Oui, je te l'ai dit je devine et entend beaucoup de chose
* [SORCIÈRE !] MSG;A;3.0;JE LE SAVEZ VOUS ÊTES VRAIMENT UNE SORCIÈRE !
-> sorciere
* [Espace] MSG;A;3.0;Vous savait ou elle es parti ?
-> continuer4

=== sorciere ===
- MSG;B;5.0;Ta mami m'a dis qu'elle était plutôt déçu de ce genre de comportement.

* [Mami ?] Ma mami ?
-> continuer3

=== continuer3 ===
- MSG;B;5.0;Certaines personnes arrivent à parler avec les personnes qui sont parties, mais on les appelle des sorcières, non ?
* [Demander] MSG;A;5.0;Estceque vous savait ou elle est ?
->continuer4

=== continuer4 ===
- MSG;B;5.0;Dans l'espace mon garçon, je sais pas si on peut la contacter de là-bas, c'est si vaste et toutes ces lumières doivent dérouter les fantômes, tu ne penses pas ?
* [Découragé] Vous avez réson c bcp trop grand...
->continuer4bis
* [Demander] MSG;A;5.0;Esce ke vous penser que je pourrez au moins essayé ?
->jepenseoui
* [SORCIÈRE !] MSG;A;5.0.0;JE LE SAVEZ VOUS ÊTES VRAIMENT UNE SORCIÈRE !
-> sorciere

=== continuer4bis ===
- MSG;B;5.0;Il y a aussi le royaume des rêves qui peut-être une bonne alternative, pour ceux qui ont le mal de l'espace
* [Demander] MSG;A;5.0;Vous pourrez me montrer ?
->jepenseoui

=== jepenseoui ===
- MSG;B;3.0;Oui, bien sur, juste demande à tes parents si tu peux passer chez moi et on essayera de lui parler. Tes excuses sont sincères je pense qu'on peux être de nouveau de bon voisin
* [Remercier] Merci grand-mère
-> END