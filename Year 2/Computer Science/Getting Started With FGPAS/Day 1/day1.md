# Getting Started With FGPAS

## Day 1

### Who's Russell Merrick?

All he does is explain things.

Worked on Laser-guided missiles, IR goggles, satellites

## What's FPGA

Field Programmable Gate Array, can be reprogrammed on field, but they aren't gate arrays anymore.
The technology has changed a lot but they are still called FPGA

### Use Cases

Phone towers, sattelites, Radars, Robotics.

### Usage

They are:

- fast processing
- Lots of data
- Lots of maths

## Transitors

Crested in 1947 at Bell Labs

They are switches that enabled complexities like computers. they enaled the digital age.
they are the building blocks of all integrated circuits

## How many bits do we need?

In general, 2^N-1 where N is the numbers of bits.

## Look up table (LUP)

One of the 2 most critcal components in an FGPA, it allows us to do boolean algebra.

## Truth Tables

## AND Truth Table (`A ∧ B`)

| A   | B   | A ∧ B |
| --- | --- | ----- |
| 0   | 0   | 0     |
| 0   | 1   | 0     |
| 1   | 0   | 0     |
| 1   | 1   | 1     |

## OR Truth Table (`A ∨ B`)

| A   | B   | A ∨ B |
| --- | --- | ----- |
| 0   | 0   | 0     |
| 0   | 1   | 1     |
| 1   | 0   | 1     |
| 1   | 1   | 1     |

## XOR Truth Table (`A ⊕ B`)

| A   | B   | A ⊕ B |
| --- | --- | ----- |
| 0   | 0   | 0     |
| 0   | 1   | 1     |
| 1   | 0   | 1     |
| 1   | 1   | 0     |

## NOT Truth Table (`¬A`)

| A   | ¬A  |
| --- | --- |
| 0   | 1   |
| 1   | 0   |

## NAND Truth Table (`A ↑ B`)

| A   | B   | A ↑ B |
| --- | --- | ----- |
| 0   | 0   | 1     |
| 0   | 1   | 1     |
| 1   | 0   | 1     |
| 1   | 1   | 0     |

**A*B+A'**
<img title="a title" alt="Alt text" src="https://github.com/Biohazardyee/algosup_courses/blob/main/Year%202/Computer%20Science/Getting%20Started%20With%20FGPAS/Images/image.png">

| A   | B   | A'  | A * B | A * B + A' |
| --- | --- | --- | ----- | ---------- |
| 0   | 0   | 1   | 0     | 1          |
| 0   | 1   | 1   | 0     | 1          |
| 1   | 0   | 0   | 0     | 0          |
| 1   | 1   | 0   | 1     | 1          |

**A+(C*B')**

<img title="a title" alt="Alt text" src="https://github.com/Biohazardyee/algosup_courses/blob/main/Year%202/Computer%20Science/Getting%20Started%20With%20FGPAS/Images/image-2.png">

| A   | B   | B'  | C   | C * B' | A + (C * B') |
| --- | --- | --- | --- | ------ | ------------ |
| 0   | 0   | 1   | 0   | 0      | 0            |
| 0   | 0   | 1   | 1   | 1      | 1            |
| 0   | 1   | 0   | 0   | 0      | 0            |
| 0   | 1   | 0   | 1   | 0      | 0            |
| 1   | 0   | 1   | 0   | 0      | 1            |
| 1   | 0   | 1   | 1   | 1      | 1            |
| 1   | 1   | 0   | 0   | 0      | 1            |
| 1   | 1   | 0   | 1   | 0      | 1            |

Multiple LUTs can be cascaded to make much more complicated operations.

## The Flip-Flop

**Not this...**

<img title="a title" alt="Alt text" src="https://github.com/Biohazardyee/algosup_courses/blob/main/Year%202/Computer%20Science/Getting%20Started%20With%20FGPAS/Images/image-1.png">

Second critical FPGA component, it stores state. Flip-Flops have memory.
Knowing passage of time would be impossible without flip-flops.


## Example of a flip-flop

<img title="a title" alt="Alt text" src="https://github.com/Biohazardyee/algosup_courses/blob/main/Year%202/Computer%20Science/Getting%20Started%20With%20FGPAS/Images/flip-flop.png>

It delays the input a little bit (as it is related to the clock cycle).

### Frogger project  

- The user control the frog's movement
- Buttons on the go board are used to direct the frog 
- cars move horizontally

We will use Verilog, which is similar to C. It is a Hardware Description Language, created especially for FGPA development.
