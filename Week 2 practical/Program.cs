/*
 * Week 2 Practical
 * Task 1: Create a PrintMenu() method
 * Task 2: Create InputOptional() method
 * Task 3: Create GetMessage() method
 * Task 4: Putting it all together
*/



//Task 1
// return type void
//asks user to pich from a menu of options
using System;
static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:\n" +
        "1. Hello in French?\n" +
        "2. Hello in Spanish?\n" +
        "3. Hello in German?\n" +
        "4. Hello in Italian?\n" +
        "0. Exit application");
}


// Task 2
//  convert choice selected by user and return this option as an integer to Main
//store this value in an int variable called option.
// add try-catch to catch any errors that could occur from user
static int InputOption()
{

    //read option value from user
    //PrintMenu();
    //int x = Convert.ToInt32((Console.ReadLine()));
    //return x ;

    int x;
    try
    {
        //read option value from user
        //PrintMenu();
        x = Convert.ToInt32((Console.ReadLine()));
        

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
        x = 0;

    }
    return x;



}

//main

Main();

static void Main()
{

    PrintMenu();
    int option = InputOption();
    Console.WriteLine(option);
 
}

