#include <iostream>
#include "balanceBST.hpp"

using namespace std;

// typedef struct Node
// {
//     int data;
//     struct Node *leftChild;
//     struct Node *rightChild;
// } Node;

Node *ROOT = NULL;

void insert(int data)
{
    Node *temp = new Node;
    Node *current;
    Node *parent;

    temp->data = data;
    temp->leftChild = NULL;
    temp->rightChild = NULL;

    if (ROOT == NULL)
    {
        ROOT = temp;
    }
    else
    {
        current = ROOT;
        parent = NULL;

        while (true)
        {
            parent = current;

            if (data < parent->data)
            {
                current = current->leftChild;

                if (current == NULL)
                {
                    parent->leftChild = temp;
                    return;
                }
            }
            else
            {
                current = current->rightChild;

                if (current == NULL)
                {
                    parent->rightChild = temp;
                    return;
                }
            }
        }
    }
}

void preOrderTraversal(Node *root)
{
    if (root != NULL)
    {
        cout << root->data << endl;
        preOrderTraversal(root->leftChild);
        preOrderTraversal(root->rightChild);
    }
}

void inOrderTraversal(Node *root)
{
    if (root != NULL)
    {
        inOrderTraversal(root->leftChild);
        cout << root->data << endl;
        inOrderTraversal(root->rightChild);
    }
}

void postOrderTraversal(Node *root)
{
    if (root != NULL)
    {
        postOrderTraversal(root->leftChild);
        postOrderTraversal(root->rightChild);
        cout << root->data << endl;
    }
}

int main()
{
    int array[7] = {27, 30, 35, 10, 19, 31, 42};

    for (int i = 0; i < 7; i++)
    {
        insert(array[i]);
    }
    postOrderTraversal(ROOT);
    balanceBST(ROOT);
    cout << "Preorder Traversal: " << endl;
    inOrderTraversal(ROOT);

    return 0;
}