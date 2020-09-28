# For Loops Practice
For this session, practice using `for` loops in C#.

1. Complete the [basic practice](BasicPractice.md) exercises
1. Work on any of the various challenges from the [previous session](StudentDesc.md)
1. Try to complete the more difficult challenges below

## Bonus Challenge 1: Heat Tracker
Imagine a race. There are several contestants, and each contestant has three chances (each called a _heat_) to achieve their best time. The times for each of their heats are recorded in a `List`, with each time being represented as a `double`. All of those results are stored in _another_ `List`, which is a `List` of `List` objects.

Open up the [Heat Tracker Repl](https://repl.it/@JosephMaxwell/HeatTracker) and take a look at what it does so far. It works, but there are a lot of enhancements to be made! Add the ability for the user to do the following:

- Add a new result
- Print the lowest heat time for each result
- Print the average heat time for each result
- Remove a result
- Update a heat time for a result
- Print the average heat time across all results
- Print the results in order based on their lowest heat time

## Bonus Challenge 2: Flower Garden
Create a program that contains an ASCII-art flower garden. Flowers should sprout at random, then grow into full flowers, and then die. There should be three total spots for flowers to live.

It should end up looking something like this when the program runs:

![](https://i.imgur.com/QwNdnhu.gif)

If desired, start from this [Repl](https://repl.it/@JosephMaxwell/FlowerGarden) with guiding comments. The Repl contains all of the ASCII art necessary for the garden.

### Beyond the Basics
After creating the basic flower garden, make some enhancements to it!

#### Before the garden starts, ask the user how many flowers they would like
Dynamically generate the flower garden based on the user input.

#### Add different styles of flowers
Create more ASCII art for a different type of flower, and give the new flower styles certain probabilities for sprouting in any given frame.

#### User Deadheading
In gardening, [deadheading](https://en.wikipedia.org/wiki/Deadheading_(flowers)) is the practice of removing spent flowers from plants. This can encourage further blooming. In the basic Flower Garden program as it stands, deadheading happens automatically when a flower dies.

Instead of making this process happen by default, add a way for the user to determine when it should happen. Once that is complete, add a scoring mechanism where the user can earn points for deadheading flowers!

#### Make the flowers display horizontally as well as vertically
Try to make it so it looks something like this:

```
.---------. .---------. .---------.
|         | |         | |         |
|         | |         | |         |
|         | |         | |         |
*---------* *---------* *---------*

.---------. .---------. .---------.
|         | |         | |         |
|         | |         | |         |
|         | |         | |         |
*---------* *---------* *---------*

.---------. .---------. .---------.
|         | |         | |         |
|         | |         | |         |
|         | |         | |         |
*---------* *---------* *---------*
```