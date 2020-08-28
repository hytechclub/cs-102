# Movie Watchlist Code-Along
Currently, there is [a program](https://Movies.josephmaxwell.repl.run) that tracks movies a person wants to watch. It works pretty well, but there are some improvements to be made in the code. [Refactor](https://en.wikipedia.org/wiki/Code_refactoring) the program so that it uses a `Movie` class, and tracks a `List` of `Movie` objects instead of two lists.

Note that the goal of this exercise is NOT to change the functionality of the application; it should still work in the same way. The goal is to improve the architecture, to make it easier to maintain.

## The Current App
Visit the [Repl](https://repl.it/@JosephMaxwell/Movies#main.cs) for the app so far, and try to figure out how it works. There are a few important features:

- Two `List`s: one that stores movie titles, and one that stores movie release years
- An `while` loop that infinitely displays the menu for the application
- An "Add Movie" command that adds a movie title and year to the respective `List`s
- A "View Movies" command that displays information about each movie

So, what's wrong with the way it works now? It seems to be functioning properly, but it could be organized in a simpler way. Separating some code into another class makes it easier to separate concerns for the app, and it also makes it easier to add features. The way it currently works, with two separate lists, is a little fragile. If those lists somehow become desynchronized, the data would not match up. Additionally, a whole new list would have to be created to store an additional piece of information about a movie (e.g. its rating, its Rotten Tomatoes score, or anything else). For these reasons, it makes a lot of sense to create a new class!

Here is the plan:

1. Create a class named `Movie`
1. Add a `Title` and `Year` field to the `Movie` class
1. Update the main code so that it creates a `List` of `Movie` objects instead of two separate lists
1. Update the adding code so that it creates a new `Movie` object, sets the fields properly, and adds it to the list
1. Add a method on the `Movie` class to print out a movie in the proper format
1. Update the viewing code so that it uses a `foreach` loop to go through each `Movie` object and print it

Let's get started!

## Creating the `Movie` Class
Create a new file in the same folder named **Movie.cs**. This file will contain the `Movie` class.

1. At the top of the file, add `using System;`
1. Under that, _define_ the `Movie` class with `public class Movie {}`
1. What should the `Movie` class contain? What pieces of data are stored for each movie? So far, the app stores a title, and a year. Add those as fields for the movie

**Movie.cs**
```cs
using System;

public class Movie
{
    public string Title;
    public int Year;
}
```

That's all that's needed to start working with the `Movie` class and creating `Movie` objects.

## Using the `Movie` Type: Adding `Movie` objects
Consolidate the two `List`s that store movie information into one: a `List` of `Movie` objects!

First, remove the two existing `List` variables, and create a new `List<Movie>` named `movies`. Everything looks the same as any other `List`, only with `Movie` as the type:

```cs
List<Movie> movies = new List<Movie>();
```

Next, when adding a movie, update the code so that it creates a new `Movie` object. For the new `Movie` object, set the `Title` and `Year` fields to be whatever the user entered, and add the new movie to the `movies` list.

```cs
Movie movie = new Movie();
movie.Title = newTitle;
movie.Year = Convert.ToInt32(newYear);

movies.Add(movie);
```

For now, comment out the `for` loop code for viewing movies so the code will work without an error. Run the program, and make sure movies can be added! Obviously, adding movies doesn't do much good if they cannot be viewed.

## Using the `Movie` Type: Viewing `Movie` objects
Before, the code used a `for` loop and printed out the title and year from the separate lists. Now that the `Movie` class exists, the actual printing can be done there instead! This helps separate concerns, and makes the code easier to read.

In the **Movie.cs** file, add a new method named `Print` to the `Movie` class. It should be `public`, and have a return type of `void`:

```cs
public void Print()
{

}
```

Note that there is no `static` keyword used! This is because this method will use the fields on the class. Copy the code from the original `for` loop into the body of the method, and update the variable names so that they use the fields instead:

```cs
Console.WriteLine($"{Title} ({Year})");
```

Now, find the "View Movies" code where the `for` loop is commented out. Remove the `for` loop, and replace it with a `foreach` loop. This should loop through each `Movie` object in the `movies` list:

```cs
foreach (Movie m in movies)
{

}
```

In the body of the `foreach` loop, all that's needed is to _call_ the `Print` method on the current `Movie`!

```cs
m.Print();
```

Run the program, and verify that the current movie watchlist can be viewed!

## Adding a `Rating` field
To illustrate the usefulness of classes, add an additional field to the `Movie` class: `Rating`.

1. In the **Movie.cs** file, add a new `public string` field to the `Movie` class
2. In the `Print` method, update the message so that it includes the `Rating` value
3. In the **main.cs** file, when adding a movie, ask the user for a rating
4. Set the `Rating` property on the new `Movie` object to reflect what the user entered

That's all that's needed! The "View Movies" code does not need to be updated, and a new `List` does not need to be created. This makes the Movie Watchlist application much easier to maintain!