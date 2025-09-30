# 1 - Algorithme de recherche dichotomique 
# Implémentation de l'algorithme de recherche dichotomique (binary search)
def binary_search(arr, target):
    left, right = 0, len(arr) - 1  # Définir les bornes de la recherche
    while left <= right:
        mid = (left + right) // 2  # Calculer l'indice du milieu
        if arr[mid] == target:
            return mid  # Élément trouvé, retourner l'indice
        elif arr[mid] < target:
            left = mid + 1  # Chercher dans la moitié droite
        else:
            right = mid - 1  # Chercher dans la moitié gauche
    return -1  # Élément non trouvé

# Tests pour la recherche dichotomique
print("Binary Search tests:")
print(binary_search([1, 2, 3, 4, 5], 3))      # Résultat attendu : 2
print(binary_search([1, 2, 3, 4, 5], 6))      # Résultat attendu : -1
print(binary_search([], 1))                    # Résultat attendu : -1
print(binary_search([10, 20, 30, 40, 50], 10))# Résultat attendu : 0
print(binary_search([10, 20, 30, 40, 50], 50))# Résultat attendu : 4

# 2 - Tours de Hanoï
# Implémentation récursive pour résoudre le problème des Tours de Hanoï
# Ce petit jeu est constitué de 3 tours et de n disques ayant tous des diamètres différents. 
# Initialement tous les disques sont sur la première tour, ordonnés selon leur diamètre, du plus grand en bas au plus petit en haut :
# Le but est de déplacer tous les disques vers la troisième tour tout en conservant leur ordre.
# Pour cela on doit se soumettre aux règles suivantes :
#   On ne peut bouger qu'un seul disque à la fois.
#   On ne peut déplacer un disque que vers une tour vide ou sur un disque de diamètre plus grand.
# Implémenter une procédure récursive améliorée pour résoudre ce problème en affichant successivement sur la console les différents déplacements.
# Ajout d'une indentation pour visualiser la profondeur de la récursion et d'un compteur de mouvements.

def hanoi(n, source, target, auxiliary, move_counter=[0], depth=0):
    indent = "  " * depth
    if n == 1:
        move_counter[0] += 1
        print(f"{indent}Déplacer le disque 1 de {source} à {target} (Mouvement {move_counter[0]})")
        return
    hanoi(n - 1, source, auxiliary, target, move_counter, depth + 1)
    move_counter[0] += 1
    print(f"{indent}Déplacer le disque {n} de {source} à {target} (Mouvement {move_counter[0]})")
    hanoi(n - 1, auxiliary, target, source, move_counter, depth + 1)

# Tests pour les Tours de Hanoï
print("Hanoi tests:")
hanoi(3, 'A', 'C', 'B')  # Déplacer
hanoi(4, 'A', 'C', 'B')  # Déplacer
hanoi(2, 'A', 'C', 'B')  # Déplacer