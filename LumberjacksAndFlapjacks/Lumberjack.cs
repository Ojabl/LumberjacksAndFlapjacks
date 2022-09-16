using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberjacksAndFlapjacks
{
    class Lumberjack
    {
        public string Name { get; private set; }
        Stack<Flapjack> flapjackStack = new Stack<Flapjack>();

        public Lumberjack(string name)
        {
            this.Name = name;
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while(flapjackStack.Count > 0)
            {
                Console.WriteLine($"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
            }
        }
    }
}
