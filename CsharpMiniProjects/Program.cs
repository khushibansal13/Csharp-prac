// // ## Calculator

// using System;

// namespace Calculator {

//     class Program {

//         static void Main(string[] args) {

//             int num1;
//             int num2;
//             int res;

//             Console.WriteLine("Welcome to the Calculator");
//             System.Console.WriteLine("Please enter the first number");
//             num1 = Convert.ToInt32(Console.ReadLine());
//             System.Console.WriteLine("Please enter the second number");
//             num2 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Please select an opperator: a for additin , s for subtraction , m for multiplication, d for division");
//             string ans = Console.ReadLine();

//             switch (ans) {
//                 case "a":
//                     res = num1 + num2;
//                     break;
//                 case "s":
//                     res = num1 - num2;
//                     break;
//                 case "m":
//                     res = num1 * num2;
//                     break;
//                 case "d":
//                     if (num2 == 0) {
//                         Console.WriteLine("Error: Division by zero is not allowed");
//                         return;
//                     }
//                     res = num1 / num2;
//                     break;
//                 default:
//                     Console.WriteLine("Error: Invalid operator. Please choose a valid operator (a, s, m, d)");
//                     return;
//             }
//             Console.WriteLine($"The result of {num1} {ans} {num2} is {res}");
//         }
//     }
// }
// -------------------------------------------------------------
// // ## Dice Game

// using System;
// using System.Runtime.InteropServices;

// namespace DiceGame {

//     class Program {

//         static void Main(string[] args) {

//             int playerRollNum;
//             int computerRollNum;
//             int count = 0;
//             int enemyCount = 0;

//             Random random = new Random();

//             for (int i = 0; i < 10; i++)
//             {
//                 System.Console.WriteLine("press any key to roll the dice");
//                 Console.ReadKey();

//                 playerRollNum = random.Next(1,7);
//                 System.Console.WriteLine("the player rolled a " + playerRollNum);

//                 System.Console.WriteLine("...");
//                 System.Threading.Thread.Sleep(1000);

//                 computerRollNum = random.Next(1,7);
//                 System.Console.WriteLine("the computer rolled a " + computerRollNum);

//                 if (playerRollNum > computerRollNum) {
//                     System.Console.WriteLine("Player wins");
//                     count++;
                    
//                 }
//                 else {
//                     System.Console.WriteLine("Computer wins");
//                     enemyCount++;
//                 }
                
//             }
//                 System.Console.WriteLine("Score: Player - " + count + ", Computer - " + enemyCount);

//         }
//     }
// }
// ----------------------------------------------------------------------------------
// ## Guess Game

// using System;

// namespace GuessGame {
//     class Program {
//         static void Main(string[] args) {

//             bool randomGuess = false;

//             Random random = new Random(); 
//             int randomNumber = random.Next(1, 11);

//             System.Console.WriteLine("Welcome to the guessing game!\n");
//             System.Console.WriteLine("Please enter a number between 1 and 10");

//             while(!randomGuess) {
//                 System.Console.WriteLine("Please enter your guess:");
//                 int guess = Convert.ToInt32(Console.ReadLine());

//                 if (guess > randomNumber) {
//                     System.Console.WriteLine("your guess is too high");
//                 }
//                 else if (guess < randomNumber) {
//                     System.Console.WriteLine("your guess is too low");
//                 }
//                 else {
//                     System.Console.WriteLine("Correct");
//                     randomGuess = true;
//                 }
//             }
//             System.Console.WriteLine("You Won!, Thank you for playing the guessing game");



//         }
//     }
// }
// -----------------------------------------------------------------
// ## Shape Area Calculator

// using System;

// namespace shapeArea {
//     class Program {
//         static void Main(string[] args) {

//             string ans;

//             System.Console.WriteLine("what shape would you like to find the area of> Please enter 'r' for recatnagle and press any other key for circle");

//             ans = Console.ReadLine();

//             if (ans == "r") {
//                 System.Console.WriteLine("Please enter the length of the rectangle");
//                 double length = Convert.ToDouble(Console.ReadLine());
//                 System.Console.WriteLine("Please enter the width of the rectangle");
//                 double width = Convert.ToDouble(Console.ReadLine());
//                 double area = length * width;
//                 System.Console.WriteLine("The area of the rectangle is " + area);
//             }
//             else {
//                 System.Console.WriteLine("Please enter the radius of the circle");
//                 double radius = Convert.ToDouble(Console.ReadLine());
//                 double area = Math.PI * (radius * radius);
//                 System.Console.WriteLine("The area of the circle is " + area);
//             }
//             System.Console.WriteLine("Thank you for using the shape area calculator");
//         }
//     }
// }
// -----------------------------------------------------------------
// ## Combat GAme

// using System;

// namespace CombatGame {
//     class Program {
//         static void Main(string[] args) {

//             int playerAttack = 10;
//             int enemyAttack = 7;

//             int playerHealth = 10 ;
//             int enemyHealth = 15;

//             int healAmount = 6;

//             Random random = new Random();

//             while(playerHealth > 0 && enemyHealth > 0) {
//                 System.Console.WriteLine("--- Player Turn ---");
//                 System.Console.WriteLine("Please enter 'a' to attack, 'h' to heal");
//                 string choice = Console.ReadLine();

//                 if (choice == "a") {
//                     enemyHealth -= playerAttack;
//                     System.Console.WriteLine($"You attacked the enemy, dealing {playerAttack} damage. Enemy health: {enemyHealth}");
//                 }
//                 else{
//                     playerHealth += healAmount;
//                     System.Console.WriteLine($"You healed yourself, gaining {healAmount} health. Your health: {playerHealth}");
//                 }

//                 System.Console.WriteLine("---");
//                 System.Threading.Thread.Sleep(1000);

//                 if (enemyHealth > 0) {
//                     int enemyChoice = random.Next(0,2);
//                     if (enemyChoice == 0) {
//                         playerHealth -= enemyAttack;
//                         System.Console.WriteLine($"The enemy attacked you, dealing {enemyAttack} damage. Your health: {playerHealth}");
//                     }
//                     else {
//                         enemyHealth += healAmount;
//                         System.Console.WriteLine($"The enemy healed itself, gaining {healAmount} health. Enemy health: {enemyHealth}");
//                     }
//                 }
//                 System.Console.WriteLine("Player health:" + playerHealth);
//                 System.Console.WriteLine("Enemy health:" + enemyHealth);
//             }
//             if (playerHealth <= 0) {
//                 System.Console.WriteLine("You have been defeated!");
//             }
//             else {
//                 System.Console.WriteLine("You have defeated the enemy!");
//             }

//         }
//     }
// }
// -----------------------------------------------------------------
// ## Rock Paper Scissors

// using System;

// namespace RockPaperScissors {
//     class Program {
//         static void Main(string[] args) {

//             int playerScore = 0;
//             int enemyScore = 0;
//             Random random = new Random();

//             System.Console.WriteLine("Welcome to Rock Paper Scissors");

//             while (playerScore != 3 && enemyScore != 3) {
//                 System.Console.WriteLine("Player score: " + playerScore);
//                 System.Console.WriteLine("Enemy score: " + enemyScore);
//                 System.Console.WriteLine("Please enter 'r' for rock, 'p' for paper, 's' for scissors");

//                 string playerChoice = Console.ReadLine();

//                 System.Console.WriteLine("---");
//                 System.Threading.Thread.Sleep(1000);
                
//                 int enemyChoice = random.Next(0, 3);

//                 if(enemyChoice == 0) {
//                     System.Console.WriteLine("Enemy chose rock");

//                     switch (playerChoice) {
//                         case "r":
//                             System.Console.WriteLine("It's a tie!");
//                             break;
//                         case "p":
//                             System.Console.WriteLine("You win!");
//                             playerScore++;
//                             break;
//                         case "s":
//                             System.Console.WriteLine("You lose!");
//                             enemyScore++;
//                             break;
//                         default:
//                             System.Console.WriteLine("Invalid input. Please try again.");
//                             break;
//                     }
//                 }
//                 else if (enemyChoice == 1) {
//                     System.Console.WriteLine("Enemy chose paper");

//                     switch (playerChoice) {
//                         case "r":
//                             System.Console.WriteLine("You lose!");
//                             enemyScore++;
//                             break;
//                         case "p":
//                             System.Console.WriteLine("It's a tie!");
//                             break;
//                         case "s":
//                             System.Console.WriteLine("You win!");
//                             playerScore++;
//                             break;
//                         default:
//                             System.Console.WriteLine("Invalid input. Please try again.");
//                             break;
//                     }
//                 }
//                 else {
//                     System.Console.WriteLine("Enemy chose scissors");

//                     switch (playerChoice) {
//                         case "r":
//                             System.Console.WriteLine("You win!");
//                             playerScore++;
//                             break;
//                         case "p":
//                             System.Console.WriteLine("You lose!");
//                             enemyScore++;
//                             break;
//                         case "s":
//                             System.Console.WriteLine("It's a tie!");
//                             break;
//                         default:
//                             System.Console.WriteLine("Invalid input. Please try again.");
//                             break;
//                     }
//                 }   
//             }
//             if (playerScore == 3) {
//                 System.Console.WriteLine("You win the game!");
//             }
//             else {
//                 System.Console.WriteLine("You lose the game!");
//             }
//         }
//     }
// }
// -----------------------------------------------------------------
// #To Do List

// using System;
// using System.Transactions;

// namespace ToDoList {
//     class Program {
//         static void Main(string[] args) {
//             List<string> taskList = new List<string>();
//             string option = "";

//             while (option != "e") {
//                 System.Console.WriteLine("Welcome to the To Do list");
//                 System.Console.WriteLine("Please select an option:");
//                 System.Console.WriteLine("1: Add a task");
//                 System.Console.WriteLine("2: View tasks");
//                 System.Console.WriteLine("3: Remove a task");
//                 System.Console.WriteLine("e: Exit");

//                 option = Console.ReadLine();

//                 if(option == "1") {
//                     System.Console.WriteLine("Enter the task name:");
//                     string taskName = Console.ReadLine();
//                     taskList.Add(taskName);
//                     System.Console.WriteLine($"Task '{taskName}' added successfully.");
//                 }
//                 else if(option == "2") {
//                     for (int i = 0; i < taskList.Count; i++)
//                     {
//                         System.Console.WriteLine(i + " : " + taskList[i]);
//                     }
//                 }
//                 else if(option == "3") {
//                     for (int i = 0; i < taskList.Count; i++)
//                     {
//                         System.Console.WriteLine(i + " : " + taskList[i]);
//                     }
//                     System.Console.WriteLine("Enter the index of the task you want to remove:");
//                     int index = Convert.ToInt32(Console.ReadLine());
//                     taskList.RemoveAt(index);
//                     System.Console.WriteLine("Task removed successfully.");
//                 }
//                 else if(option == "e") {
//                     System.Console.WriteLine("Thank you for using the To Do list");
//                 }
//                 else {
//                     System.Console.WriteLine("Invalid option. Please try again.");
//                 }
//             }
//             System.Console.WriteLine("Thank you for using the To Do list");
//         }
//     }
// }
// -----------------------------------------------------------------
// ## Currency/Temperature Converter

using System;
using System.Data.Common;

namespace Convertor {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Welcome to Convertor! Please enter 'c' to use the currency convertor or anything else for temperature convertor");
            string ans = Console.ReadLine();

            if (ans == "c")
            {
                System.Console.WriteLine("You have selected a currency convertor");
                System.Console.WriteLine("Please enter 'a' to convert from pounds or anything else to convert from euros");
                string choice = Console.ReadLine();

                if (choice == "a") 
                {
                    System.Console.WriteLine("Please enter your amount in British pounds");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    System.Console.WriteLine("Your amount in euros is" + euros.ToString("0.00"));
                }
                else {
                    System.Console.WriteLine("Please enter your amount in euros");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    System.Console.WriteLine("Your amount in British pounds is" + pounds.ToString("0.00"));
                }
            }
            else {
                System.Console.WriteLine("You have selected a temperature convertor");
                System.Console.WriteLine("Please enter 'a' to convert from Celsius to Fahrenheit or anything else to convert from Fahrenheit to Celsius");
                string choice = Console.ReadLine();

                if (choice == "a") {
                    System.Console.WriteLine("Please enter the temperature in Celsius");
                    float celsius = float.Parse(Console.ReadLine());
                    float fahrenheit = (celsius * 9/5) + 32;
                    System.Console.WriteLine("The temperature in Fahrenheit is" + fahrenheit.ToString("0.00"));
                }
                else {
                    System.Console.WriteLine("Please enter the temperature in Fahrenheit");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celsius = (fahrenheit - 32) * 5/9;
                    System.Console.WriteLine("The temperature in Celsius is" + celsius.ToString("0.00"));
                }
            }
            System.Console.WriteLine("Thank you for using Convertor!");
        }
    }
}