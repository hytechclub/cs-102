# <span>C# 101 Review: Basic Practice</span>
Follow the instructions to review some basic C# concepts.

## Illustrator Enhancements
After completing the [Illustrator Code-Along](IllustratorCodeAlong.md), make the following enhancements:

1. Add more command options to draw more ASCII art!
    - Check out [this guide](AsciiArt.md) for help making ASCII art and using it in C#
2. (BONUS) Instead of using `if` statements to run the commands, use a [`switch` statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)
3. (BONUS) Define a method for each command, and call each method based on the user's selection

## Find the Bugs
Visit each of the following Repls, and fix the errors in them.

- [Bug 1](https://repl.it/@JosephMaxwell/Cs101ReviewBug1#main.cs)
- [Bug 2](https://repl.it/@JosephMaxwell/Cs101ReviewBug2#main.cs)
- [Bug 3](https://repl.it/@JosephMaxwell/Cs101ReviewBug3#main.cs)
- [Bug 4](https://repl.it/@JosephMaxwell/Cs101ReviewBug4#main.cs)

## Multi-Page Story
Often when reading something on a computer, the program will contain multiple pages instead of showing all the text at once. Create a C# application that will display a story, one passage at a time. It should end up looking something like [this Frankenstein story](https://StoryBook.josephmaxwell.repl.run) by the end.

Use `Console.WriteLine` to display the text from the story. Use `Console.ReadLine` to wait for the user to press Enter and continue. Use a `while` loop to loop through each passage of the story. Make sure to declare a counter variable to keep track of the current passage, and increment it every time through the loop.

### Bonus Challenge - Word Breaking
Currently, using `Console.WriteLine` will add line breaks in the middle of words.

For example, it will show this:
```
the success of my und
ertaking.
```

When it should show this:
```
the success of my
undertaking.
```

Fix this by inserting a newline character (`\n`) in the text for every place the line should break.

#### Bonus Bonus Challenge - Console Window Width
To make the newlines truly dynamic, measure the width of the console using `Console.Window.Width`. Use that value to determine where the newline characters should go. This way, it will properly keep words together regardless of the size of the console!