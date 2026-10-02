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
    string newStr = ""; // creates an empty string to store the new encrypted string


    //goes through each character in in str and replaces each character with one that K spaces after.
    for (int i = 0; i < str.Length; i++)
       
    {
        //
        char current = str[i]; // means the current character in the string str
        int position = alphabets.IndexOf(current); // finds the index of the current character in the alphabet string

        int newPosition = (position + K) % 26; // calculates the new position of the character after K rotations, using modulo to wrap around the alphabet
        newStr += alphabets[newPosition]; // adds the new character to the newStr string


    }

    return newStr;
}


//main
Main();

static void Main()
{

    Console.WriteLine("Enter a string: ");
    string str = Console.ReadLine();

    Console.WriteLine("Enter number of rotations: ");
    int K = Convert.ToInt32(Console.ReadLine());

    string encrypted = Encrypt(str, K);

    Console.WriteLine($"The sentence you inputtes is: {str}");
    Console.WriteLine($"The encrypted sentence is now: {encrypted}");



}

