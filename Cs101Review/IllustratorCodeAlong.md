# Illustrator Code-Along
Follow the instructions below to build a simple menu-based application that can draw some ASCII art.

## Printing the Welcome Message
Start by printing out a message that says "Welcome to the Illustrator!"

After the initial `Console.WriteLine`, add another _empty_ `Console.WriteLine` statement just to add a space beneath the first message. Run the program and ensure that the message appears in the console.

### Code
```cs
using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Welcome to the Illustrator!");
		Console.WriteLine();
	}
}
```

## Printing the Menu
Next, print out the menu for the application. It should start with another empty `Console.WriteLine` for some more space. It should then ask the user which command they would like to execute. To start, add one option for a command: `"1. Draw Bunny"`. Add empty `Console.WriteLine` statements to make spaces between the messages where necessary. Run the program and ensure that the menu text appears as expected.

### Code
```cs
Console.WriteLine();
Console.WriteLine("What would you like to do?");
Console.WriteLine();
Console.WriteLine("1. Draw Bunny");
Console.WriteLine();
```

## Receiving User Input
Once the user has been prompted, it is necessary to receive their input from the console.

1. Create a new `string` variable named `command`, and use `Console.ReadLine` to read the user's command from the console
1. Repeat the command back to the user. For example, if they entered "1" as the command, the program should print "You entered: 1"
1. Add an empty `Console.WriteLine` to make some space
2. Run the program, enter a command, and verify that it is properly remembered and repeated

```cs
string command = Console.ReadLine();
Console.WriteLine("You entered: " + command);
Console.WriteLine();
```

## Executing the User Command
Now that the command is known, it is time to execute it. Currently, it is only possible to execute one command: the "1. Draw Bunny" command. To start, print out the word "bunny" if the user entered "1" for the command.

1. After the command is read from the user, add an `if` statement
1. Within the conditional for the `if` statement, check if the `command` variable is equal to `"1"`
1. In the body of the `if` statement, use `Console.WriteLine` to write "bunny" to the console
1. Run the program, and verify that "bunny" is printed _if_ the command entered is "1"

### Code
```cs
if (command == "1")
{
    Console.WriteLine("bunny");
}
```

## Updating the Bunny
Instead of simply printing the word "bunny" to the console, the program should draw an ASCII art bunny. Use three `Console.WriteLine` statements to draw a bunny. Run the program to see the new bunny!

### Code
```cs
Console.WriteLine("() ()");
Console.WriteLine("(^ ^)");
Console.WriteLine("(___)");
}
```

## Adding Another Command
So far, the program is not all that interesting. It can only execute one command! Add some code so that the program can execute another command: "2. Draw Fish"

1. In the menu section, add another `Console.WriteLine` to print out "Draw Fish" option:
    ```cs
    Console.WriteLine("2. Draw Fish");
    ```
1. Under the existing `if` statement, create a new `if` statement
1. In this `if` statement, check if the `command` variable is equal to `"2"`
1. In the body of this `if` statement, write code to print out a small ASCII fish
1. Run the program, and verify that the fish is printed if the command entered is "2"

### Code
```cs
if (command == "2")
{
    Console.WriteLine("  _ ");
    Console.WriteLine("><_>");
}
```

## Looping the Process Infinitely
Currently, the program will run once, and then exit. However, to be a true menu-based application, the program should load the menu repetitively. Use a `while` loop to accomplish this.

1. Find the first empty `Console.WriteLine` statement, above the one that says "What would you like to do?"
1. Right above that statement, create a while loop
1. Set the condition of the `while` loop to be `true`
    - This means the `while` loop will repeat infinitely!
1. Add the opening curly bracket immediately after the closing parenthesis for the `while` loop
1. Find the end of the second `if` statement, and add the closing curly bracket for the `while` loop immediately following it
1. Indent the code within the `while` loop so it is easier to read
1. Run the program, and verify that the menu continuously re-appears!

### Code
```cs
while (true)
{
    Console.WriteLine();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine();
    Console.WriteLine("1. Draw Bunny");
    Console.WriteLine("2. Draw Fish");
    Console.WriteLine();

    string command = Console.ReadLine();
    Console.WriteLine();

    if (command == "1")
    {
        Console.WriteLine("() ()");
        Console.WriteLine("(^ ^)");
        Console.WriteLine("(___)");
    }

    if (command == "2")
    {
        Console.WriteLine("  _ ");
        Console.WriteLine("><_>");
    }
}
```

## Adding an Exit Command
To ensure that the program does not actually run forever, add an additional "3. Exit" command.

1. In the menu section, add another `Console.WriteLine` to print out "Exit" option:
    ```cs
    Console.WriteLine("3. Exit");
    ```
1. Under the existing `if` statement, create a new `if` statement
1. In this `if` statement, check if the `command` variable is equal to `"3"`
2. In the body of this `if` statement, add a `break` command that will break out of the `while` loop
3. Run the program, and verify that the program exits if the command entered is "2"

### Code
```cs
if (command == "3")
{
    break;
}
```

## Final Code
- [Repl](https://repl.it/@JosephMaxwell/Cs101BasicReviewComplete#main.cs)