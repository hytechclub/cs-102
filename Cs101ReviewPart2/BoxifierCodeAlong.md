# Boxifier Code-Along
Follow the instructions below to create and use a method that encases a piece of text in an ASCII box.

## Printing the Welcome Message
```cs
using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Welcome to the Boxifier!");
		Console.WriteLine();
	}
}
```

## Defining the `boxify` Method
```cs
public static void boxify()
{
    Console.WriteLine(".-------.");
    Console.WriteLine("|  Box  |");
    Console.WriteLine("*-------*");
}
```

## Calling the `boxify` Method
```cs
boxify();
```

## Returning a `string` from the `boxify` Method
```cs
public static string boxify()
{
    string topLine = ".-------.";
    string middleLine = "|  Box  |";
    string bottomLine = "*-------*";

    string entireBox = topLine + "\n" + middleLine + "\n" + bottomLine;
    return entireBox;
}
```

## Using a Custom `message` Parameter for the `boxify` Method
```cs
public static string boxify(string message)
{
    string topLine = ".-------.";
    string middleLine = "|  " + message + "  |";
    string bottomLine = "*-------*";

    string entireBox = topLine + "\n" + middleLine + "\n" + bottomLine;
    return entireBox;
}
```

## Updating the `boxify` Method Call with the `string` Argument
```cs
string boxMessage = "I am in a box";

string box = boxify(boxMessage);
```

## Calculating the Box Top and Bottom Dashes
```cs
string dashes = "";
while (dashes.Length < message.Length)
{
    dashes += "-";
}

string topLine = ".--" + dashes + "--.";
string middleLine = "|  " + message + "  |";
string bottomLine = "*--" + dashes + "--*";
```

## Receiving the Box Message from the Console
```cs
Console.WriteLine("What would you like to put in a box?");
string boxMessage = Console.ReadLine();
Console.WriteLine();
```

## Calling the `boxify` Method on the Welcome Message
```cs
string welcomeBox = boxify("Welcome to the Boxifier!");
Console.WriteLine(welcomeBox);
```

## Final Code
- [Repl](https://repl.it/@JosephMaxwell/Cs101MethodReviewComplete#main.cs)