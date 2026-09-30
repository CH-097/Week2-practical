/*
 * Tasks 6-9
 * Caesar's cipher rotated every letter in a string by a fixed
 * number, K, making it unreadable by his enemies. Each 
 * unencrypted letter is replaced with the letter occurring K 
 * spaces after it when listed alphabetically.
 */


// Implement method that accepts string and number of rotations as input
// return the encrypted resutl to a string then display that and orig 
static string Encrypt(string str, int K);
{
    char[] result = new char[str.Length];



    

} return string(result);


//main

static void Main()
{

    Console.WriteLine("Enter a string: ");
    string str = Console.ReadLine();

    Console.WriteLine("Enter number of rotations: ");
    int K = Convert.ToInt32(Console.ReadLine());

    string encrypted = Encrypt(str, K);



}

