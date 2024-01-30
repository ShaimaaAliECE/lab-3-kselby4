using System;
namespace Lab3App
{
	public class Axe:Tool
	{
		public Axe(string description) :base(description)
		{
            Console.WriteLine($"{Description} Collected, Congrats!!!");
           // DoAction(); 
		}

        public override void Display()
        {
            Console.WriteLine("Axe " + this.Description + " is displayed"); 
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used"); 
        }
    }
}

