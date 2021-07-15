// Perform basic string formatting in C#

// Character Escape Sequences and Verbatim Strings

// In C#, the escape character sequences begin with a backslash \ and then include another character. 
// the \n sequence will add a new line, and a \t sequence will add a tab.

/*
Console.WriteLine("Hello\nWorld!");

Console.WriteLine("Hello\tWorld!");

Console.WriteLine("The song \"Some Might Say\" is contained in the album \"What's the Story Morning Glory\" realised by the britpop band Oasis");

Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\t100%\tComplete!");
Console.WriteLine("Invoice: 1022\t\t100%\tComplete!");
Console.WriteLine("\nOutput Directory\t");
Console.WriteLine(@"c:\invoices");


// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
*/


// String Interpolation
/*
string myName = "PierMario";

string myLastName = "Salis";

int myAge = 27;

string interpolation = $"{myName} {myLastName} {myAge}";

Console.WriteLine(interpolation);

string greeting = "Hello";
string name = "Bob!";
string question = "How are you?";


Console.WriteLine($"{greeting} {name} {abjective}");
*/

// Verbatim Literals - Unicode Char (japanese)



/* 
// To generate Japanese invoices (FLAG: -j) :
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
*/




