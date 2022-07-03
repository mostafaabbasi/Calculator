namespace Calculator
{
    public class Context
    {
        #region Definitions
        private readonly ICalculator _calculator;
        private double FirstNumber { get; set; }
        private double SecondNumber { get; set; }
        private string Operator { get; set; }
        #endregion

        #region Public
        public Context(double firstNumber, double secondNumber, string oprt)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operator = oprt;
        }

        public double Execute()
        {
            Context calaculator;
            double result = 0.0;

            switch (Operator)
            {
                case "+":
                    calaculator = new Context(new Addition());
                    result = calaculator.Execute(FirstNumber, SecondNumber);
                    break;
                case "-":
                    calaculator = new Context(new Subtraction());
                    result = calaculator.Execute(FirstNumber, SecondNumber);
                    break;
                case "/":
                    calaculator = new Context(new Division());
                    result = calaculator.Execute(FirstNumber, SecondNumber);
                    break;
                case "*":
                    calaculator = new Context(new Multiplication());
                    result = calaculator.Execute(FirstNumber, SecondNumber);
                    break;
                default:
                    throw new Exception("Error occured");
            }
            return result;
        }
        #endregion

        #region Private
        private Context(ICalculator calculator)
        {
            _calculator = calculator;
        }

        private double Execute(double x, double y)
        {
            return _calculator.Calculate(x, y);
        }
        #endregion
    }
}
