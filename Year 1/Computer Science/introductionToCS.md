# Computer Science Notes (25/09/2023)

- [Computer Science Notes (25/09/2023)](#computer-science-notes-25092023)
	- [What are computers for?](#what-are-computers-for)
	- [History of Modern Computing](#history-of-modern-computing)
		- [Ada Lovelace](#ada-lovelace)
		- [Alan Turing (1912–1954)](#alan-turing-19121954)
	- [Caesar Cipher](#caesar-cipher)
	- [Enigma](#enigma)
		- [Bomba Decipher](#bomba-decipher)
	- [John von Neumann](#john-von-neumann)
		- [Analogies](#analogies)
	- [Types of Memory](#types-of-memory)
	- [Read vs Write](#read-vs-write)
	- [Grace Hopper](#grace-hopper)
	- [Binary](#binary)
		- [Binary Examples](#binary-examples)
	- [Hexadecimal](#hexadecimal)
	- [Von Neumann Architecture](#von-neumann-architecture)
		- [Bus Width](#bus-width)
	- [Analog vs Digital](#analog-vs-digital)
	- [Basic Boolean Operations](#basic-boolean-operations)
		- [AND Operation](#and-operation)
		- [OR Operation](#or-operation)
	- [Etymology of the word "Algorithm"](#etymology-of-the-word-algorithm)
- [Additional Notes (27/09)](#additional-notes-2709)
	- [RGB Color Representation](#rgb-color-representation)
		- [Hex to Binary Conversion](#hex-to-binary-conversion)
	- [Bitwise Shift Operations](#bitwise-shift-operations)
	- [Bitwise Roll Operations](#bitwise-roll-operations)
	- [Bitwise AND Operation](#bitwise-and-operation)
	- [Bitwise OR Operation](#bitwise-or-operation)
	- [Bitwise XOR Operation](#bitwise-xor-operation)
	- [Inverse Operation](#inverse-operation)
- [Hexadecimal to Binary Conversion](#hexadecimal-to-binary-conversion)
- [RGB24 to RGB12](#rgb24-to-rgb12)
		- [Breakdown](#breakdown)
		- [Example](#example)
- [Binary Counting](#binary-counting)
		- [Notes](#notes)
- [XOR Logic](#xor-logic)
- [RGB Mixing and Shifting](#rgb-mixing-and-shifting)
		- [RGB Example](#rgb-example)
		- [Shifting](#shifting)
		- [Rolling](#rolling)
- [Logical Operations](#logical-operations)
		- [XOR Rules](#xor-rules)
- [Open Source](#open-source)
		- [Key Points](#key-points)
		- [Licenses](#licenses)
- [User Interfaces](#user-interfaces)
- [Operating Systems](#operating-systems)
		- [Filesystems](#filesystems)
		- [The OS provides](#the-os-provides)
- [Filesystem](#filesystem)
		- [Key Features](#key-features)
		- [Components](#components)
- [Common Commands](#common-commands)
		- [Windows CLI Commands](#windows-cli-commands)
		- [Unix Commands](#unix-commands)
		- [CLI (Command Line Interface) relies on text input and output](#cli-command-line-interface-relies-on-text-input-and-output)
- [RGB Color Mixing](#rgb-color-mixing)
		- [Average Formula](#average-formula)
- [Data Compression](#data-compression)
		- [Compression Schemes](#compression-schemes)
- [Memory and CPU Architecture](#memory-and-cpu-architecture)
	- [Solution#1: Increase the CPU’s clock speed](#solution1-increase-the-cpus-clock-speed)
	- [Solution#2: Build a computer with more CPUs](#solution2-build-a-computer-with-more-cpus)
	- [Solution#3: Identify the bottlenecks](#solution3-identify-the-bottlenecks)
	- [Bitmap, or how to store images?](#bitmap-or-how-to-store-images)
	- [What about audio files?](#what-about-audio-files)
	- [Boolean Fun](#boolean-fun)
	- [Command Line Operations](#command-line-operations)
	- [Programming Languages Overview](#programming-languages-overview)
		- [Turing Machine \& Turing Completeness](#turing-machine--turing-completeness)
		- [Is Minecraft Turing-complete?](#is-minecraft-turing-complete)
	- [Source Code to Machine Code](#source-code-to-machine-code)
		- [Programming Paradigms](#programming-paradigms)
		- [How do we get from source code to machine code?](#how-do-we-get-from-source-code-to-machine-code)
		- [Python Compilation Process](#python-compilation-process)
		- [C Compilation Process](#c-compilation-process)
	- [Abstract Syntax Tree (AST)](#abstract-syntax-tree-ast)
	- [JavaScript Implementations](#javascript-implementations)
	- [Emulator vs Simulator](#emulator-vs-simulator)
	- [Memory in Modern Computers](#memory-in-modern-computers)
- [Big Endian vs Little Endian](#big-endian-vs-little-endian)
		- [Big Endian](#big-endian)
		- [Little Endian](#little-endian)
		- [Industry Examples](#industry-examples)
		- [When to Consider Endianness](#when-to-consider-endianness)
	- [UTF and Endianness](#utf-and-endianness)
- [Code Versioning](#code-versioning)
		- [Why Code Versioning?](#why-code-versioning)
		- [History of Code Versioning](#history-of-code-versioning)
	- [Subversion](#subversion)
		- [Repository Structure \& Philosophy](#repository-structure--philosophy)
		- [Branching \& Merging](#branching--merging)
		- [Commits](#commits)
		- [Working Directory](#working-directory)
	- [Git](#git)
		- [Repository Structure \& Philosophy](#repository-structure--philosophy-1)
		- [Branching \& Merging](#branching--merging-1)
		- [Commits](#commits-1)
	- [GitHub vs GitLab](#github-vs-gitlab)
		- [GitHub](#github)
		- [GitLab](#gitlab)
		- [Git LFS (Large File Storage)](#git-lfs-large-file-storage)
- [Bitmap vs Vector and DPI](#bitmap-vs-vector-and-dpi)
		- [What Are Bitmap (Raster) Images?](#what-are-bitmap-raster-images)
		- [What Are Vector Images?](#what-are-vector-images)
		- [Bitmap Images](#bitmap-images)
		- [Vector Images](#vector-images)
- [Bitmap Interpolation Methods](#bitmap-interpolation-methods)
		- [Nearest Neighbor](#nearest-neighbor)
		- [Bilinear Interpolation](#bilinear-interpolation)
		- [Bicubic Interpolation](#bicubic-interpolation)
		- [AI-Enhanced Upscaling](#ai-enhanced-upscaling)


## What are computers for?

- Do things for humans faster and more efficiently.
- Speed up intellectual work.

---

## History of Modern Computing

### Ada Lovelace

- Created the first-ever computer algorithm during the 19th century.
- Worked with Charles Babbage on the analytical engine, enabling more complex operations (e.g., Bernoulli).

### Alan Turing (1912–1954)

- Created the Turing machine and established the limits of what computers can or cannot do.

---

## Caesar Cipher

- Shift each letter by 1 position.
- Easy to decipher due to frequent letter repetition and predictable patterns in human languages.

## Enigma

- The shift changes for each letter, making brute-force deciphering impractical.
- Deciphering involves using mathematics to find weak points in the German cipher. Machines are faster than humans in this process.

### Bomba Decipher

- Exploited weaknesses using cribs (known plaintext attack).

---

## John von Neumann

- Created basic modern computer architecture.

### Analogies

- **Neocortex ↔ CPU** (central processing unit): decision-making and reasoning.
- **Short/long-term memory ↔ Memory + storage**: working and long-term memory.
- **Sensory + motor neurons ↔ I/O systems**: outside world interactions.

---

## Types of Memory

- **RAM** (volatile, fast-access) vs **Storage** (slow, non-volatile).
- Human brain: **Working memory** vs **Long-term memory**.

## Read vs Write

- Computers: Read and write data to memory.
- Brain: Encode (write) and recall (read).

---

## Grace Hopper

- Created the world’s first compiler.
- Paved the way for high-level programming languages.
- Made machine language more readable.

---

## Binary

- Each position in a number represents a power of 2.
- **Bit**: A single 0 or 1.
- **Byte**: Eight bits, e.g., 10001011.

### Binary Examples

- `1` → 2⁰ = 1
- `11` → 2¹ = 2
- `111` → 2² = 4

---

## Hexadecimal

- Digits: `0123456789ABCDEF`.
- 1 nibble = 4 bits.

---

## Von Neumann Architecture

- 3 types of buses:
  1. **Control bus**: Lets the CPU know what action to take.
  2. **Address bus**: Tells the CPU where to read/write.
  3. **Data bus**: Transfers data.

### Bus Width

- **Byte**: 8 bits.
- **Word**: 16 bits (2 bytes).
- **Long**: 32 bits (4 bytes).
- 64-bit architecture uses long width, either 32 or 64 depending on language, etc.

---

## Analog vs Digital

- **Analog**: Continuous wave.
- **Digital**: Convert bits to sound (e.g., cassette).

---

## Basic Boolean Operations

### AND Operation

| Input | Output |
|-------|--------|
| 0 AND 0 | 0 |
| 0 AND 1 | 0 |
| 1 AND 0 | 0 |
| 1 AND 1 | 1 |

### OR Operation

| Input | Output |
|-------|--------|
| 0 OR 0 | 0 |
| 0 OR 1 | 1 |
| 1 OR 0 | 1 |
| 1 OR 1 | 1 |

---

## Etymology of the word "Algorithm"

- The word "algorithm" comes from the name of the mathematician Al-Khwârizmî (Latinized in the Middle Ages to "Algoritmi"), connected with the Greek word ἀριθμός (arithmós, meaning "number").

---

# Additional Notes (27/09)

## RGB Color Representation

- **RGB**: Red, Green, Blue.
- Color codes:
  - White: `0xFFFFFF`
  - Dark Blue: `0x0000FF`
  - Light Blue: `0x00FFFF`
  - Grey: `RGB(128,128,128)` = `10000000` = `0x808080`
  - Orange: `0xFF8040`

### Hex to Binary Conversion

- `0x00FF00` → `0b 00000000 11111111 00000000`
- `0xFFF110` → `0b 11111111 11110001 00010000`
- `0xFFAA48` → `0b 11111111 10101010 01001000`
- `0xEDA27B` → `0b 11101101 10100010 01111011`

---

## Bitwise Shift Operations

- `11110000 >> 1` → `0b 0111 1000`
- `10100101 >> 2` → `0b 0010 1001`
- `10101010 >> 3` → `0b 0001 0101`
- `00001111 << 4` → `0b 1111 0000`

## Bitwise Roll Operations

- `11110000 LROLL(1)` → `1110 0001`
- `10100101 LROLL(2)` → `1001 0110`
- `10101010 LROLL(3)` → `0101 0101`
- `00001111 RROLL(4)` → `1111 0000`

---

## Bitwise AND Operation

- `0110 AND 1001` → `0000`
- `0xFF AND 0xF0` → `0xF0`
- `0xF0FF AND 0x0F0F` → `0x000F`

---

## Bitwise OR Operation

- `0110 OR 1001` → `1111`
- `0xFF OR 0xF0` → `0xFF`
- `0xF0FF OR 0x0F0F` → `0xFFFF`

---

## Bitwise XOR Operation

- `0110 XOR 1001` → `1111`
- `0xFF XOR 0xF0` → `0x0F`
- `0xF0FF XOR 0x0F0F` → `0xFFF0`

---

## Inverse Operation

- `0110` → `1001`
- `0xFF` → `0x00`
- `0xF0FF` → `0x0F00`
- `0xA083` → `0x5F7C`
- `0xA3E8` → `0x5C17`
- `0x4FB1` → `0xB04E`

- The inverse operation is a step to reach 15.

# Hexadecimal to Binary Conversion

- `0xFFAA48` = `0b111111111010101001001000`
- `0xA xor 0xA` = `0b1010 xor 1010` = `0000`
- `0xF3 xor 0x3F` = `0b11110011 xor 00111111` = `11001100` = `0xCC`
- `0xCC xor 0xF3` = `0b11001100 xor 11110011` = `00111111` = `0x3F`

---

# RGB24 to RGB12

- `0xEDA27B` → `0x0EA7`
- `0b111011011010001001111011` → `0000111010100111`

### Breakdown

- `R8 = 0xED` → `RGB >> 16`
- `G8 = 0xA2` → `(RGB << 8) AND 0x00FF`, then `RGB >> 16`
- `B8 = 0x7B` → `RGB << 16`

### Example

- `0x00EDA2 AND 0x0000FF` → `0x0000A2`

---

# Binary Counting

| Binary | Hexadecimal |
|--------|-------------|
| `0000` | `0`         |
| `1001` | `9`         |
| `0001` | `1`         |
| `1010` | `A`         |
| `0010` | `2`         |
| `1011` | `B`         |
| `0011` | `3`         |
| `1100` | `C`         |
| `0100` | `4`         |
| `1101` | `D`         |
| `0101` | `5`         |
| `1110` | `E`         |
| `0110` | `6`         |
| `1111` | `F`         |
| `0111` | `7`         |
| `1000` | `8`         |

### Notes

- Overflow occurs at `10000`.

---

# XOR Logic

- `0xA xor 0x0 = 0x1010`
- `0xF3 xor 0x3F = 0b11110011 xor 0b00111111 = 0b11001100 = 0xCC`
- `0xCC xor 0xF3 = 0b11001100 xor 0b11110011 = 0x3F`

---

# RGB Mixing and Shifting

- `0xFF0000 | 0x00FF00 | 0x00FF00` = `0xFFFF00`
- `64 = 01000000` → `0x40`
- `128 = 10000000` → `0x80`
- `255 = 11111111` → `0xFF`

### RGB Example

- `(255,128,64)` → `0xFF8040`
- `0x00FF00` = `0b000000001111111100000000`
- `0xFFF110` = `0b111111111111000100010000`
- `0xFFAA48` = `0b111111111010101001001000`
- `0xEDA27B` = `0b111011011010001001111011`

### Shifting

- `1111000011110000 >> 4` → `0b0000111100001111` (exceeding numbers disappear)

### Rolling

- `1111000011110000 << 4` → `0b0000111100001111` (exceeding numbers re-included)

---

# Logical Operations

- `0xF0FF AND 0x0F0F` → `0x000F`
- `0xFOFF OF 0x0F0F` → `0xFFFF`

### XOR Rules

- `0 | 0 = 0`
- `0 | 1 = 1`
- `1 | 0 = 1`
- `1 | 1 = 0`

---

# Open Source

Open source is the “freedom to see the source code, to modify it, to redistribute it, to make it available, and to work for the user in whatever way.”

### Key Points

- Open source means distributing software in the form of source code, guaranteeing the user the right to study how it works, modify it, improve it, or redistribute it.
- **Freedom:** To sell, access source code, create derivative work, or use in any field.

### Licenses

- **Permissive Licenses:** MIT/BSD
- **Restrictive Licenses:** GPL/LGPL
- **Hybrid Licenses:** GPL/LGPL/Commercial
  - **MIT** can be transferred to **GPL**, but not the other way around.
  - GPL is often used in academic projects, LGPL in commercial contexts, and commercial licenses for private use.

---

# User Interfaces

- **Batch Computing:** Punch cards
- **CLI (Command Line Interface):** Text commands
- **GUI (Graphical User Interface):** Visual-based
- **Touch:** Touchscreen
- **Voice:** Alexa, etc.

---

# Operating Systems

- **Examples:**
  - Windows
  - Linux

### Filesystems

- NTFS, EXT4

### The OS provides

- Resource allocation
- Control program to prevent errors
- UI interface
- Data management
- Task management
- Service provider
- Hardware abstraction

---

# Filesystem

A filesystem organizes, manages, and stores data efficiently for retrieval.

### Key Features

- **Organization:** Files, folders, links
- **Storage Efficiency:** How much device space is used by the filesystem structure
- **Data Integrity:** Detecting and recovering from corruption
- **Security:** Access control, privilege, confidentiality

### Components

- Root
- File
- Folder

---

# Common Commands

### Windows CLI Commands

- `dir`
- `copy`
- `del`
- `move`
- `mkdir`
- `rmdir`
- `tracert`
- `ipconfig`
- `ping`
- `echo`
- `cls`
- `type`
- `find`
- `help`
- `attrib`
- `tasklist`
- `taskkill`
- `notepad`
- `call`
- `chkdsk`
- `diskpart`
- `net`
- `runas`
- `systeminfo`

### Unix Commands

- `ls`
- `mv`
- `rm`
- `mkdir`
- `rmdir`
- `pwd`
- `sudo`
- `ps`
- `kill`
- `top`
- `df`
- `du`
- `man`
- `grep`
- `more`
- `cat`
- `login`
- `exit`
- `alias`
- `clear`
- `whereis`
- `chmod`
- `chown`
- `nano`
- `ping`
- `traceroute`
- `ifconfig`

### CLI (Command Line Interface) relies on text input and output

---

# RGB Color Mixing

### Average Formula

`AVG(A,B) = (A+B)/2`

Example:

- `0xFF0000 + 0x0000FF / 2` = `0x7F007F`

Shifting:

- `0xFF/2 = 0b11111111 >> 1 = 01111111 = 0x7F`

---

# Data Compression

Why do we need data compression? To reduce file size.

### Compression Schemes

- **RLE (Run-length Encoding):** Compresses data by reducing sequences of repeating elements to a single value and count.  
  Example: `AAAABBB` becomes `4A3B`.
- **LZ (Lempel-Ziv):** Replaces repeated data sequences with references to earlier occurrences.  
  Example: `[AB] [CD] [EFK] {1,5}_{2,4}*{3,3}`
- **LZMA (Lempel-Ziv-Markov-Chain-Algorithm):** Uses a Markov chain to predict sequential data and applies precise range encoding for notable compression ratios.

---

# Memory and CPU Architecture

- **CPU:** Executes instructions
- **RAM (Random Access Memory):** Volatile memory
- **ROM (Read-Only Memory):** Stores firmware and boot-up instructions
- **I/O:** Handles communication between a computer and external devices
- **HDD (Hard Disk Drive):** Magnetic storage device for digital data with moving parts
- **SSD (Solid-State Drive):** Fast, durable storage device for digital data, without moving parts
           
## Solution#1: Increase the CPU’s clock speed

**Examples:**

- Zilog Z80 - 4Mhz (1976)
- Intel 80386 12-40Mhz (1985)
- IBM PowerPC 450Mhz (1997)
- Intel Core i9 5Ghz (2019)

**Challenges:**

- **Heat dissipation:** Increasing speed = more heat. Solutions: air vent, water cooling.
- **Power consumption:** More speed = more power consumption, affecting devices from batteries to data centers.
- **Signal integrity and Propagation delay:** Higher speeds can compromise signal integrity and create timing issues.
- **Transistor switching speed:** Transistors have inherent switching speed limits. Higher speeds lead to issues like electron tunneling.
- **Economic and manufacturing challenges:** High-speed CPUs require advanced, costly manufacturing processes.

## Solution#2: Build a computer with more CPUs

**Challenges:**

- **Communication overhead:** Coordination between multiple CPUs is complex and requires synchronization.
- **Parallel processing:** Software must efficiently utilize multiple CPUs for parallel processing.
- **Memory access:** Coordinating memory access between CPUs to avoid conflicts and ensure data consistency.
- **Hardware compatibility:** Ensuring that all CPUs and associated hardware can efficiently work together.
- **Cost implications:** More CPUs mean higher financial investments in hardware, power, and cooling.

## Solution#3: Identify the bottlenecks

**Memory cache:** Placing a cache between RAM and the CPU speeds up data access.

**Other strategies:**

- **SIMD (Single Instruction, Multiple Data):** Allows a single instruction to perform the same operation on multiple data points. Highly efficient for graphics processing and simulations.
- **Cache enhancement:** Increase cache size, levels, or optimize cache algorithms.
- **Multi-core processors:** Implement multiple processing cores on a single chip for parallel data processing.
- **Instruction-level parallelism:** Execute multiple instructions in a single clock cycle.

---

## Bitmap, or how to store images?

- A **Bitmap** is a type of memory organization or image file format used to store digital images.
- The smallest unit of a bitmap is a pixel.
- A bitmap is always defined by a width and a height in pixels (resolution).
- A bitmap represents a grid of pixels in 2D but is stored linearly in memory.

---

## What about audio files?

- **Frequency** refers to the number of vibrations of a sound wave per second.
- A **sample** is a snapshot of the audio wave, measured in kilohertz (kHz). Example: a sample rate of 44.1kHz means 44,100 samples are taken per second.
- **Shannon’s sampling theorem**: To accurately reproduce a continuous audio signal in a digital format, it must be sampled at a rate.

---

## Boolean Fun

**Commutative Law:**

- OR operator: `A + B = B + A`
- AND operator: `A.B = B.A`

**Associative Law:** `(A.B).C = A.(B.C)`

**Distributive Law:** `A + B.C = (A+B)(A+C)`

**Annulment Law:**

- `A.0 = 0`
- `A+1 = 1`

**Identity Law:**

- `A.1 = A`
- `A+0 = A`

**Idempotent Law:**

- `A + A = A`
- `A.A = A`

**Complement Law:**

- `A + NOT A = 1`
- `A.NOT A = 0`

**Double Negation Law:** `NOT(NOT(A)) = A`

**Absorption Law:**

- `A.(A+B) = A`
- `A + A.B = A`

**De Morgan’s Law:**

- `NOT (A.B) = NOT A + NOT B`
- `NOT (A + B) = NOT A . NOT B`

---

## Command Line Operations

- Root path: `cd  C:/Users/Info/Desktop/ALGOSUP/New folder/New folder 2`
- Copy file: `copy C:/Users/Info/Desktop/ALGOSUP/New folder/New folder 2/test.txt`
- Delete files starting with 'B': `DEL B*.*`

---

## Programming Languages Overview

### Turing Machine & Turing Completeness

- **Turing completeness** implies the ability to perform loops, conditionals, and read/write operations.

### Is Minecraft Turing-complete?

- **Answer:** Probably.

---

## Source Code to Machine Code

### Programming Paradigms

- **Procedural:** C, C++, Go, Python
- **Object-Oriented:** Java, C++, Python, Go, Ruby
- **Functional:** Haskell, Lisp, Erlang, Scheme

**Assembly Programming:** Subset of imperative programming, focusing on loops, variables, and conditionals.

### How do we get from source code to machine code?

- **Interpreters**: Python, Ruby, PHP, JS, Lua, Shell Script
- **Compilers**: C, C++, Rust, Go, Ada, Kotlin

### Python Compilation Process

1. **Lexical analysis**: Breaks code into tokens.
2. **Syntax analysis**: Builds an abstract syntax tree (AST).
3. **Semantic analysis**: Ensures code follows logical rules.
4. **Compilation**: Converts AST into bytecode.
5. **Execution**: Bytecode is executed by the Python Virtual Machine (PVM).

### C Compilation Process

1. **Preprocessing**: Handles `#include`, `#define`, etc.
2. **Lexical analysis**: Breaks code into tokens.
3. **Syntax analysis**: Builds AST.
4. **Semantic analysis**: Checks for semantic errors.
5. **Code generation**: Converts AST to intermediate/assembly code.
6. **Assembly**: Assembles into machine code.
7. **Linking**: Combines with libraries to create executable.

---

## Abstract Syntax Tree (AST)

- AST captures the hierarchical structure of code relationships (e.g., operator precedence).

---

## JavaScript Implementations

- **V8**: Uses JIT (Just-in-time) compilation.
- **QuickJS**: Uses an interpreter and bytecode compiler, does not use JIT.

---

## Emulator vs Simulator

- **Emulator**: Mimics a hardware/software system faithfully.
- **Simulator**: Replicates an environment without mimicking the internal behavior.

---

## Memory in Modern Computers

- Combines **physical memory**, **virtual memory**, and **compressed memory**.
- Not all physical addresses are contiguous; memory controllers assign addresses to each memory block.

# Big Endian vs Little Endian

Endianness refers to the byte order in which data is stored in memory. The debate between Big Endian and Little Endian arises from the choice of where to store the most significant byte (MSB) of multi-byte data types.

### Big Endian

- The most significant byte is stored at the lowest memory address.
- The order of the bits within each byte remains the same regardless of machine architecture.
- Example: The most significant byte of a 32-bit word is placed at the byte with the lowest address.

### Little Endian

- The least significant byte is stored at the lowest memory address.
- Example: The least significant byte of a 32-bit word is placed at the byte with the lowest address.

### Industry Examples

- **Big Endian CPUs**: Motorola 68k, IBM mainframes.
- **Little Endian CPUs**: Intel/AMD x86 and x64.
- **Bi Endian CPUs**: IBM, PowerPC, ARM.

### When to Consider Endianness

- Writing low-level code (C, C++, or Assembly).
- Dealing with binary formats storing data on words (16 or 32 bits).
- Working on multi-platform software with varying CPU architectures.

## UTF and Endianness

UTF-8 was invented to represent every character in the Unicode standard while maintaining compatibility with ASCII. It allows for efficient representation using a variable-length encoding.

- **UTF-8**: Endianness is not a concern, as it is a byte-oriented encoding.
- **UTF-16 / UTF-32**: Endianness matters.

In a nutshell, UTF-8 combines ASCII and Unicode within a consistent and backward-compatible storage format.

---

# Code Versioning

### Why Code Versioning?

- Track and follow changes.
- QA and debugging.
- Experiment with new features.
- Collaborative effort.

### History of Code Versioning

- CVS, Subversion, Alienbrain, Perforce, Git, Mercurial.

---

## Subversion

### Repository Structure & Philosophy

- SVN uses a centralized system.
- Users check out only one version of files, not the entire repository history.

### Branching & Merging

- Branching is done by copying the code into a new directory.
- Merging can be more complex and error-prone.

### Commits

- Linear and sequential, each commit increments a global revision number.

### Working Directory

- Each sub-directory can have its own `.svn` directory with metadata, allowing for sub-directory checkouts.

---

## Git

### Repository Structure & Philosophy

- Git uses a distributed system.
  
### Branching & Merging

- More efficient and easier merging compared to SVN.

### Commits

- Commits are local until pushed to a remote repository.

---

## GitHub vs GitLab

### GitHub

- Acquired by Microsoft in 2018, originally an independent company.
- Offers free private repositories and various paid plans with additional features.
- **GitHub Enterprise**: Allows for self-hosting but primarily a cloud service.
- The platform itself is not open-source but serves as a major hub for open-source projects.

### GitLab

- An open-source alternative to GitHub.
- Offers more self-hosting and DevOps features integrated into the platform.

### Git LFS (Large File Storage)

- Used to manage repositories with large files like binaries or media files that could grow the size of a repository significantly.

---

# Bitmap vs Vector and DPI

### What Are Bitmap (Raster) Images?

- Composed of individual pixels.
- Each pixel holds color information.
- Examples: JPEG, PNG, BMP, GIF.

### What Are Vector Images?

- Defined by mathematical equations and geometric primitives.
- Comprised of paths, points, lines, curves.
- Examples: SVG, AI, EPS.

### Bitmap Images

- Suitable for photographs and complex images.
- More detail is tied to resolution, which limits scalability.

### Vector Images

- **Advantages**:
  - Scalable without loss of quality.
  - Typically smaller file sizes.
  - Ideal for logos, icons, and illustrations.
- **Limitations**:
  - Not suitable for complex images like photographs.
  - Limited in the representation of colors.

---

# Bitmap Interpolation Methods

### Nearest Neighbor

- Simplest method: Maps the closest pixel's color.
- Fast but can produce jagged or "pixelated" images.

### Bilinear Interpolation

- Considers the closest 2x2 neighborhood of known pixel values.
- Takes a weighted average of these 4 pixels.
- Smoother than nearest neighbor but can be blurry.

### Bicubic Interpolation

- Uses polynomial functions (or splines) to determine pixel values.
- Offers smoother curves and lines than bilinear interpolation.
- Good for images with curves and gradients.

### AI-Enhanced Upscaling

- Uses deep learning models trained on vast image sets.
- Can (re)introduce detail not present in the original.
- Offers the most accurate results but requires more computational power.
