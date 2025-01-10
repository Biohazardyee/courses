#include <iostream>

#define MAX_CAPACITY 5000

using namespace std;

unsigned long hashfunction(char* key){
    
    unsigned long hash = 0;

    for (int i = 0; key[i]; i++)
    {
        hash += key[i];
    }

    return hash % MAX_CAPACITY;
}

typedef struct 
{
    char* key; 
    long value;
} Item;

typedef struct HashTable
{
    Item** Items; 
    int elements; 
    int capacity;
} HashTable;


Item* createItem(char* key, long value)
{
    // todo
}

HashTable* createTable(int capacity)
{
    // todo
}

void deleteItem(Item* item)
{
    // todo
}

void deleteItem(char* key, long value)
{
    // todo
}


void deleteHashTable(char* key, long value)
{
    // todo
}


int main()
{
    char* key = "hello";
    cout << hashfunction(key) << endl;
    return 0;
}
