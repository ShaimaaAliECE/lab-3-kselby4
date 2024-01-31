using System;
namespace Lab3App
{
	public class MagicWand : Tool
	{
		public MagicWand(String description) :base(description)
		{
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            DoAction();
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.Description + " is displayed");
        }

        public override void DoAction()
		{
			Console.WriteLine("MagicWand is Used"); 
		}
	}
}

