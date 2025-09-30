import random

def numberGuessingGame():
    GuessNumber = random.randint(1, 100)
    tries = 0
    
    while True:
        choice = input("Enter a number between 1 and 100: ")
        try:
            i = int(choice)
        except ValueError:
            print("Enter a valid number.")
            continue
        
        tries += 1
        
        if i < GuessNumber:
            print("Too low, try again.")
        elif i > GuessNumber:
            print("Too high, try again.")
        else:
            print(f"You've won! The number was {GuessNumber}. You found it in {tries} tries.")
            break

numberGuessingGame()