# Linux Professional Institute LPIC-2

- Master processes and signals
- Manage scheduled tasks
- Understand boot procedure, initrd and runlevels
- Talk about kernel types, modules, parameters and patches

## Processes

- System task management abstraction 
  - in memory executable code
  - Many properties (runs as a uig/gid couple, attached to a TTY/daemons)
- Identified by a PID (Process IDentifier)

### Hierarchy

- init is the first userland process PID 1 started off by the kernel, it is the ancestor of all other processes
- cp is a task running in the background
- ls is a command just issued by the user
- ftpd is a daemon

- Processes on Unix: fork()
- Process can spawn children
  - Child process: inherits environment, die if parent dies (can be detached)
  - Parent process: must wait for children (zombies)

### Daemons and states

- Daemon
  - Processes gone rogue
  - Special state: detached from original parent (PPID = 1 ), no control TTY (STDIN, STOUT, STDERR) used for services
  
A process can be:
- runnin: has cpu time
- runnable: waits for cpu time
- sleeping: does nothing or waits for smthg
- Zombie/Defunct: process ended, parent did not wait 

### Zombie

- Cannot kill what is already dead
- Ended process
  - no cpu cycles
  - no resources
  - only id block and process table entry 

- Needs to be wait()ed
    - stalled parent
    - bugged parent
- Kill the parent, init will adopt the process, read its exit code so the kernel can reap it 

### Running processes 

- Background processes
  - start with &
  - Ctrl-Z + bg

- Move to foreground
  - fg
  - Ctrl-C to kill foreground process

List running tasks:
  - jobs

Detach from the shell:
    - disown

### Priority 

- The last will be first and the first will be last
- Priority (PR)
  - kernel-computer, many elements

- Niceness
  - -20 to 19
  - Default 0
  - Only root can go negative

### Niceness

- Starting a niced process
  - nice [option] cmdline
  - use -n to run the process with the specified niceness
- Modifying the nice value of a running process (only root)
  - renice [-n] priority options
  - Use -p to renice the PID process
  - Use -u to renice processes owned by the user

### Listing processes

- List running processes using ps:

- None: processes running in the current shell
- -u: processes of a user
- -e or -A: all processes
- -ef: full format listing
- aux - BSD style listing

Filter processes using pgrep:

- none: only show process ID
- -l: show PID and process name
- -u: show processes of a user
- -g: show processes of a group
- -v: invert the match

### Signals 

- Primitive IPC/Soft IRQ
  - signal other process
  - Signal self
- Events 
  - Modem hangup
  - Timer elapsed
- Erros 
  - Broken pipe
  - seg fault
- Customize meaning

Common signals: 
- number 15: SIGTERM, default signal sent by kill, can be caught and ignored
- number 9: SIGKILL, cannot be caught or ignored, forces process termination
- number 11: SIGSEGV, segmentation fault, sent when a process tries to access an invalid memory address
- number 1: SIGHUP, sent when a terminal is disconnected, often used to reload configuration files

kill (PID):
- -l: list all signal names and numbers
- -number: specify the signal to send by number
- -signal: specify the signal to send by name

- killall (name):
- -l: list all signal names and numbers
- -s: send signal number or name, default to SIGTERM(15)
- -u: select only processes owned by a user

pkill (as pgrep): send signal number or name 

## Task Scheduling

### Cron 

- Repetitive tasks
- Standard
  - Many implementetations
- System daemon
    - crond
    - spawn processes
- Per user task lisk
  - crontab
  - var/spool/cron/crontabs/username


## Boot and runlevels

Linux Boot procedure:
1. BIOS: tests and MBR chain-up
2. Bootloader: kernel selection
3. Kernel startup
4. sbin/init: init system 

### BIOS

- Basic Input Output System
- POST (Power On Self Test)
  - Detect hardware
  - accessing bootable devices
- Read MBR (Master boot record)
  - First 512 bytes of the disk
  - Hosts the partition table 
  - hosts the starting procedure
- Start Boot manager (GRUB, LILO)

### Kernel 

- boot/vmlinuz
- The kernel controls the entire system hardware

1. Decompresses itself, organizes and takes control of the futrther booting of the system
2. Checks and sets the console, read BIOS seetings, initializes basic hardware interfaces
3. Drivers probe existing hardware and initialize it

### initrd

- Early userland and pivot_root
  - linuxrc script
  - fake init
  - load drivers
  - pivot_root to real root filesystem
- Initial RAM disk
  - Filesystem image loaded in memory by the bootloader
  - CPIO archive
  - Compressed
  
### /sbin/init

- Userland entry point
- the parent of all other processes (PID 1)
- Allocate VT's and run rc to switch to default runlevel

1. /etc/inittab: configuration file
2. /etc/init.d/boot: main services
3. /etc/init.d/rc: runlevel specific services

### init/inits

- Legacy init
  - Widely used
  - Scripts
  - Sequential
- Systemd
    - New standard
    - Parallel startupt
    - launchd alike
    - System V compatible
    - services description
    - Default for Debian, CentOS, Arch

### Different init 

- Use /bin/bash as an init
- Use kernel parameters
  - depends on your bootloader
  - init=
  - Run any binary
  - Can run a /bin/sh shell
  - UID = 0

- Recover passwords, fix boot issues

### Runlevels

- System profiles
- Identifier for system state
  - Numeric 
  - 0 to 6
- Used by init and rc
  - start/stop services
  - Enable/disable multi-user

- init configuration file syntax: id:runlevels:action:command

Somme actions:
- once: run the command and continue to the next entry
- wait: run the command and wait for completion before continuing to the next entry
- respawn: run the command, continue to the next entry and restart the process if it dies

## Linux Kernel 

### About kernels 

- Provide abstractions
  - Files/filesystems
  - Network sockets 
  - etc
- Manage hardware
  - allocate CPU time (multitasking)
  - manage memory (process isolation, Virtual memory)
- it exposes a VM to userland application and hides complexity
  - IDE commands, blocks, files

### Kernel families

- Different implementations to provide the same services
- Monolithic kernels
  - Everything run in kernel mode (ring 0 on x86), crash on fault
  - faster
  - easier to implement
- Micro kernels
  - Most services as userland processess, no crash on fault: just restart faulty 'server'
  - slower (ontext switches)
  - hard to keep in sync

### Sources 

- Sources available from kernel.org
  - Patches
  - full versions
- Versioning 
  - version.major.minor-rev
  - main trunk
  - old trunk 

uname [options]

### Architecture

- Module does not mean micro kernel
- Monolithic 
  - Everything in kernel land
  - Privileged mode

### Modules

- Functional units
- Provide features

- Hardware drivers
  - wide range
  - gigantic footprint
  - load only what is needed


- Modules are stored as
  - .ko (kernel objects)
  - .ko.gz (compressed)

- Per kernel 
  - lib/modules/<kernel-version>
- Per category
  - ex: /lib/modules/2.6.18/kernel/drivers/car/drm/radeon.ko

- Tools work
  - files
  - names

### Loading modules

- modprobe command will resolve dependencies and autoload needed modules

modprobe [options] module [params]

You can see any kernel message using dmesg

insmod is a low level command mostly used when doing kernel dev

it doesnt auto resolve dependencies and expects a filename

### Information about modules

- modinfo gives many information about the module, such as author and license but also gives useful information like params and types
- you need to specify the module name or the module file to read from: modinfo [options] module|module-file

### Patching 

- kernel flavors:
  - vanilla: official version from kernel.org
  - Distro: customized vanilla distro patches

- Customized kernels:
  - New features: not in vanilla not in your distro
  - Bugfixes (kernel panics soled, performance enhancements)
  - Supported hardware
  - various hacks

- Patches are released in diff format: text file made of code to add or remove

### Configure and compile

- Optimize
  - only needed features
  - smaller binary
  - faster kernel
  - compile for your architecture
- New features
  - patched version
  - new version not in your distro repi

- Download the sources: kernel.org full version
- unpack in /usr/src (you get /usr/src/linux-x.y.z, create /usr/src/linux symlink)
 

1. Configure
2. Compile
3. Install (you may need to manually update your bootloader)

Working toolcahin

## Variables

### Scalar Variables

- No spaces around the "=" operator
- Set: no $
- Use: $ before the variable name
- the variable name be put into braces

### Arrays

- Set as scalar variables
- Use braces to get the value
- Bash 4+ supports associative arrays
  - string indexes
  - same behavior

### Executing commands

- Grab a command output:
  - Using backtiks
  - Using parenthesis

### Input/Output

- Use echo to print a string to STDOUT
- Read an input from the keyboard read[-p prompt] [variable]

## Writing scripts

### Overview

- Text file 
  - Executable
  - Shebang
- Shell executes
  - $(shebang self)
  - Run the file with specified interpreter

### Invocation

- Set executable bit chmod +x script.sh

### Exit codes and signals 

- The exit statement:
  - Exits the script and returns a value (0 or >0)
  - Unix convention (0 success, non-zeron failure)
- The trap statement can interpret signals sent to the script

### Functions

- Variable scope: default global or local keyword
- Arguments: use $1 etc
- Numeric return = return keyword
- String return = write to STDOUT

### Tests

- test keyword
- Shorten to []
- Extented to [[]]

### Mathematical expressions

- expr
  - write result to STDOUT
  - int division
- let 
  - bash builtin
  - works on variables
  - does not wrtie anything to STDOUT
- Arithmetic expansion

### If's

- if condition; then command; fi 

if [ 'a' = 'a']; then echo "true"; fi

- if condition; then command; else command; fi
- if condition; the, command; elif command; then command; fi 

### Cases

case var in 
        case1)
        echo ''
        ;;


### While

- While condition; do command; done

### Until 

- until codition; do command; done
- while opposite

### For

- The fort statement can act like the foreach of other programming languages
  - iterates over a $IFS-separated list of values
  - {m..n} generates a space-seperated number list

### Control statements

- the break statement interrupts the running loop
- The continue statement stops the running iteration and goes to the next iteration

## HTTP Protocol

### Definitions 

- HyperText Transfer Protocol: a protocol used at first  to retrieve inter-linked documents (called hypertext documents), works at the layer 7 of the OSI model 

- Uniform Resource Identifier: a string used to identify a resource (only identifies the resource, it does not necessarily precise how to access it), an abstraction for URLs

- Uniform Resource Locator: it is a URI that, in addition to identifying a resource, gives information on how to retrieve it

