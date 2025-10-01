# Classes & Objects

- Procedural languages (e.g., C, Pascal) are based on the concept of procedure calls.

- Data are separated from subroutines (procedures/functions) that operate on them.

- We must first start by identifying the main function and the data structures.

## Two Downfalls of Procedural Programming

1. The written functions for a project will rarely be reusable in other projects.
2. Data decouplage between data and functions means that a modification of the data structure may require a modification of all functions that manipulate this data structure.

## Object-Oriented Programming (OOP)

- Regroup inside of one entity both data and functions that operate on this data.
- Break the decouplage between data and functions. Produces more reusable code.

### Objects

- An entity that has:
  - an identity (name)
  - variables defining its state (attributes)
  - functions defining its behavior (methods)

### Classes

- An abstract way to regroup objects with the same attributes and methods.

- An object is an instance of a class. It distinguishes itself from other instances by its attribute values.

- We find our nomrla way of thinking about the world where we classify elements into categories (classes) and subcategories (subclasses). (Animals, vehicles, computers, students, books, etc.)

- In an abstract way, a class could be seen as a mold in a factory.

Exemple: a rectangle class and a person class.

Rectangle: width: float, height: float, area(): float, perimeter(): float

Person: surname: str, name: str, year: int, age(): int

### Object Instantiation

Two instances for the person class:

Mick : name="Jagger", surname="Mick", year=1943

Keith : name="Richards", surname="Keith", year=1943

### Procedural vs OOP

- In OOP one of the most fundamental question is "why is the program about?" (the objects)

- In opposition to procedural programming where the main question is "what is the program about?" (the functions)

- This difference can be found during the conception phase, where we would reserve classical algorithms to method implementation, in opposition to we would use graphic language such as UML to design the classes and their relationships.

### Abstraction

- Retain only the attributes and methods that are relevant for the problem we want to solve.

“An abstraction denotes the essential characteristics of an object that distinguish it from all other kinds of object and thus provide crisply defined conceptual boundaries, relative to the perspective of the viewer.” - Grady Booch

exemple:

- A class person in a SUPINFO context will have, name, surname, ID, Marks... attributes

- However, in a health security context, the same person class will have name, surname, social security number, blood type... attributes.

### Encapsulation

- Disallows access to some attributes and methods from outside the class.

- We will communicate with the object through services defining the accesibility of the object, it is the role of methods.

#### 2 key points

1. Simplify the evolution of an application, we can modify the attributes of an object without modifying the code that uses this object.

2. Protect the integrity of the data, we can control the way data are accessed or modified.

#### Visibility of Attributes and Methods

- An attribute or method are said private if their usage is restricted to the class itself.
- An attribute or method are said public if they can be used outside of the class.

- The goal of incapsulation is to declare attributes as private and to provide public methods to access and modify them.

#### Accesing Private Attributes and Methods

- To access attributes from outside of the object, we will use specific methods
  - a getter, which is a method whose role is to return the value of an attribute
  - a setter, which is a method whose role is to modify the value of an attribute

Exemple:

- an account class with private attributes: name: string, number: int, balance: float

To change the value of the balance, we will necessarily use a public method (setBalance) that controls the new value of the balance (for example, it must be positive).

## Classes & Objects in Python

- We start by declaring a class which is going to be the mold to our futur objects.

```python
class myClass:
    # class attributes
    # constructor
    # methods
```

- Depending of our needs, we will instantiate the objects of the class, each of them have an identity and values for the attributes that are unique.

```python
myObject = myClass()
```

### Declaring a method

```python
class myClass:
    def myMethod(self, param1, param2):
        # method body
    def myMethod2(self):
        # method body
```

- The first parameter of a method is always a reference to the object. Usually named `self`.

- Other parameters are data transmitted to the method.

- Declaring a method is made inside of the class
- Syntax of a method is the same as a function.
- Parameters can have default values.

### The Constructor Method `__init__`

- Specific method enabling to declare and initialize the attributes of an object.

```python
class myClass:
    def __init__(self, para1, para2):
        self.attr1 = para1
        self.attr2 = para2
    def myMethod(self):
        # method body

myObject = myClass(val1, val2)
myObject.myMethod()
```

- Python is quite permissive and allows the dynamic creation of attributes, after instantiation of the object without using the constructor.

- Though this is bad practice and should be avoided.

#### Encapsulation of Attributes

- To declare a private attribute, we precede its name with two underscores `__`.

```python
def __init__(self, para1, para2):
    self.__attr1 = para1  # private attribute
    self.attr2 = para2    # public attribute
```

#### Accessing Private Attributes

From inside the class:

```python
self.__attr1
self.myMethod()
```

From outside the class:

```python
myObject.myMethod()  # public method
```

### Getter

- Its role is to return the value of an attribute, it contains generally only the return statement.

```python
def getAttr1(self):
    return self.__attr1

```

- In practice, there's a getter for each attribute

#### Accesing attributes and methods

From inside the class:

```python
self.__attr1
self.myMethod(para1, para2)
```

From outside the class:

```python
myObject.getAttr1()  # public method
```

### Class Attributes

- Attributes that have the same value for each instance of the class.

- It must be declared and intialized inside of the class but outside of any method.

- For instance: counting the number of instances of a class, constants etc.

### Class Methods

- Method having an independant behavior from the instances of the class.
- Its role will be to manipulate class attributes.
- Their name is preceded by the decorator `@classmethod`. and its first parameter is a reference to the class itself, usually named `cls`.

```python
class myClass:
    __myClassAttribute = 0  # class attribute

    def __init__(self, para1):
        self.__attr1 = para1
        myClass.__myClassAttribute += 1  # increment class attribute

    def myMethod(self):
        # method body

    @classmethod
    def myClassMethod(cls):
        return cls.__myClassAttribute  # access class attribute

```

In the case of a counter of instances, it is pertinent to increment inside of the constructor. and vice versa to decrement it when deconstructing.

### Deconstructor Method

- Method specific permeting to free memory of an object when it is no longer used.

- Its not always necessary to implement it, Python has a garbage collector that frees memory automatically.

- It will be useful to do it when another task is needed, like updating an attribute of a class.

- Its name is imposed **del**

````python
class myClass:
    def __init__(self, para1):
        self.__attr1 = para1
        # other initializations
    def __del__(self):

    def myMethod(self):
        # method body

````
