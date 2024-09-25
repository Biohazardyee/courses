# Workshop 25/09/2024

4'd6 = 4 bits wide, decimal, set to 6.
3'b010 = 3 bits wide in binary set to 010, 2 in decimal.
8 h'AB = 8 bits wide in hex, set to 0xAB, which is 171 in decimal.

## Bit indexing 

Given an N-bit wide signla, we can slect any individual bit.

```Verilog
reg [3:0] r_test = 4'b0011;

r_test[0] is 4'b1
```

We can also select a range of bits.

```Verilog
reg [3:0] r_test = 4'b0011;

r_test[1:0] is 4'b11;
```

## Constants in Verilog

```Verilog
localparam 


localparam COUNT_LIMIT = 250;

reg [15:0] r_counter; 

always @(posedge i_Clk)
begin 
    if (r_counter == COUNT_LIMIT)
        // do smthg
    else if (r_counter < COUNT_LIMIT / 2)
        // do smthg
end
```

## Ripple carry adder

several full adders can be used to add larger binary numbers together, called a ripple carry adder.

## LED Blinker

```Verilog
module led_blinker(
    input CLK,
    output LED1, LED2, LED3, LED4
);

  reg [23:0] r_counter1;
  reg [23:0] r_counter2; 
  reg [23:0] r_counter3;
  reg [23:0] r_counter4;

    always @(posedge CLK) begin 
        r_counter1 <= r_counter1 + 1;
        r_counter2 <= r_counter2 + 1;
        r_counter3 <= r_counter3 + 1;
        r_counter4 <= r_counter4 + 1;

        if (r_counter1 == 24'd12500000) begin
            r_counter1 <= 0;
            LED1 <= ~LED1;
        end
        if (r_counter2 == 24'd9375000) begin
            r_counter2 <= 0;
            LED2 <= ~LED2;
        end

        if (r_counter3 == 24'd6250000) begin
            r_counter3 <= 0; // Reset the counter
            LED3 <= ~LED3;
        end 
        if (r_counter4 == 24'd3125000) begin
            r_counter4 <= 0; // Reset the counter
            LED4 <= ~LED4;
        end 
    end

endmodule
```

## Shift register

```Verilog
reg [3:0] r_shift; // 4-bit shift register

always @(posedge Clk) begin
    // Shift data left and insert new data on the rightmost bit
    r_shift[3] <= r_shift[2];
    r_shift[2] <= r_shift[1];
    r_shift[1] <= r_shift[0];
    r_shift[0] <= data_to_delay; // New data is inserted into the least significant bit
end
```

## LFSR

## RAM

Very common in fpga design, allors us to store data for an amout of time and then read it back.

Total Size = WIDTH * DEPTH

Dual port RAM are composed of two ports:

- Write Port
  - Wr clk
  - Wr address
  - Wr data valid
  - Wr data
- Read Port
  - Rd clk
  - Rd address
  - Rd en
  - Rd dv
  - Rd data

## Latch Problem

Problem

```Verilog
module project_latch
 (input i_Clk,
  input i_Switch_1,
  input i_Switch_2,
  output o_LED_1,
  output o_LED_2,
  output o_LED_3,
  output o_LED_4);

  wire [1:0] w_Select;
  reg [3:0] r_Latch;

always @ (w_Select)
  begin
    if (w_Select == 2'b00)
      r_Latch <= 4'b0001;
    else if (w_Select == 2'b01)
      r_Latch <= 4'b0011;
    else if (w_Select == 2'b10)
      r_Latch <= 4'b0111;
    // Incomplete assignment, missing one last else if!
  end

  assign w_Select = {i_Switch_2, i_Switch_1}; // concatenation

  assign o_LED_1 = r_Latch[0];
  assign o_LED_2 = r_Latch[1];
  assign o_LED_3 = r_Latch[2];
  assign o_LED_4 = r_Latch[3];

endmodule

```

Solution

```Verilog
module project_latch
 (input i_Clk,
  input i_Switch_1,
  input i_Switch_2,
  output o_LED_1,
  output o_LED_2,
  output o_LED_3,
  output o_LED_4);

  wire [1:0] w_Select;
  reg [3:0] r_Latch;

always @ (posedge i_Clk)
  begin
    case (w_Select) // Missing 2'b11 case
      2'b00: r_Latch <= 4'b0001;
      2'b01: r_Latch <= 4'b0011;
      2'b10: r_Latch <= 4'b0111;
      2'b11: r_Latch <= 4'b1111;
      default : r_Latch <= 4'b0000;
    endcase
  end

  assign w_Select = {i_Switch_2, i_Switch_1}; // concatenation

  assign o_LED_1 = r_Latch[0];
  assign o_LED_2 = r_Latch[1];
  assign o_LED_3 = r_Latch[2];
  assign o_LED_4 = r_Latch[3];

endmodule

```

Added a clock, the missing condition and the switch case to handle the problem that was causing undefined behaiours on the previous code.

## Build process

Verilog -> Synthesis -> Place & Route -> Program FPGA

### Synthesis

Is like a compiler in C, turns the verilog to primitive fpga components.
the output is a netlist.

Common problems:

- syntax errors
  - Fix the first error first
  - Might be cascading series of errors
- High utilization
  - Switch to larger fpga
  - find largest contributor and rewrite it
  - Remove/Move functionality
- Synthesis warnings
  - Do not ignore inferred latch problems

## Place & Route

- Takes synthesized desdgin as input
- Places physically design to your FPGA
- Routes all wires
- Analyzes timing, generates report
- Output can be progranned to FPGA

### Timing Errors

Means the design might not work as intended.
Might work fine on you desk, but not in real environment.
