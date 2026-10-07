/*
 * Tasks 6-9
 * Caesar's cipher rotated every letter in a string by a fixed
 * number, K, making it unreadable by his enemies. Each 
 * unencrypted letter is replaced with the letter occurring K 
 * spaces after it when listed alphabetically.
 */


// Implement method that accepts string and number of rotations as input
// return the encrypted resutl to a string then display that and orig 
static string Encrypt(string str, int K)
{
    string alphabets = "abcdefghijklmnopqrstuvwxyz";
    string alphabetsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // creates a string of uppercase alphabets
    string newStr = ""; // creates an empty string to store the new encrypted string

    for (int i = 0; i < str.Length; i++)
    {
        char current = str[i]; // means the current character in the string str
        int position = alphabets.IndexOf(current); // finds the index of the current character in the alphabet string

        int positionUpper = alphabetsUpper.IndexOf(current); // finds the index of the current character in the uppercase alphabet string

        if (position != -1) // if the character is found in the lowercase alphabet string, otherwirse returns -1
        {
            int newPosition = (position + K) % 26; // calculates the new position of the character after K rotations, using modulo to wrap around the alphabet
                                                   // % 26 means that if the new position is greater than 25, it will wrap around to the beginning of the alphabet
            newStr += alphabets[newPosition]; // adds the new character to the newStr string

        } else if (positionUpper != -1) {
            int newPositionUpper = (positionUpper + K) % 26; // calculates the new position of the character after K rotations, using modulo to wrap around the alphabet
            newStr += alphabetsUpper[newPositionUpper]; // adds the new character to the newStr string

        } else
        {
            newStr += current; // if the character is not a letter, it is added to the newStr string as is
        }
    }
    return newStr;
}


static string Decrpt(string str, int K)
{
    // reverse encryption.
    string alphabets = "abcdefghijklmnopqrstuvwxyz";
    string alphabetsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // creates a string of uppercase alphabets
    string newStr = ""; // creates an empty string to store the new encrypted string

    for (int i = 0; i < str.Length; i++)
    {
        char current = str[i]; // means the current character in the string str
        int position = alphabets.IndexOf(current); // finds the index of the current character in the alphabet string

        int positionUpper = alphabetsUpper.IndexOf(current); // finds the index of the current character in the uppercase alphabet string

        if (position != -1) // if the character is found in the lowercase alphabet string, otherwirse returns -1
        {
            int newPosition = (position - K) % 26; // calculates the new position of the character before K rotations, using modulo to wrap around the alphabet
                                                   // % 26 means that if the new position is greater than 25, it will wrap around to the beginning of the alphabet
            newStr += alphabets[newPosition]; // adds the new character to the newStr string

        }
        else if (positionUpper != -1)  
        {
            int newPositionUpper = (positionUpper - K) % 26; // calculates the new position of the character after K rotations, using modulo to wrap around the alphabet
            newStr += alphabetsUpper[newPositionUpper]; // adds the new character to the newStr string

        }
        else
        {
            newStr += current; // if the character is not a letter, it is added to the newStr string as is
        }
    }
    return newStr;
}



//main
Main();

static void Main()
{
    Console.WriteLine("Main Menu\n" +
        "Select an option:\n" +
        "1 - encrypt text\n" +
        "2 - decrypt text\n" +
        "0 - End");

    int userChoice = Convert.ToInt32((Console.ReadLine()));


    if (userChoice == 1)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Enter number of rotations: ");
        int K = Convert.ToInt32(Console.ReadLine());

        string encrypted = Encrypt(str, K);

        Console.WriteLine($"The sentence you inputted is: {str}");
        Console.WriteLine($"The encrypted sentence is now: {encrypted}");

    } else if (userChoice == 2)
    {
        Console.WriteLine("Enter a string you wish to decrypt: ");
        string str = Console.ReadLine();

        Console.WriteLine("Enter number of rotations: ");
        int K = Convert.ToInt32(Console.ReadLine());

        string decrypted = Decrpt(str, K);

        Console.WriteLine($"The sentence you inputted is: {str}");
        Console.WriteLine($"The decrypted sentence is now: {decrypted}");
    } else
    {
        Console.WriteLine("Goodbye!");
    }
  







}

