Computer Science 25/09/2023


What are computers for? 
	Do things for humans faster and more efficiently + speed up intellectual work. 



History of modern computing : 

Ada Lovelace created the first ever computer algorithm during the 19th century. 
Created along with Charles Babbage the analytical engine which led to more complex operations (ex: Bernoulli) 

Alan Turing (1912-54)
Created the Turing machine and established the limits of what computers can or cannot do. 



Caesar Cypher : 
shift each letter by 1 position. Easy to decipher. Letters are too frequent + human language is too predictable whatever the language is. 

Enigma : 
shift changes for each letter. 
Deciphering via Brute force would take forever to do. 
So use math to find the weak points of the german cipher + a machine is faster than humans. 

Bomba Decipher : 
Exploit weaknesses 
Use of cribs 
based on known plain-text attack


John von Neumann : 
Created basic modern computer architecture 

Neocortex <-> decision-making + reasoning <-> CPU (central processing unit) 

Short/long-term memory <-> working + memory <-> Memory + storage 

Sensory + motor neurons <-> outside world interactions <-> Input/Output systems 


Types of memory : 
In computer, RAM (volatile, fast-access) and storage (slow, non-versatile) 
Human brain working memory + long term memory 

Read VS Write :
Computers read + write data to memory 
The brain encodes (writes) + recalls (read) 

Access speed : 
–


Grace Hopper : 
Created the world’s first compiler *
Paved way to high level language programming 

Made machine language more readable 

C language → Compiler → assembler → binary 


Binary 
Each position in a number represents a power of 2. 

Bit represents a single 0 or 1.
Bytes = eight bits put together 10001011

1 → 2⁰ = 1 
11 → 2e2 = 4 
111 → 2e3 = 8 

Hexadecimal : 
0123456789ABCDEF
1 nibble = 4 bits 




Von Neumann architecture : 
3 types of “bus”
Control bus (let the cpu know what we wanna do) 
Address bus (tell the cpu where to read/write)
data bus 

Bus width 
byte (8 bits) 
word (16 bits, 2 bytes)
long (32 bits, 4 bytes)

64 bit architecture is a long width, either 32 or 64 depending on language etc…







analog = wave 
convert bits to a sound (ex cassette) 



Basic boolean operations: 
“And operation”
0-0 = 0				
0-1 = 0
1-0 = 0
1-1 = 1 

“or operation” 
0 | 0 = 0
1 | 1 = 1 
1 | 0 = 1 
0 | 1 = 1 


 








Origine du mot algorithme : 
Le mot « algorithme » vient du nom du mathématicien Al-Khwârizmî (latinisé au Moyen  ge en Algoritmi), rapprochement avec le grec ἀριθμός (arithmós)





VOIR NOTES SUR CAHIER DE BROUILLON 


















27/09
RGB = Red Green Blue
RGB : 
0xFF0000 | 0x00FF00 | Ox00FF00

white = 0xFFFFFF
dark blue = 0x0000FF
light blue = 0x00FFFF
grey = RGB(128,128,128) = 1000 0000 = 0x808080			
orange = 0xFF8040

0x00FF00 	0b 00000000 11111111 00000000
0xFFF110 	0b 11111111 11110001 00010000
0xFFAA48 	0b 11111111 10101010 01001000
0xEDA27B 0b 11101101 10100010 01111011

Shift: 
11110000 >> 1 : 0b 0111 1000
10100101 >> 2 : 0b 0010 1001
10101010 >> 3 : 0b 0001 0101
00001111 << 4 : 0b 1111 0000

Roll: 
11110000 LROLL(1) : 1110 0001 
10100101 LROLL(2) : 1001 0110
10101010 LROLL(3) : 0101 0101
00001111 RROLL(4) : 1111 0000

And operation : 
0110 and 1001 = 0000
0xFF and 0xF0 = 0xF0 
0xF0FF and 0xOFOF = 0x000F



Or operation: 
0110 or 1001 = 0b 1111
0xFF or 0xF0 = 0xFF
0xF0FF or 0x0F0F = 0xFFFF



Xor operation: 
0110 xor 1001 = 0b 1111
0xFF xor 0xF0 = 0x0F
0xF0FF xor 0x0F0F = 0xFFF0

Xor 			 






Inverse: 
0110 = 1001
0xFF = 0x00
0xF0FF = 0x0F00
0xA083 = 0x5F7C
0xA3E8 = 0x5C17
0x4FB1 = 0xB04E

inverse = step to go to 15 




Hexadecimal to binary : 
0xFFAA48 = 0b 111111111010101001001000



0xA xor 0xA = 0b 1010 xor 1010 = 0000
0xF3 xor 0x3F = 0b 1111 0011 xor 0011 1111 = 1100 1100 = CC 
0xCC xor F3 = 0b 1100 1100 xor 1111 0011 = 0011 1111 = 3F


RGB24 → RGB12

Ox EDA27B → Ox OEA7

Ob 1110 1101 1010 0010 0111 1011 → 0000 1110 1010 0111

EDA27B 

R8 = ED → RGB >> 16
G8 = A2 → (RGB << 8) AND 0x00FF
	         RGB >> 16
B8 = 7B → RGB << 16

00EDA2 AND 0000FF → 0000A2

Binary counting:
0000 = 0 	1001 = 9 →
0001 = 1 	1010 = 10 → A
0010 = 2	 1011 = 11 → B
0011 = 3 	1100 = 12 → C
0100 = 4 	1101 = 13 → D
0101 = 5 	1110 = 14 → E
0110 = 6 	1111 = 15 → F (0xF)
0111 = 7
1000 = 8 	10000 → overflow


The inverse is the steps to go to 15 (inverse of A is 5 ‘cause 10 + 5 = 15)
0xFF0000 | 0x00FF00 | 0x00FF00 = 0xFFFF00 RGB
64 = 0100 0000 → 0x40
128 = 1000 0000 → 0x80
255 = 1111 1111 → 0xFF
(255;128;64) → 0xFF8040
0x00FF00 = 0b000000001111111100000000
0xFFF110 = 0b111111111111000100010000
0xFFAA48 = 0b111111111010101001001000
0xEDA27B = 0b111011011010001001111011
Shift:
1111000011110000 >> 4 → 0b0000111100001111 (exceeding numbers are disappearing)
Roll:
1111000011110000 << 4 → 0b0000111100001111 (exceeding numbers are re-including)
0xF0FF AND 0x0F0F → 0x000F
0xFOFF OF 0x0F0F → 0x FFFF
xor = 0 | 0 = 0
	0 | 1 = 1 When there are 2 same numbers, they will be 0
	1 | 0 = 1 When there are 2 different numbers, they will be 1
	1 | 1 = 0
0xA xor 0x0 = 0x1010
0xF3 xor 0x3F = 0x1111 0011 xor 0x0011 1111 = 0x1100 1100 = 0xCC
0xCC xor 0xF3 = 0x1100 1100 xor 0x1111 0011 = 0x0011 1111 = 0x3F
 R G B 














{
	var r, g ,b 

	r = (rgb24 AND 0xF000000) >> 12
	g = (rgb24 AND 0x00F000) >> 8 
	b = (rbg24 AND 0x00F0) >> 4 

	return (r OR b OR g)
}



10/02/2023



OPEN SOURCEEEEEEEEEE :

Open source is the “Freedom to see the source code, to modify it , to redistribute it, to make it available and to work for the user in whatever way..” 
Open source means distributing software in the form of source code, guaranteeing the user the right to study how it works but also to modify it, improve it or redistribute it. 


Freedom to sell, to access source code, to create derivative work, of use for any field.



permissive licenses - MIT/BSD
restrictive licenses - GPL/LGPL

MIT can be transferred to GPL the other way around isn’t possible.
hybrid licences - GPL/LGPL/Commercial: 
used in academic project (GPL) 
commercial context w/ limited integration possibilities(LGPL) 
can be used in private mode(commercial licence) 




4 great categories of UI : 

Batch computing - punch cards 
CLI - Command line interface 
GUI - Graphical user interface 
Touch - Touch screen 
Voice - Alexa.. 




Operating Systems :
Windows  
Linux 
… 

Filesystem : NTFS, EXT4 

User interface: CLI, GUI


The Operating System : 

Altair 8800(1975) → Apple (1977)

OS = system software that manages computer hardware, software resources and provides various services for computer programs. Sits between user and computer.

Resource allocator (allocate resources) 
Control program (manages execution/prevent errors)
interface provider (provides a UI)
data management (handles the storage)
task management (manages tasks)
service provider (offers services to support functions of application software)
hardware abstraction (abstracts and interacts with computer hardware)
How is a program loaded into a computer ?

insert diapo 


Different OS on the market: insert diapo





Multitasking: 
The ability for an OS to run several processes simultaneously. 

insert diapo *

coop multitasking: allows processes to run until they voluntarily yield control potentially monopolizing the cpu if they don’t relinquish it. 

preemptive multitasking: forcibly interrupts processes to allocate cpu time to others, controlling how much computing resources each process will obtain.











The filesystem  

how the data are written/read by the system 
The invention of the filesystem was driven by the need to organize, manage, and store data on computer storage devices in an efficient and retrievable manner. 

Organization →
File, folders, links… →
Filename,conventions, name length, forbidden characters


Storage efficiency →
What proportion of the device is occupied by the filesystem structure? →
Maximum storage capacity, how many files per folder max..




Data integrity →
How to prevent and detect data corruption? →
Is it possible to recover a file? 




Security
Access control, privilege, confidentiality 





The filesystem is made of: 
root
file 
folder


insert les diapos là 



The biggest filesystem difference between Unix and Windows 




CLI: is a user interaction mode where commands are typed in a terminal or a console to perform specific tasks. 

some of the most common commands:
dir
copy
del
move
mkdir
rmdir
tracert 
ipconfig
ping
echo 
cls
type
find
help
attrib
tasklist
taskkill
notepad
call 
chkdsk 
diskpart
net
runas
systeminfo


Some of the most common command Unix: 
ls
mv
rm
mkdir
rmdir
pwd
sudo
ps
kill
top
df
du
man
grep
more
cat
login
exit
alias
clear
whereis
chmod
chown
nano
ping
traceroute
ifconfig

cwd = Current Working Directory


CLI or Command Line Interface, commands are typed on a terminal or console to perform specific tasks within an OS. Relies solely on text input and output. 







10/04/2023

Mixing color (RGB) →Average : AVG(A,B) = (A+B)/2 

0xFF0000 + 0x0000FF / 2 = 0x7F007F

dividing by 2 = shifting by 1 bit

0xFF/2 = 0b1111 11111 >> 1 
0111 1111 = 0x7F 
Decimal (base 10) 	VS 	Binary (base 2) 

3000/100 = 30 	1110 >> 1 = 0111 = 7
100/10 = 10		1110 / 10 = 
10*10 = 100 



EVEN 
2,4,6,8,10,...
LSB = 0 
ODD
3,5,7,9,...
LSB = 1  


LSB = Least Significant Bit

0xFF0000 = red
0x0000FF = blue 


0xFF0000 + 0x0000FF = 0xFF00FF

0xFF00FF / 2 

0b 11111111 00000000 11111111

r = 1111 1111 < 1 = 0111 1111 = 0x7F 
g = 0000 0000 < 1 = 00000000 = 0x00 
b = 11111111 < 1 = 0111 1111 = Ox7F 

return (r OR g OR b) 


{


return (r OR g OR b) 
}



0x64FAC1 = 0b 01100100 11111010 11000001
0xB847C2 = 0b 10111000 01000111 11000010


0x64FAC1 AND 0xB847C2 = 0010 0000 01000010 11000000
2 0 4 2 12 0 
0x2042C0 


Correction: 
0xFF00FF AND 0x000000
0xFFFFFF AND 0x00FF00
0b11110000 AND 0b 00111100

0b00110000
0x30



color 1: 0xFF0000 				color 2: 0x0000FF

0xFFFFFF >> 12 → 0x0000FF : r = 0xFF
0xFFFFFF >> 8 → 0x00FFFF : g = 0xFF
0x00FFFF AND 0x00FF00 → 0x00FF00
b = 0xFFFFFF << 12 = 0xFF


R = 	0xFF0000 >> 16 		0x0000FF >> 16 
	0x0000FF 		+	0x000000
			0x0000FF/2
				=
				7F



G =	 0xFF0000 << 8 			0x0000FF << 8 
				AND		 	
	0x000000 		+		0x000000
			0x000000/2
				=
			0x000000

R = 	0xFF0000 << 16 		0x0000FF << 16 
	0x000000 		+	0xFF0000
			0xFF0000/2
				=
				7F

return (r OR g OR b)




—------------------------------------------------------------------------------------------------------------------------
																			The core of coding logic														


	

09/10/2023																		

Why do we need data compression? 								
 data compression schemes 
RLE : Run-length Encoding : 22.5KB
LZ : Lempel-Ziv : 4.66KB
LZMA : Lempel-Ziv-Markov-Chain-Algorithm : 2.42KB 

RLE: compresses data by reducing sequences of repeating elements to a single value and count. 
“AAAABBB” becomes “4A3B”. 																
LZ : employs a dictionary method replacing repeated data sequences with references to earlier occurrences. 
“ABABABAB_CDCDCDCD*EFKEFKEFK”

[AB] [CD] [EFK]  			{1,5}_{2,4}*{3,3}		


LZMA : uses a Markov chain to predict sequential data and applies precise range encoding for compression achieving notable compression ratios. 
								
Original file –> find repeated patterns –> learn pattern predictability –> build dictionary, probabilistic model																												


Memory and CPU architecture 

CPU : executes instruction	
RAM (Random access memory) : volatile memory 
ROM (Read-only memory)  : Stores firmware and boot-up instructions 
I/O : handles communication between a computer and an external device  
HDD (Hard Disk Drive) : Magnetic storage device for digital data with moving parts 
SSD (Solid-state drive): fast, durable storage device without moving parts for digital data 														
																			

How to improve the speed of the architecture?

Solution#1 : Increase the CPU’s clock speed. 
Zilog Z80 - 4Mhz (1976) → Intel 80386 12-40Mhz (1985) → IBM PowerPC 450Mhz (1997) → Intel Core i9 5Ghz (2019) 														

Heat dissipation : increasing speed = more heat demanding to be cooled down. → Air vent + Water cooling
Power consumption : More speed = more power, affecting battery to data center power use. 
Signal integrity and Propagation delay: high speeds = compromise signal integrity and create timing issues 
Transistor switching speed : transistors have inherent switching speed limits w/ increasing speeds leading to issues like electron tunneling
Economic and Manufacturing Challenges: High speed CPUs necessitate technologically advanced and often financially prohibitive manufacturing processes and technologies
																										Solution#2: build a computer with more CPUs 
Communication Overhead : gotta ensure communication between CPUs = more complex and synchronization. 
Parallel processing : designing softwares that effectively utilizes multiple cpus for parallel processing can be… 

Memory access : Coordinating memory access between CPUs to avoid conflicts and ensure data consistency introduces additional complexities.

Hardware Compatibility : Ensuring all CPUs and associated hardware are compatible and can efficiently work together can be technically challenging. 

Cost Implications :  Employing multiple CPUs involves substantial financial investment in hardware, power, and cooling infrastructure.

Solution#3: Identify the bottlenecks. 

We put a Memory Cache between the RAM and the CPU to make it faster to access data. 	
		
Other strategies : 
SIMD (Single Instruction, Multiple Data) = Parallel computing architecture that allows a single instruction to perform the sale operation on multiple data points simultaneously. 
Highly efficient for graphics processing and scientific simulations.

Cache enhancement : Increasing cache size, or cache levels, optimizing cache algorithms.

Multi-core processors  : Implementing multiple processing cores on a single chip to parallelize data processing

Instruction level Parallelism : Executing multiple instructions in a single clock cycle. 






Bitmap, or how to store images? 

A Bitmap is a type of memory organization or image file format used to store digital images. 
The smallest unit of a bitmap is a pixel. 
A bitmap is always defined by a width and a height in pixels. 
The combination of width and height is called a resolution.

Bitmap, simple “one color” example: 
The term bitmap comes from bit and map.
A bitmap represents a grid of pixels. *
Even if a bitmap is a 2d representation the block of memory that contains it is always linear ( or 1D) 

shadertoy.com



What about audio files? 

Frequency refers to the number of vibrations of a sound wave per second.
A sample is essentially a snapshot of the audio wave. 
measured in kilohertz (kHz). a sample rate of 44.1kHz means that 44,100 samples are taken per second. 

Shannon’s sampling theorem states that to accurately reproduce a continuous audio signal in a digital format, it must be sampled at a rate. 


More boolean fun

boolean laws: 

Commutative law states that the interchanging of the order of operands in a boolean equation does not change its result. For example : 
OR operator → A + B = B + A 
AND operator → A.B = B.A 

Associative Law of multiplication states that the AND operations are done on two or more than two variables. for example: 
A.(B.C) = (A.B).C 

Distributive Law states that the multiplication of two variables and adding the result with a variable will result in the same value as multiplication of addition of the variable with individual variables. For example: 
A + B.C = (A+B) (A+C) 
A + (B.C) = (A+B) (A+C) 


Annulment law: 	A.0 = 0 
A+1 = 1

Identity law: 		A.1 = A 
A+0 = A 

Idempotent law: 	A+A = A 
A.A = A 			

Complement law: 	A + NOT A = 1
A.NOT A = 0

Double negation law: NOT(NOT(A)) = A 

Absorption law : 	A.(A+B) = A 
			A+A.B =A 
De Morgan law: 
The negation of a conjunction is the disjunction of the negations. 
NOT (A.B) = NOT A + NOT B 
The negation of disjunction is the conjunction of the negations 
NOT (A+B) = NOT A . NOT B 





11/10/2023

root path : >cd  C:/Users/Info/Desktop/ALGOSUP/New folder/New folder 2

copy C:/Users/Info/Desktop/ALGOSUP/New folder/New folder 2/test.txt

separator : “”

delete all the files that start with B : DEL B*.*
DEL AB?.* specifies that we accept only one character.






16/10/2023


Programming languages :

Turing machine 

What’s a programming language? 
A computer program is a series of instructions, written in a programming language that a computer follows and executes. 
A computer program when in a format readable by humans, is known as source code.

A programming language is a Turing complete, it has the ability to perform loops, conditionals and read/write operations. 



Is Minecraft “turing-complete”? 
Probably. 


How do we get from the source code to the machine code? 

The main programming paradigms : 

Low-level : assembly
Middle-level : C ? 
High-level : Python

Is there a better way to categorize these languages? 
Paradigms 

Procedural : C, C++, Go, Python, Cobol, Fortran. 

Object oriented : Java, C++, Python, Go, Ruby, OCaml

Functional : Haskell, Lisp, Erlang, Scheme, Python, Ocaml


What about Assembly? 
Imperative : Assembly, C 

imperative: 
gives the computer a sequence of tasks to execute 
specifies how precisely the computation is performed. 
Uses loops, variables, and conditionals to manipulate the state of the program 

inside imperative : procedural : 
Subtype of imperative programming 
Divides the programme into procedures ( or function or routines) and data structure to do specific tasks. 

Object oriented : 
Organizes code into classes “representing real world” objects (or concepts) 
Objects bundle data and the procedures that operate on that data 
interaction between objects are defined by interfaces (or methods) 

Functional : 
computes everything as mathematical functions 
avoids changing states or mutable data 
uses declarative expressions and avoids side effects 
Functions are 1st class citizens, passed as arguments or returned as values. 

What are these paradigms all about? 

“A programming paradigm is a way of programming that defines how we decide to solve problems with code.”

Three different languages and their main features : 

C : 
Manual Memory Management : Provides functions for manual memory management (,malloc, free, etc.. )

Static typing : Variable types must be declared and remain constant 

Pointers : Allow direct manipulation of memory via pointers

Structures : Allow grouping of data of different types 

Python : 
Dynamic typing : No need to explicitly declare variable types

Object oriented polymorphism : Supports polymorphism and allows objects of different types to respond to method calls of the same name, each with different interfaces. 

Garbage collection : Automatically manages(user) memory recovery. 


Go : 
Goroutines : Ease of concurrent programming by utilizing goroutines which are lightweight and managed by the language itself 

Static typing : Variable typing must be declared and remain constant. 

Garbage collection : Automatically manages (user) memory recovery 


Paradigm =/ interpreter 

How is a programming language implemented? 

Interpreters : Python, Ruby, PHP, JS, Lua, Shell Script
Compilers : C, C++ , Rust, Go, Ada, Kotli,


a program that runs a program : interpreter 

a program that builds a program :  compiler



Python source code → print(“Hello world”) → insert image. 

The python interpreter (CPython) parses the entire source code and converts it into a set of intermediate instructions (bytecode). This involves a form of “compilation”, although the result is not machine code, but bytecode, which is then executed by the Python virtual machine. 

Lexical analysis : The python source code is first broken down into “tokens” to identify keywords, identifiers, literals, etc.
Syntax analysis : The tokens are assembled into an abstract tree (AST) representing the grammatical structure of the code.
Semantic analysis : Checks for the logical coherence and adherence to language specifications
Compilation : The AST is compiled into bytecode, which is a lower-level platform-independent form of code.
Execution : The bytecode is sent to the Python Virtual MAchine (PVM) for execution

During this compilation stage, the interpreter identifies defined functions, classes and variables. 


Python source code → compiler → bytecode → virtual machine → CPU/OS
			    (compile)			(execute) 

The C language compilation process translates the entire source code into machine code through several stages, eventually creating an executable file that can run independently of the original code. 

Preprocessing : incorporates the #include, #define and headers
Lexical Analysis : Breaks down the source into “tokens” to identify the basic elements (keywords, operators, identifiers, literals…) 
Syntax Analysis : The tokens are processed into an Abstract Syntax Tree (AST) 
Semantic analysis : Checks the AST for semantic errors and compliance to the language’s definition.
Code generation : The semantically valid AST is translated into intermediate or assembly code. Optimization of the code might also occur at this stage 
Assembly :The assembly code is processed by an assembler, converting it into machine code (or object code) 
Linking : The linker combines the machine code with necessary library code to produce a stand-alone executable file. Optimization might occur at this stage again 
Execution : Finally the executable file can be run independently on the appropriate platform without requiring the original source code


C source code → Compiler → Assembly code → assembler —> Machine code → Linker → 
      (compile)
executable → CPU/OS
		      

Abstract syntax tree : 
An abstract syntax tree (AST) is a tree representation of the syntactic structure of source code 

The syntax tree captures the hierarchical structure of code relationships, such as operator precedence and the association of procedure and their parameters

The euclidean algorithm, in the subtraction-based version, continuously subtracts the smaller number from the larger number, replacing the larger number with the difference, until the two numbers become equal.
This method iteratively reduces the size of the number until they converge on their greatest common divisor.

How many different implementations of Javascript?
bokou

V8 : 
Implements just-in-time compilation (JIT), translating JS code into machine code at runtime, which is then executed directly by the computer’s CPU
Uses two compilers: ignition (an interpreter) and TurboFan (an optimizing compiler) to manage a balance between startup performance and peak performance. 


QuickJS : 
incorporates an interpreter for direct execution of JS code and a bytecode compiler which can precompile JS to bytecode. 
Does not employ JIT compilation and thus doesn’t convert code into machine code, which generally results in less processing overhead and memory usage compared to V8 


Emulator vs Simulator 

Emulator : 
mimics a hardware or software system. In a development context, this means that an emulator reproduces the internal behaviors of the emulated system. 

Seeks to faithfully replicate all functionalities of the original system, for example, a video game console emulator would run original games by imitating the hardware of the console.

Simulator : 
Creates an environment that resembles the system. It tries to replicate but does not try to emulate the internal operation of the system.

In mobile development…
10/23/2023 

The memory of computers is linear…
Except… 
Modern computer can combine : 
Physical memory 
Virtual memory 
Compressed memory 


Not all the physical addresses of a computer are contiguous : 
The memory controller will assign an address to each block of physical memory 




Big Endian vs Little Endian : 

The endianness refers to the byte order in which data is stored in memory. The debate between Big Endian and Little Endian arises from the choice of where to store the most significant byte (MSB) of multi-byte data types. 

Big Endian : The most significant byte is stored at the lowest… 

The order of the bits within each byte is the same regardless of the machine’s architecture. The position of each bit within one byte is not affected by the endianness.

Little Endian : The least significant byte is stored at the lowest memory address…



Big Endian : The most significant byte of the 32 bit word is placed in memory at the byte with the lowest address

Little Endian : The least significant byte of the 32 it word is placed in memory at the byte with the lowest address. 


Big Endian vs Little Endian in the industry : 

Big endian CPUs: Motorola 68k, IBM mainframes. 
Little Endian CPUs : Intel/AMD x86 and x64 

Bi Endian CPUs : IBM, PowerPC, ARM 



What are the consequences on your projects? 
You need to consider endianness when: 

Writing low level code (C++, C or Assembly=
 Dealing with binary formats storing data on words (16 or 32 bits)
Working on multi-platform software with varying CPU architecture



UTF and Endianness

UTF-8 was invented to provide an efficient and compatible way to represent every character in the Unicode standard while maintaining compatibility with ASCII and addressing the challenges of multi-byte encodings. 

UTF-8 allows for the representation of a wide range of characters from various languages and scripts using a variable length encoding that's both space-efficient for common characters (like ASCII) and adaptable to the entire Unicode range.

In UTF-8 the question of big endian and little endian is not addressed as for UTF-16 or UTF-32 

UTF-8 is a variable length byte encoding. Each 
: 
: 

In a nutshell, UTF-8 combines ASCII and UNICODE within a consistent and backward-compatible storage format. 
 






Code versioning 


Track and follow the changes 
QA / debugging 
Experiment features 
Collaborative effort 


History of code versioning…

cvs,  subversion, alienbrain, Perforce, git, mercurial 


Client/server architecture is a computing model… 


SUBVERSION 

Repository structure & philosophy : SVN uses a centralized system. Users check out only on version of files, not the whole repository history.
*
Branching and merging : Branching is done by creating a copy of the code into a new directory. Merging can be more complex nd error-prone.

Commits : Linear and sequential, Each commit increments a global revision number. 

Working directory each sub-directory can have its own .svn directory with metadata, allowing for sub-directory checkouts 

Network access : 

Collaboration



git : 

Repository structure & Philosophy : 

Branching & Merging 
Commits









Github isn’t Git : 
Git : It’s a distributed version control system used to track changes in source code during software dev. It allows 








Github vs Gitlab : 
Github : Acquired by Microsoft in 2018, Github was originally an independent company. 

Offers free private repositories and has various paid plans with additional features.

Github enterprise allows for self-hosting but is primarily a cloud service 

The platform itself is not open source, but it is a major hub…






Git LFS (Large File System) 
Purpose : Git repositories can grow significantly in size when large files (e.g, binaries… 





Vectors, bitmap and DPI 



What are bitmap (Raster) images ? 
composed of individual pixels 
each pixel holds color information 
examples JPEG, PNG,BMP,GIF

What are vector images ? 
defined by mathematical equations and geometric primitives. 
comprised of paths, points , lines, curves
Exemples: SVG, AI, EPS. 


Bitmap images (again) : 	


vector images 
advantages : 
scalable without loss 
typically smaller files 
ideal for logos, icons and illustrations 

Limitations : 
Not suitable for complex images like photograph 
limited in the representation of colors 


Bitmap and vector images overview : 
Bitmap vs vector When to use? 
Bitmap : photographs, complex images, digital painting








Bitmap limitations and interpolation methods  

interpolation methods 
Nearest neighbor : 
Simplest method: maps the closest pixel’s color 
fast but can produce jagged or “pixelated” images
bilinear interpolation: 
Considers the closest 2x2 neighborhood of known pixel value surrounding an unknown pixel 
it then takes a weighted average of these 4 pixels to arrive at its final interpolated value 
smoother than nearest neighbor but can be blurry 
bicubic interpolation : 
Uses polynomial functions (or splines) to determine pixel values
Typically offers smoother curves and lines than bilinear 
good for images with curves and gradient 
in areas for higher 
AI-enhanced upscaling : 
uses deep learning models trained on vast images sets 
can (re)introduce detail that's not present in the original 
often provides the most accurate and high-quality results but requires more computational power

Gigapixel AI 


