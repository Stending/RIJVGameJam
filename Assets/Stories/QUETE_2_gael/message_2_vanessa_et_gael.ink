MSG;B;3.0;Bonjour,
 Je m'appelle Vanessa et je suis étudiante en troisième année de droit. On a emménagé avant-hier avec ma colocataire Tasha et je suis votre nouvelle voisine, on s'est peut-être déjà croisé•es ou parlé•es mais du coup je tenais à me présenter. 
 J'espère qu'on pourra vite se rencontrer :3
 
 Ps: J'ai récupéré votre numéro grâce à la gardienne, j'espère que ça ne pose pas de soucis.

* [Bienvenue]MSG;A;3.0;Hey, bienvenue.
-> welcome
* [Ne pas répondre]
-> paswelcome

=== welcome ===
- MSG;B;2.0;Hey, tu es le premier à répondre à mon message, en réalité je ne suis pas sur d'avoir beaucoup de succès mais je voulais innover, je connais personne dans cette ville, même ma nouvelle coloc je viens juste de la rencontrer.
* [J'espère que tu vas t'adapter]MSG;A;2.0;J'espère que ça va bien se passer, j'espère que tout le monde va te répondre :)
-> ahmerde
* [C'est déstabilisant]MSG;A;3.0;C'est plutôt déstabilisant comme présentation, mais au moins ça change de voir les gens passer sans même connaitre leurs prénoms.
-> ahcool

=== paswelcome ===
- MSG;B;2.5;Hey, y a l'air d'y avoir surtout des familles et des vieux dans cette immeuble quand j'ai demandé s'il y avait des jeunes on m'a dit qu'il y avait toi.
* [Pas si jeune] MSG;A;3.5;J'ai trente ans, je suis pas sur d'être aussi jeune que toi.
-> stopbaching
* [Enfants] Il y a aussi des enfants, tu les oublies !
-> welcome

=== stopbaching ===
-MSG;B;2.0;Lol, effectivement je cherche des paires pas un père xD
* :D
->ahcool
* [Pas drôle] Ok, je pense que je pense que l'humour n'est pas ton point fort :P
->ahcool

=== ahmerde ===
- MSG;B;2.0;Ah merde, tu penses qu'on va pas me répondre ?
* [Plaisanter] MSG;A;3.0;Baaaaah rien n'est moins sur :P
->ahcool
* [Pas Blanche] MSG;A;3.0;Je ne pense pas que la dame dans l'appartement en bas de chez moi le fasse. Elle est sympa, faut la connaitre, mais je suis pas sûr que ta présentation lui plaise.
->ahcool

=== ahcool ===
- MSG;B;4.0;Bon je te laisse, j'ai promis à ma colloc de lui faire découvrir Steven Univers
* [Steven Universe] MSG;A;2.0;OMG, tu es fan de Steven Universe ?
->stevenuniverse

=== stevenuniverse ===
- MSG;B;2.0;Oui, si j'étais plus jeune et plus opé sur la couture, je pense que mon cosplay de Garnett aurait déjà sa place dans mon dressing
* [Déguisement] Je comprends ;)
->cosplay2
* [Steven Univers] Je suis fan aussi :D
->cosplay

=== cosplay ===
- MSG;B;5.0;C'est quoi ton perso préféré ?
* [Pearl] MSG;A;3.0;Pearl bien évidemment :D
->cosplay3
* [Steven] MSG;A;3.0;Steven ;)
->cosplay3

=== cosplay3 ===
- MSG;B;5.0;Et du coup tu n'as jamais penser à t'en faire des déguisements ? :D
* [Oui] MSG;A;3.0;Bien sûr que si
->cosplay4
* [C'est pas pour les hommes] MSG;A;3.0;Bien sûr que si
->cosplay4

=== cosplay4 ===
- MSG;B;5.0;Donc tu kiff le cosplay aussi ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag
* [Eluder] MSG;A;3.0;Ah c'est compliqué
->stevenuniverse3

=== cosplay2 ===
- MSG;B;5.0;Tu kiff le cosplay aussi ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag
* [Eluder] MSG;A;3.0;J'aime surtout Steven Universe
->stevenuniverse2

=== stevenuniverse2 ====
- MSG;B;2.0;Sûr, t'avais l'air de vouloir parler cosplay, non ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag

=== stevenuniverse3 ====
- MSG;B;6.0;Tu peux m'en parler, promis je ne te jugerais pas
* [Ok] MSG;A;8.0;Bah en fait, je suis drag queen.
->drag2

=== drag ===
- MSG;B;6.0;Vas-y je te jugerais pas, no problemo.
* [Ok] MSG;A;8.0;Bah en fait, je suis une drag queen.
->drag2

=== drag2 ===
-  MSG;B;2.0;Hey, mais c'est trop cool, tu te produits où ? Je pourrais venir une fois ? Steplait
* [Oui bien sur] MSG;A;3.0;Bah j'ai un spectacle ce soir tu as qu'à venir avec ta coloc :)
->bonnefin
* [Je sais pas trop] MSG;A;3.0;Je sais pas trop
->bonnefin2

=== bonnefin2 ====
- MSG;B;4.0;Alleeeeeez
- MSG;A;3.0;Ok ça roule, j'ai un spectacle ce soir? Tu pourras venir si tu veux ;)
->END

=== bonnefin ====
- MSG;B;3.0;Trop bien, merci à ce soir ;)
->END