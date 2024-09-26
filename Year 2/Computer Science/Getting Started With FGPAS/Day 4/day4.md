# Workshop 26/09/2024

## Timing Errors

Means the design might not work as intended.
Might work fine on you desk, but not in real environment.

### How they occur

When requested Clock freq > actual clock freq

will produce routes with neggative slack = timing error

Clock period calculated by steuo time + propagation delay

tclk(min) = tsu + tp

tsu = setup time
tp = propagation delay

## Setup and hold time

Flips-flops arent instant, they need time for a stable state.

Setup time is the amount of time required for the input of a flip-flop to be stable before a clock edge
Hold time is the amount of time required for the input of a flip-flop to be stable after a clock edge

Violating these causes bad things

### Propagation delay

Amount of time for a signal to travel from source to destination
The voltage do not travel instantly , electricity travel at a meter/ns

In Timing errors the setup time is fixed, and the clock frequency i susually chosen and advance and do not change, the propagation delay is the only knob we can turn in order to prevent a timing error.

## Timing errors and GOBoard

- GO board uses a 25MHz clock
- 1/25 MHz = 40ns period

## Metastability

IF setup hold time are violated, the output of a flip flop can become metastable.

Might be 0 might be 1 might be somewhere in between.

They are unpredicatable, the effect is a timing error.

## Debounce filter

```Verilog
module Debounce_Filter #(parameter DEBOUNCE_LIMIT = 20) (
  input  CLK,
  input  i_Bouncy,
  output o_Debounced);
 
  // Will set the width of this counter based on the input parameter
  reg [$clog2(DEBOUNCE_LIMIT)-1:0] r_Count = 0; 
  reg r_State = 1'b0;
  
  always @(posedge CLK)
  begin
    // Bouncy input is different than internal state value, so an input is
    // changing.  Increase the counter until it is stable for enough time.  
    if (i_Bouncy !== r_State && r_Count < DEBOUNCE_LIMIT-1)
    begin
      if (r_Count < DEBOUNCE_LIMIT-1)
      begin
        r_Count <= r_Count + 1;
      end
    end
    
    else if (r_Count == DEBOUNCE_LIMIT-1)
    begin
      r_State <= i_Bouncy ;
      r_Count <= 0;

    end 

    // Switches are the same state, reset the counter
    else
    begin
      r_Count <= 0;
    end
  end
  
  // Assign internal register to output (debounced!)
  assign o_Debounced = r_State;
  
endmodule
```

Implemented into a project
```Verilog
module LED_Toggle_Project
 (input  CLK,
  input  SW1,
  output LED1
  );

  wire w_Debounced;               
  reg r_LED_1    = 1'b0;
  reg r_Switch_1 = 1'b0;

  // Instantiate the Debounce_Filter module
  Debounce_Filter #(20) Debounce_1 (
    .CLK      (CLK),
    .i_Bouncy (SW1),
    .o_Debounced (w_Debounced)
  );

  // Purpose: Toggle LED output when i_Switch_1 is released.
  always @(posedge CLK)
  begin
    r_Switch_1 <= w_Debounced;  // Creates a Register
 
    // This conditional expression looks for a falling edge on i_Switch_1.
    // Here, the current value (i_Switch_1) is low, but the previous value
    // (r_Switch_1) is high.  This means that we found a falling edge.
    if (w_Debounced == 1'b0 && r_Switch_1 == 1'b1)
    begin
      r_LED_1 <= ~r_LED_1;   // Toggle LED output
    end
  end
 
  assign LED1 = r_LED_1;
 
endmodule

```
