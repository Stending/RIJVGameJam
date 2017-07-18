MSG;B;10.0;Bonjour,
 Je m'appelle Vanessa et je suis étudiante en troisième année de droit. On a emménagé avant-hier avec ma colocataire Tasha et je suis votre nouvelle voisine. On s'est peut-être déjà croisé•es ou parlé•es mais je tenais à me présenter. 
 J'espère qu'on pourra vite se rencontrer :3
 
 PS : J'ai récupéré votre numéro grâce à la gardienne, j'espère que ça ne pose pas de soucis.

* [Bienvenue]MSG;A;3.0;Hey, bienvenue !
MSG;A;2.0;Je comptais passer te voir dans la journée !
-> welcome
* [Ne pas répondre]
-> paswelcome

=== welcome ===
- MSG;B;2.0;Hey, tu es le premier à répondre à mon message ! En réalité je ne suis pas sûre d'avoir beaucoup de succès mais je voulais innover. Je ne connais personne dans cette ville, pas même ma nouvelle coloc.
* [J'espère que tu vas t'adapter]MSG;A;2.0;J'espère que ça va bien se passer et que tout le monde va te répondre :)
-> ahmerde
* [C'est déstabilisant]MSG;A;3.0;C'est plutôt déstabilisant comme présentations, mais au moins ça change de voir les gens passer sans même connaître leur prénom
-> ahcool

=== paswelcome ===
- MSG;B;2.5;Hey, il a l'air d'y avoir surtout des familles et des vieux dans cette immeuble ! Quand j'ai demandé s'il y avait des jeunes on m'a parlé de toi.
* [Pas si jeune] MSG;A;3.5;J'ai trente ans, je suis pas sûr d'être aussi jeune que toi :)
-> stopbaching
* [Enfants] Il y a aussi des enfants, tu les oublies !
-> welcome

=== stopbaching ===
-MSG;B;2.0;Lol, effectivement je cherche des paires pas un père xD
* :D
->ahcool
* [Pas drôle] Ok, je pense que l'humour n'est pas ton point fort :P
->ahcool

=== ahmerde ===
- MSG;B;2.0;Ah merde, tu penses qu'on va pas me répondre ?
* [Plaisanter] MSG;A;3.0;Baaaaah rien n'est moins sûr :P
->ahcool
* [Pas Blanche] MSG;A;3.0;La dame qui habite en-dessous de chez moi ne le fera sûrement pas. Elle est sympa mais faut la connaître un minimum pour qu'elle réponde
->ahcool

=== ahcool ===
- MSG;B;4.0;Bon je te laisse, j'ai promis à ma coloc de lui faire découvrir Steven Universe
* [Steven Universe] MSG;A;2.0;OMG, tu es fan de Steven Universe ?
->stevenuniverse

=== stevenuniverse ===
- MSG;B;2.0;Oui, si je savais coudre correctement et que j'étais plus adroite pour ça, je pense que mon cosplay de Garnett aurait déjà sa place dans mon dressing !!
* [Déguisement] Haha, je comprends ;)
->cosplay2
* [Steven Univers] Je suis fan aussi :D
->cosplay

=== cosplay ===
- MSG;B;3.5;C'est qui ton perso préféré ?
* [Pearl] MSG;A;3.0;Pearl bien évidemment :D
->cosplay3
* [Steven] MSG;A;3.0;Steven ;)
->cosplay3

=== cosplay3 ===
- MSG;B;5.0;Et du coup tu n'as jamais pensé à t'en faire des déguisements ? :D
* [Oui] MSG;A;3.0;Bien sûr que si
->cosplay4
* [C'est pas pour les hommes] MSG;A;3.0;Bien sûr que si
->cosplay4

=== cosplay4 ===
- MSG;B;5.0;Donc tu kiffes le cosplay, toi aussi ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag
* [Eluder] MSG;A;3.0;Ah... c'est compliqué
->stevenuniverse3

=== cosplay2 ===
- MSG;B;5.0;Tu kiffes le cosplay, toi aussi ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag
* [Eluder] MSG;A;3.0;J'aime surtout Steven Universe
->stevenuniverse2

=== stevenuniverse2 ====
- MSG;B;2.0;Bien sûr. T'avais l'air de vouloir parler cosplay, non ?
* [Pas exactement] MSG;A;3.0;C'est pas exactement ça, je sais pas si je peux t'en parler...
->drag

=== stevenuniverse3 ====
- MSG;B;6.0;Tu peux m'en parler, je suis plutôt open comme personne.
* [Ok] MSG;A;8.0;Et bien, je suis une Drag Queen
->drag2

=== drag ===
- MSG;B;6.0;Vas-y je te jugerai pas, no problemo.
* [Ok] MSG;A;8.0;Et bien, je suis une Drag Queen
->drag2

=== drag2 ===
-  MSG;B;3.5;Hey, mais c'est trop cool, tu te produis où ? Je pourrais venir une fois ? Please :3
* [Oui bien sur] MSG;A;3.0;Bah j'ai un spectacle ce soir, t'as qu'à venir avec ta coloc :)
->bonnefin
* [Je sais pas trop] MSG;A;3.0;Je sais pas trop
->bonnefin2

=== bonnefin2 ====
- MSG;B;4.0;Alleeeeeez
- MSG;A;5.5;Ok ça roule, j'ai un spectacle ce soir. Tu pourras venir si tu veux ;)
->END

=== bonnefin ====
- MSG;B;5.5;Trop bien, merci et à ce soir ;)
->END