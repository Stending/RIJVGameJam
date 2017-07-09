MSG;B;3.0;Bonjour,
 Je m'appelle Vanessa et je suis étudiante en troisième année de droit. On a emmenagé avant-hier avec ma colocataire Tasha et je suis votre nouvelle voisine,
 J'espère qu'on pourra vite se rencontrer 🌸🌺🌼💎
 
 Ps: J'ai récuperé votre numéro grâce à la gardienne, j'espère que ça ne pose pas de soucis.

* [Bienvenue]MSG;A;3.0;Hey, bienvenue.
-> welcome
* [Ne pas répondre] 
-> paswelcome

=== welcome ===
- MSG;B;2.0;Hey, tu es le premier à répondre à mon message, en réalité je ne suis pas sur d'avoir beaucoup de succès mais je voulais innover, je connais personne dans cette ville, même ma nouvelle coloc je viens juste de la rencontrer.
* [J'espère que tu vas t'adapter]MSG;A;2.0;J'espère que ça va bien se passer, j'espère que tous le monde va te répondre :)
-> ahmerde
* [C'est déstabilisant]MSG;A;3.0;C'est plutôt déstabilisant comme présentation, mais au moins ça change de voir les gens passer sans même connaitre leurs prénoms.
-> ahcool

=== paswelcome ===
- MSG;B;2.5;Hey, y a l'air d'y avoir suretout des familles et des vieux dans cette immeuble quand j'ai demandé s'il y avait des jeunes on m'a dit qu'il y avait toi.
* [Pas si jeune] MSG;A;3.5;J'ai trente ans, je suis pas sur d'être aussi jeune que toi.
-> stopbaching
* [Ne pas répondre]
-> END

=== ahmerde ===
- MSG;B;2.0;Ah merde, tu penses qu'on va pas me répondre ?
* [Plaisanter] MSG;A;3.0;Baaaaah rien n'est moins sur :P
->ahcool
* [Pas Blanche] MSG;A;3.0;Pas sûr que la femme dans l'appartement en bas de chez moi le fasse. Elle est sympa, faut la connaitre, je suis pas sur que ta présentation lui plaise, mais je me trompe peut-être.
->ahcool

=== ahcool ===
- MSG;B;4.0;Bon je te laisse, j'ai promis à ma colloc de lui faire découvrir Steven Univers
* [Steven Universe] MSG;A;2.0;OMG, tu es fan de Steven Universe ?
->stevenuniverse

=== stopbaching ===
- Lol, effectivement je cherche des paires pas un père xD
* :D
->ahcool
* [Pas drôle] Ok, je pense que je pense que l'houmour n'est pas ton point fort :P
->ahcool

=== stevenuniverse ===
- MSG;B;2.0;Oui, si j'étais plus jeune et plus opé sur la couture, je pense que mon cosplay de Garnett aurait déjà sa place dans mon dressing
* [Déguisement] Je comprend ;)
->cosplay
* [Steven Univers] Je suis fan aussi :D
->stevenuniverse

=== cosplay ===
- MSG;B;5.0;Tu kiff le cosplay aussi ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag
* [Eluder] MSG;A;3.0;J'aime surtout Steven Universe
->stevenuniverse2

=== stevenuniverse2 ====
- MSG;B;2.0;Sur, t'avais l'air de vouloir parler cosplay, non ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag

=== drag ===
- MSG;B;7.0;Vas-y je te jugerais pas, no problemos.
* [Ok] MSG;A;10.0;Bah en fait, je suis drag queen.
->drag2

=== drag2 ===
-  MSG;B;2.0;Hey, mais c'est trop cool, tu te produit où ? Je pourrais venir une fois ? Steplait
* [Oui bien sur] MSG;A;3.0;Bah j'ai une spectacle ce soir tu as qu'à venir avec ta coloc :)
->bonnefin
* [Je sais pas trop] MSG;A;3.0;Je sais pas trop
->bonnefin2

=== bonnefin2 ====
- MSG;A;4.0;Alleeeeeez
- MGS;B;3.0;Ok ça roule, j'ai un spectacle ce soir? tu pourras venir si tu veux ;)
->END

=== bonnefin ====
- MSG;B;3.0;Trop bien, merci à ce soir ;)
->END