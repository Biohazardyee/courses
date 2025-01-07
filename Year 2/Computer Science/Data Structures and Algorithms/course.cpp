#include <stdio.h>

//linking section
#include <iostream>
using namespace std;

//definition section
#define message "factorial"
typedef int GT_int;

//global declaration section 
GT_int num = 0; 
GT_int fact = 1;
GT_int store = 0; 

GT_int factorial(GT_int num){
    if (num == 0){

    }
    for (GT_int i = 1; i <= num; i++){
        fact = fact * i; 
    }

    return fact;
}

GT_int main(){

    GT_int num = 6;
    
    store = factorial(num);

    cout << message << " of " << num << " is " << store << endl;
    cout << "This is a new line" << endl;

    return 0;
}