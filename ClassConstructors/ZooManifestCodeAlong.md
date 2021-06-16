# Zoo Manifest Code-Along
Update an existing class so that it uses a custom constructor!

## Starter App
Open up the [starter Zoo Manifest app](https://replit.com/@JosephMaxwell/ZooManifest), and take a look at it.

### `Animal` Class
The `Animal` class represents an animal. Each `Animal` has a name, a species, a height (in inches), and a certain number of legs. There is a method that prints this information to the console.

### `Main` Method
First, the main method loops with a `while` loop, allowing the user to add new `Animal` objects to the `List` of animals. After adding animals, the program prints out the information for each `Animal` object.

### Modifications
The goal of this activity is to add a _constructor_ to the `Animal` class. The actual functionality should NOT change; this is an example of refactoring. This will simplify the code, and make it easier to maintain!

## Creating a Constructor
In the **Animal.cs** file, at the bottom of the class definition, add code for a new custom constructor. Remember, defining a constructor is like defining any other method, with two key differences:

- The name of the constructor has to be the name of the class (in this case, `Animal`)
- There is no return type for the constructor; instead of returning anything, it _initializes_ a new object of the class type

The code looks like this:

```cs
public Animal()
{

}
```

### Constructor Parameters
Now that the skeleton of the constructor has been defined, it's time to make it actually do something!

Developers often use constructors to initialize fields or properties on a class object. To do this for the `Animal` class, add four parameters to the `Animal` constructor, each corresponding to one of the fields on the class. The parameters should have the same types as the fields, but they should NOT have the same name.

The code should look something like this:

```cs
public Animal(string name, string species, int legs, double heightInCm)
{

}
```

### Setting the Field Values in the Constructor
Now that the constructor has some parameters, the constructor can use them to build the object. This is a lot like setting the field values outside of the constructor, but it makes it easier to initialize objects. In the body of the constructor, set each field to be the parameter value (except for the `heightInCm` parameter):

```cs
Name = name;
Species = species;
NumberOfLegs = legs;
```

### Setting the Height
For the `HeightInInches` property, things will be a little different. Although it is a little contrived, for this application, the user will always want to enter the height in centimeters, but have it stored in inches. Currently, the `Main` method converts the height from centimeters to inches before setting the `HeightInInches` property. Instead, it will be cleaner to do the conversion in the constructor!

Since the height parameter is currently measured in centimeters, set the `HeightInInches` field to be the value of the `heightInCm` parameter multiplied by `0.39`:

```cs
HeightInInches = heightInCm * 0.39;
```

Now the constructor is complete! That should be all the changes needed in the **Animal.cs** file.

## Using the Constructor
Upon running the project in its current state, an error should appear:

```
The type `Animal` does not contain a constructor that takes `0` arguments
```

This is caused by the following statement:

```cs
Animal a = new Animal();
```

Because the `Animal` class now has a custom constructor, the default constructor no longer exists! This means it is necessary to use the custom constructor when instantiating new `Animal` objects. Update the code in the **main.cs** file so that it properly utilizes the `Animal` constructor.

### Passing the Arguments
Now, instead of taking zero arguments, the `Animal` constructor method takes four. Pass in the `name`, `species`, `legNum`, and `heightCm` values directly:

```cs
Animal a = new Animal(name, species, legNum, heightCm);
```

>Note that it is no longer necessary to convert the `heightCm` value to inches; that happens in the constructor.

Once this change has been made, remove the direct field setting statements below, as they are no longer required! At this point, the program should work again. Run it, and ensure that it works the same as it did before the changes!