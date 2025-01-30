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
using System;

interface ICallback
{
    void OnCompleted(string result);
}

class Worker
{
    private ICallback callback; // ✅ Interface reference (not an instance)

    public Worker(ICallback callback) // Assigning via constructor
    {
        this.callback = callback;
    }

    public void DoWork()
    {
        Console.WriteLine("Working...");
        callback.OnCompleted("Work done!");
    }
}

class Client : ICallback
{
    public void OnCompleted(string result)
    {
        Console.WriteLine("Client received: " + result);
    }
}

class Program
{
    static void Main()
    {
        Client client = new Client();
        Worker worker = new Worker(client); // Passing an instance of Client
        worker.DoWork();
    }
}
 