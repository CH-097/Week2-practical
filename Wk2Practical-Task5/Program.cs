// Parse (divide), and build (concatenate) strings

//user enter a sequence of words as a string of letters
// first letter of each word is uppercase 
Console.WriteLine("Enter a string:");
string str = Console.ReadLine();


//count how many words are in the string
//split string into array of substrings using space as a delimiter which is space
string[] words = str.Split(' ');  //   eg. words = ["Hello", "world"]
int count = words.Length; //counts length of the array


//print the number of words in str on a lew line
Console.WriteLine($"The sentence you inputted is: {str}");

Console.WriteLine("Number of words = " + count);








