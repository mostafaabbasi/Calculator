double number1, number2, result = 0.0;
string Operator = string.Empty;

Console.Write("Enter first number : ");
number1 = double.Parse(Console.ReadLine());
Console.Write("Enter second number : ");
number2 = double.Parse(Console.ReadLine());
Console.Write("Enter one of these => +,-,/,* : ");
Operator = Console.ReadLine();

Context calaculator;

switch (Operator)
{
    case "+":
        calaculator = new Context(new Addition());
        result = calaculator.Execute(number1, number2);
        break;
    case "-":
        calaculator = new Context(new Subtraction());
        result = calaculator.Execute(number1, number2);
        break;
    case "/":
        calaculator = new Context(new Division());
        result = calaculator.Execute(number1, number2);
        break;
    case "*":
        calaculator = new Context(new Multiplication());
        result = calaculator.Execute(number1, number2);
        break;
    default:
        throw new Exception("Error occured");
}
Console.WriteLine("Result : {0}", result);