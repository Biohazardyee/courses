def TicTacToe():
    board = newBoard()
    current_player = 1
    
    while True:
        displayBoard(board)
        
        print(f"Player {current_player}'s turn (X)" if current_player == 1 else f"Player {current_player}'s turn (O)")

        x, y = select(board, current_player)
        place(board, current_player, x, y)
        
        if checkWin(board, current_player):
            displayBoard(board)
            print(f"Player {current_player} wins!")
            break

        if checkDraw(board):
            displayBoard(board)
            print("It's a draw!")
            break

        current_player = 2 if current_player == 1 else 1

def newBoard():
    board = [
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
    ]
    return board
    
def displayBoard(board):
    for i in range(3):
        for j in range(3):
            if board[i][j] == 0:
                print(".", end=" ")
            elif board[i][j] == 1:
                print("X", end=" ")
            else:
                print("0", end=" ")
        print()
    print()
    
def select(board, player):
    while True:
        choice1 = input("Enter the row (0-2): ")
        choice2 = input("Enter the column (0-2): ")

        try:
            x = int(choice1)
            y = int(choice2)
        except ValueError:
            print("Enter valid numbers between 0 and 2.")
            continue
        
        if 0 <= x <= 2 and 0 <= y <= 2:
            if board[x][y] == 0:
                return x, y
            else:
                print("That cell is already taken.")
        else:
            print("Coordinates must be between 0 and 2.")

def place(board, player, x, y):
    if player == 1:
        board[x][y] = 1
    else:
        board[x][y] = 2
        
        
def checkWin(board, player):
    for i in range(3):
        if board[i][0] == board[i][1] == board[i][2] == player:
            return True
    for j in range(3):
        if board[0][j] == board[1][j] == board[2][j] == player:
            return True
    # Top-left to bottom-right
    if board[0][0] == board[1][1] == board[2][2] == player:
        return True

    # Top-right to bottom-left
    if board[0][2] == board[1][1] == board[2][0] == player:
        return True
    
    return False

def checkDraw(board):
    for i in range(3):
        for j in range(3):
            if board[i][j] == 0:  # found an empty cell
                return False      # not a draw
    return True  # no empty cells → draw

TicTacToe()