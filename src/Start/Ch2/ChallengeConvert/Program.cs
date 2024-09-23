// Exercise file for C# Exception and Error Handling by Joe Marini
// Programming Challenge - convert user input into numbers

bool Continue = true;

while (Continue) {
    Console.WriteLine("Enter the first integer number: ");
    string str = Console.ReadLine() ?? "";
    Console.WriteLine("Enter the second integer number: ");
    string str2 = Console.ReadLine() ?? "";

    Console.WriteLine("Enter the operation: (a)dd, (s)ubtract, (m)ultiply, (d)ivide or 'exit' to quit: ");
    string op = Console.ReadLine() ?? "";
    op = op.ToLower();
    if (op == "exit") {
        break; // exit the loop at this point and terminate the program
    }

    int n1, n2;

    // Challenge: Convert the string to a number and perform the operation
    try
    {
        n1 = Int32.Parse(str);
        n2 = Int32.Parse(str2);

        Console.WriteLine($"Result: {calculate(n1, n2, op)}");
    }
    catch (Exception e) 
    {
        Console.WriteLine(e.Message);
    }

}


static int calculate (int a, int b, string op)
{
    int x = 0;

    switch (op)
    {
        case "a":
            x = a + b;
            break;
        case "s":
            x = a - b;
            break;
        case "m":
            x = a * b;
            break;
        case "d":
            x = a / b;
            break;
        default: 
            throw new InvalidOperationException();
    }

    return x;
}