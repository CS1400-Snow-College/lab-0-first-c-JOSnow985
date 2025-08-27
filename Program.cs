// See https://aka.ms/new-console-template for more information

// Clears the terminal window so we it only displays this run's output
Console.Clear();
Console.WriteLine("Hello, World!");

//string aFriend = "Bill";
//Console.WriteLine(aFriend);
//aFriend = "Maira";
//Console.WriteLine(aFriend);

//Console.WriteLine("Hello " + aFriend);

string aFriend = "Bill";
Console.WriteLine($"Hello {aFriend}");

// Can assign values to variables after they've been declared in the initial assignment
aFriend = "Maira";
Console.WriteLine($"Hello {aFriend}");

// Multiple variables in curly braces
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Length is a property, and returns the number of characters ina  string
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


// Testing trim command, [] brackets show where the space is being trimmed off
Console.WriteLine("Using various types of Trim");
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// .Replace can search for a substring and replace it with different text
Console.WriteLine("Using Replace to replace Hello with Greetings");
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// .ToUpper and .ToLower can be used to change the case of a string
Console.WriteLine("Using ToUpper and ToLower to change the case");
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// Contains returns a boolean value if the string specified was found
Console.WriteLine("Using Contains to check if goodbye, then greetings, are in the string");
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

// Challenge, use StartsWith and EndsWith instead of Contains to get boolean values
Console.WriteLine("Now, using StartsWith and EndsWith instead");
string songLyrics2 = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics2.StartsWith("goodbye"));
Console.WriteLine(songLyrics2.StartsWith("You"));
Console.WriteLine(songLyrics2.EndsWith("hello"));
Console.WriteLine(songLyrics2.EndsWith("goodbye"));