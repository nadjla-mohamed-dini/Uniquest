# 🧙‍♂️ UniQuest – RPG Tour par Tour (Unity 6)

## 🎮 Présentation

Les RPG ont évolué depuis les années 70, passant des dés et du papier aux mondes 3D interactifs.  
Avec Unity 6 et C#, créer un RPG est devenu accessible aux étudiants… et c’est ainsi qu’est né **UniQuest**, un projet scolaire inspiré des classiques du genre.

UniQuest est un **RPG tour par tour simplifié**, conçu pour apprendre les bases de la programmation orientée objet, de la logique de combat et de la structure d’un jeu vidéo.

---

## 🎯 Objectif du projet

Développer un **jeu de rôle tour par tour** en C# sous Unity 6, intégrant :

- Une **map explorable** avec déplacements au clavier  
- Des **rencontres aléatoires** déclenchant des combats  
- Un **système de combat 1v1** contre un seul ennemi  
- Un **inventaire simple** (objets utilisables en combat)  
- Un **système de statistiques** pour le joueur et l’ennemi  
- Des **attaques avec dégâts, précision et critiques**  

Ce projet se concentre sur les **fondamentaux** d’un RPG, sans menu équipe ni système de sauvegarde.

---

## 🗺️ Fonctionnalités principales

### 🌍 Exploration
- Déplacement du joueur sur une carte en vue du dessus  
- Rencontres aléatoires pendant les déplacements  
- PNJ et coffres interactifs (selon version)

### ⚔️ Combat tour par tour (1v1)
- Un seul ennemi par combat  
- Choix d’action :  
  - Attaque  
  - Magie (si disponible)  
  - Objet (potion, boost…)  
- Gestion des PV, PM, attaque, défense, vitesse, précision  
- Chances de coup critique  
- Calculs de dégâts basés sur les statistiques  

### 🎒 Inventaire
- Objets utilisables en combat  
- Potions de soin  
- Objets de boost temporaire  

### 📈 Progression
- Gain d’expérience après les combats  
- Amélioration des statistiques  
- Déblocage d’attaques selon la version  

---

## 🧠 Architecture & conception

Le projet repose sur une structure orientée objet :

- **Classes de base** : Personnage, Ennemi, Attaque, Objet  
- **Héritage** pour les types d’attaques et d’objets  
- **Gestion des états** : exploration → combat → retour à la map  
- **Calculs mathématiques** pour les dégâts, critiques, précision  

---

## 🧪 Tests unitaires

Des tests unitaires ont été réalisés pour valider :

- les calculs de dégâts  
- la précision et les critiques  
- la gestion des PV/PM  
- la progression d’expérience  

---

## 🛠️ Technologies utilisées

- **Unity 6**
- **C#**
- **ScriptableObjects** (attaques, objets, personnages)
- **Unity Input System**
- **NUnit** pour les tests unitaires

---

## 🎓 Compétences développées

- Développer des composants métier en C#  
- Concevoir une architecture logicielle simple  
- Analyser des besoins et structurer un jeu  
- Implémenter un système de combat tour par tour  
- Gérer des statistiques et des calculs de gameplay  
- Réaliser des tests unitaires  
- Organiser un projet Unity  

---

## 📦 État du projet

- Exploration : ✔️  
- Combat 1v1 : ✔️  
- Inventaire : ✔️  
- IA ennemie simple : ✔️  
- Menu équipe : ✖️  
- Sauvegarde / chargement : ✖️  

---

## 💬 Notes du projet

UniQuest est un projet pédagogique visant à comprendre les bases d’un RPG.  
Il met l’accent sur la logique, la structure et la programmation plutôt que sur le contenu ou les graphismes.

---

## 📁 Lien GitHub

👉 *(À compléter)*  
