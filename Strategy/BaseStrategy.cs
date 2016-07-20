using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Execute()
        {
            return _strategy.Execute();
        }

    }

    public interface IStrategy
    {
        string Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public string Execute()
        {
            return "A";
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public string Execute()
        {
            return "B";
        }
    }
}
