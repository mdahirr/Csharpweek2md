# Sparta global week 2

Projects and other learning material from the Engineering152 class.

## Table of contents
1. projects
2. installation
3. development
4. references

### 1. Projects


#### Monday - HelloWorldApp lesson

* created a small program that prints the number of iterations in a loop and a variable changes, in this case the variable x increased by 1 for each iteration.

simple for loop used:
```C#
int x = 100;
x += 10;

for (int i = 0; i < 10; i++)
{
 Console.WriteLine("i: " + i + " -- x: " + x);

 x += 1;
}
```
- used breakpoints to see which order the code is run.
- learned about conditions that can be used with breakpoints such as a hit count
- learned how to add arguments through the command line

example code:
```c#
foreach (var item in args)
   {
     Console.WriteLine(item);
   }
```
