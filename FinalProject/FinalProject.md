# Final Project
## Minimum Technical Requirements
1. Requires user input
    - Should take and respond to user input
    - Should behave differently based on the user input
1. Example of classes (at least 3)
    - `MainWindow` does NOT count as one of the 3 classes
    - Use inheritance
    - Use either collection or instance of the base class type to interact with the child types as if they are the base class (Polymorphism). Example:
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
1. Expectation is that the student will use all office hours time to complete this project. They are welcome to work on the project any other time, but the project should be scoped to about 4-5 hours of work.
    - Your project should reflect that you have worked 4-5 hours on it!
1. Keep your project backed up in GitHub

## Presentations
Students will be expected to present their projects at the last meeting of the semester.

### Content
The presentation should include:

- Background about the idea behind the program
- An overview of the program's functionality
- An explanation of any new topics learned
- A brief look into any relevant or interesting parts of the code
- A discussion of any challenges that arose during the project development

### Procedure

- Students should push all of their code to GitHub
    - Make sure the code is shared with the instructors
- If a student is able to share their screen and talk through their project on Zoom, that is preferred
    - If a student does not have a microphone, they can join the Zoom meeting from a telephone
    - If a student cannot share their screen, the instructor can show the student's project
- A student also has the option of recording a video presentation
- There will be a defined schedule and order for each student to present
- **If a student does not present a final project, they may not be able to move onto the next level of Hy-Tech Club**

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