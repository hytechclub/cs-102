# Basic `List` Practice
Complete the following exercises related to `List` objects.

## Exercise 1: Bugs
Visit each of the following Repls. Start by trying to run the programs, and make a note of any error messages received. Then, fork the Repl and try to fix the code!

- [Bug 1](https://replit.com/@JosephMaxwell/ListBug1#main.cs)
- [Bug 2](https://replit.com/@JosephMaxwell/ListBug2#main.cs)
- [Bug 3](https://replit.com/@JosephMaxwell/ListBug3#main.cs)
- [Bug 4](https://replit.com/@JosephMaxwell/ListBug4#main.cs)
- [Bug 5](https://replit.com/@JosephMaxwell/ListBug5#main.cs)

## Exercise 2: A Playlist of Your Favorite Songs
Think of some of your favorite songs. Create a program that adds those songs to a list, and then displays them!

1. Create a new project in Repl
1. At the top of the file, add `using System.Collections.Generic;`
1. In the body of the `Main` method, print out a message that says "My Favorite Songs"
1. Under that, initialize a new `List<string>` object named `songs`  
    ```cs
    List<string> songs = new List<string>();
    ```
1. Under that, add a few of your favorite songs to the list  
    ```cs
    songs.Add("9 to 5 by Dolly Parton");
    // etc
    ```
1. Under _that_, create a `foreach` loop to loop through each `string` in the `songs` list  
    ```cs
    foreach (string song in songs) { }
    ```
1. In the body of the `foreach` loop, print out the `song`  
    ```cs
    Console.WriteLine(song);
    ```

Run the program, and make sure that all the songs in the list appear!

## Exercise 3: Spaced Out Text
Sometimes, people on the internet like to display messages with extra spaces between each text character. For example, instead of writing `THE VOID`, they might write `T H E   V O I D `. Create a program that allows the user to input some text, and gives them the "spaced" version of that text!

### Background - `string` Objects
For this to work, it is important to know that a `string` object can actually be treated as a `List` of `char` objects. A `char` is just like a `string`, only it contains one single character instead of multiple characters. This means that, given a `string` variable named `myString` it is possible to do something like this:

```cs
foreach (char c in myString)
{
    Console.WriteLine(c);
}
```

The code above would print out each individual character in the `string`!

### Implementation
Follow the steps below to implement the "Spaced Out Text" program.

1. Create a new project in Repl
2. In the body of the `Main` method, print out a message that says "Enter some text to space out"
3. Under that, create a new `string` variable named `text`
4. Set the `text` variable to the result of `Console.ReadLine()`
5. Under that, create another `string` variable named `spacedText`
    - This will hold the "spaced out" text
6. Set the `spacedText` variable to be an empty string (`""`)
7. Under that, create a `foreach` loop that will loop through each `char c` in the `text` string  
    ```cs
    foreach (char c in text) { }
    ```
8. In the body of the `foreach` loop, add `c` and an extra space to the `spacedText` variable  
    ```cs
    spacedText += c + " ";
    ```
9. Under the `foreach` loop, print out the final `spacedText` value

Run the program. Make sure it is possible to enter some text, and see the spaced out version of it!

## Exercise 4: Course Ranking
Think about all of the courses you take in school. Order them by how much you like them, with number `1` being the top course. Create a program that will allow the user to check which course corresponds with each ranking.

1. Create a new project in Repl
1. At the top of the file, add `using System.Collections.Generic;`
1. In the body of the `Main` method, print out a message that says "Course Ranking"
1. Under that, initialize a new `List<string>` object named `courses`  
    ```cs
    List<string> courses = new List<string>();
    ```
1. Under that, add each of your courses _in order_, with the top course coming first  
    ```cs
    courses.Add("Geometry");
    // etc
    ```
1. Under _that_, use `Console.WriteLine` to ask the user which ranking they would like to see
1. Under that, create a new `int` variable named `rank`
1. Set the `rank` variable to `Convert.ToInt32(Console.ReadLine())`
1. Under that, create a new `int` variable named `rankIndex`, and set it to `rank - 1`
    - Note that this is necessary because `List` objects start index at `0`
1. On the next line, create a new `string` variable named `courseAtRank`
1. Set the `courseAtRank` variable to the element of the list at the `rankIndex` index  
    ```cs
    string courseAtRank = courses[rankIndex];
    ```
1. On the next line, print out the value of the `courseAtRank` variable

Run the program and verify that the proper courses appear based on what the user enters!

### Bonus - Limited Ranking
Currently, if the user enters something outside of the range of the course ranking list, the program will fail. Update it so that it checks whether the rank the user enters is within range. If it is not, display a message saying "Course Ranking Not In Range."
