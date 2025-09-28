// Variable names should be short and meaningful

//Ask for input for first number
Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//Ask for input for second number
Console.WriteLine("Type in the second number followed by the Enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Perform calculation
int result = firstNumber + secondNumber;

//Output answer
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
