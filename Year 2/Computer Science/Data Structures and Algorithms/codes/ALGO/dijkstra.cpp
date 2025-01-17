#include <iostream>

#define V 9

int minDistanceIdx(int distance[], bool shortestPathSet[])
{
    int minIdx;
    int min = INT_MAX;

    for (int i = 0; i < V; i++)
    {
        if ((distance[i] < min) && (!shortestPathSet[i] == false))
        {
            min = distance[i];
            minIdx = i;
        }
    }
    return minIdx;
}

void dijkstraAlgorithm(int adjacencyMatrix[V][V], int srcIndex)
{
    int distance[V];         // dist[i] will hold the shortest distance from srcIndex to i
    bool shortestPathSet[V]; // shortestPathSet[i] == true if i is included in the shortest path tree
                             // or if the distance[i] is finalized

    for (int i = 0; i < V; i++)
    {
        distance[i] = INT_MAX;
        shortestPathSet[i] = false;
    }
    distance[srcIndex] = 0;

    for (int count = 0; count < V - 1; count++)
    {
        // Pick minimum distance set not yet processed
        int currentIndex = minDistanceIdx(distance, shortestPathSet);
        shortestPathSet[currentIndex] = true;

        for (int v = 0; v < V; v++)
        {
            if (shortestPathSet[v] == false 
                && (adjacencyMatrix[currentIndex][v] != 0) 
                && distance[currentIndex] != INT_MAX 
                && (distance[currentIndex] + adjacencyMatrix[currentIndex][v] < distance[v]))
            {
                distance[v] = distance[currentIndex] + adjacencyMatrix[currentIndex][v];
            }
        }
    }
    // print the constructed distance array
}

int main()
{
    // adjacency matrix. Vertices represented by index numbers
    int graph[V][V] = {{0, 4, 0, 0, 0, 0, 0, 8, 0},
                       {4, 0, 8, 0, 0, 0, 0, 11, 0},
                       {0, 8, 0, 7, 0, 4, 0, 0, 2},
                       {0, 0, 7, 0, 9, 14, 0, 0, 0},
                       {0, 0, 0, 9, 0, 10, 0, 0, 0},
                       {0, 0, 4, 14, 10, 0, 2, 0, 0},
                       {0, 0, 0, 0, 0, 2, 0, 1, 6},
                       {8, 11, 0, 0, 0, 0, 1, 0, 7},
                       {0, 0, 2, 0, 0, 0, 6, 7, 0}};

    // TODO implement Dijkstra's algorithm here

    return 0;
}