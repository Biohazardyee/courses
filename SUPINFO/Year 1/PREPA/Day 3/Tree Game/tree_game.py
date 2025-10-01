import random

class Tree:
    def __init__(self, state=0):
        self.__state = state
        
    def get_state(self):
        return self.__state
    
    def set_state(self, state):
        self.__state = state
    
    def tree_state(self):
        if self.__state == 0:
            return "."
        elif self.__state == 1:
            return "A"
        elif self.__state == 2:
            return "F"
        else:
            return "C"
        
    def update_state(self, has_burning_neighbor: bool):
        if self.__state == 1 and has_burning_neighbor == True:
            self.__state = 2
        elif self.__state == 2:
            self.__state = 3
        else:
            pass
        
        
class Forest:
    def __init__(self, cols=5, rows=6, prob=0.5):
        self.__rows = rows
        self.__cols = cols
    
        self.grid = [
            [Tree(1) if random.random() < prob else Tree(0) 
            for _ in range(cols)]
            for _ in range(rows)
        ]
        
        healthy_trees = [
            self.grid[r][c] 
            for r in range(self.__rows) 
            for c in range(self.__cols) 
            if self.grid[r][c].get_state() == 1
        ]
        
        if healthy_trees:
            tree_to_brun = random.choice(healthy_trees)
            tree_to_brun.__state(2)

    def display(self):    
        for i in range (self.__rows):
            print("")
            for j in range(self.__cols):
                state = self.grid[i][j].get_state()
                if state == 0:
                    print("." , end="")
                elif state == 1:
                    print("A" , end="")
                elif state == 2:
                    print("F" , end="")
                else:
                    print("C" , end="")
            print()
    
    def has_burning_neighbor(self, row, col):
        # South
        if row < self.__row - 1 and self.grid[row+1][col].get_state() == 2:
            return True
        # North
        if row > 0 and self.grid[row-1][col].get_state() == 2:
            return True
        # West
        if col > 0 and self.grid[row][col-1].get_state() == 2:
            return True
        # East
        if col < self.__cols - 1 and self.grid[row][col+1].get_state() == 2:
            return True

        return False

        