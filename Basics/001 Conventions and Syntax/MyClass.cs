//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;

public class program
{
    public Barbarian barbarianone;

    public void Main()
    {
        barbarianone = new Barbarian();

        barbarianone.health = 5;
        barbarianone.powerLevel = 4;
        barbarianone.speed = 2;

        Console.WriteLine(barbarianone.health);
        Console.WriteLine(barbarianone.powerLevel);
        Console.WriteLine(barbarianone.speed);
    }
}

public class Barbarian {
    public int health;
    public int powerLevel;
    public int speed;
}