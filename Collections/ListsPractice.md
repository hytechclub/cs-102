# Lists Practice
For this session, practice using `List` objects in C#.

1. Complete the [basic practice](BasicPractice.md) exercises
1. Work on any of the various challenges from the [previous session](StudentDesc.md)
2. Try to complete the more difficult challenges below

## Bonus Challenge 1: ASCII Art Animation
Create a new Repl, and in it, create an ASCII art animation. When the program runs, it should repeatedly cycle through the frames of an animation. The end result should look something like this:

![](https://i.imgur.com/JTUPKv0.gif)

Here are some things that may help accomplish this:

- A `List` of [verbatim literal strings](../Cs101Review/AsciiArt.md), each with one frame of the animation
- The [`Console.Clear`](https://docs.microsoft.com/en-us/dotnet/api/system.console.clear?view=netcore-3.1) method to clear the console before drawing each frame
- An infinite `while` loop, along with a variable to track the current frame for the animation (i.e., the spot in the `List` of strings)
- The [`Thread.Sleep`](https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=netcore-3.1) method to add time between each frame
- Some way to go back to the first frame of the animation after the last frame has been reached

## Bonus Challenge 2: A `List` of `List`s
Sometimes, it makes sense to represent data as a `List` of `List`s in C#. This is sometimes referred to as a 2D (two-dimensional) collection.

For example, imagine a school attendance tracker. A teacher would like to keep track of which students are absent each day. For a given day, there is a `List` of `string` objects, each of which contains the name of an absent student. All of these lists are stored in _another_ `List`, which contains all of the information across all of the days.

The _type_ of the `List`, instead of being something like `int` or `string`, is `List<string>` because the list _contains_ `List` objects! It ends up looking like this:

```cs
List<List<string>> attendanceDays = new List<List<string>>();
```

**Create a program that allows a teacher to keep track of the absences across multiple days.** This should be a menu-based application. The teacher should be able to do the following:

#### Add a new daily entry to the main `List`
Create a new `List<string` object for the current day, and add it to the `List<List<string>>`.

#### View the entire list of absences
Print out each day of absences. Note that if the list is empty for a given day, "(no absences)" should be printed.

It should end up looking something like this:
```
--Day 1--
Lucy
Shan
Darius

--Day 2--
Shan

--Day 3--
Mario
Lucy

--Day 4--
(no absences)

--Day 5--
Darius
```

#### Find the total number of absences for a given student
Loop through each day of absences, and keep track of how many times the student's name appears.

### Side-Note: Wikipedia List of lists of lists
There is an impressively comprehensive [list on Wikipedia](https://en.wikipedia.org/wiki/List_of_lists_of_lists) that contains lists of other lists.