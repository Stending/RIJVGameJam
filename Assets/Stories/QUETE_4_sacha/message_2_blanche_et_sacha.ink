* [Bonjour] MSG;A;15.0;Bonjour
-> bonjour

=== bonjour ===
- MSG;A;3.0;Je suis désolé pour les msg madame. Je faisais ça juste pour plaisanter 
* [Continuer] MSG;A;10.0;
-> continuer

=== continuer ===
- MSG;A;3.0;Je pensai pas, que ça vous blesseré.
* [Continuer] MSG;A.10.0; si je pouvai revenir en arrière je le ferai pa
->continuer2

=== continuer2 ===
- MSG;A;3.0;Je suis vrément désolé...
- MSG;B;8.0;Le problème c'est qu'on ne peux pas revenir en arrière, mais il est possible de se racheter.
- MSG;B;5.0;Ta mami m'a dis qu'elle était plutôt dessus de ce genre de comportement.

* [Mami ?] Ma mami ? Comment vous arrivez à lui parler ?
-> continuer3

=== continuer3 ===
- MSG;B;5.0;Certaines personnes arrivent à parler avec les morts, mais on les appelle des sorcières, non ?
* [Demander] MSG;A;10.0;Est-ce que vous pensez que je pourrais lui parler ?
->jepenseoui

=== jepenseoui ===
- MSG;A;3.0;Oui, bien sur, demande à tes parents si tu peux passer chez moi et on essayera de lui parler. Tes excuses sont sincères je pense qu'on peux être de nouveau de bon voisin
* [Remercier] Merci grand-mère
-> END