# MOSCOW WEB FPGA

| Must                                                     | Should                                                       | Could                                                                 | Won't                                                  |
| -------------------------------------------------------- | ------------------------------------------------------------ | --------------------------------------------------------------------- | ------------------------------------------------------ |
| Web interface                                            | Appealing visual interface                                   | Verbose mode                                                          | Code Verilog ourselves                                 |
| Accept files as input (Verilog netlist & SDF)             | Manage multiple speeds (x1/x2/x4)                            | Export output as a GIF                                                | Convert Verilog to another HDL like VHDL automatically |
| Display visual representation of FPGA floorplan           | Color-code signals for clarity                               | Allow students to modify parameters (e.g., clock speed, input values) | Implement full FPGA synthesis in-browser               |
| User-friendly design                                     | Implement basic error handling for invalid Verilog/SDF files  | Export simulation results as a report (PDF, JSON)                     | Modify the bitstream                                   |
| Display step-by-step signal propagation                  | Provide a timeline slider for navigation                     | Take external variables into account                                  | Interact with any pre-processing                       |
| Play - pause / slow-motion controls                      | Multi-user sessions support                                  |                                                                       | Calculate the amount of usage (stats)                  |
| File pivotation                                          | Backend processing optimizations                             |                                                                       | Take into account difficult or specific examples         |
| Client-server interaction                                | Real-time performance improvements                           |                                                                       | Adapt to portable devices (phones /tablets)            |
| Display 2D floorplan of FPGA with BELs and routing        | Basic statistics on signal delays and logic utilization      |                                                                       | Add sounds                                             |
| Provide interactive controls (zoom, pan, select signals) | Annotation support for educational use                       |                                                                       |                                                        |
| Display issues (eg. Speed difference, clock, desync)     |                                                              |                                                                       |                                                        |
| Animations                                               |                                                              |                                                                       |                                                        |

## Must-Have Features
These features are essential for the project to function as intended.

- **Web interface**  
- **Accept files as input** (Verilog netlist & SDF)  
- **Display visual representation of FPGA floorplan**  
- **User-friendly design**  
- **Display step-by-step signal propagation**  
- **Play - Pause / Slow-motion controls**  
- **File pivotation**  
- **Client-server interaction**  
- **Display 2D floorplan of FPGA with BELs and routing**  
- **Provide interactive controls** (zoom, pan, select signals)  
- **Display issues** (e.g., speed differences, clock desync)  
- **Animations**  

---

## Should-Have Features
These features improve usability but are not critical for a functional system.

- **Appealing visual interface**  
- **Manage multiple speeds** (x1, x2, x4)  
- **Color-code signals for clarity**  
- **Implement basic error handling** for invalid Verilog/SDF files  
- **Provide a timeline slider** for navigation  
- **Multi-user sessions support**  
- **Backend processing optimizations**  
- **Real-time performance improvements**  
- **Basic statistics on signal delays and logic utilization**  
- **Annotation support** for educational use  

---

## Could-Have Features
These features add value but are not a priority for the initial release.

- **Verbose mode**  
- **Export output as a GIF**  
- **Allow students to modify parameters** (e.g., clock speed, input values)  
- **Export simulation results** (PDF, JSON)  
- **Take external variables into account**  
- **Advanced performance statistics**  
- **Support future extensions or additional FPGA models**  

---

## Won't-Have Features
These features are explicitly excluded from the project scope.

- **Code Verilog ourselves**  
- **Convert Verilog to another HDL (e.g., VHDL) automatically**  
- **Implement full FPGA synthesis in-browser**  
- **Modify the bitstream**  
- **Interact with any pre-processing**  
- **Calculate the amount of usage (stats)**  
- **Take into account difficult or specific examples**  
- **Adapt to portable devices (phones/tablets)**  
- **Add sounds**  

