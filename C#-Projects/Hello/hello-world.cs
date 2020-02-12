console.WriteLine("Hello World!");
//Console says hello world
string aFriend = "Bill";
Console.WriteLine(aFriend);
//When declearing aFriend, the console prints out Bill
aFriend = "Maria";
Console.WriteLine(aFriend);
//Now the console will print out Maria, even though up above it says Bill. It will change to Maria
Console.WriteLine("Hello " + aFriend);
//Console says "Hello Maria"
Console.WriteLine($"Hello {aFriend}");
//Says the same thing, but done in a different way. This is String interpolation. Its only used to make it so you don't have to keep adding "+" to everything
string firstFriend = "Bill";
string secondFriend = "Maria";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
//Result = My friends are Bill and Maria
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
//Result = The name Bill has 4 letters
Console.WriteLine($"{secondFriend} has {secondFriend.Length} letters.");
//Result = Maria has 5 letters
//Length just tells you how many of whatever you put in, is. For the example above its just, how many letters are in these variables
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
//Result = Hello World!
sayHello = sayHello.Replace("Hello", "Greetings"); //using Replace
Console.WriteLine(sayHello);
//Result = Greetings World!
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye")); //Using Contains, it uses booleans
//Result = true
Console.WriteLine(songLyrics.Contains("greetings"));
//Result = false
//Greetings is nowhere to be found in the string, thus the second consolelog shows up as false
