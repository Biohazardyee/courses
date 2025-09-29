def Dawson(n):
    board = newBoard(n)
    current_player = 1
    
    while again(board, n):
        print(f"Player {current_player}'s turn:")
        display(board, n)
        i = select(board, n)
        put(board, n, i)
        
        if current_player == 1:
            current_player = 2
        else: 
            current_player = 1
    
    winner = 2 if current_player == 1 else 1
    print(f"Player {winner} wins!")
    display(board, n)
    
    
    

def newBoard(n):
    board = [0] * n
    return board

def display(board, n):
    length = len(board)
    for i in range(length):
        if board[i] == -1:
            print("o", end=" ")
        elif board[i] == 1:
            print("x", end=" ")
        else:
            print(".", end=" ")
    print()
    for i in range(n):
        print(i, end= " ")
    print()

def possible(board, n, i):
    # Check if i is within the board
    if i < 0 or i >= n:
        return False

    # Check if the cell is empty
    if board[i] != 0:
        return False

    # Check left neighbor (if it exists)
    if i > 0 and board[i-1] == 1:
        return False

    # Check right neighbor (if it exists)
    if i < n-1 and board[i+1] == 1:
        return False

    # If all checks passed, the move is possible
    return True

def select(board, n):
    while True:
        choice = input("Enter the cell number where you want to place the pawn: ")
        try:
            i = int(choice)
        except ValueError:
            print("Please enter a valid number.")
            continue
        if possible(board, n, i):
            return i
        else:
            print("Invalid move, choose a correct cell")

def put(board, n, i):
    board[i] = 1
    if i > 0 and board[i-1] == 0:
        board[i-1] = -1

    if i < n-1 and board[i+1] == 0:
        board[i+1] = -1


def again(board, n):
    for i in range(n):
        if possible(board, n, i):
            return True
    else:
        return False


Dawson(10)