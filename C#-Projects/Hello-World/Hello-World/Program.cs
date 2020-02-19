using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is just a test!");
            //All above code is needed in order to write any code
            string aFriend = "Bill";
            //When declearing aFriend, the console prints out Bill
            Console.WriteLine("Hello " + aFriend);
            aFriend = "Maria";
            Console.WriteLine(aFriend);
            //Now the console will print out Maria, even though up above it says Bill. It will change t4o Maria
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            //Says the same thing, but in a different way. This is called String interpolation. Its only used to make it so you don't have to keep adding "+" to everything
            string firstFriend = "Bill";
            string secondFriend = "Maria";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            //Result = My friends are Bill and Maria
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            //Result = The name Bill has 4 letters
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");
            //Results = Maria has 5 letters
            //Length just tells you how many of whatever you put in, is. For the example above its just, how many letters are in these variables
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            //Result = Hello World!
            sayHello = sayHello.Replace("Hello", "Greetings"); //using Replace
            Console.WriteLine(sayHello);
            //Result = Greetings world!
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye")); //Using Contains, it uses booleans
            //Result = true
            Console.WriteLine(songLyrics.Contains("greetings"));
            //Result = false
            Console.WriteLine(songLyrics.StartsWith("You")); //StarsWith function will select to let you know if the item in the () is at the start or not
            Console.WriteLine(songLyrics.EndsWith("goodbye")); //EndsWith function will select to let you know if the item in the () is at the end or not
            //Result = true followed by false
            Console.WriteLine(songLyrics.StartsWith("Hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            //Result = false and false
        }
    }
}
