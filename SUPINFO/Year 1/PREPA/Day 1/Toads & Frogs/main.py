def toadsAndFrogs(n, p):
    board = initBoard(n,p)
    
    current_player = 1 
    
    while again(board, n, current_player):
        print(f"Player {current_player}'s turn:")
        display(board, n)
        i = select(board, n, current_player)
        move(board, n, current_player, i)
    
        # Switch player
        current_player = 2 if current_player == 1 else 1
        
    winner = 2 if current_player == 1 else 1
    print(f"Player {winner} wins!")
    display(board, n)


    

def initBoard(n, p):
    # Edge case
    if p >= n // 2:
        p = n // 2 - 1
    
    # Create the board
    board = [1]*p + [0]*(n - 2*p) + [2]*p
    
    return board

def display(board, n):
    for i in range(len(board)):
        if board[i] == 1:
            print("x", end=" ")
        elif board[i] == 2:
            print("o", end=" ")
        else:
            print(".", end=" ")
    print()
    
    for i in range(n):
        print(i, end=" ")
    print()

def possible(board, n, i, player):
    if board[i] != player:
        return False
    
    if player == 1:
        if i+1 < n and board[i+1] == 0:
            return True
        if i+2 < n and board[i+1] == 2 and board[i+2] == 0:
            return True
        
    else:  # player 2
        # Move left
        if i-1 >= 0 and board[i-1] == 0:
            return True
        # Jump over 1
        if i-2 >= 0 and board[i-1] == 1 and board[i-2] == 0:
            return True

    return 

def select(board, n, player):
    while True:
        choice = input("Select which pawn you want to move:")
        try:
           i = int(choice)
        except ValueError:
            print("Please enter a valid number.")
            continue
        if possible(board, n, i, player):
            return i
        else:
            print("Please select a correct pawn")
            
            
def move(board, n, player, i):
    if player == 1:
        # Move right
        if i+1 < n and board[i+1] == 0:
            board[i+1] = 1
            board[i] = 0
        # Jump over player 2
        elif i+2 < n and board[i+1] == 2 and board[i+2] == 0:
            board[i+2] = 1
            board[i] = 0
    else:  # player 2
        # Move left
        if i-1 >= 0 and board[i-1] == 0:
            board[i-1] = 2
            board[i] = 0
        # Jump over player 1
        elif i-2 >= 0 and board[i-1] == 1 and board[i-2] == 0:
            board[i-2] = 2
            board[i] = 0

def again(board, n , player):
    for i in range(n):
        if board[i] == player and possible(board, n, i, player):
            return True
    else:
        return False
    
toadsAndFrogs(8, 3)
