# Boxifier Code-Along
Follow the instructions below to create and use a method that encases a piece of text in an ASCII box.

## Printing the Welcome Message
Start by creating a new project and simply printing out a basic welcome message.

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
The goal of this program will be to have a method named `boxify` that places a custom message in a box. To start, have the method simply print out a box containing a static message.

Under the `Main` method, _define_ a new method named `boxify`:

```cs
public static void boxify() { }
```

Then, in the _body_ of the `boxify` method, add three `Console.WriteLine` statements to print out the word "Box" surrounded by an ASCII art box:

```cs
Console.WriteLine(".-------.");
Console.WriteLine("|  Box  |");
Console.WriteLine("*-------*");
```

Finally, _call_ the `boxify` method from the `Main` method, under the other code:

```cs
boxify();
```

Run the program, and verify that the properly boxed message appears!

## Returning a `string` from the `boxify` Method
To make this more dynamic, the `boxify` method should _return_ a `string`. This way, the code that _calls_ the method can do anything with the result.

Start by updating the _method signature_ of the `boxify` method so that its return type is `string` instead of `void`:

```cs
public static string boxify()
```

Next, in the _body_ of the `boxify` method, move the three `string`s _out_ of the `Console.WriteLine` statements, and into their own variables:

```cs
string topLine = ".-------.";
string middleLine = "|  Box  |";
string bottomLine = "*-------*";
```

Finally, combine the three `string` lines, separated by `'\n'` characters, into a new `string` variable, and `return` it:

```cs
string entireBox = topLine + "\n" + middleLine + "\n" + bottomLine;
return entireBox;
```

## Using a Custom `message` Parameter for the `boxify` Method
Now that the box message has been returned as a string, it's time to add the ability to customize the message. Instead of always putting "Box" in the box, the message will be determined by a _parameter_ on the `boxify` method.

First, update the _method signature_ for the `boxify` method so that it contains a new `string` parameter of `message`:

```cs
public static string boxify(string message)
```

Then, update the `middleLine` variable so that instead of containing "Box" it contains the custom `message` parameter

```cs
string middleLine = "|  " + message + "  |";
```

Everything else should still work the same for now!

## Updating the `boxify` Method Call with the `string` Argument
The `boxify` method has been updated quite a bit, but it appears to be broken when it is called from the `Main` method! This is because the `boxify` method takes an _argument_ now, and the `Main` method needs to pass something into it.

Create a new `string` variable above the _call_ to `boxify`, and pass it into the `boxify` method call:

```cs
string boxMessage = "I am in a box";

boxify(boxMessage);
```

Additionally, it is important to save what is _returned_ from the `boxify` method call! Create a new `string` variable named `box`, and update the code so that it stores the result in the variable:

```cs
string box = boxify(boxMessage);
```

Run the code to make sure it works! It should look okay for some messages, but it also appears to be a little off.

## Calculating the Box Top and Bottom Dashes
Currently, the number of dashes on the top and the bottom of the box does not change with the message length. This means that the box does not look much like a box! Update the code in the `boxify` method so that it dynamically creates `string`s for the top and bottom dashes.

At the top of the _body_ of the `boxify` method, create a new `string` variable named `dashes`, and set it to the empty string:

```cs
string dashes = "";
```

The `dashes` variable should eventually hold one dash for each character in the `message`. To accomplish this, set up a `while` loop:

```cs
while ()
{

}
```

In the _condition_ for the `while` loop, check that the length of `dashes` is _less than_ the length of `message`:

```cs
while (dashes.Length < message.Length)
```

Basically, the loop should continue until the number of dashes matches the number of characters in the message. Next, in the _body_ of the `while` loop, add a dash to the `dashes` variable:

```cs
dashes += "-";
```

Now that the proper dashes have been calculated, it's time to place them within the `topLine` and `bottomLine` variables. Remove the three `-` characters currently in the middle of the top and bottom lines, and replace them with the `dashes` variable:

```cs
string topLine = ".--" + dashes + "--.";
string middleLine = "|  " + message + "  |";
string bottomLine = "*--" + dashes + "--*";
```

Run the code again, and verify that the box properly sizes to the message! Try updating the `boxMessage` variable in the `Main` method, and make sure the box resizes as needed.

## Receiving the Box Message from the Console
The usefulness of the `boxify` method is that it can boxify any message! Instead of hard-coding a message, ask the user for one.

First, at the top of the _body_ of the `Main` method, use `Console.WriteLine` to print the question to the console:

```cs
Console.WriteLine("What would you like to put in a box?");
```

Then, update the value of the `boxMessage` variable so that it is set to `Console.ReadLine`:

```cs
string boxMessage = Console.ReadLine();
```

Finally, add an extra `Console.WriteLine` underneath the `string boxMessage` line for some extra space:

```cs
Console.WriteLine();
```

Run the code again, and verify that it is possible to boxify any message entered!

## Calling the `boxify` Method on the Welcome Message
One final benefit to the `boxify` method is that the welcoming message can also be boxified! Create a new `string` variable named `welcomeBox`, and set it equal to the boxified welcome message. Then, write it to the console:

```cs
string welcomeBox = boxify("Welcome to the Boxifier!");
Console.WriteLine(welcomeBox);
```

Run the program one last time to see the ultimate power of the Boxifier!

## Final Code
- [Repl](https://replit.com/@JosephMaxwell/Cs101MethodReviewComplete#main.cs)