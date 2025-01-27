using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks.Dataflow;

class Program {
    static void Main(string[] args) {
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


        Random dice = new Random();
        int roll = dice.Next(1, 1000);
        Console.WriteLine(roll);


    }

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
}






 