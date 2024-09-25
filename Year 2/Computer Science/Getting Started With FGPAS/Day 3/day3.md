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
