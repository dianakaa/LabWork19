namespace LabWork19
{
    internal class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return strategy.DoOperation(a, b);
        }
    }
}
