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
    

