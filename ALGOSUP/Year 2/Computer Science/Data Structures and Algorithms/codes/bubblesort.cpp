#include <iostream> 

#define SIZE_N 100

using namespace std; 

int _OP_COUNT = 0;
int _COMP_COUNT = 0;

void bubbleSort(int* numArray, int size)
    {
        for (int i = 0; i < size - 1; i++)
        {
            _COMP_COUNT++;
            for(int j = 0; j < size - i - 1; j++){
                if(numArray[j] > numArray[j + 1]){
                    _OP_COUNT++; 
                    int temp = numArray[j];
                    numArray[j] = numArray[j + 1];
                    numArray[j + 1] = temp; 
                }
            }
        }
    }

void insertSort(int* numArray, int size){
    for (int i = 0; i < size; i++)
    {
        int j = i + 1;
        while (j > 1 && (numArray[j - 1] > numArray[j]))
        {
            int temp = numArray[j];
            numArray[j] = numArray[j - 1];
            numArray[j - 1] = temp;
            j--;
        }

    }
}

void printArray(int* numArray, int size) {
    cout << "Array contents: " << endl;

    for (int i = 0; i < size; i++)
    {
        cout << numArray[i] << ",";
    }
    
}

int main()
{
    int myArray[SIZE_N];
    for (int i = 0; i < SIZE_N; i++)
    {
        myArray[i] = rand() % SIZE_N; // Fix rand function call
    }
    
    bubbleSort(myArray, SIZE_N);
    printArray(myArray, SIZE_N);

    cout << "operations: " << _OP_COUNT << endl; // Fix output format
    cout << "comparisons: " << _COMP_COUNT << endl; // Fix output format
    return 0;
}

