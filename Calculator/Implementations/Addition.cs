namespace Calculator.Implementations
{
    public class Addition : ICalculator
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}
