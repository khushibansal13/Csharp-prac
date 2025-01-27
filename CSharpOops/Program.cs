using System;
using System.Reflection.Metadata;


// ### Generic

// public class Program<T> {
//     private T data;

//     public T value {
//         get {
//             return this.data;
//         }
//         set {
//             this.data = value;
//         }

//     }
// }

// class Test {
//     static void Main(String[] args) {
//         Program<string> name = new Program<string>();
//         name.value = "Hello World";

//         Console.WriteLine(name.value);

//         Program<int> number = new Program<int>();
//         number.value = 100;
//         Console.WriteLine(number.value);
//     }
// }

// ### Exception Handling

// class Program : System.Exception {
//     static void Main(String[] args) {
//         int[] arr = {1, 2, 3, 4, 5};

//         for (int i = 0; i < arr.Length; i++) {
//             Console.WriteLine(arr[i]);
//         }

//         try {
//             Console.WriteLine(arr[7]);
//         }
//         catch (IndexOutOfRangeException e) {
//             Console.WriteLine("An exception was encountered"+ ", " + e.Message);
//         }
//      }
// }


