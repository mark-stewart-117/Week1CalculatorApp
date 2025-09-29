using System.Xml.Serialization;

CalculatorApp();

void CalculatorApp()
{
    // Declare variables and initalise them to 0.
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    //Ask for input for first number
    Console.WriteLine("Type in the first number followed by the Enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    //Ask for input for second number
    Console.WriteLine("Type in the second number followed by the Enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    //Use a loop to make the relevant decision
    //and perform the maths operation
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    //Convert string to integer
    choice = Convert.ToInt32(Console.ReadLine());

    //Use IF statement to perform calculation
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} from {secondNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }
    //Output answer
    Console.WriteLine("The result is ", result);
}