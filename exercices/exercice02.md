# Exercice02 - Animation

## Objectif

L'objectif de cet exercice est de créer cinq boutons représentant les jours de la semaine. Lorsque l'utilisateur passe la souris sur un bouton, celui-ci doit avoir un effet de **zoom au survol**.

## Sujet

```
+-------+  +-------+  +-------+  +-------+  +-------+
|       |  |       |  |       |  |       |  |       |
|  LUN  |  |  MAR  |  |  MER  |  |  JEU  |  |  VEN  |
|       |  |       |  |       |  |       |  |       |
+-------+  +-------+  +-------+  +-------+  +-------+
```

1. Créez une nouvelle application WPF.
2. Ajoutez cinq boutons à votre fenêtre principale (`MainWindow.xaml`), chacun représentant un jour de la semaine (LUN, MAR, MER, JEU, VEN).
3. Utilisez des `EventTrigger` et des `Storyboard` pour implémenter un effet de zoom au survol pour chaque bouton. Lorsque la souris entre dans la zone du bouton, celui-ci doit s'agrandir. Lorsque la souris quitte la zone du bouton, il doit revenir à sa taille initiale.
