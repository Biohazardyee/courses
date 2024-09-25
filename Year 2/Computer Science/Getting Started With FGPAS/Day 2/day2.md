# Workshop 24/09/2024

| SW1 | SW3 | SW2 | SW4 | O2  | O1  | O3  |
| --- | --- | --- | --- | --- | --- | --- |
| 0   | 0   | 0   | 0   | 0   | 1   | 1   |
| 0   | 0   | 0   | 1   | 0   | 1   | 1   |
| 0   | 0   | 1   | 0   | 0   | 0   | 0   |
| 0   | 0   | 1   | 1   | 1   | 1   | 1   |
| 0   | 1   | 0   | 0   | 0   | 0   | 0   |
| 0   | 1   | 0   | 1   | 0   | 0   | 0   |
| 0   | 1   | 1   | 0   | 0   | 0   | 0   |
| 0   | 1   | 1   | 1   | 1   | 0   | 1   |
| 1   | 0   | 0   | 0   | 0   | 1   | 1   |
| 1   | 0   | 0   | 1   | 0   | 1   | 1   |
| 1   | 0   | 1   | 0   | 0   | 0   | 0   |
| 1   | 0   | 1   | 1   | 1   | 1   | 1   |
| 1   | 1   | 0   | 0   | 1   | 1   | 1   |
| 1   | 1   | 0   | 1   | 1   | 1   | 1   |
| 1   | 1   | 1   | 0   | 1   | 0   | 1   |
| 1   | 1   | 1   | 1   | 1   | 1   | 1   |

``` Verilog
module Boolean(
    input CLK,                 // Clock signal
    input SW1, SW2, SW3, SW4,  // Unused switches
    output LED1, LED2, LED3, LED4 // LEDs
);

assign LED1 = ((SW1 && SW3) | (SW2 && SW4)) | ((SW1 | !SW3) && (!SW2 | SW4));
assign LED2 = (SW1 && SW3) | (SW2 && SW4);
assign LED3 = (SW1 | !SW3) && (!SW2 | SW4);

   
endmodule
```

``` Verilog Multiplexer
assign out = !sel1 & !sel2 ? in1 : 
             !sel1 & sel@ ? in2 : 
             sel1 & !sel2 ? in3 :
             in4  
```

FPGAs are like LEGOs, you can make sophiticated design from simple building blocks.
Modules alloq us to build a component and use it over and over.

They are a way to wrap code in a single piece of function.

``` Verilog
wire Input; 
wire Output; 

module name INSTANCE_NAME 
(.i_1(Input)),
 .o_1(Output);
```

Wiring an and_module

``` Verilog
module project_and_gates(
    input SW1, SW2, SW3, SW4,  // Inputs for switches
    output LED1, LED2          // Outputs for LEDs
);

    wire and_out1, and_out2;   // Intermediate wires for the outputs of AND gates

    // Instantiate first and_gate module
    and_gate and1 (
        .a(SW1),
        .b(SW2),
        .c(and_out1)
    );

    // Instantiate second and_gate module
    and_gate and2 (
        .a(SW3),
        .b(SW4),
        .c(and_out2)
    );

    // Connect the outputs of the AND gates to the LEDs
    assign LED1 = and_out1;
    assign LED2 = and_out2;

endmodule


module and_gate(
    input a, 
    input b, 
    output c,
);
    assign c = a & b;
endmodule

```

Always blocks gives us the ability to create flip-flops,
posedge is reserved word in verilog

```Verilog
always @(posedge i_Clock)
begin 
    // do smthg
end
```

```Verilog
always @(posedge i_Clock)
begin 
    if (Value > Check)
        begin 
            // do smth
        end
    else
        begin
            // do smth else
        end
end
```

```Verilog
module flip_flops(
    input CLK,
    input SW1, 
    output LED1
);

    reg r_LED1;
    reg r_Switch1;

    always @(posedge CLK) 
    begin
        r_Switch1 <= SW1;
        if (r_Switch1 == 1 && SW1 == 0)
            begin 
                r_LED1 <= ~r_LED1;
            end 
    end 
    
    assign LED1 = r_LED1;

endmodule

```

### Combninational logic

logic for which the outputs are determined from present inputs with no memory of the previous state

### Sequential logic

logic for which the outouts are detemined from both present inputs and previous outpouts, also called Synchronous.

We want to avoid Combitional always block

```Verilog
always @(input_1 or input_2)
    begin 
    and_gate <= input_1 & input_2
    end
```

We want to use **Sequential always blocks** (with a clock).

### Simulation

The best way to find bugs is to simulate, to see what's happening inside of the FPGA.

#### Testbench

Is to exercise our Unit Under Test, it is a way to wrap our UUT.
