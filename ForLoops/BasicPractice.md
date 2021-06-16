# Basic `for` Loop Practice
Complete the following exercises related to `for` loops.

## Exercise 1: Bugs
Visit each of the following Repls. Start by trying to run the programs, and make a note of any error messages received. Then, fork the Repl and try to fix the code!

- [Bug 1](https://replit.com/@JosephMaxwell/ForLoopBug1#main.cs)
- [Bug 2](https://replit.com/@JosephMaxwell/ForLoopBug2#main.cs)
- [Bug 3](https://replit.com/@JosephMaxwell/ForLoopBug3#main.cs)
- [Bug 4](https://replit.com/@JosephMaxwell/ForLoopBug4#main.cs)
- [Bug 5](https://replit.com/@JosephMaxwell/ForLoopBug5#main.cs)

## Exercise 2: Rocket Launch Countdown
Create a program that uses a `for` loop to count down the numbers from `10` to `1`, then says "Lift off!"

1. Create a new project in Repl
1. In the body of the `Main` method, print out a message that says "Rocket Launch"
1. Under that, create a `for` loop  
    ```cs
    for () { }
    ```
1. For the first part of the `for` loop (**initializer**), create an `int i` variable and set it to `10`  
    ```cs
    for (int i = 10;) { }
    ```
1. For the next part (**conditional**), check if `i` is _greater than_ `0`  
    ```cs
    for (int i = 10; i > 0;) { }
    ```
1. For the final part (**modifier**), decrease the value of `i` by `1` with `i--`  
    ```cs
    for (int i = 10; i > 0; i--) { }
    ```
1. In the _body_ of the `for` loop (between the brackets), print the value of `i`  
    ```cs
    Console.WriteLine(i);
    ```
1. Under the `for` loop, print a message that says "Lift off!"

Run the program, and verify that it counts down and says "Lift off!" at the end.

### Bonus: Slow Counter
Right now, all of the countdown numbers appear pretty much at the same time. The computer moves too fast! It is actually possible to slow it down using the `Thread.Sleep` method. This will stop program execution for a given amount of time. This can be very helpful for programs that deal with timing of any kind.

1. At the top of the file, add `using System.Threading;`
1. In the body of the `for` loop, make a new line
1. Add `Thread.Sleep(1000);` to wait for `1000` ms (one second) before continuing

Run the program, and make sure the countdown is slowed down!

## Exercise 3: Triangle of Zeroes
Create a program that can print a triangle consisting of [powers of `10`](https://en.wikipedia.org/wiki/Power_of_10). It should ask the user how tall the triangle should be, and then print it out. This will be possible using the `Math.Pow` function to calculate each power of `10`.

### Examples
If the user entered `3`, the program should print:

```
1
10
100
```

If the user entered `5`, the program should print:

```
1
10
100
1000
10000
```

>Note: This will not work for large inputs, because C# will truncate the numeric output

### Implementation
Follow the steps below to implement the program.

1. Create a new project in Repl
1. In the body of the `Main` method, print out a message that says "How tall of a triangle?"
1. Under that, create a new `int` variable named `height`
1. Set the `height` variable to `Convert.ToInt32(Console.ReadLine())`
1. Under that, create a `for` loop  
    ```cs
    for () { }
    ```
1. For the first part of the `for` loop (**initializer**), create an `int i` variable and set it to `0`  
    ```cs
    for (int i = 0;) { }
    ```
1. For the next part (**conditional**), check if `i` is _less than_ the `height` variable  
    ```cs
    for (int i = 0; i < height;) { }
    ```
1. For the final part (**modifier**), increase the value of `i` by `1` with `i++`  
    ```cs
    for (int i = 0; i < height; i++) { }
    ```
1. In the body of the `for` loop, create a new `double` variable named `power`
1. Set the `power` variable to `Math.Pow(10, i)`
    - This will calculate the power of `10` for the given index
1. Use `Console.WriteLine` to print out the value of the `power` variable

Run the program, and verify that it properly prints out some triangles!

## Exercise 4: Rainbow Road
Create a program that will print out a road that changes colors as it goes. This will be possible using a `List` of `ConsoleColor` values. Create a new Repl, and remove any code from the body of the `Main` method to get started.

### The `List<ConsoleColor>`
First, create a new `List` of `ConsoleColor` values containing the colors of a rainbow: red, orange, yellow, green, blue, and purple. For convenience, the code for that is here:

```cs
List<ConsoleColor> colors = new List<ConsoleColor>()
{
    ConsoleColor.Red,
    ConsoleColor.DarkYellow,
    ConsoleColor.Yellow,
    ConsoleColor.Green,
    ConsoleColor.Blue,
    ConsoleColor.Magenta
};
```

Make sure to add `using System.Collections.Generic;` so the `List` works properly!

### The Road
Follow the steps below to create the rainbow road.

1. Under the `colors` list, create a `for` loop that will loop through `15` times
    ```cs
    for (int i = 0; i < 15; i++) { }
    ```
1. In the body of the `for` loop, print out the text `|  ||  |`
1. Run the program, and verify that a colorless road appears in the console
1. Back in the `for` loop body, make some new lines _above_ the `Console.WriteLine` statement
1. At the top of the `for` loop body, create a new `int` variable named `colorIndex`
1. Set the `colorIndex` variable to `i % colors.Count`
    - This will allow the road to cycle through the colors multiple times
1. On the next line, create a new `ConsoleColor` variable named `currentColor`
1. Set the `currentColor` variable to the value in the `colors` list _at_ `colorIndex`  
    ```cs
    ConsoleColor currentColor = colors[colorIndex];
    ```
1. Under that, set the `Console.ForegroundColor` value to `currentColor`  
    ```cs
    Console.ForegroundColor = currentColor;
    ```

Run the program again, and verify that a rainbow road appears! Feel free to change the length of the road by updating the `15` in the **conditional** part of the `for` loop.