double number1, number2, result = 0.0;
string Operator = string.Empty;

Console.Write("Enter first number : ");
number1 = double.Parse(Console.ReadLine());

Console.Write("Enter one of these => +,-,/,* : ");
Operator = Console.ReadLine();

Console.Write("Enter second number : ");
number2 = double.Parse(Console.ReadLine());

Context calaculator = new Context(number1, number2, Operator);

result = calaculator.Execute();

Console.WriteLine("Result : {0}", result);