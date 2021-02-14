using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            
        }
    }
    class CustomerManager
    {
        public void add()
        {
            Logger logger = new Logger();
            logger.log();
            Console.WriteLine("Added!");
        }
    }
    class Logger
    {
       public void log()
        {
            Console.WriteLine("Logged!");
        }
    }
}
