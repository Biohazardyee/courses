#include <iostream>
#include <array>

#define MAX_SIZE 5

using namespace std;

typedef struct vertex
{
    char label;
    bool visited;
} Vertex;

// Queue variables

array<int, MAX_SIZE> graphQueue;
int rear = -1;
int front = 0;
int queueSize = 0;

// Queue functions
void enqueue(int item)
{
    queueSize++;
    graphQueue[++rear] = item;
}

int dequeue()
{
    queueSize--;
    return graphQueue[front++];
}

bool isQueueEmpty()
{
    return queueSize == 0;
}

// array of vertices
array<Vertex *, MAX_SIZE> vertices;
int vertexCounter = 0;

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

void breadthFirstSearch()
{
    // cout << vertices[0]->label << endl;
    // vertices[0]->visited = true;
    enqueue(0);
    vertices[0]->visited = true;

    while (!isQueueEmpty())
    {
        int currentVertex = dequeue();
        cout << vertices[currentVertex]->label << endl;

        int unvisitedIdx = getAdjacentUnvisited(currentVertex);
        while (unvisitedIdx != -1)
        {
            enqueue(unvisitedIdx);
            vertices[unvisitedIdx]->visited = true;
            unvisitedIdx = getAdjacentUnvisited(currentVertex);
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

    cout << "BFS: " << endl;
    breadthFirstSearch();

    return 0;
}