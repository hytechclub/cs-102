# Classes Practice
Spend some time practicing class concepts, including constructors. Note that the purpose of this practice is to aid in [final project](../FinalProject/FinalProject.md) preparations!

## Restaurant Class Redux
Look back at the [restaurant challenge](../Classes/RestaurantClass.md) from the previous session, and try to build on it. Include a constructor for the `Restaurant` class, and work on creating a full-fledged console app to track restaurant reviews or restaurant ordering.

## Fruit Stand: Bug Extermination

![](https://i.imgur.com/cnEliHB.png)

Visit the [Fruit Stand Repl project](https://replit.com/@JosephMaxwell/FruitStandBugs), and try to fix the bugs in it. Some of these bugs may not be immediately obvious: try testing out the programs to discover them. Make sure that everything functions properly by the end!

There should be a total of `6` bugs to find and fix, across both the **main.cs** file and the **Fruit.cs** file.

>**HINT**: Use the errors to guide the debugging process. Each error should point to the line number on which it occurs; start by finding the line, and then try to figure out what's wrong with it!

## Fruit Stand: Enhancements
Once all of the bugs have been removed from the fruit stand, try adding the following enhancements!

### Add Another Fruit to the Inventory
Create another `Fruit` object, and add it to the inventory `List<Fruit>`! One possible idea for another fruit would be grapes:

```
  \
 ()()
()()()
 ()()
  ()
```

Feel free to add any other fruit as well. Notice that all that is required is to create the new `Fruit` object and add it to the `inventory` list; the rest will take care of itself!

### Add a Sugar Field
In addition to tracking the name, image, price, and calorie count for a `Fruit`, track the total grams of sugar it contains.

1. Update the `Fruit` class so that it contains a new `int` field: `Sugar`
1. Update the `Fruit` constructor so that it takes in a new `int` parameter for the sugar, and sets the field value
1. Update the `Display` method on the `Fruit` class so that it includes the total grams of sugar for the fruit
1. Update each new `Fruit` object created so that they all pass in a value for the `Sugar` field

### Refactor the Program: `ShoppingCart` Class
Currently, a lot of the code for the program lives in the **main.cs** file. This can become a little unwieldy. Try to refactor the program so that there is a new class, `ShoppingCart`, that handles a lot of the functionality.

The `ShoppingCart` class should contain:

- A `List<Fruit>` for the inventory of the fruit stand
- A `List<Fruit>` for the current items in the cart

The `ShoppingCart` should be able to:

- Calculate the total price for the cart
- Calculate the total calories for the cart
- Get the count for a given item in the cart
- Print out the contents of the cart, including total price and calories

By the end of the refactoring, the **main.cs** file should not contain _any_ methods other than the `Main` method. This separation of concerns will make the program much easier to maintain in the future.