## Exercice03 - Custom Control

## Objectifs

- Comprendre la différence entre un custom control et un user control en WPF.
- Apprendre à créer et utiliser un custom control.
- Apprendre à créer et utiliser un user control.
- Intégrer ces contrôles dans une application WPF.

## Sujet

1. Création d'un **Custom Control** :

   1. Créez un nouveau projet WPF.
   2. Ajoutez un nouveau dossier nommé Controls.
   3. Dans ce dossier, ajoutez une nouvelle classe nommée CustomButton.
   4. Faites hériter cette classe de Button.
   5. Ajoutez une propriété de dépendance nommée CornerRadius de type CornerRadius.
   6. Redéfinissez le template du bouton pour utiliser cette nouvelle propriété.

2. Création d'un **User Control** :

   1. Ajoutez un nouveau dossier nommé UserControls.
   2. Dans ce dossier, ajoutez un nouveau User Control nommé UserProfileControl.
   3. Ce contrôle doit contenir :
   4. Une image pour la photo de profil.
   5. Un label pour le nom de l'utilisateur.
   6. Un label pour l'email de l'utilisateur.
   7. Ajoutez des propriétés de dépendance pour le ProfileImage, UserName, et UserEmail.
