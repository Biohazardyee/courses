# Implémenter une fonction qui retourne la puissance 
# n-ème d'un nombre x, i.e. xn. 
# On écrira deux versions, l'une itérative et 
# l'autre récursive.

def power_iterative(x, n):
    result = 1
    for i in range(n):
        result *= x
    return result

def power_recursive(x, n): 
    if n == 0:
        return 1
    else:
        return x * power_recursive(x, n - 1)

# Tests
print("Power tests:")
print(power_iterative(2, 3))  # 8
print(power_recursive(2, 3))  # 8
print(power_iterative(5, 0))  # 1
print(power_recursive(5, 0))  # 1

#2 - Suite de Fibonacci

# Implémenter une fonction récursive qui retourne le n-ième terme de la la suite de Fibonacci
# Pour rappel, cette suite est définie par F0=0,F1=1 et ∀n≥2,Fn=Fn−1+Fn−2.

def fibonacci(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fibonacci(n - 1) + fibonacci(n - 2)
    
# Tests

print("Fibonacci tests:")
print(fibonacci(5))
print(fibonacci(8))

# 3 - Suite de Syracuse

# Implémenter une fonction récursive qui retourne le n-ième terme de la suite de Syracuse. 
#
# Pour rappel, pour une graine a∈R, cette suite est définie par u0=a et ∀n≥1,un={un−1÷2 if un−1 est pair et 3∗un−1+1 if un−1 est impair

def Syracuse(u, n):
    if n == 0:
        return u
    elif u % 2 == 0:
        return Syracuse(u // 2, n - 1)
    else:
        return Syracuse(3 * u + 1, n - 1)
    
# Tests
print("Syracuse tests:")
print(Syracuse(6, 3))  # 3
print(Syracuse(7, 4))  # 52
print(Syracuse(1, 5))  # 16