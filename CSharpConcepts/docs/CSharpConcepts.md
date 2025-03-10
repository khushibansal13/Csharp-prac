- Console.WriteLine() adds a new line after the output and moves the cursor to the next line 
```
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
```
- for Float (F) and for decimal (m)
- var is implicit typed variable
- The var keyword tells the C# compiler that the data type is implied by the assigned value. After the type is implied, the variable acts the same as if the actual data type had been used to declare it. The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context
- A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.
- Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
- Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.(depends on application)
- 2D arrays:
    ```csharp
    dataType[,] arrayName = new dataType[rows, columns];
    int[,] matrix = {
        {1, 2}, 
        {3, 4}, 
        {5, 6}
    }; // A 3x2 array with pre-defined values
    ```
 ![state vs stateless](image.png)
 - The new operator does several important things:
    - It first requests an address in the computer's memory large enough to store a new object based on the Random class.
    - It creates the new object, and stores it at the memory address.
    - It returns the memory address so that it can be saved in the dice object.
    - Stateless objects don’t rely on instance-specific data (state), so you can directly call their methods without creating an object. To achieve this, their methods are often declared as static.

![access modifier](image-1.png)  
![access modifier](image-2.png)
![C# keywords](image-3.png)
- in forEach method you cannot change the value like update the value 
- params is used when we dont know the number of parameters that will be passed.
- In declarative programming, the focus is on expressing the logic of computation without getting into the step-by-step implementation details (i.e., how the task is carried out). In contrast, imperative programming focuses on how a program operates by providing step-by-step instructions for the computer to follow.
- TryParse is a method in C# used to convert a string into a number (or other data types) safely without throwing an error. It’s especially useful when you’re unsure if the input can actually be converted to a number.
    ```csharp
    bool int.TryParse(string input, out int result);
    ```
- IndexOf(): Finds the position of a specific character in a string (. in this case).
- Remove(): Removes part of a string, returning the portion up to a specified index.
- Substring(): Extracts a portion of a string starting from a given index.
- TrimStart(): Removes leading spaces from a string.
- Trim(): Removes both leading and trailing spaces from a string.

### Data and Data types:

- Value types are stored in stack for faster and limited memory space.
    - contains the actual value, each variable has its own independent copy of the data.
Examples:
Primitive types: int, double, float, bool, char
Structs: struct
Enumerations: enum
- Reference types are stored in heap for larger memory space.
    - contains the address of the value, multiple variables can point to the same memory location.
Examples:
Classes: class
Interfaces: interface
Delegates: delegate
Arrays: array

#### Signed and Unsigned Data Types:
Signed types can store both positive and negative values.
Unsigned types can store only positive values.
- Signed types: sbyte, short, int, long, float, double, decimal 
- Unsigned types: byte, ushort, uint, ulong

![Convert Vs Parse](image-4.png)
- Use typecasting ((int)) when you want simple truncation.
- Use Convert.ToInt32() for rounding when converting to integers.

#### Array helper methods:
```csharp
Array.Clear(array, index, length);
```

### Composite formatting VS string interpolation:
![CF VS SI](image-5.png)

```csharp
string result = string.Format("Name: {0}, Age: {1}, Salary: {2:C}", name, age, salary); // Composite formatting

string result = $"Name: {name}, Age: {age}, Salary: {salary:C}"; // String interpolation
```

- currency formatting can be done by {variable:C} and also there are various other formats like {variable:D} for decimal, {variable:F} for fixed point, {variable:E} for scientific notation, {variable:X} for hexadecimal, {variable:P} for percentage, {variable:N} for number with commas, {variable:G} for general format.

- The PadLeft() method adds blank spaces to the left-hand side of the string so that the total number of characters equals the argument you send it.

### Delegates
```csharp
// declaration
public delegate void Testdel();
// Instantation
Testdel delObj = TestMethod;
// Usage
delObj();
```
- A delegate in C# is a type-safe function pointer that holds a reference to a method. Delegates allow methods to be passed as arguments, stored in variables, or dynamically assigned at runtime.
    - the signature of the delegate should be same as the signature of the method
    - in delagates we can instantiate multiple methods
     ```csharp
    (GreetDelegate greet= sayHello;
    greet += sayGM;)
    ```
    - Its a callback function and higher order functions
    - Delegates are not functions themselves; they are just pointers to functions. The actual logic resides in the methods assigned to the delegate.
    - Delegates can be used to take functions as arguments or return functions from other methods. This is what makes them higher-order functions in C#.
- C# provides built-in delegates for common scenarios to avoid the need to define custom delegate types. These built-in delegates are part of the System namespace and include:
1. Action<T>
- Represents a method that takes one or more arguments but does not return a value.
You can have Action, Action<T1>, Action<T1, T2>, etc., up to 16 parameters.
2. Func<T, TResult>
- Represents a method that takes one or more arguments and returns a value.
The last type parameter is always the return type.
3. Predicate<T>
- Represents a method that takes one argument and returns a bool.
Used for conditions or checks.

## events in C#

An event in C# is a way to enable communication between classes through the publisher-subscriber model. It allows a class (the publisher) to notify other classes (the subscribers) when something happens.

- Delegate: Defines the signature for the methods that handle the event.
- Publisher: Fires the event, notifying subscribers.
- Subscriber: Listens to the event and reacts when it is triggered.
- Syntax: Use the event keyword to declare an event and += to subscribe to it.
- Purpose: Provides loose coupling between the publisher and subscribers, allowing multiple - subscribers to respond to an event.
- Example: A Button click event where multiple subscribers (like different UI elements) can react to the click without the button knowing who those subscribers are.
- The EventHandler in C# is a predefined delegate used for handling events. It provides a standard pattern for creating event handlers. It's part of the System namespace and can be used to attach and handle events in your application.
```csharp
public delegate void EventHandler(object? sender, EventArgs e);
// object? sender: The object that raised the event.
// EventArgs e: Holds event-specific data. If no data is required, EventArgs.Empty is used.
```



Key Benefits:
- Encapsulation: Only the publisher can trigger the event, ensuring proper handling.
- Asynchronous: Events can handle notifications asynchronously.
Usage: Typically used in UI frameworks (like WinForms, WPF) or in any situation where objects need to notify others of changes or actions.







