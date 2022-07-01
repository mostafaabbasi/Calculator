namespace Calculator
{
    public class Context
    {
        private readonly ICalculator _calculator;
        public Context(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public double Execute(double x, double y)
        {
            return _calculator.Calculate(x, y);
        }
    }
}
