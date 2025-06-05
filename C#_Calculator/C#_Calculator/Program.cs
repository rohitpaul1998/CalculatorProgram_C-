// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {

        // int a; //declaring 'a' -- global variable
        // int b; //declaring 'b' -- global variable
        // int result; //resultant variable

        Console.WriteLine("\nWelcome to the calculator program!\n"); //welcome message

        while (true)
        {
            mainMenu();
            int userInput = Convert.ToInt32(Console.ReadLine()); //reads user input as integer

            switch (userInput)
            {
                case 1:
                    additionOperation();
                    break;

                case 2:
                    subtractionOperation();
                    break;

                case 3:
                    multiplicationOperation();
                    break;

                case 4:
                    divisionOperation();
                    break;

                case 5:
                    exitingCalculator();
                    break;

                default:
                    Console.WriteLine("\nInvalid Input!");
                    break;
            }
        }

    }

    //Main Menu
    static void mainMenu() //usage of void is to not return anything
    {
        Console.WriteLine("\nPlease choose an operation from the below options:"); //selection message
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Exit\n");
    }

    //Addition
    static void additionOperation()
    {
        int a; //declaring 'a' -- local variable
        int b; //declaring 'b' -- local variable
        int result; //resultant variable

        Console.WriteLine("\nEnter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nYour sum is: ");
        result = a + b;
        Console.WriteLine(result);
    }

    //Subtraction
    static void subtractionOperation()
    {
        int a; //declaring 'a' -- local variable
        int b; //declaring 'b' -- local variable
        int result; //resultant variable

        Console.WriteLine("\nEnter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nYour subtraction is: ");
        result = a - b;
        Console.WriteLine(result);
    }

    //Multiplication
    static void multiplicationOperation()
    {
        int a; //declaring 'a' -- local variable
        int b; //declaring 'b' -- local variable
        int result; //resultant variable

        Console.WriteLine("\nEnter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nYour multiplication is: ");
        result = a * b;
        Console.WriteLine(result);
    }

    //Division
    static void divisionOperation()
    {
        int a; //declaring 'a' -- local variable
        int b; //declaring 'b' -- local variable
        int result; //resultant variable

        Console.WriteLine("\nEnter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nYour result is: ");

        try
        {
            result = a / b;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero. Please try again.");
        }

    }

    static void exitingCalculator()
    {
        Console.WriteLine("\nExiting the calculator...\n");
        Environment.Exit(0);
    }
    
}
