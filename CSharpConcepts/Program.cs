﻿// using System;
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

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodIndex = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodIndex = myString.IndexOf(".");

//     string mySentence;

//     while (periodIndex != -1)
//     {
//         mySentence = myString.Remove(periodIndex);

//         myString = myString.Substring(periodIndex + 1);

//         myString = myString.TrimStart();

//         periodIndex = myString.IndexOf(".");
//         System.Console.WriteLine(mySentence);
//     }
//     mySentence = myString.Trim();
//     System.Console.WriteLine(mySentence);
// }
// --------------------------------------------------------------------------------------
// ##Module 3: Guided Project

// using System;
// using System.IO;

// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";
// string suggestedDonation = "";

// int maxPets = 8;
// string? readResult;
// string menuSelection = "";
// int petCount = 0;
// string anotherPet = "y";
// bool validEntry = false;
// int petAge = 0;
// decimal decimalDonation = 0.00m;

// string[,] ourAnimals = new string[maxPets, 6];

// for (int i = 0; i < maxPets; i++)
// {
//     switch (i)
//     {
//         case 0:
//             animalSpecies = "dog";
//             animalID = "d1";
//             animalAge = "2";
//             animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//             animalNickname = "lola";
//             suggestedDonation = "85.00";
//             break;

//         case 1:
//             animalSpecies = "dog";
//             animalID = "d2";
//             animalAge = "9";
//             animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//             animalNickname = "loki";
//             suggestedDonation = "49.99";
//             break;

//         case 2:
//             animalSpecies = "cat";
//             animalID = "c3";
//             animalAge = "1";
//             animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//             animalPersonalityDescription = "friendly";
//             animalNickname = "Puss";
//             suggestedDonation = "40.00";
//             break;

//         case 3:
//             animalSpecies = "cat";
//             animalID = "c4";
//             animalAge = "?";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             suggestedDonation = "";

//             break;

//         default:
//             animalSpecies = "";
//             animalID = "";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             suggestedDonation = "";
//             break;

//     }

//     ourAnimals[i, 0] = "ID #: " + animalID;
//     ourAnimals[i, 1] = "Species: " + animalSpecies;
//     ourAnimals[i, 2] = "Age: " + animalAge;
//     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

//     if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//     {
//         decimalDonation = 45.00m;
//     }
//     ourAnimals[i , 6] = $"Suggested Donation: {decimalDonation:C2}";
// }

// do
// {
//     Console.Clear();

//     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//     Console.WriteLine(" 1. List all of our current pet information");
//     Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//     Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//     Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//     Console.WriteLine(" 5. Edit an animal’s age");
//     Console.WriteLine(" 6. Edit an animal’s personality description");
//     Console.WriteLine(" 7. Display all cats with a specified characteristic");
//     Console.WriteLine(" 8. Display all dogs with a specified characteristic");
//     Console.WriteLine();
//     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         menuSelection = readResult.ToLower();

//     }

//     switch (menuSelection)
//     {
//         case "1":
//         // List all of our current pet information
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     Console.WriteLine();
//                     for (int j = 0; j < 6; j++)
//                     {
//                         Console.WriteLine(ourAnimals[i, j].ToString());
//                     }
//                 }
//             }
//             Console.WriteLine("\n\rPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         case "2":
//             // Add a new animal friend to the ourAnimals array
//             anotherPet = "y";
//             petCount = 0;
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     petCount += 1;
//                 }
//             }

//             if (petCount < maxPets)
//             {
//                 Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
//             }

//             while (anotherPet == "y" && petCount < maxPets)
//             {
//                 do
//                 {
//                     Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
//                     readResult = Console.ReadLine();
//                     if (readResult != null)
//                     {
//                         animalSpecies = readResult.ToLower();
//                         if (animalSpecies != "dog" && animalSpecies != "cat")
//                         {
//                             validEntry = false;
//                         }
//                         else
//                         {
//                             validEntry = true;
//                         }
//                     }
//                 } while (validEntry == false);
//                 animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
//                 do
//                 {
//                     Console.WriteLine("Enter the pet's age or enter ? if unknown");
//                     readResult = Console.ReadLine();
//                     if (readResult != null)
//                     {
//                         animalAge = readResult;
//                         if (animalAge != "?")
//                         {
//                             validEntry = int.TryParse(animalAge, out petAge);
//                         }
//                         else
//                         {
//                             validEntry = true;
//                         }                        
//                     }
//                 } while (validEntry == false);

//                 do
//                 {
//                     Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
//                     readResult = Console.ReadLine();
//                     if (readResult != null)
//                     {
//                         animalPhysicalDescription = readResult.ToLower();
//                         if (animalPhysicalDescription == "")
//                         {
//                             animalPhysicalDescription = "tbd";
//                         }
//                     }
//                 } while (validEntry == false);

//                 do
//                 {
//                     Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
//                     readResult = Console.ReadLine();
//                     if (readResult != null)
//                     {
//                         animalPersonalityDescription = readResult.ToLower();
//                         if (animalPersonalityDescription == "")
//                         {
//                             animalPersonalityDescription = "tbd";
//                         }
//                     }
//                 } while (validEntry == false);
//                 do
//                 {
//                     Console.WriteLine("Enter a nickname for the pet");
//                     readResult = Console.ReadLine();
//                     if (readResult != null)
//                     {
//                         animalNickname = readResult.ToLower();
//                         if (animalNickname == "")
//                         {
//                             animalNickname = "tbd";
//                         }
//                     }
//                 } while (validEntry == false);

//                 ourAnimals[petCount, 0] = "ID #: " + animalID;
//                 ourAnimals[petCount, 1] = "Species: " + animalSpecies;
//                 ourAnimals[petCount, 2] = "Age: " + animalAge;
//                 ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
//                 ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
//                 ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

//                 petCount = petCount + 1;

//                 if (petCount < maxPets)
//                 {
//                     Console.WriteLine("Do you want to enter info for another pet (y/n)");
//                     do
//                     {
//                         readResult = Console.ReadLine();
//                         if (readResult != null)
//                         {
//                             anotherPet = readResult.ToLower();
//                         }

//                     } while (anotherPet != "y" && anotherPet != "n");
//                 }
//             }

//             if (petCount >= maxPets)
//             {
//                 Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
//                 Console.WriteLine("Press the Enter key to continue.");
//                 readResult = Console.ReadLine();
//             }

//             break;

//         case "3":
//             // Ensure animal ages and physical descriptions are complete

//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ")
//                 {
//                     do
//                     {
//                         Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
//                         readResult = Console.ReadLine();
//                         if (readResult != null)
//                         {
//                             animalAge = readResult;
//                             validEntry = int.TryParse(animalAge, out petAge);
//                         }
//                     } while (validEntry == false);
//                     ourAnimals[i, 2] = "Age: " + animalAge.ToString();
//                 }

//                 if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: ")
//                 {
//                     do
//                     {
//                         Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
//                         readResult = Console.ReadLine();
//                         if (readResult != null)
//                         {
//                             animalPhysicalDescription = readResult.ToLower();
//                             if (animalPhysicalDescription == "")
//                             {
//                                 validEntry = false;
//                             }
//                             else
//                             {
//                                 validEntry = true;
//                             }

//                         }
//                     } while (validEntry == false);

//                     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//                 }
//             }
//             Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         case "4":
//             // Ensure animal nickname and personality descriptions are complete
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: ")
//                 {
//                     do
//                     {
//                         Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
//                         readResult = Console.ReadLine();
//                         if (readResult != null)
//                         {
//                             animalNickname = readResult;
//                             if (animalNickname == "")
//                             {
//                                 validEntry = false;
//                             }
//                             else
//                             {
//                                 validEntry = true;
//                             }

//                         }

//                     } while (validEntry == false);

//                     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//                 }

//                 if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: ")
//                 {
//                     do
//                     {
//                         Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
//                         readResult = Console.ReadLine();
//                         if (readResult != null)
//                         {
//                             animalPersonalityDescription = readResult.ToLower();
//                             if (animalPersonalityDescription == "")
//                             {
//                                 validEntry = false;
//                             }
//                             else
//                             {
//                                 validEntry = true;
//                             }
//                         }
//                     } while (validEntry == false);

//                     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
//                 }
//             }
//             Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         case "5":
//             // Edit an animal’s age");
//             Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         case "6":
//             // Edit an animal’s personality description");
//             Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         case "7":
//             // Display all cats with a specified characteristic
//             Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         case "8":
//             // Display all dogs with a specified characteristic
//             Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
//             Console.WriteLine("Press the Enter key to continue.");
//             readResult = Console.ReadLine();
//             break;

//         default:
//             break;
//     }

// } while (menuSelection != "exit");
// ----------------------------------------------------------------------------------------------------------------

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);
// ----------------------------------------------------------------------------
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));
// --------------------------------------------------------------------------------
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);
// ----------------------------------------------------------------------------------------------
// ###Module 4 : Final project

// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";
// string suggestedDonation = "";

// int maxPets = 8;
// string? readResult;
// string menuSelection = "";
// decimal decimalDonation = 0.00m;

// string[,] ourAnimals = new string[maxPets, 7];

// for (int i = 0; i < maxPets; i++)
// {
//     switch (i)
//     {
//         case 0:
//             animalSpecies = "dog";
//             animalID = "d1";
//             animalAge = "2";
//             animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//             animalNickname = "lola";
//             suggestedDonation = "85.00";
//             break;

//         case 1:
//             animalSpecies = "dog";
//             animalID = "d2";
//             animalAge = "9";
//             animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//             animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//             animalNickname = "gus";
//             suggestedDonation = "49.99";
//             break;

//         case 2:
//             animalSpecies = "cat";
//             animalID = "c3";
//             animalAge = "1";
//             animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
//             animalPersonalityDescription = "friendly";
//             animalNickname = "snow";
//             suggestedDonation = "40.00";
//             break;

//         case 3:
//             animalSpecies = "cat";
//             animalID = "c4";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "lion";
//             suggestedDonation = "";

//             break;

//         default:
//             animalSpecies = "";
//             animalID = "";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             suggestedDonation = "";
//             break;
//     }

//     ourAnimals[i, 0] = "ID #: " + animalID;
//     ourAnimals[i, 1] = "Species: " + animalSpecies;
//     ourAnimals[i, 2] = "Age: " + animalAge;
//     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

//     if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//     {
//         decimalDonation = 45.00m; 
//     }
//     ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
// }
// do
// {
//     Console.Clear();

//     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//     Console.WriteLine(" 1. List all of our current pet information");
//     Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//     Console.WriteLine();
//     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         menuSelection = readResult.ToLower();
//     }
//     switch (menuSelection)
//     {
//         case "1":
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     Console.WriteLine();

//                     for (int j = 0; j < 7; j++)
//                     {
//                         Console.WriteLine(ourAnimals[i, j].ToString());
//                     }
//                 }
//             }

//             Console.WriteLine("\r\nPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         case "2":
//             string dogCharacteristics = "";

//             while (dogCharacteristics == "")
//             {
//                 Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
//                 readResult = Console.ReadLine();

//                 if (readResult != null)
//                 {
//                     dogCharacteristics = readResult.ToLower();
//                     Console.WriteLine();
//                 }
//             }

//             string[] dogSearches = dogCharacteristics.Split(",");
//             for (int i = 0; i < dogSearches.Length; i++)
//             {
//                 dogSearches[i] = dogSearches[i].Trim();
//             }

//             Array.Sort(dogSearches);
//             string[] searchingIcons = {" |", " /", "--", " \\", " *"};

//             bool matchesAnyDog = false;
//             string dogDescription = "";
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 1].Contains("dog"))
//                 {
//                     dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
//                     bool matchesCurrentDog = false;

//                     foreach (string term in dogSearches)
//                     {
//                         if (term != null && term.Trim() != "")
//                         {
//                             for (int j = 2; j > -1 ; j--)
//                             {
//                                 foreach (string icon in searchingIcons)
//                                 {
//                                     Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
//                                     Thread.Sleep(100);
//                                 }

//                                 Console.Write($"\r{new String(' ', Console.BufferWidth)}");
//                             }
//                             if (dogDescription.Contains(" " + term.Trim() + " "))
//                             {
//                                 Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

//                                 matchesCurrentDog = true;
//                                 matchesAnyDog = true;
//                             }
//                         }
//                     }

//                     if (matchesCurrentDog)
//                     {
//                         Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
//                     }
//                 }
//             }

//             if (!matchesAnyDog)
//             {
//                 Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
//             }

//             Console.WriteLine("\n\rPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         default:
//             break;
//     }
// } 
// while (menuSelection != "exit");
// ----------------------------------------------------------------------------------------------

// class Program {
//     static void Main(string[] args) {
//         void DisplapRandomNum() {
//             Random random = new Random();

//             for (int i = 0; i < 5; i++)
//             {
//                 System.Console.WriteLine($"{random.Next(1, 100)}");
//             }
//             System.Console.WriteLine();
//         }

//         System.Console.WriteLine("Generating random numbers:");
//         DisplapRandomNum();
//     }
// }
// -------------------------------------------------------------------------------------------------
// ## Delegates as Callbacks

// using System;

// public class Program {
//     public delegate void PrintDelegate(string message);

//     static void Main(string[] args) {
//         ExecuteCallback(PrintMessage);

//         static void PrintMessage(string message) {
//             Console.WriteLine(message);
//         }

//         static void ExecuteCallback(PrintDelegate callback) {
//             System.Console.WriteLine("Calling");
//         }
//     }
// }

// ## Delegates as Higher order 
// using System;

// class Program
// {
//     public delegate int MathOperation(int x, int y);

//     static void Main()
//     {
//         // Pass different operations as delegates
//         MathOperation add = (x, y) => x + y;
//         MathOperation multiply = (x, y) => x * y;

//         Console.WriteLine(Operate(5, 3, add));       // Output: 8
//         Console.WriteLine(Operate(5, 3, multiply));  // Output: 15
//     }

//     static int Operate(int a, int b, MathOperation operation)
//     {
//         return operation(a, b);
//     }
// }
// --------------------------------------------------------------------------------------------------------
// ## using interface as reference
// using System;

// interface ICallback
// {
//     void OnCompleted(string result);
// }

// class Worker
// {
//     private ICallback callback; // ✅ Interface reference (not an instance)

//     public Worker(ICallback callback) // Assigning via constructor
//     {
//         this.callback = callback;
//     }

//     public void DoWork()
//     {
//         Console.WriteLine("Working...");
//         callback.OnCompleted("Work done!");
//     }
// }

// class Client : ICallback
// {
//     public void OnCompleted(string result)
//     {
//         Console.WriteLine("Client received: " + result);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Client client = new Client();
//         Worker worker = new Worker(client); // Passing an instance of Client
//         worker.DoWork();
//     }
// }
//  -------------------------------------------------------------------------------------------
// ## Module 5:

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }
// ---------------------------------------------------------------------------------------------
// using System;

// class Program
// {
//     string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
//     string[] address;
//     bool isLengthValid = false;
//     bool isZeroesValid = false;
//     bool isRangeValid = false;

//     static void Main()
//     {
//         Program program = new Program();

//         foreach (string ip in program.ipv4Input)
//         {
//             program.address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//             program.CheckLength();
//             program.CheckZeroes();
//             program.CheckRange();

//             if (program.isLengthValid && program.isZeroesValid && program.isRangeValid)
//             {
//                 Console.WriteLine($"{ip} is a valid IPv4 address");
//             }
//             else
//             {
//                 Console.WriteLine($"{ip} is not a valid IPv4 address");
//             }
//         }
//     }

//     void CheckLength()
//     {
//         isLengthValid = address.Length == 4;
//     }

//     void CheckZeroes()
//     {
//         foreach (string number in address)
//         {
//             if (number.Length > 1 && number.StartsWith("0"))
//             {
//                 isZeroesValid = false;
//                 return;
//             }
//         }
//         isZeroesValid = true;
//     }

//     void CheckRange()
//     {
//         foreach (string number in address)
//         {
//             int value;
//             if (!int.TryParse(number, out value) || value < 0 || value > 255)
//             {
//                 isRangeValid = false;
//                 return;
//             }
//         }
//         isRangeValid = true;
//     }
// }
// ------------------------------------------------------------------------------------------------
// ## Random Fortune Teller

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// TellFortune();

// void TellFortune() {
//     System.Console.WriteLine("A fortune teller whisprer the follow words: ");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         System.Console.WriteLine($"{text[i]} {fortune[i]}");
//     }
// }
// ----------------------------------------------------------------------------------------------------

// string[,] corporate = 
// 	{
// 		{"Robert", "Bavin"}, {"Simon", "Bright"},
// 		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
// 		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

// 	string[,] external = 
// 	{
// 		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
// 		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
// 	};

// 	string externalDomain = "hayworth.com";

// 	for (int i = 0; i < corporate.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// 	}

// 	for (int i = 0; i < external.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// 	}

// 	void DisplayEmail(string first, string last, string domain = "contoso.com") 
// 	{
// 		string email = first.Substring(0, 2) + last;
// 		email = email.ToLower();
// 		Console.WriteLine($"{email}@{domain}");
// 	}
// -----------------------------------------------------------------------------------------------
// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", false); 
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize, string allergies, bool inviteonly) {
//     if (inviteonly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name)) {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found) {
//             System.Console.WriteLine($"Sorry, {name} you cannot RSVP without being invited.");
//             return;
//         }
//     }
//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs() {
//     System.Console.WriteLine("\nTotal RSVPs: ");
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.WriteLine(rsvps[i]);
//     }
// }
// --------------------------------------------------------------------------------------------------
// using System;

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }
// -------------------------------------------------------------------------------------------
// string input = "there are snakes at the zoo";

// System.Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseSentence(string input) {
//     string result = "";
//     string[] words = input.Split(' ');
//     foreach(string word in words) {
//         result += ReserveWord(word) + " ";
//     }
//     return result.Trim();
// }
// string ReserveWord(string word) {
//     string result = "";
//     for(int i = word.Length - 1; i >= 0; i--) {
//         result += word[i];
//     }
//     return result;
// }
// --------------------------------------------------------------------------------------------
// ## Zoo

// using System;

// string[] pettingZoo = 
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6) 
// {
//     RandomizeAnimals(); 
//     string[,] group1 = AssignGroup(groups);
//     Console.WriteLine(schoolName);
//     PrintGroup(group1);
// }

// void RandomizeAnimals() 
// {
//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++) 
//     {
//         int r = random.Next(i, pettingZoo.Length);

//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }

// string[,] AssignGroup(int groups = 6) 
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     int start = 0;

//     for (int i = 0; i < groups; i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++) 
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }

//     return result;
// }

// void PrintGroup(string[,] groups) 
// {
//     for (int i = 0; i < groups.GetLength(0); i++) 
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < groups.GetLength(1); j++) 
//         {
//             Console.Write($"{groups[i,j]}  ");
//         }
//         Console.WriteLine(); 
//     }
// }
// ------------------------------------------------------------------------------------------------
// using System;

// Random random = new Random();
// Console.CursorVisible = false;
// int height = Console.WindowHeight - 1;
// int width = Console.WindowWidth - 5;
// bool shouldExit = false;

// int playerX = 0;
// int playerY = 0;

// int foodX = 0;
// int foodY = 0;

// string[] states = {"('-')", "(^-^)", "(X_X)"};
// string[] foods = {"@@@@@", "$$$$$", "#####"};

// string player = states[0];

// int food = 0;

// InitializeGame();
// while (!shouldExit) 
// {
//     if (TerminalResized()) 
//     {
//         Console.Clear();
//         Console.Write("Console was resized. Program exiting.");
//         shouldExit = true;
//     } 
//     else 
//     {
//         if (PlayerIsFaster()) 
//         {
//             Move(1, false);
//         } 
//         else if (PlayerIsSick()) 
//         {
//             FreezePlayer();
//         } else 
//         {
//             Move(otherKeysExit: false);
//         }
//         if (GotFood())
//         {
//             ChangePlayer();
//             ShowFood();
//         }
//     }
// }
// bool TerminalResized() 
// {
//     return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
// }

// void ShowFood() 
// {
//     food = random.Next(0, foods.Length);

//     foodX = random.Next(0, width - player.Length);
//     foodY = random.Next(0, height - 1);

//     Console.SetCursorPosition(foodX, foodY);
//     Console.Write(foods[food]);
// }

// bool GotFood() 
// {
//     return playerY == foodY && playerX == foodX;
// }
// bool PlayerIsSick() 
// {
//     return player.Equals(states[2]);
// }

// bool PlayerIsFaster() 
// {
//     return player.Equals(states[1]);
// }

// void ChangePlayer() 
// {
//     player = states[food];
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// void FreezePlayer() 
// {
//     System.Threading.Thread.Sleep(1000);
//     player = states[0];
// }

// void Move(int speed = 1, bool otherKeysExit = false) 
// {
//     int lastX = playerX;
//     int lastY = playerY;
    
//     switch (Console.ReadKey(true).Key) {
//         case ConsoleKey.UpArrow:
//             playerY--; 
//             break;
// 		case ConsoleKey.DownArrow: 
//             playerY++; 
//             break;
// 		case ConsoleKey.LeftArrow:  
//             playerX -= speed; 
//             break;
// 		case ConsoleKey.RightArrow: 
//             playerX += speed; 
//             break;
// 		case ConsoleKey.Escape:     
//             shouldExit = true; 
//             break;
//         default:
//             shouldExit = otherKeysExit;
//             break;
//     }

//     Console.SetCursorPosition(lastX, lastY);
//     for (int i = 0; i < player.Length; i++) 
//     {
//         Console.Write(" ");
//     }

//     playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
//     playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }void InitializeGame() 
// {
//     Console.Clear();
//     ShowFood();
//     Console.SetCursorPosition(0, 0);
//     Console.Write(player);
// }
// ------------------------------------------------------------------------------------------
// using System;

// Random random = new Random();
// Console.CursorVisible = false;
// int height = Console.WindowHeight - 1;
// int width = Console.WindowWidth - 5;
// bool shouldExit = false;

// // Console position of the player
// int playerX = 0;
// int playerY = 0;

// // Console position of the food
// int foodX = 0;
// int foodY = 0;

// // Available player and food strings
// string[] states = { "('-')", "(^-^)", "(X_X)" };
// string[] foods = { "@@@@@", "$$$$$", "#####" };

// // Current player string displayed in the Console
// string player = states[0];

// // Index of the current food
// int food = 0;

// InitializeGame();
// while (!shouldExit)
// {
//     if (TerminalResized())
//     {
//         Console.Clear();
//         Console.Write("Console was resized. Program exiting.");
//         shouldExit = true;
//     }

//     if (PlayerIsFaster())
//     {
//         Move(1, false);
//     }
//     else if (PlayerIsSick())
//     {
//         FreezePlayer();
//     }
//     else
//     {
//         Move(otherKeysExit: false);
//     }

//     if (GotFood())
//         {
//             ChangePlayer();
//             ShowFood();
//         }

// }

// bool GotFood(){
//      return playerY == foodY && playerX == foodX;
// }

// bool PlayerIsFaster()
// {
//     return player.Equals(states[1]);
// }

// bool PlayerIsSick()
// {
//     return player.Equals(states[2]);
// }

// // Returns true if the Terminal was resized 
// bool TerminalResized()
// {
//     return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
// }

// // Displays random food at a random location
// void ShowFood()
// {
//     // Update food to a random index
//     food = random.Next(0, foods.Length);

//     // Update food position to a random location
//     foodX = random.Next(0, width - player.Length);
//     foodY = random.Next(0, height - 1);

//     // Display the food at the location
//     Console.SetCursorPosition(foodX, foodY);
//     Console.Write(foods[food]);
// }

// // Changes the player to match the food consumed
// void ChangePlayer()
// {
//     player = states[food];
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Temporarily stops the player from moving
// void FreezePlayer()
// {
//     System.Threading.Thread.Sleep(1000);
//     player = states[0];
// }

// // Reads directional input from the Console and moves the player
// void Move(int speed = 1, bool otherKeysExit = false)
// {
//     int lastX = playerX;
//     int lastY = playerY;

//     switch (Console.ReadKey(true).Key)
//     {
//         case ConsoleKey.UpArrow:
//             playerY--;
//             break;
//         case ConsoleKey.DownArrow:
//             playerY++;
//             break;
//         case ConsoleKey.LeftArrow:
//             playerX -= speed;
//             break;
//         case ConsoleKey.RightArrow:
//             playerX += speed;
//             break;
//         case ConsoleKey.Escape:
//             shouldExit = otherKeysExit;
//             break;
//     }

//     // Clear the characters at the previous position
//     Console.SetCursorPosition(lastX, lastY);
//     for (int i = 0; i < player.Length; i++)
//     {
//         Console.Write(" ");
//     }

//     // Keep player position within the bounds of the Terminal window
//     playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
//     playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

//     // Draw the player at the new location
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Clears the console, displays the food and player
// void InitializeGame()
// {
//     Console.Clear();
//     ShowFood();
//     Console.SetCursorPosition(0, 0);
//     Console.Write(player);
// }

// ---------------------------------------------------------------------------------------
// ### Delegates

// using System;

// class Program {
//     public delegate void VoidDelegate();

//     public static void Main(string[] args) {
//         VoidDelegate del1 = Print1;
//         MyClass.ExecuteDelegate(del1);
//     }

//     private static void Print1() {
//         System.Console.WriteLine("Method 1");
//     }
// }

// class MyClass {
//     public static void ExecuteDelegate(Program.VoidDelegate del) {
//         System.Console.WriteLine("Method 2");
//         del();
//     }
// }

// ## another example of delegate
// using System;

// class Program {
//     public delegate void GreetDelegate(string name);

//     static void Main(string[] args) {
//         GreetDelegate greet= sayHello;
//         greet += sayGM;
//         greet("John Doe");
//     }

//     static void sayHello(string name) {
//         Console.WriteLine($"Hello, {name}!");
//     }
//     static void sayGM(string name) {
//         Console.WriteLine($"Good Morning, {name}!");
//     }
// } 
// -------------------------------------------------------------------------------
// ### Func in delegate


// using System;

// class Program {
//     public static void Main(string[] args) {
//         Func<string> message1 = GetMessage;
//         Console.WriteLine(message1());
//         Func<string,string> message2 = GetMessageAgain;
//         Console.WriteLine(message2("from delegate"));
//     }
//     public static string GetMessage(){
//         return "Message 1";
//     }
//     public static string GetMessageAgain(string msg){
//         return "Message 2 " + msg;
//     }
// }
// ------------------------------------------------------------------------------------
// ### Action in delegates

// using System;

// class Program {
//     public static void Main(string[] args) {
//         Action message1 = GetMessage;
//         message1();
//         Action<string> message2 = GetMessageAgain;
//         message2("from delegate");
//     }
//     public static void GetMessage(){
//         System.Console.WriteLine("Message 1");
//     }

//     public static void GetMessageAgain(string msg){
//         System.Console.WriteLine("Message 2 " + msg);
//     }
// }
// -----------------------------------------------------------------------------------
// ### predicate in delegate
// using System;

// class Program {
//     static void Main(string[] args) {
//         Predicate<int> isEven = CheckEven; 

//         int number1 = 10;
//         int number2 = 15;

//         Console.WriteLine($"Is {number1} even? {isEven(number1)}");
//         Console.WriteLine($"Is {number2} even? {isEven(number2)}"); 
//     }

//     static bool CheckEven(int num) {
//         return num % 2 == 0;
//     }
// }
// ----------------------------------------------------------------------------------------
// ### Events:
// using System;

// class Program {
//     public delegate void NotifyEventHandler();

//     public static event NotifyEventHandler Notify;

//     public static void Main() {
//         Notify += NotifyMethod;
//         TriggerEvent();
//     }

//     static void TriggerEvent() {
//         Notify?.Invoke();
//     }
//     static void NotifyMethod() {
//         Console.WriteLine("Event triggered!");
//     }
// }
// -----------------------------------------------------------------------------------------------

// using System;
// using System.Security.Cryptography.X509Certificates;

// class Program {
//     public delegate void ButtonClickedEventHandler(string message);

//     public static event ButtonClickedEventHandler ButtonClicked;
//     static void Main() {
//         UserInterface ui = new UserInterface();
//         ButtonClicked += ui.HandleButtonCLick;

//         Button button = new Button();
//         button.Click();
//     }

//         public static void OnButtonCLicked(string message) {
//             ButtonClicked?.Invoke(message);
//         }

//     }

// public class Button {
//     public void Click() {
//         System.Console.WriteLine("Button CLicked");
//         Program.OnButtonCLicked("Button was clicked , notifying all listner");

//     }
// }

// public class UserInterface {
//     public void HandleButtonCLick(string message) {
//         System.Console.WriteLine($"UI recieved event: {message}");
//     }
// }
// ---------------------------------------------------------------------------------
using System;

class Program
{
    public static event EventHandler<string> ButtonClicked;

    static void Main()
    {
        UserInterface ui = new UserInterface();
        ButtonClicked += ui.HandleButtonClick;
        Button button = new Button();
        button.Click();
    }

    public static void OnButtonClicked(string message)
    {
        ButtonClicked?.Invoke(null, message);  
    }
}

public class Button
{
    public void Click()
    {
        Console.WriteLine("Button clicked");
        Program.OnButtonClicked("Button was clicked, notifying all listeners");
    }
}

public class UserInterface
{
     public void HandleButtonClick(object sender, string message)
    {
        Console.WriteLine($"UI received event: {message}");
    }
}
