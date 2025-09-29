#include <iostream>
#include <array>

#define MAX_SIZE 5

using namespace std;

typedef struct vertex
{
    char label;
    bool visited;
} Vertex;

array<int, MAX_SIZE> graphStack;
int top = -1;

// Array of vertices
array<Vertex *, MAX_SIZE> vertices;
int vertexCounter = 0;

// Adjacency matrix
array<array<int, MAX_SIZE>, MAX_SIZE> adjacencyMatrix;

int getAdjacentUnvisited(int vertexIndex)
{
    for (int i = 0; i < vertexCounter; i++)
    {
        if ((adjacencyMatrix[vertexIndex][i] == 1) && (vertices[i]->visited == false))
        {
            return i;
        }
    }
    return -1;
}

// stack functions
void push(int item)
{
    graphStack[++top] = item;
}

int pop()
{
    return graphStack[top--];
}

int peek()
{
    return graphStack[top];
}

bool isStackEmpty()
{
    return top == -1;
}

void addVertex(char label)
{
    Vertex *vertex = new Vertex;
    vertex->label = label;
    vertex->visited = false;
    vertices[vertexCounter] = vertex;
    vertexCounter++;
}

void addEdge(int orig, int dest)
{
    adjacencyMatrix[orig][dest] = 1;
    adjacencyMatrix[dest][orig] = 1;
}

void depthFirstSearch()
{
    cout << vertices[0]->label << endl;
    vertices[0]->visited = true;
    push(0);

    while (!isStackEmpty())
    {
        // Get the first unvisited adjacent vertex of the top vertex
        int unvisitedIdx = getAdjacentUnvisited(peek());

        if (unvisitedIdx == -1)
        {
            pop();
        }
        else
        {
            cout << vertices[unvisitedIdx]->label << endl;
            vertices[unvisitedIdx]->visited = true;
            push(unvisitedIdx);
        }
    }
}

int main()
{
    // adjacency matrix initialization
    for (int i = 0; i < MAX_SIZE; i++)
    {
        for (int j = 0; j < MAX_SIZE; j++)
        {
            adjacencyMatrix[i][j] = 0;
        }
    }

    // Add vertices to the list
    addVertex('S');
    addVertex('A');
    addVertex('B');
    addVertex('C');
    addVertex('D');

    // Update the adjacency matrix
    addEdge(0, 1);
    addEdge(0, 2);
    addEdge(0, 3);
    addEdge(1, 4);
    addEdge(2, 4);
    addEdge(3, 4);

    cout << "Depth First Search: " << endl;
    depthFirstSearch();

    return 0;
}