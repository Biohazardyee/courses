# Big Data Fundamentals 

## Définition 

Le big data désigne l'ensemble des technologies et des pratiques permettant de stocker, de collecter, de traiter et d'analyser des volumes massifs de données variées et générées à grande vitesse, afin d'en extraire des informations et des insights précieux. 

### Données

Une donnée est un fait brut qui n'a pas encore été interprétée, traitée ou mis en contexte, elle n'appelle pas à l'action.

- Les données peuvent être incohérentes ou inexactes. 
- Les données peuvent être incomplètes
- Les données ne sont pas représentatives de la cible visée par les analyses.
- Les données ne sont pas dans un format permettant de les exploiter (pour la prise de décision Business par exemple)

### Volume

Le Volume correspond à la quantité de données disponibles.

- Vecteur de volume
  - Multiplication des sources de données (iot)
  - Stockage au fil du temps
  - Production massive de contenus à la main des utilisateurs (réseaux sociaux, blogs, etc.)

- Défis 
  - Cout de stockage
  - Capacité à traiter dans un temps raisonnable
  - Cohérence de l'ensemble

### Variété

La variété fait référence à la diversité des types de données disponibles. Ces données peuvent être 

- Structurées (bases de données relationnelles, feuilles de calcul)
- Non structurées (textes, images, vidéos, données de capteurs)
- Semi-structurées (JSON, XML)

- Défis
  - Integration: Combiner des données issues de format différents
  - Traitement: Adapter les outils pour gérer et analyser des données non standardisées. Analyser des données complexes
  - Qualités des données: Gérer les incohérences, erreurs, ou lacunes dans des données hétérogènes

### Vélocité

Rapidité à laquelle les données sont générées, collectées et traitées. Deux aspects à prendre en considération: vitesse à laquelle les données arrivent dans un systeme et vitesse avec laquelle elles dovient être analysées et taitées

- Défi
  - Scalabilité des systemes
  - Disponibilité des systemes
  - Latence réseau
  - Traitement de la donnée en temps réel

### Valeur

La valeur des big data réside dans les bénéfices qu'elles apportent aux organisations, en fonction des informations qu'elles en tirent

Par exemple en profilant ses clients, une entreprise peut personnaliser son marketing.

- Defis
  - Identification des données pertinentes
  - Qualité des données
  - Cout de traitement de la donnée versus capacité à monétiser la donnée traitée

### Véracité

Concerne la qualité, précision, intégrité et crédibilité des données. La véracité et la valeur des données déterminent leur pertinence pour la prise de décisions importantes.

- Defis
  - Qualités des données
  - Risque d'inexactitudes et d'inchérences
  - Sources multiples: Intégration complexe et erreurs possibles
  - Données non structurées: Difficulté à assurer la qualité
  - Maintenir une haute véracité est crucial pour des analyses fiables et des décisions éclairées. 

## Nouvelles approches d'architectures

- Changement d'approche par rapport aux SGBDR: passer de la scalabilité verticale à la scalabilité horizontale
- Stockage distribué des données
- Traitement distribué des données
- Traitement en batch et en temps réel des données

### Cas d'usage Big Data

Pour chacun des éléments suivants, trouvez au moins un exmeple concret d'utilisation du big data.

- Analyse Prédictive: Evaluer les risques de blessure pour les athlètes

- Détection de fraude: Identifier les transactions financières suspectes

- Analyse des sentiments: Google analyse les besoins des utilisateurs pour donner des pubs ciblées

- Maintenance predictive: Prédire pannes d'équipements industriels

- Optimisation de la chaîne d'approvisionnement: Analyser les données de vente et de stock pour optimiser les niveaux d'inventaire

- Personnalisation de l'experience utilisateur: Recommender des produits ou des contenus basés sur les préferences ex YouTube

- Analyse des reseaux sociaux et tendances: entreprise de creation de contenu analyse les tendances sur les réseaux sociaux pour adapter sa stratégie de contenu

- Optimisation des campagnes marketing: Analyse des reactions des clients aux pubs et campagnes pour ajuster les stratégies marketing

- Analyse géospatiale: Analyser les données de localisation pour optimiser les itinéraires de livraison

- Recherche scientifique et médicale: Analyser de grandes quantités de données génomiques pour identifier des mutations associées à des maladies

- Sécurité et surveillance: Analyse des comportements suspects dans les données de surveillance pour prévenir les menaces à la sécurité

## Data Ingestion 

- L'ingestion de données est le processus d'acquisition et d'importation de données pour une utilisation immédiate ou future. 
- L'ingestion consiste à transférer des données de diverses sources vers une destination commune pour analyse. 
- Permet l'analyse en temps réel ou en différé. 
- Garantit une prise de décision basée sur des données fiables.
- Facilite la gestion des grandes volumétries de données. 

### Types d'ingestion de données

- Batch Ingestion: 
  - Collecte et chargement des données à intervalles réguliers
  - Utilisé pour les analyses différées

- Streaming Ingestion:
  - Collecte et chargement des données en temps réel
  - utile pour les applications nécessitant une latence faible (ex: IOT, surveillance en temps réel)

### Approches Batch - ETL

ETL (Extract, Transform, Load) méthode classique pour déplacer des données entre systèmes.

- Extract
  - Les données sont extraites depuis diverses sources (bases de données relationnelles, fichiers plats, API, etc.)
- Transform
  - Les données brutes extraites sont néttoyées, formatées ou enrichies pour repondre à des besoins spécifiques (suppresion des doublons, gestionn des valeurs nulles, transformation des formats, application de règles métier).
- Load 
  - Les données transformées sont chargées dans un entrepot de données ou un système de destination. 

### Approches Stream - ELT


- Extract
  - Similaire à l'ETL, les données sont extraites depuis diverses sources.
- Load
  - Les données brutes sont directement chargées dans un entrepot ou un lac de donnéess sans transformation préalable.
- Transform
  - Les données sont transformées après le chargement, souvent directement dans l'entrepot de données
  - Cette étape profite des capacités de calcul massivement parallèles des systems modernes (cloud).
  
### Défis de l'ingestion de données

- Hétérogénéité des formats de données
- Gestion des erreurs et des données corrompues
- Scalabilité face à des volumes croissants
- Sécurité et conformité (GDPR, HIPAA, etc.)

## Apache Spark 

- Moteur de traitement distribué à grande échelle.
- Concu pour traiter de grandes quantités de données rapidement
- Supporte plusieurs langages de programmation (Scala, Java, Python, R)
- Projet Open Source

### Definition 

- Traitement in memory: Reduit la latence par rapport à Hadoop
- API unifiée: Supporte batch, streaming, ML et SQL
- Résilience: Basé sur les RDD (Resilient Distributed Datasets) pour la tolérance aux pannes
- Intégré pour le traitement batch et streaming

### Cas d'usage

- Analyse de logs
- Recommendations personalisées
- Analyse de données en temps réel (données IoT, réseaux sociaux)

### Principaux concepts

- RDD (Resilient Distributed Dataset)
- DataFrame: Structure tabulaire
- Dataset: Représentation typée

## RDD

- Collection distribuée d'objets immuables répartis sur un cluster permettant de traiter parallelement et efficacement des données massives 

Il y a deux types d'opérations possible: Actions / Transformations

### Transformations

- Elles génèrent de nouveaux RDD à partir d'un RDD existant
- Elles sont lazy, càd qu'elles ne s'éxècutent pas immédiatement. Il faut attendre le lancement d'une opération d'action pour qu'elles s'appliquent

- Exemple: map, join, filter, distinct

### Actions

- Déclenchent l'éxécution des transformations et renvoient un résultat
- Exemple: collect, count, take, reduce, saveAsTextFile

### Résilience

- Les RDD sont tolérantes aux pannes
- Si une partition est perdue en raison d'une panne, Spark peut la recréer automatiquement en utilisant son historique de transformations (lineage)
  
### Distribution

- Les RDD sont divisés en partitions qui sont distribuées à travers les noeuds d'un cluster
- Cela permet un traitement parallèle efficace des données massives

### Immuabilité

- Une fois crée une RDD ne peut pas être modifiée. Vous pouvez créer de nouveaux RDD à partir de transformations d'un RDD existant.  

### Laziness

- Comme vu précédemment, les Transformations ne s'appliquent pas immédiatement. Il faut une opération ACtion pour les jouer. 

### Abstraction bas-niveau

- Bien que flexible et puissant, RDD est une abstraction bas-niveau ce qui peut rendre son utilisation plus complexe

### Avantages / Limites

- Puissant mais complexe à utiliser (en comparaison avec la manipulation d'un dataset classique)
- Les RDD ne possèdent pas de schéma structuré
- Travaillre directement avec des RDD nécessite une connaissance approfondie des principes du traitement distribué. 
  
### Dataframe

- Abstraction de haut niveau qui represente des données structurées organisées sous forme de tableau
- Similaire à une table dans une base de données relationelle ou un tableau de données dans Python ou R.
- Dataframes offrent une API pour effectuer des opérations sur des données massives tout en utilisant le moteur distribué de Spark. 
- Les transformations sont évaluées paresseusement comme pour les RDD.

Dataframe est:

- plus simple à exploiter / utiliser que les RDD
- Moins flexible pour les transformations complexes par rapport aux RDDs
- Necessite une structure ou un schéma explicite pour les données
- Approche recommandée pour la plupart des cas d'utilisation dans apache Spark en raison de leur efficacité et de leur simplicité. Pour les projets modernes, ils remplaces souvent les RDDs. 

### Dataset 

- Abstraction de haut niveau utilisé pour manipuler des données structurée de manière efficace et distribuée.
- Combine les avantages des RDD et des DataFrames
  - Possibilite de jouer des opérations de transformation
  - Typage des données / organisée

### Résumé

RDD: Comme une boite pleine d'objet et l'utilisateur doit naviguer lui meme dedans sans organisation clairement identifiée. Moins optiisé et ne verifie pas si les données ont le bon format. 

DataFrame: Comme une feuille Excel avec colonnes et lignes, mais il ne sait pas ce qu'il y a dans chaque colonne. Tres rapide, mais moins rigoureux que le dataset.

Dataset: Combine le meilleur des deux mondes: rapide et intelligent. Possible de travailler avec des données organisées tout en ayant des performances importantes. 

## Spark Core

- Base de Spark, gère les taches fondamentales de traitements des données
- permet le calcul distrivué. Fournit l'API RDD
- Gere la tolérance aux pannes et l'allocation des ressources

## Spark SQL

- Fournit une interface pour ececuter des requetes SQL standards sur des données distribuées
- Il permet d'utiliser directement le language SQL pour intéragir avec des dataframes ou des tables 
- Peut lire et ecrire dans divers format comme JSON, Parquet, etc.
- Spark SQl peut se connerter avec Hive pour executer des requeste sur les tables Hive. 

### Avantages 

- Facilité d'utilisation: Familiarité pour les utilisateurs de SQL
- Performance élevée: optimisation, profite des mécanismes distribués
- Intégration native: compatible avec d'autres modules et systemes de stockage
- Flexibilité: Compatible avec les API dataframe et dataset

# Kafka

## Présentation

- **Technologie fondatrice** au service des **Big Data**
- Utilisée principalement pour la **gestion de flux de données en temps réel**
- Développée à l’origine par **LinkedIn**
- Devenue ensuite un projet **open source** géré par la **Fondation Apache**

---

## Rôle de Kafka (Streaming + Buffer)

Kafka peut servir de **buffer** :

1. Les données arrivent en **stream**
2. Elles entrent dans Kafka
3. Elles sont ensuite envoyées vers une ou plusieurs destinations

Kafka peut gérer :

- **Plusieurs sources**
- **Plusieurs destinations**

---

## Messages et Topics

Ce qui est transféré dans Kafka s'appelle un **message**.

Les messages sont organisés en **topics**.

Les messages sont immuables et ordonnés.

📌 Fonctionnement :

- La destination demande à Kafka les topics qui l’intéressent
- Kafka envoie les messages correspondants

---

## Producer et Consumer

- Celui qui crée des messages = **Producer**
- Celui qui consomme les messages = **Consumer**

### Découplage total

Les producers et consumers :

- Ne se voient pas
- N’ont aucune information les uns sur les autres
- Ne savent pas qui produit ou consomme les messages

---

## Topics, Partitions et Brokers

Les **topics** sont organisés en **partitions**.

Les partitions sont réparties sur les **brokers** (serveurs Kafka).

Chaque partitions sont ordonnées et immuables.

### Réplication

Chaque partition est répliquée sur plusieurs brokers pour assurer :

- La **tolérance aux pannes**
- La **continuité du service**

---

## Offset (Suivi de lecture)

Les consumers peuvent savoir quels messages ils ont déjà consommés grâce à un système appelé :

➡️ **Offset**

Un offset est :

- Un numéro
- Qui indique la position d’un message dans une partition

Si un message est supprimé, les offsets disparaissent aussi.
Dans un sens large, tout ce qu'il n'est pas le contenu du message, est de la métadonnée, l'offset en fait partie.

### Avantage

En cas de panne, un consumer peut :

- Reprendre la consommation à partir du dernier offset connu

---

## Rejouer des messages

Kafka permet de rejouer des messages en rejouant l’offset :

- Manuellement (à la main)
- Via script

⚠️ Conditions :

- Il faut un temps de **rétention** assez long (voire illimité)
- Sinon, on peut utiliser un **stockage externe** pour conserver les messages de manière permanente

---

## Transformation de données

Kafka **ne fait pas nativement** de transformation de données.

---

# Schema Registry

## Rôle

Le **Schema Registry** permet de :

- Gérer les schémas de données des messages Kafka
- Valider que les messages respectent un schéma défini
- Assurer la compatibilité entre producers et consumers

---

## Avro (au lieu de JSON)

Au lieu d’utiliser du JSON, les données sont souvent encodées en **Avro** :

- Format de sérialisation **binaire**
- Plus efficace :
  - En taille
  - En vitesse de traitement

---

## Avantage global

Avec Schema Registry + Avro :

- Producers et consumers échangent des données cohérentes
- Le format reste maintenable dans le temps
- L’évolution des schémas est mieux contrôlée

---

# Brokers

## Rôles possibles dans un cluster Kafka

Les brokers peuvent avoir différents statuts / rôles :

- **Leader**
- **Follower**
- **In-Sync Replica (ISR)**
- **Out-of-Sync Replica (OSR)**
- **Offline**

---

# Zookeeper et KRaft

## Zookeeper

Zookeeper permet de gérer les leaders.

C’est un outil qui n’existe pas uniquement pour Kafka.

C’est un **orchestrateur de cluster** qui gère :

- La configuration
- La synchronisation
- La coordination des services distribués

Zookeeper :

- Désigne le leader
- Gère les partitions
- Surveille la santé des brokers
- Etc.

---

## KRaft (remplaçant de Zookeeper)

Zookeeper est progressivement remplacé par **KRaft**.

KRaft permet :

- L’élection du leader sur différents serveurs
- La conservation des métadonnées du cluster

### Différence importante

- KRaft est **intégré directement dans Kafka**
- Il n’est pas un orchestrateur externe
- Il gère :
  - Les métadonnées du cluster
  - L’élection des leaders
  - La concurrence entre leader
