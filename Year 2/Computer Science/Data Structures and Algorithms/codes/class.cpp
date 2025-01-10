#include <iostream>

using namespace std;

class Node
{
    public:
        int value;
        Node* next;
};


class AlgoList
{
    public:
        int getSize();
        Node* getHead();
        Node* getTail();
        void push(int element);
        int pop();
        int getElementAt(int index);
        int setElementAt(int index, int value);  
        AlgoList();                               // default constructor
        AlgoList(int size);
        AlgoList(int size, Node* newHead);       //overloading constructor
    
    private: 
        int size;
        Node* head;
        Node* tail;

};

AlgoList::AlgoList()
{
    // todo do default constructor stuff
}

AlgoList::AlgoList(int size)
{
    this->size = size;
    // allocate space for size elements
}


int AlgoList::getSize()
{
    return size;
}

Node* AlgoList::getHead()
{
    return head;
}

Node* AlgoList::getTail()
{
    return tail;
}
