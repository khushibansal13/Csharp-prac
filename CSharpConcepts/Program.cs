// using System;
// using System.Runtime.InteropServices;
// using System.Security.Principal;
// using System.Threading.Tasks.Dataflow;

// class Program {
//     static void Main(string[] args) {
// string phrase = "Hello world started";
// Console.WriteLine(phrase.ToLower());
// Console.WriteLine(phrase.Contains("World"));
// Console.WriteLine(phrase.Replace("Hello", "Goodbye"));
// Console.WriteLine(phrase.Length);
// Console.WriteLine(phrase.Substring(0, 5));


// Console.WriteLine((int)(5 + 5.5));
// Console.WriteLine(Math.PI);

// Console.Write("Enter your name: ");
// string name = Console.ReadLine() ?? string.Empty;   
// Console.WriteLine($"Hello, {name}!");

// string color , pluralNoun, celebrity;
// Console.Write("Enter a color: ");
// color = Console.ReadLine();
// Console.Write("Enter a plural noun: ");
// pluralNoun = Console.ReadLine();
// Console.Write("Enter a celebrity: ");
// celebrity = Console.ReadLine();


// Console.WriteLine("Roses are" + " " + color);
// Console.WriteLine(pluralNoun+ " " + "are blue");
// Console.WriteLine("I love" + " " + celebrity);

// int[] luckyNumbers = {4, 8, 15, 16, 23, 42}; 
// string[] friends = new string[5];

// bool isMale = true;
// bool isTall = false;

// if(isMale || isTall) {
//     Console.WriteLine("You are male");
// }
// else if(isMale && isTall) {
//     Console.WriteLine("You are female");
// }

// static int GetMax(int num1 ,int num2) {
//     int result;
//     if(num1 > num2) {
//         result = num1;
//     }
//     else {
//         result = num2;
//     }
//     return result;
// }

// Console.WriteLine(GetMax(2, 10));

// Console.WriteLine("Enter a number");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter a number");
// double num2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter a operator");
// string op = Console.ReadLine();

// if (op == "+") {
//     Console.WriteLine(num1 + num2);
// }
// else if (op == "-") {
//     Console.WriteLine(num1 - num2);
// }
// else if(op == "*") {
//     Console.WriteLine(num1 * num2);
// }
// else if(op == "/") {
//     Console.WriteLine(num1 / num2);
// }
// else {
//     Console.WriteLine("Invalid operator");
// }

// Console.WriteLine(GetDay(10 ));

// int index = 6;
// do {
//     Console.WriteLine(index);
//     index++;
// } while(index <= 5);


// string secretWord = "giraffe";
// string guess = "";
// int guessCount = 0;
// int guessLimit = 3;
// bool outOfGuesses = false;

// while (guess != secretWord && !outOfGuesses) {
//     if (guessCount < guessLimit) {
//         Console.Write("Enter guess: ");
//         guess = Console.ReadLine();
//         guessCount++;
//     }
//     else {
//         outOfGuesses = true;
//         break;

//     }
// }
// if (outOfGuesses) {
//     Console.WriteLine("You lose!");
// }
// else {
//         Console.WriteLine("You win!");
// }


// int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
// for (int i = 0; i < luckyNumbers.Length; i++) {
//     Console.WriteLine(luckyNumbers[i]);
// }

// Console.WriteLine(GetPow(3, 2));

// int[,] numberGrid = {
//     {1, 2},
//     {3, 4},
//     {5, 6}
// };

// Console.WriteLine(numberGrid[0, 1]);


//     Random dice = new Random();
//     int roll = dice.Next(1, 1000);
//     Console.WriteLine(roll);


// }

// static int GetPow(int baseNum, int powNum) {
//     int res = 1;

//     for(int i = 0; i < powNum; i++) {
//         res *= baseNum;
//     }
//     return res;
// }

//         static string GetDay(int dayNum) {
//             string dayName;

//             switch (dayNum) {
//                 case 0:
//                     dayName = "Sunday";
//                     break;
//                 case 1:
//                     dayName = "Monday";
//                     break;
//                 case 2:
//                     dayName = "Tuesday";
//                     break;
//                 case 3:
//                     dayName = "Wednesday";
//                     break;
//                 case 4:
//                     dayName = "Thursday";
//                     break;
//                 case 5:
//                     dayName = "Friday";
//                     break;
//                 case 6:
//                     dayName = "Saturday";
//                     break;
//                 default:
//                     dayName = "Invalid day number";
//                     break;
//             }

//             return dayName;
//         }
// }

// ----------------------------------------------------------------------------------
// Module 3: Unit 3.3

// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0]) {
//     case "01":
//         type = "Sweat Shirt";
//         break;
//     case "02":
//         type = "T-shirts";
//         break;
//     case "03":
//         type = "Sweat Pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1]) {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "Other";
//         break;   
// }

// switch (product[2]) {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     case "XL":
//         size = "Extra Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");
// --------------------------------------------------------------------------
// #FizzBuzz challenge

// using System;

// class Program {
//     static void Main(string[] args) {
//     //     for (int i = 1; i < 101; i++)
//     // {
//     //     if ((i % 3 == 0) && (i % 5 == 0))
//     //         Console.WriteLine($"{i} - FizzBuzz");
//     //     else if (i % 3 == 0)
//     //         Console.WriteLine($"{i} - Fizz");
//     //     else if (i % 5 == 0)
//     //         Console.WriteLine($"{i} - Buzz");
//     //     else
//     //         Console.WriteLine($"{i}");
//     // }

// }
// }
// ----------------------------------------------------------------------------------
// #Game rules

// int hero = 0;
// int monster = 0;

// Random dice = new Random();

// do{
//     int monsterRoll = dice.Next(1, 7);
//     monster -= monsterRoll;
//     Console.WriteLine($"Monster rolled {monsterRoll}. Monster's position is {monster}.");

//     if (monster <= 0) continue;

//     int heroRoll = dice.Next(1, 7);
//     hero -= heroRoll;
//     System.Console.WriteLine($"Hero rolled {heroRoll}. Hero's position is {hero}.");

// } while (hero > 0 && monster > 0);
// {
//     System.Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
// }
// ----------------------------------------------------------------------------------
// ##Code Project 1

// using System;

// class Program {
//     static void Main(string[] args) {
//         string? readResult;
//         string valueEntered = "";
//         int numValue =0 ;
//         bool validNumber = false;

//         System.Console.WriteLine("Enter an integer value between 5 and 10");

//         do {
//             readResult = Console.ReadLine();
//             if(readResult != null) {
//                 valueEntered = readResult;
//             }
//             validNumber = int.TryParse(valueEntered,  numValue);

//             if (validNumber == true) {
//                 if(numValue <= 5 || numValue >= 10) {
//                     validNumber = false;
//                     System.Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10");
//                 }
//             }
//             else {
//                     System.Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
//                 }

//         } while (validNumber == false);
//         System.Console.WriteLine($"Congratulations! You entered a valid number: {numValue}");

//     }
// }
// ----------------------------------------------------------------------------------
// ##Code Project 2

// string? readResult;
// string roleName = "";
// bool validRole = false;

// do
// {
//     System.Console.WriteLine(
//         "Enter the role you are assigned: \n" +
//         "1. Administrator\n" +
//         "2. Manager\n" +
//         "3. User\n"
//     );
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         roleName = readResult.Trim();
//     }
//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
//     {
//         validRole = true;
//     }
//     else
//     {
//         System.Console.WriteLine("Invalid role. Please try again.");
//     }
// } while (validRole == false);
// System.Console.WriteLine($"You are assigned the role of {roleName}.");
// --------------------------------------------------------------------------------------
// ##Code Project 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodIndex = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodIndex = myString.IndexOf(".");

    string mySentence;

    while (periodIndex != -1)
    {
        mySentence = myString.Remove(periodIndex);

        myString = myString.Substring(periodIndex + 1);

        myString = myString.TrimStart();

        periodIndex = myString.IndexOf(".");
        System.Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    System.Console.WriteLine(mySentence);
}
