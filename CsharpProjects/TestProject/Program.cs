using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
#region Design Specification and pseudo code
/*
- There will be three visiting schools
   - School A has six visiting groups (the default number)
   - School B has three visiting groups
   - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the school name
    - Pritn the animal groups
*/

/* Pseudo-code for one school

Pseudo-code method for randomizing the petting zoo animals
RandomizeAnimals();

Pseudo-code method to assign animal group
AssignGroup();

Print school name using Console.Write
Console.WriteLine("School A");

Print animal groups
PrintGroup(group);
We added a parameter to this method. We know that we need to print
different groups of animals several times, so you use a method to 
perform this task with the groyp as the input parameter

We can assign the group argument by storing the value returned by 
AssignGroup() into a variable.
var group = AssignGroup();
We used the var keyword so that it can store variables of any data type

Now let's consider what data type to assign to the group variable.
we want School A to have animals assigned into six groups. We also know 
that there are 18 animals and that they are represented using string.

So, we can use a 2D array that contains six groups of three animals each.
Instead of using var, we can use the string data type
string[,] group = AssignGroup();
THe default group value is six so we don't have to add any arguments to 
the AssignGroup method in this case. */
#endregion

Console.WriteLine("School A");