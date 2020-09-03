# TP SoundTower

## Objectif : 
Créer un instrument musical et visuel. Utilisant la physique et des scripts pour générer du son.
Vous êtes libre dans la forme, à vous d'être imaginatif pour créer une sorte d'instrument de musique expérimental.


### Etape 1 :
- Importer le model 3D et le configurer dans la scène.
- Ajouter un mesh collider aux objets enfants [cone.000 - cone.044]
- Astuce : pour selection tous les objets , Sélection du premier objet -> sélection du dernier en maintenant la touche shift.

### Etape 2 : Creer le spawner
- Créer un empty objets : click droit dans hierarchie

![image](/img/image22.png)

- Rename l’objet : spawner
- Importer le script spawn.cs dans le projet unity
- Ajouter le script spawn.cs sur l’objet.
    - AddComponent -> spawn

![image](/img/image17.png)

![image](/img/image5.png)

- Créer une sphère qui nous servira de prefab : 
- pour créer la sphère : click droit dans la hierarchie -> create ->3D ->sphere
- pour la transformer en prefab : Glisser cette sphere de la hierarchy vers la fenêtre projet.

![image](/img/image2.gif)

- Ensuite donner ce prefab au script spawn sur l’objet spawner.

![image](/img/image8.png)

![image](/img/image12.gif)

- Ajouter un tag “SoundTrigger” dans la liste de tag du projet.

![image](/img/image29.gif)
![image](/img/image15.gif)

- Attribuer ce tag à toutes les marches de la tour [cone.000 - cone.043].
Attention à ne pas ajouter ce tag sur l’objet cone.044, car il s’agit des murs de la tour.

- Faire play pour tester l’apparition des shperes au dessus des marches lorsqu’on click dessus. Assurez vous d’avoir bien placé votre camera pour voir votre tour. Les sphères doivent apparaitre et resté immobiles.

- Pour faire tomber les sphères, vous devez modifier le préfab et lui ajouter le composant Rigidbody.
    - Pour modifier le prefab, il faut double cliquer dessus dans la fenêtre projet.
    - Ajouter ensuite un rigidbody sur la sphère contenue dans le prefab.
    
### Etape 3 : DestroyBox
- Creer un cube.
- Le placer au fond de la tour.

![image](/img/image20.png)

- Cocher la case isTrigger dans le composant BoxCollider
- Rendre le cube invisible en supprimant son composant MeshRenderer.

![image](/img/image16.png)

- Créer un nouveau tag “Sphere”.
- Attribuer ce nouveau tag au prefab sphere. 
- Créer un script Destroy.cs
- Écrire dans ce script la fonction OnTriggerEnter illustrée ci-dessous.

![image](/img/image19.png)

- Ajouter ce script sur l’objet DestroyBox.

![image](/img/image6.png)

- Fin de l’étape 3.

### Étape 4 : Déclencher du son lorsqu’une balle tombe sur une marche.
- Selectionnez toutes les marches et y ajouter un component AudioSource et un nouveau script. Appelons le SoundTrigger.
- Commencez par y déclarer un tableau d’AudioClip public nommé notes.

![image](/img/image18.png)

- Retournez ensuite dans l’éditeur Unity. Toujours en ayant toutes les marches sélectionnées, donnez une taille au tableau notes. Et remplissez les cases avec des fichiers son.
 
![image](/img/image24.png)

- Vous pouvez attribuer différent son aux différentes marches.
- Écrivez le code ci-dessous :

![image](/img/image14.png)

### Étape 5 : Créer une rythmique.
- Créez un nouvel objet vide ( Create Empty) nommé Rythmic, y ajouter une audioSource, ainsi qu’un nouveau script nommé Rythme.

![image](/img/image1.png)

- Comme pour ajouter des sons sur les marches. Ajouter 1 ou plusieurs audioClip au tableau drums sur l’objet Rythmic dans l’éditeur Unity.
- Définissez la fréquence à laquelle sera joué vos sons (0.5 fera jouer votre son toutes le demi secondes).

### Étape 6 : Créer une mélodie.
- Comme pour la rythmique. Créez un nouvel objet vide nommé Melody, y ajouter une audioSource et un nouveau script nommé Melody.

![image](/img/image30.png)

- Ajoutez des audioClip à son tableau.
- Définissez la fréquence

### Étape 7 : Animer une lumière.
- Ajouter une point light dans la hierachy : click droit -> light -> point light.
- Positionnez cette lumière en bas de la tour.
- Augmenter son intensité et sa range.
- Changer sa couleur

![image](/img/image4.png)

- Nous souhaitons faire bouger la lumière de haut en bas. Pour cela nous allons créer une animation depuis la fenêtre animation. Si vous ne la voyez pas dans votre interface. - - Allez la chercher dans le menu window - > animation -> animation.
- Ayez toujours l’objet point light sélectionné. Et cliquez sur le bouton create dans l’interface d’animation.

![image](/img/image10.png)

- Cela vous ouvre votre explorateur de fichier afin de décider du nom et de l’emplacement d’enregistrement de votre nouvel animation. (restez dans le dossier Asset de votre projet).
- Ensuite votre interface d’animation doit ressembler à ca :

![image](/img/image11.png)
vous pouvez remarquer qu’un component Animator équipé d’un nouveau Controller(portant le même non que la lumière) à automatiquement été ajouté sur la PointLight.

- Assurez vos que la tête de lecture de la timelaps soit bien positionnée au début de l’animation. Ajoutez la property transform->position. Placez la tête de lecture à la fin de l’animation. Activez le mode Rec. Déplacez la lumière en haut de la tour (si besoin vous pouvez activer l’outil de translation avec la touche W). Arretez le mode Rec. Et previsualiser votre animation en cliquant sur le bouton play.

![image](/img/image26.png)

### Étape 8 : Ajouter des effets sonores grace à l'audio mixer.
- Ouvrez la fenêtre Audio Mixer. Menu window -> Audio -> Audio Mixer
- Ajouter un nouveau mixer en cliquant sur le bouton + ci-dessous.

![image](/img/image25.png)

- Ajouter 3 groupes en enfant du groupe Master (les groupes correspondent à des canaux de mixage. Cela nous permet d’ajuster indépendamment le son des différents canaux)

![image](/img/image27.png)

- Rangez les différentes audioSources de votre projet dans les différents canaux.
    - Les audioSources des marches dans OtherSounds
    - L’audioSource de l’objet rythme dans rythme
    - L’audioSource de l’objet melody dans melody
- Pour faire cela, vous devez indiquer dans chaques audio leur canal de sortie (Output)    

![image](/img/image9.png)

- Ajoutez des effets sonores.

![image](/img/image23.png)

- Vous pouvez ensuite les sélectionner pour les modifier dans l’inspecteur.

