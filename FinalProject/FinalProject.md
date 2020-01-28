# Final Project
## Minimum Technical Requirements
1. Requires user input
    - Should take and respond to user input
    - Should behave differently based on the user input
1. Example of classes (at least 3)
    - Use either inheritance
    - Use either collection or instance of the base class/interface type to interact with the child types as if they are the base class/interface (Polymorphism). Example:
        ```cs
        List<Animal> ClaytonsListOfPets = new List<Animal>();

        Dog jimboTheDog = new Dog("Jimbo", 12.21);
        Cat suzyTheCat = new Cat("The Adorable", "Suzy", 10);

        ClaytonsListOfPets.Add(suzyTheCat);
        ClaytonsListOfPets.Add(jimboTheDog);

        foreach (Animal pet in ClaytonsListOfPets) {
            pet.Speak();
        }
        ```

## Expectations
1. Expectation is that the Student will use all class time to complete this project. They are welcome to work on the project outside of class, but the project should be scoped to the time they have in class (approximately 4-5 hours of work).
    - Your project should reflect that you have worked 4-5 hours on it!
1. Keep in mind that you will be presenting this to the entire class, so make sure you are prepared.
1. Keep your project backed up in GitHub


<br>

## Ideas
You can do whatever you want for your final project as long as it meets the requirements above. However, if you'd like a good starting point, you can try one of the ideas below:

### Mini Database of some sort
Create a simple application to create, view, update and delete data objects. These objects can be anything, such as:
- Animals (like a Zoo)
- Songs (like Spotify)
- Videos (like YouTube)
- Documents (like OnBase)

### Pet Match App
Create an application that allows a user to enter some information about themselves, and then matches them up with a pet based on the information they entered.

### Desktop search
Create an application that will search all the files on the computer given some search criteria.