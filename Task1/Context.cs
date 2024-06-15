namespace Task1
{
    internal class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int executeStrategy(int number1, int number2)
        {
            return strategy.DoOperation(number1, number2);
        }
    }
}
