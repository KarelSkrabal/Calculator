# Calculator
Calculator
Calculates a result from a set of instructions loaded from a text file, please read Important notes section, otherwise it will not be possible to compile/run this application. Instructions comprise of a keyword and a number that are separated by a space per line.
Instructions are loaded from file and results are output to the screen. Any number of Instructions can be specified. Instructions can be any binary operators of your choice (e.g., add, divide, subtract, multiply etc). The instructions will ignore mathematical precedence. The last instruction should be “apply” and a number (e.g., “apply 3”). The calculator is then initialised with that number and the previous instructions are applied to that number.

Examples of the calculator lifecycle might be:

[Input from file] 
add 2 
multiply 3 
apply 3
[Output to screen]
15

IMPORTANT NOTES !

In the project is referenced a library FileHelpers (https://www.nuget.org/packages/FileHelpers/). FileHelpers is open source library for automatic formatted file read/write operations (more info www.filehelpers.net)

To install FileHelpers library, run this command in the Package Manager Console : Install-Package FileHelpers -Version 3.4.1

To run Calculator application in the project, go to Project -> Calculator Properties -> Debug -> Command line arguments , specify path to file containing instructions,ex. D:\Data.txt (such a file was added into the solution, folder Data). 
Example of instructions in Data.txt file

add 20 
multiply 2 
divide 2 
substract 10 
apply 3
