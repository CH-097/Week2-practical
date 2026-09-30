/*
 * Week 2 Practical
 * 
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
        x = Convert.ToInt32((Console.ReadLine()));
        

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
        x = 0;

    }
    return x;
} 

// Task 3
static string GetMessage(int option)
{
    //determines which language is required using switch, thenr eturn correct hello phrase
    // depending in the language selected by user
    string message = "";
    switch (option)
    {
        case 1:
            message = ("Bonjour!");
            break;
        case 2:
            message = ("Hola!");
            break;
        case 3:
            message =("Hallo!");
            break;
        case 4:
            message = ("Ciao!");
            break;
    }
    return message;
} 





//main
Main();

static void Main()
{
    //PrintMenu();
    //int option = InputOption();
    //Console.WriteLine(option);
    // display the message in the langauge selected by user
    //Console.WriteLine(GetMessage(option));



    //Task 4, do-while loop, iterates until user enters 0 to exit application
    int option;
    do
    {
        PrintMenu();
        option = InputOption();
        Console.WriteLine(option);
        //display the message in the langauge selected by user
        Console.WriteLine(GetMessage(option));

    } while (option != 0);




}

